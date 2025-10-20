# BarberShop App - Ứng dụng Cắt Tóc Thông Minh

## Tổng quan

BarberShop App là một ứng dụng mobile hoàn chỉnh được xây dựng với backend C# API và frontend Flutter, cung cấp các dịch vụ cắt tóc và chăm sóc tóc chuyên nghiệp với các tính năng AI thông minh.

## Tính năng chính

### 🔐 Xác thực và Quản lý Tài khoản
- Đăng ký/Đăng nhập với JWT
- Quản lý thông tin cá nhân
- Hệ thống điểm thưởng tích lũy

### 📅 Đặt lịch và Quản lý Dịch vụ
- Đặt lịch cắt tóc trực tuyến
- Quản lý lịch hẹn
- Hủy/Thay đổi lịch hẹn
- Tích điểm sau mỗi dịch vụ

### 🛒 Cửa hàng Trực tuyến
- CRUD sản phẩm và danh mục
- Giỏ hàng thông minh
- Hệ thống giảm giá và voucher
- Thanh toán tích hợp

### 🤖 AI và Chatbot
- **AI Gemini**: Gợi ý kiểu tóc dựa trên khuôn mặt
- **Chatbot**: Tư vấn dịch vụ 24/7
- **SignalR**: Chat realtime với hỗ trợ

### 🎁 Hệ thống Loyalty
- Tích điểm tự động
- Voucher và mã giảm giá
- Chương trình thành viên VIP

## Công nghệ sử dụng

### Backend (C# .NET 9)
- **Framework**: ASP.NET Core Web API
- **Database**: Entity Framework Core với SQL Server
- **Authentication**: JWT Bearer Token
- **Real-time**: SignalR Hub
- **AI Integration**: Google Gemini API
- **Documentation**: Swagger/OpenAPI

### Frontend (Flutter)
- **Framework**: Flutter 3.9+
- **State Management**: Provider
- **Navigation**: GoRouter
- **HTTP Client**: Dio
- **Local Storage**: SharedPreferences + Hive
- **UI Components**: Material Design 3

## Cài đặt và Chạy

### Backend Setup

1. **Cài đặt Prerequisites**:
   ```bash
   # Cài đặt .NET 9 SDK
   # Cài đặt SQL Server hoặc SQL Server LocalDB
   ```

2. **Clone và Setup**:
   ```bash
   cd BarberShopApi
   dotnet restore
   ```

3. **Cấu hình Database**:
   - Cập nhật connection string trong `appsettings.json`
   - Chạy migration để tạo database:
   ```bash
   dotnet ef database update
   ```

4. **Cấu hình API Keys**:
   - Thêm Gemini API key vào `appsettings.json`:
   ```json
   {
     "GeminiApiKey": "YOUR_GEMINI_API_KEY_HERE"
   }
   ```

5. **Chạy Backend**:
   ```bash
   dotnet run
   ```
   - API sẽ chạy tại: `https://localhost:7000`
   - Swagger UI: `https://localhost:7000/swagger`

### Frontend Setup

1. **Cài đặt Flutter**:
   ```bash
   # Cài đặt Flutter SDK 3.9+
   flutter doctor
   ```

2. **Clone và Setup**:
   ```bash
   cd barbershop
   flutter pub get
   ```

3. **Cấu hình API Endpoint**:
   - Cập nhật `baseUrl` trong `lib/services/api_service.dart`

4. **Chạy Flutter App**:
   ```bash
   flutter run
   ```

## Cấu trúc Project

### Backend Structure
```
BarberShopApi/
├── Controllers/          # API Controllers
├── Models/              # Entity Models
├── DTOs/                # Data Transfer Objects
├── Services/            # Business Logic Services
├── Data/                # DbContext và Database
├── Hubs/                # SignalR Hubs
└── Program.cs           # Application Entry Point
```

### Frontend Structure
```
lib/
├── models/              # Data Models
├── services/            # API Services
├── providers/           # State Management
├── screens/             # UI Screens
├── theme/               # App Theme
├── router/              # Navigation
└── main.dart            # App Entry Point
```

## API Endpoints

### Authentication
- `POST /api/auth/register` - Đăng ký
- `POST /api/auth/login` - Đăng nhập
- `GET /api/auth/profile` - Lấy thông tin profile

### Booking
- `GET /api/booking/my-bookings` - Lịch hẹn của user
- `POST /api/booking` - Tạo lịch hẹn mới
- `PUT /api/booking/{id}/cancel` - Hủy lịch hẹn
- `GET /api/booking/services` - Danh sách dịch vụ

### Products
- `GET /api/product` - Danh sách sản phẩm
- `GET /api/product/{id}` - Chi tiết sản phẩm
- `GET /api/product/categories` - Danh mục sản phẩm

### AI & Chat
- `POST /api/ai/hair-style-suggestion` - Gợi ý kiểu tóc
- `POST /api/ai/chat` - Chat với AI
- SignalR Hub: `/chathub` - Chat realtime

### Vouchers
- `GET /api/voucher/available` - Voucher có thể nhận
- `GET /api/voucher/my-vouchers` - Voucher của user
- `POST /api/voucher/{id}/assign` - Nhận voucher

## Tính năng nâng cao

### AI Hair Style Suggestion
- Phân tích khuôn mặt (Oval, Round, Square, Heart, Diamond)
- Đề xuất kiểu tóc phù hợp
- Tư vấn sản phẩm chăm sóc

### Real-time Chat
- Chat với AI chatbot
- Hỗ trợ khách hàng realtime
- Lưu lịch sử chat

### Loyalty System
- Tích điểm tự động (1 điểm/1000đ)
- Voucher đa dạng (%, số tiền cố định)
- Chương trình thành viên VIP

## Bảo mật

- JWT Authentication với refresh token
- Password hashing với BCrypt
- CORS configuration
- Input validation và sanitization
- SQL injection protection

## Deployment

### Backend
- Deploy lên Azure App Service hoặc AWS
- Cấu hình SQL Server production
- Setup CI/CD pipeline

### Frontend
- Build APK/IPA cho mobile
- Deploy web version lên Firebase Hosting
- App Store/Play Store submission

## Đóng góp

1. Fork project
2. Tạo feature branch
3. Commit changes
4. Push to branch
5. Tạo Pull Request

## License

MIT License - Xem file LICENSE để biết thêm chi tiết.

## Liên hệ

- Email: support@barbershop.com
- Website: https://barbershop.com
- GitHub: https://github.com/barbershop/app

---

**Lưu ý**: Đây là phiên bản demo. Để sử dụng trong production, cần cấu hình thêm các tính năng bảo mật và tối ưu hóa performance.





