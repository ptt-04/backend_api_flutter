# Script triệt để để sửa lỗi file bị khóa trong Visual Studio
Write-Host "=== SCRIPT TRIỆT ĐỂ SỬA LỖI FILE BỊ KHÓA ===" -ForegroundColor Cyan
Write-Host "Đang kiểm tra và dừng TẤT CẢ process liên quan..." -ForegroundColor Yellow

# 1. Dừng tất cả process BarberShopApi
$barberProcesses = Get-Process | Where-Object {$_.ProcessName -like "*BarberShop*"}
if ($barberProcesses) {
    foreach ($process in $barberProcesses) {
        Write-Host "Dừng process: $($process.ProcessName) (PID: $($process.Id))" -ForegroundColor Red
        Stop-Process -Id $process.Id -Force
    }
} else {
    Write-Host "Không tìm thấy process BarberShopApi nào đang chạy" -ForegroundColor Green
}

# 2. Dừng các process dotnet liên quan đến project
$dotnetProcesses = Get-Process | Where-Object {$_.ProcessName -like "*dotnet*" -and $_.Path -like "*BarberShopApi*"}
if ($dotnetProcesses) {
    foreach ($process in $dotnetProcesses) {
        Write-Host "Dừng process: $($process.ProcessName) (PID: $($process.Id))" -ForegroundColor Red
        Stop-Process -Id $process.Id -Force
    }
} else {
    Write-Host "Không tìm thấy process dotnet liên quan nào" -ForegroundColor Green
}

# 3. Kiểm tra và dừng Visual Studio debug sessions
$vsProcesses = Get-Process | Where-Object {$_.ProcessName -like "*devenv*"}
if ($vsProcesses) {
    Write-Host "⚠️  Visual Studio đang chạy. Vui lòng:" -ForegroundColor Yellow
    Write-Host "   1. Dừng debug session (Shift+F5)" -ForegroundColor Yellow
    Write-Host "   2. Hoặc đóng Visual Studio tạm thời" -ForegroundColor Yellow
    Write-Host "   3. Sau đó chạy lại script này" -ForegroundColor Yellow
    Write-Host ""
    Write-Host "Tiếp tục với việc clean và build..." -ForegroundColor Cyan
}

# 4. Xóa hoàn toàn các file có thể bị khóa
Write-Host "Đang xóa các file có thể bị khóa..." -ForegroundColor Yellow
Remove-Item -Path "bin" -Recurse -Force -ErrorAction SilentlyContinue
Remove-Item -Path "obj" -Recurse -Force -ErrorAction SilentlyContinue

# 5. Clean project
Write-Host "Đang clean project..." -ForegroundColor Yellow
dotnet clean

# 6. Restore dependencies
Write-Host "Đang restore dependencies..." -ForegroundColor Yellow
dotnet restore

# 7. Build project
Write-Host "Đang build project..." -ForegroundColor Yellow
dotnet build

# 8. Kiểm tra kết quả
if ($LASTEXITCODE -eq 0) {
    Write-Host "✅ Build thành công!" -ForegroundColor Green
    Write-Host "Bạn có thể:" -ForegroundColor Cyan
    Write-Host "   - Chạy ứng dụng: dotnet run" -ForegroundColor Cyan
    Write-Host "   - Build trong Visual Studio: Ctrl+Shift+B" -ForegroundColor Cyan
    Write-Host "   - Debug trong Visual Studio: F5" -ForegroundColor Cyan
} else {
    Write-Host "❌ Build thất bại!" -ForegroundColor Red
    Write-Host "Vui lòng:" -ForegroundColor Yellow
    Write-Host "   1. Đóng Visual Studio hoàn toàn" -ForegroundColor Yellow
    Write-Host "   2. Chạy lại script này" -ForegroundColor Yellow
    Write-Host "   3. Hoặc khởi động lại máy tính" -ForegroundColor Yellow
}

Write-Host ""
Write-Host "=== HOÀN THÀNH ===" -ForegroundColor Cyan
Write-Host "💡 Mẹo: Để tránh lỗi này trong tương lai:" -ForegroundColor Magenta
Write-Host "   - Luôn dừng debug session (Shift+F5) trước khi build lại" -ForegroundColor Magenta
Write-Host "   - Sử dụng script này khi gặp lỗi file bị khóa" -ForegroundColor Magenta

