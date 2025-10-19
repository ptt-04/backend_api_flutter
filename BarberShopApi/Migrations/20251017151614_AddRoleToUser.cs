using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarberShopApi.Migrations
{
    /// <inheritdoc />
    public partial class AddRoleToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 14, 38, 5, 838, DateTimeKind.Utc).AddTicks(8250), new DateTime(2025, 10, 17, 14, 38, 5, 838, DateTimeKind.Utc).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 14, 38, 5, 838, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 10, 17, 14, 38, 5, 838, DateTimeKind.Utc).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 14, 38, 5, 838, DateTimeKind.Utc).AddTicks(8395), new DateTime(2025, 10, 17, 14, 38, 5, 838, DateTimeKind.Utc).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 14, 38, 5, 838, DateTimeKind.Utc).AddTicks(8397), new DateTime(2025, 10, 17, 14, 38, 5, 838, DateTimeKind.Utc).AddTicks(8396) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(6739), new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(6867), new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(6869), new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(4407), new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(4537), new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(4539), new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(4540), new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(4542), new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(9506), new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(7688), new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(9069), new DateTime(2026, 4, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(9673), new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(9661), new DateTime(2025, 10, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(9669), new DateTime(2026, 1, 17, 14, 38, 5, 839, DateTimeKind.Utc).AddTicks(9669) });
        }
    }
}
