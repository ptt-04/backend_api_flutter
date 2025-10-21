using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarberShopApi.Migrations
{
    /// <inheritdoc />
    public partial class FixCartItemColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(5316), new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(5470), new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(5471), new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 55, 14, 935, DateTimeKind.Utc).AddTicks(2108), new DateTime(2025, 10, 21, 12, 55, 14, 935, DateTimeKind.Utc).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 55, 14, 935, DateTimeKind.Utc).AddTicks(2271), new DateTime(2025, 10, 21, 12, 55, 14, 935, DateTimeKind.Utc).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 55, 14, 935, DateTimeKind.Utc).AddTicks(2272), new DateTime(2025, 10, 21, 12, 55, 14, 935, DateTimeKind.Utc).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 55, 14, 935, DateTimeKind.Utc).AddTicks(2274), new DateTime(2025, 10, 21, 12, 55, 14, 935, DateTimeKind.Utc).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(3316), new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(3455), new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(3457), new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(858), new DateTime(2025, 10, 21, 12, 55, 14, 935, DateTimeKind.Utc).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(1001), new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(1003), new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(1005), new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(1007), new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 55, 14, 938, DateTimeKind.Utc).AddTicks(7680), new DateTime(2025, 10, 21, 12, 55, 14, 938, DateTimeKind.Utc).AddTicks(5728), new DateTime(2025, 10, 21, 12, 55, 14, 938, DateTimeKind.Utc).AddTicks(7190), new DateTime(2026, 4, 21, 12, 55, 14, 938, DateTimeKind.Utc).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 55, 14, 938, DateTimeKind.Utc).AddTicks(7833), new DateTime(2025, 10, 21, 12, 55, 14, 938, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 10, 21, 12, 55, 14, 938, DateTimeKind.Utc).AddTicks(7828), new DateTime(2026, 1, 21, 12, 55, 14, 938, DateTimeKind.Utc).AddTicks(7829) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
