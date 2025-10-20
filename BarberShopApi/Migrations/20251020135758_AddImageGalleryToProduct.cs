using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarberShopApi.Migrations
{
    /// <inheritdoc />
    public partial class AddImageGalleryToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageGallery",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 57, 57, 632, DateTimeKind.Utc).AddTicks(4300), new DateTime(2025, 10, 20, 13, 57, 57, 632, DateTimeKind.Utc).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 57, 57, 632, DateTimeKind.Utc).AddTicks(4503), new DateTime(2025, 10, 20, 13, 57, 57, 632, DateTimeKind.Utc).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 57, 57, 632, DateTimeKind.Utc).AddTicks(4504), new DateTime(2025, 10, 20, 13, 57, 57, 632, DateTimeKind.Utc).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 57, 57, 632, DateTimeKind.Utc).AddTicks(4506), new DateTime(2025, 10, 20, 13, 57, 57, 632, DateTimeKind.Utc).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ImageGallery", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(8373), null, new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ImageGallery", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(8501), null, new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ImageGallery", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(8503), null, new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(5761), new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(5891), new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(5892), new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(5894), new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(5896), new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 57, 57, 634, DateTimeKind.Utc).AddTicks(991), new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(9409), new DateTime(2025, 10, 20, 13, 57, 57, 634, DateTimeKind.Utc).AddTicks(460), new DateTime(2026, 4, 20, 13, 57, 57, 634, DateTimeKind.Utc).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 57, 57, 634, DateTimeKind.Utc).AddTicks(1119), new DateTime(2025, 10, 20, 13, 57, 57, 634, DateTimeKind.Utc).AddTicks(1112), new DateTime(2025, 10, 20, 13, 57, 57, 634, DateTimeKind.Utc).AddTicks(1115), new DateTime(2026, 1, 20, 13, 57, 57, 634, DateTimeKind.Utc).AddTicks(1116) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageGallery",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 15, 16, 13, 897, DateTimeKind.Utc).AddTicks(6386), new DateTime(2025, 10, 17, 15, 16, 13, 897, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 15, 16, 13, 897, DateTimeKind.Utc).AddTicks(6530), new DateTime(2025, 10, 17, 15, 16, 13, 897, DateTimeKind.Utc).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 15, 16, 13, 897, DateTimeKind.Utc).AddTicks(6532), new DateTime(2025, 10, 17, 15, 16, 13, 897, DateTimeKind.Utc).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 15, 16, 13, 897, DateTimeKind.Utc).AddTicks(6533), new DateTime(2025, 10, 17, 15, 16, 13, 897, DateTimeKind.Utc).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(6411), new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(6675), new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(6677), new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(4063), new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(4206), new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(4208), new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(4210), new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(4212), new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(9843), new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(7922), new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(9320), new DateTime(2026, 4, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(9981), new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(9974), new DateTime(2025, 10, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(9977), new DateTime(2026, 1, 17, 15, 16, 13, 898, DateTimeKind.Utc).AddTicks(9977) });
        }
    }
}
