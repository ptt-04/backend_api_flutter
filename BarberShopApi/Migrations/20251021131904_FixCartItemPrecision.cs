using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarberShopApi.Migrations
{
    /// <inheritdoc />
    public partial class FixCartItemPrecision : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 19, 3, 356, DateTimeKind.Utc).AddTicks(9687), new DateTime(2025, 10, 21, 13, 19, 3, 356, DateTimeKind.Utc).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 19, 3, 356, DateTimeKind.Utc).AddTicks(9835), new DateTime(2025, 10, 21, 13, 19, 3, 356, DateTimeKind.Utc).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 19, 3, 356, DateTimeKind.Utc).AddTicks(9837), new DateTime(2025, 10, 21, 13, 19, 3, 356, DateTimeKind.Utc).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 19, 3, 356, DateTimeKind.Utc).AddTicks(9838), new DateTime(2025, 10, 21, 13, 19, 3, 356, DateTimeKind.Utc).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 19, 3, 357, DateTimeKind.Utc).AddTicks(7785), new DateTime(2025, 10, 21, 13, 19, 3, 357, DateTimeKind.Utc).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 19, 3, 357, DateTimeKind.Utc).AddTicks(7915), new DateTime(2025, 10, 21, 13, 19, 3, 357, DateTimeKind.Utc).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 19, 3, 357, DateTimeKind.Utc).AddTicks(7917), new DateTime(2025, 10, 21, 13, 19, 3, 357, DateTimeKind.Utc).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 19, 3, 357, DateTimeKind.Utc).AddTicks(5906), new DateTime(2025, 10, 21, 13, 19, 3, 357, DateTimeKind.Utc).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 19, 3, 357, DateTimeKind.Utc).AddTicks(6043), new DateTime(2025, 10, 21, 13, 19, 3, 357, DateTimeKind.Utc).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 19, 3, 357, DateTimeKind.Utc).AddTicks(6045), new DateTime(2025, 10, 21, 13, 19, 3, 357, DateTimeKind.Utc).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 19, 3, 357, DateTimeKind.Utc).AddTicks(6047), new DateTime(2025, 10, 21, 13, 19, 3, 357, DateTimeKind.Utc).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 19, 3, 357, DateTimeKind.Utc).AddTicks(6048), new DateTime(2025, 10, 21, 13, 19, 3, 357, DateTimeKind.Utc).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 19, 3, 359, DateTimeKind.Utc).AddTicks(3772), new DateTime(2025, 10, 21, 13, 19, 3, 359, DateTimeKind.Utc).AddTicks(1926), new DateTime(2025, 10, 21, 13, 19, 3, 359, DateTimeKind.Utc).AddTicks(3313), new DateTime(2026, 4, 21, 13, 19, 3, 359, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 19, 3, 359, DateTimeKind.Utc).AddTicks(3938), new DateTime(2025, 10, 21, 13, 19, 3, 359, DateTimeKind.Utc).AddTicks(3925), new DateTime(2025, 10, 21, 13, 19, 3, 359, DateTimeKind.Utc).AddTicks(3931), new DateTime(2026, 1, 21, 13, 19, 3, 359, DateTimeKind.Utc).AddTicks(3932) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(2351), new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(2503), new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(2504), new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(2506), new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 8, 5, 797, DateTimeKind.Utc).AddTicks(308), new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 8, 5, 797, DateTimeKind.Utc).AddTicks(442), new DateTime(2025, 10, 21, 13, 8, 5, 797, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 8, 5, 797, DateTimeKind.Utc).AddTicks(444), new DateTime(2025, 10, 21, 13, 8, 5, 797, DateTimeKind.Utc).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(8437), new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(8576), new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(8577), new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(8579), new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(8581), new DateTime(2025, 10, 21, 13, 8, 5, 796, DateTimeKind.Utc).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 8, 5, 798, DateTimeKind.Utc).AddTicks(8482), new DateTime(2025, 10, 21, 13, 8, 5, 798, DateTimeKind.Utc).AddTicks(6548), new DateTime(2025, 10, 21, 13, 8, 5, 798, DateTimeKind.Utc).AddTicks(7853), new DateTime(2026, 4, 21, 13, 8, 5, 798, DateTimeKind.Utc).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 8, 5, 798, DateTimeKind.Utc).AddTicks(8612), new DateTime(2025, 10, 21, 13, 8, 5, 798, DateTimeKind.Utc).AddTicks(8605), new DateTime(2025, 10, 21, 13, 8, 5, 798, DateTimeKind.Utc).AddTicks(8608), new DateTime(2026, 1, 21, 13, 8, 5, 798, DateTimeKind.Utc).AddTicks(8609) });
        }
    }
}
