using System.Security.Cryptography;
using System.Text;
using BarberShopApi.DTOs;

namespace BarberShopApi.Services
{
    public interface IVNPayService
    {
        string CreatePaymentUrl(VNPayPaymentRequestDto request);
        bool ValidatePaymentCallback(PaymentCallbackDto callback);
    }

    public class VNPayService : IVNPayService
    {
        private readonly IConfiguration _configuration;
        private readonly string _vnpUrl;
        private readonly string _vnpReturnUrl;
        private readonly string _vnpTmnCode;
        private readonly string _vnpHashSecret;

        public VNPayService(IConfiguration configuration)
        {
            _configuration = configuration;
            _vnpUrl = _configuration["VNPay:Url"] ?? "https://sandbox.vnpayment.vn/paymentv2/vpcpay.html";
            _vnpReturnUrl = _configuration["VNPay:ReturnUrl"] ?? "http://localhost:4000/payment/callback";
            _vnpTmnCode = _configuration["VNPay:TmnCode"] ?? "2QXUI4J4";
            _vnpHashSecret = _configuration["VNPay:HashSecret"] ?? "RAOEXHYVSDDIIENYWSLDIAZYWAXFKPHT";
        }

        public string CreatePaymentUrl(VNPayPaymentRequestDto request)
        {
            var vnpParams = new Dictionary<string, string>
            {
                {"vnp_Version", "2.1.0"},
                {"vnp_Command", "pay"},
                {"vnp_TmnCode", _vnpTmnCode},
                {"vnp_Amount", ((long)(request.Amount * 100)).ToString()},
                {"vnp_CurrCode", "VND"},
                {"vnp_TxnRef", request.OrderId.ToString()},
                {"vnp_OrderInfo", $"Thanh toan don hang {request.OrderId}"},
                {"vnp_OrderType", "other"},
                {"vnp_Locale", "vn"},
                {"vnp_ReturnUrl", request.ReturnUrl ?? _vnpReturnUrl},
                {"vnp_IpAddr", "127.0.0.1"},
                {"vnp_CreateDate", DateTime.Now.ToString("yyyyMMddHHmmss")}
            };

            // Sort parameters
            var sortedParams = vnpParams.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            // Create query string
            var queryString = string.Join("&", sortedParams.Select(x => $"{x.Key}={x.Value}"));

            // Create hash
            var hashData = $"{queryString}&{_vnpHashSecret}";
            var hash = HmacSHA512(_vnpHashSecret, hashData);

            // Add hash to parameters
            sortedParams["vnp_SecureHash"] = hash;

            // Create final query string
            var finalQueryString = string.Join("&", sortedParams.Select(x => $"{x.Key}={x.Value}"));

            return $"{_vnpUrl}?{finalQueryString}";
        }

        public bool ValidatePaymentCallback(PaymentCallbackDto callback)
        {
            var vnpParams = new Dictionary<string, string>
            {
                {"vnp_TxnRef", callback.vnp_TxnRef},
                {"vnp_Amount", callback.vnp_Amount},
                {"vnp_ResponseCode", callback.vnp_ResponseCode},
                {"vnp_TransactionStatus", callback.vnp_TransactionStatus}
            };

            // Sort parameters
            var sortedParams = vnpParams.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            // Create query string
            var queryString = string.Join("&", sortedParams.Select(x => $"{x.Key}={x.Value}"));

            // Create hash
            var hashData = $"{queryString}&{_vnpHashSecret}";
            var hash = HmacSHA512(_vnpHashSecret, hashData);

            return hash.Equals(callback.vnp_SecureHash, StringComparison.OrdinalIgnoreCase);
        }

        private string HmacSHA512(string key, string inputData)
        {
            var hash = new StringBuilder();
            var keyBytes = Encoding.UTF8.GetBytes(key);
            var inputBytes = Encoding.UTF8.GetBytes(inputData);
            using (var hmac = new HMACSHA512(keyBytes))
            {
                var hashValue = hmac.ComputeHash(inputBytes);
                foreach (var theByte in hashValue)
                {
                    hash.Append(theByte.ToString("x2"));
                }
            }
            return hash.ToString();
        }
    }
}
