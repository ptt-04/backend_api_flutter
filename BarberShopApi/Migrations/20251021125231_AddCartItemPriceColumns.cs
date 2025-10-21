using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarberShopApi.Migrations
{
    /// <inheritdoc />
    public partial class AddCartItemPriceColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(3348), new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(3488), new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(3490), new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 52, 30, 611, DateTimeKind.Utc).AddTicks(3888), new DateTime(2025, 10, 21, 12, 52, 30, 611, DateTimeKind.Utc).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 52, 30, 611, DateTimeKind.Utc).AddTicks(4036), new DateTime(2025, 10, 21, 12, 52, 30, 611, DateTimeKind.Utc).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 52, 30, 611, DateTimeKind.Utc).AddTicks(4038), new DateTime(2025, 10, 21, 12, 52, 30, 611, DateTimeKind.Utc).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 52, 30, 611, DateTimeKind.Utc).AddTicks(4039), new DateTime(2025, 10, 21, 12, 52, 30, 611, DateTimeKind.Utc).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(1857), new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(1995), new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(1997), new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 52, 30, 611, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 10, 21, 12, 52, 30, 611, DateTimeKind.Utc).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(32), new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(34), new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(35), new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(37), new DateTime(2025, 10, 21, 12, 52, 30, 612, DateTimeKind.Utc).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 52, 30, 614, DateTimeKind.Utc).AddTicks(1316), new DateTime(2025, 10, 21, 12, 52, 30, 613, DateTimeKind.Utc).AddTicks(9445), new DateTime(2025, 10, 21, 12, 52, 30, 614, DateTimeKind.Utc).AddTicks(878), new DateTime(2026, 4, 21, 12, 52, 30, 614, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 52, 30, 614, DateTimeKind.Utc).AddTicks(1446), new DateTime(2025, 10, 21, 12, 52, 30, 614, DateTimeKind.Utc).AddTicks(1440), new DateTime(2025, 10, 21, 12, 52, 30, 614, DateTimeKind.Utc).AddTicks(1442), new DateTime(2026, 1, 21, 12, 52, 30, 614, DateTimeKind.Utc).AddTicks(1443) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
