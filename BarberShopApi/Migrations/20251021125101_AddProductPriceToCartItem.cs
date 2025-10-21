using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarberShopApi.Migrations
{
    /// <inheritdoc />
    public partial class AddProductPriceToCartItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(9767), new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(9910), new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(9912), new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 51, 1, 9, DateTimeKind.Utc).AddTicks(5003), new DateTime(2025, 10, 21, 12, 51, 1, 9, DateTimeKind.Utc).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 51, 1, 9, DateTimeKind.Utc).AddTicks(5193), new DateTime(2025, 10, 21, 12, 51, 1, 9, DateTimeKind.Utc).AddTicks(5191) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 51, 1, 9, DateTimeKind.Utc).AddTicks(5194), new DateTime(2025, 10, 21, 12, 51, 1, 9, DateTimeKind.Utc).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 51, 1, 9, DateTimeKind.Utc).AddTicks(5198), new DateTime(2025, 10, 21, 12, 51, 1, 9, DateTimeKind.Utc).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(7869), new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(8008), new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(8010), new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(5041), new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(5177), new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(5179), new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(5181), new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(5182), new DateTime(2025, 10, 21, 12, 51, 1, 10, DateTimeKind.Utc).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 51, 1, 13, DateTimeKind.Utc).AddTicks(5805), new DateTime(2025, 10, 21, 12, 51, 1, 13, DateTimeKind.Utc).AddTicks(3766), new DateTime(2025, 10, 21, 12, 51, 1, 13, DateTimeKind.Utc).AddTicks(5239), new DateTime(2026, 4, 21, 12, 51, 1, 13, DateTimeKind.Utc).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 51, 1, 13, DateTimeKind.Utc).AddTicks(5937), new DateTime(2025, 10, 21, 12, 51, 1, 13, DateTimeKind.Utc).AddTicks(5930), new DateTime(2025, 10, 21, 12, 51, 1, 13, DateTimeKind.Utc).AddTicks(5933), new DateTime(2026, 1, 21, 12, 51, 1, 13, DateTimeKind.Utc).AddTicks(5934) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 46, 29, 338, DateTimeKind.Utc).AddTicks(949), new DateTime(2025, 10, 21, 12, 46, 29, 338, DateTimeKind.Utc).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 46, 29, 338, DateTimeKind.Utc).AddTicks(1084), new DateTime(2025, 10, 21, 12, 46, 29, 338, DateTimeKind.Utc).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 46, 29, 338, DateTimeKind.Utc).AddTicks(1085), new DateTime(2025, 10, 21, 12, 46, 29, 338, DateTimeKind.Utc).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 46, 29, 336, DateTimeKind.Utc).AddTicks(7699), new DateTime(2025, 10, 21, 12, 46, 29, 336, DateTimeKind.Utc).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 46, 29, 336, DateTimeKind.Utc).AddTicks(7863), new DateTime(2025, 10, 21, 12, 46, 29, 336, DateTimeKind.Utc).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 46, 29, 336, DateTimeKind.Utc).AddTicks(7864), new DateTime(2025, 10, 21, 12, 46, 29, 336, DateTimeKind.Utc).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 46, 29, 336, DateTimeKind.Utc).AddTicks(7944), new DateTime(2025, 10, 21, 12, 46, 29, 336, DateTimeKind.Utc).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 46, 29, 337, DateTimeKind.Utc).AddTicks(9312), new DateTime(2025, 10, 21, 12, 46, 29, 337, DateTimeKind.Utc).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 46, 29, 337, DateTimeKind.Utc).AddTicks(9468), new DateTime(2025, 10, 21, 12, 46, 29, 337, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 46, 29, 337, DateTimeKind.Utc).AddTicks(9470), new DateTime(2025, 10, 21, 12, 46, 29, 337, DateTimeKind.Utc).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 46, 29, 337, DateTimeKind.Utc).AddTicks(6522), new DateTime(2025, 10, 21, 12, 46, 29, 337, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 46, 29, 337, DateTimeKind.Utc).AddTicks(6658), new DateTime(2025, 10, 21, 12, 46, 29, 337, DateTimeKind.Utc).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 46, 29, 337, DateTimeKind.Utc).AddTicks(6660), new DateTime(2025, 10, 21, 12, 46, 29, 337, DateTimeKind.Utc).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 46, 29, 337, DateTimeKind.Utc).AddTicks(6662), new DateTime(2025, 10, 21, 12, 46, 29, 337, DateTimeKind.Utc).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 46, 29, 337, DateTimeKind.Utc).AddTicks(6663), new DateTime(2025, 10, 21, 12, 46, 29, 337, DateTimeKind.Utc).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 46, 29, 341, DateTimeKind.Utc).AddTicks(2059), new DateTime(2025, 10, 21, 12, 46, 29, 340, DateTimeKind.Utc).AddTicks(9660), new DateTime(2025, 10, 21, 12, 46, 29, 341, DateTimeKind.Utc).AddTicks(1569), new DateTime(2026, 4, 21, 12, 46, 29, 341, DateTimeKind.Utc).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 46, 29, 341, DateTimeKind.Utc).AddTicks(2186), new DateTime(2025, 10, 21, 12, 46, 29, 341, DateTimeKind.Utc).AddTicks(2180), new DateTime(2025, 10, 21, 12, 46, 29, 341, DateTimeKind.Utc).AddTicks(2182), new DateTime(2026, 1, 21, 12, 46, 29, 341, DateTimeKind.Utc).AddTicks(2182) });
        }
    }
}
