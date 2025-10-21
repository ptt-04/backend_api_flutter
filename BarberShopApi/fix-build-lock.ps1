# Script để sửa lỗi file bị khóa khi build
Write-Host "=== SCRIPT SỬA LỖI FILE BỊ KHÓA ===" -ForegroundColor Cyan
Write-Host "Đang kiểm tra và dừng các process BarberShopApi..." -ForegroundColor Yellow

# Dừng tất cả process BarberShopApi
$barberProcesses = Get-Process | Where-Object {$_.ProcessName -like "*BarberShop*"}
if ($barberProcesses) {
    foreach ($process in $barberProcesses) {
        Write-Host "Dừng process: $($process.ProcessName) (PID: $($process.Id))" -ForegroundColor Red
        Stop-Process -Id $process.Id -Force
    }
} else {
    Write-Host "Không tìm thấy process BarberShopApi nào đang chạy" -ForegroundColor Green
}

# Dừng các process dotnet liên quan đến project
$dotnetProcesses = Get-Process | Where-Object {$_.ProcessName -like "*dotnet*" -and $_.Path -like "*BarberShopApi*"}
if ($dotnetProcesses) {
    foreach ($process in $dotnetProcesses) {
        Write-Host "Dừng process: $($process.ProcessName) (PID: $($process.Id))" -ForegroundColor Red
        Stop-Process -Id $process.Id -Force
    }
} else {
    Write-Host "Không tìm thấy process dotnet liên quan nào" -ForegroundColor Green
}

Write-Host "Đang clean project..." -ForegroundColor Yellow
dotnet clean

Write-Host "Đang build project..." -ForegroundColor Yellow
dotnet build

if ($LASTEXITCODE -eq 0) {
    Write-Host "✅ Build thành công!" -ForegroundColor Green
    Write-Host "Bạn có thể chạy ứng dụng với: dotnet run" -ForegroundColor Cyan
} else {
    Write-Host "❌ Build thất bại!" -ForegroundColor Red
    Write-Host "Vui lòng kiểm tra lại lỗi và thử lại" -ForegroundColor Yellow
}

Write-Host "=== HOÀN THÀNH ===" -ForegroundColor Cyan

