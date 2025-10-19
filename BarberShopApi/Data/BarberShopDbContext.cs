using Microsoft.EntityFrameworkCore;
using BarberShopApi.Models;
using BCrypt.Net;

namespace BarberShopApi.Data
{
    public class BarberShopDbContext : DbContext
    {
        public BarberShopDbContext(DbContextOptions<BarberShopDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Suppress the PendingModelChangesWarning
                optionsBuilder.ConfigureWarnings(warnings => 
                    warnings.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
            }
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<UserVoucher> UserVouchers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<HairStyleSuggestion> HairStyleSuggestions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User configuration
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasIndex(e => e.Email).IsUnique();
                entity.HasIndex(e => e.Username).IsUnique();
            });

            // Service configuration
            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Price).HasPrecision(18, 2);
            });

            // Booking configuration
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.TotalPrice).HasPrecision(18, 2);
                entity.HasOne(e => e.User)
                    .WithMany(e => e.Bookings)
                    .HasForeignKey(e => e.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(e => e.Service)
                    .WithMany(e => e.Bookings)
                    .HasForeignKey(e => e.ServiceId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Category configuration
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            // Product configuration
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Price).HasPrecision(18, 2);
                entity.Property(e => e.DiscountPrice).HasPrecision(18, 2);
                entity.HasOne(e => e.Category)
                    .WithMany(e => e.Products)
                    .HasForeignKey(e => e.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Order configuration
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.TotalAmount).HasPrecision(18, 2);
                entity.Property(e => e.DiscountAmount).HasPrecision(18, 2);
                entity.HasOne(e => e.User)
                    .WithMany(e => e.Orders)
                    .HasForeignKey(e => e.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // OrderItem configuration
            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.UnitPrice).HasPrecision(18, 2);
                entity.Property(e => e.DiscountAmount).HasPrecision(18, 2);
                entity.HasOne(e => e.Order)
                    .WithMany(e => e.OrderItems)
                    .HasForeignKey(e => e.OrderId)
                    .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(e => e.Product)
                    .WithMany(e => e.OrderItems)
                    .HasForeignKey(e => e.ProductId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Voucher configuration
            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasIndex(e => e.Code).IsUnique();
                entity.Property(e => e.DiscountAmount).HasPrecision(18, 2);
                entity.Property(e => e.MinimumOrderAmount).HasPrecision(18, 2);
            });

            // UserVoucher configuration
            modelBuilder.Entity<UserVoucher>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.User)
                    .WithMany()
                    .HasForeignKey(e => e.UserId)
                    .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(e => e.Voucher)
                    .WithMany(e => e.UserVouchers)
                    .HasForeignKey(e => e.VoucherId)
                    .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(e => e.Order)
                    .WithMany()
                    .HasForeignKey(e => e.OrderId)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            // Review configuration
            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.User)
                    .WithMany(e => e.Reviews)
                    .HasForeignKey(e => e.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(e => e.Service)
                    .WithMany()
                    .HasForeignKey(e => e.ServiceId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // ChatMessage configuration
            modelBuilder.Entity<ChatMessage>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.User)
                    .WithMany(e => e.ChatMessages)
                    .HasForeignKey(e => e.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // HairStyleSuggestion configuration
            modelBuilder.Entity<HairStyleSuggestion>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.User)
                    .WithMany()
                    .HasForeignKey(e => e.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // Seed data
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // Seed Admin User - chỉ seed nếu chưa có
            // Note: Admin user sẽ được tạo trong Program.cs để tránh conflict

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Dầu Gội", Description = "Các loại dầu gội chuyên nghiệp", CreatedAt = DateTime.UtcNow },
                new Category { Id = 2, Name = "Dầu Xả", Description = "Dầu xả và kem ủ tóc", CreatedAt = DateTime.UtcNow },
                new Category { Id = 3, Name = "Sản Phẩm Tạo Kiểu", Description = "Gel, wax, pomade tạo kiểu tóc", CreatedAt = DateTime.UtcNow },
                new Category { Id = 4, Name = "Dụng Cụ Cắt Tóc", Description = "Kéo, máy cắt, dao cạo", CreatedAt = DateTime.UtcNow }
            );

            // Seed Services
            modelBuilder.Entity<Service>().HasData(
                new Service { Id = 1, Name = "Cắt Tóc Nam", Description = "Cắt tóc nam theo phong cách hiện đại", Price = 150000, DurationMinutes = 30, CreatedAt = DateTime.UtcNow },
                new Service { Id = 2, Name = "Cắt Tóc Nữ", Description = "Cắt tóc nữ theo xu hướng mới nhất", Price = 200000, DurationMinutes = 45, CreatedAt = DateTime.UtcNow },
                new Service { Id = 3, Name = "Gội Đầu", Description = "Gội đầu và massage da đầu", Price = 50000, DurationMinutes = 20, CreatedAt = DateTime.UtcNow },
                new Service { Id = 4, Name = "Uốn Tóc", Description = "Uốn tóc tạo kiểu", Price = 500000, DurationMinutes = 120, CreatedAt = DateTime.UtcNow },
                new Service { Id = 5, Name = "Nhuộm Tóc", Description = "Nhuộm tóc màu sắc đa dạng", Price = 400000, DurationMinutes = 90, CreatedAt = DateTime.UtcNow }
            );

            // Seed Products
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Dầu Gội Pantene", Description = "Dầu gội Pantene Pro-V cho tóc mềm mượt", Price = 120000, StockQuantity = 50, CategoryId = 1, CreatedAt = DateTime.UtcNow },
                new Product { Id = 2, Name = "Gel Tạo Kiểu Gatsby", Description = "Gel tạo kiểu tóc nam cao cấp", Price = 80000, StockQuantity = 30, CategoryId = 3, CreatedAt = DateTime.UtcNow },
                new Product { Id = 3, Name = "Kéo Cắt Tóc Chuyên Nghiệp", Description = "Kéo cắt tóc chất lượng cao", Price = 500000, StockQuantity = 10, CategoryId = 4, CreatedAt = DateTime.UtcNow }
            );

            // Seed Vouchers
            modelBuilder.Entity<Voucher>().HasData(
                new Voucher { Id = 1, Code = "WELCOME10", Name = "Giảm 10% cho khách hàng mới", Description = "Áp dụng cho đơn hàng đầu tiên", DiscountAmount = 10, DiscountType = "Percentage", MinimumOrderAmount = 100000, MaxUsageCount = 1000, ValidFrom = DateTime.UtcNow, ValidTo = DateTime.UtcNow.AddMonths(6), CreatedAt = DateTime.UtcNow },
                new Voucher { Id = 2, Code = "SAVE50K", Name = "Giảm 50k cho đơn hàng từ 300k", Description = "Áp dụng cho đơn hàng từ 300k", DiscountAmount = 50000, DiscountType = "FixedAmount", MinimumOrderAmount = 300000, MaxUsageCount = 500, ValidFrom = DateTime.UtcNow, ValidTo = DateTime.UtcNow.AddMonths(3), CreatedAt = DateTime.UtcNow }
            );
        }
    }
}

