using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

class GeminiAPITest
{
    private static readonly string API_KEY = "AIzaSyAx-AH7E-ClpGVbhNhzF8XuYbujCXMx7PE";
    private static readonly string API_URL = "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent";

    static async Task Main(string[] args)
    {
        Console.WriteLine("Testing Gemini API...");
        
        var testPrompts = new[]
        {
            "Xin chào, bạn có thể giúp gì cho tôi?",
            "Hôm nay trời như thế nào?",
            "Giá vàng hôm nay bao nhiêu?",
            "Tôi muốn cắt tóc, bạn có gợi ý gì không?"
        };

        foreach (var prompt in testPrompts)
        {
            Console.WriteLine($"\n--- Testing prompt: {prompt} ---");
            try
            {
                var response = await CallGeminiAPI(prompt);
                Console.WriteLine($"Response: {response}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    static async Task<string> CallGeminiAPI(string prompt)
    {
        using var httpClient = new HttpClient();
        httpClient.Timeout = TimeSpan.FromSeconds(30);

        var requestBody = new
        {
            contents = new[]
            {
                new
                {
                    parts = new[]
                    {
                        new { text = prompt }
                    }
                }
            },
            generationConfig = new
            {
                temperature = 0.7,
                topK = 40,
                topP = 0.95,
                maxOutputTokens = 1024
            }
        };

        var json = JsonSerializer.Serialize(requestBody);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await httpClient.PostAsync($"{API_URL}?key={API_KEY}", content);

        if (response.IsSuccessStatusCode)
        {
            var responseContent = await response.Content.ReadAsStringAsync();
            var geminiResponse = JsonSerializer.Deserialize<JsonElement>(responseContent);

            if (geminiResponse.TryGetProperty("candidates", out var candidates) &&
                candidates.GetArrayLength() > 0)
            {
                var candidate = candidates[0];
                if (candidate.TryGetProperty("content", out var contentElement) &&
                    contentElement.TryGetProperty("parts", out var parts) &&
                    parts.GetArrayLength() > 0)
                {
                    var part = parts[0];
                    if (part.TryGetProperty("text", out var text))
                    {
                        return text.GetString() ?? "No response";
                    }
                }
            }
        }
        else
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            throw new Exception($"API Error {response.StatusCode}: {errorContent}");
        }

        throw new Exception("Failed to get response from Gemini API");
    }
}

