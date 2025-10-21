using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarberShopApi.Migrations
{
    /// <inheritdoc />
    public partial class AddCartTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(4712), new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(4852), new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(4854), new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 40, 41, 630, DateTimeKind.Utc).AddTicks(2597), new DateTime(2025, 10, 21, 12, 40, 41, 630, DateTimeKind.Utc).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 40, 41, 630, DateTimeKind.Utc).AddTicks(2754), new DateTime(2025, 10, 21, 12, 40, 41, 630, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 40, 41, 630, DateTimeKind.Utc).AddTicks(2756), new DateTime(2025, 10, 21, 12, 40, 41, 630, DateTimeKind.Utc).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 40, 41, 630, DateTimeKind.Utc).AddTicks(2757), new DateTime(2025, 10, 21, 12, 40, 41, 630, DateTimeKind.Utc).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(3073), new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(3207), new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(3209), new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(744), new DateTime(2025, 10, 21, 12, 40, 41, 630, DateTimeKind.Utc).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(886), new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(888), new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(889), new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(891), new DateTime(2025, 10, 21, 12, 40, 41, 631, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 40, 41, 633, DateTimeKind.Utc).AddTicks(4308), new DateTime(2025, 10, 21, 12, 40, 41, 633, DateTimeKind.Utc).AddTicks(2514), new DateTime(2025, 10, 21, 12, 40, 41, 633, DateTimeKind.Utc).AddTicks(3877), new DateTime(2026, 4, 21, 12, 40, 41, 633, DateTimeKind.Utc).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 40, 41, 633, DateTimeKind.Utc).AddTicks(4439), new DateTime(2025, 10, 21, 12, 40, 41, 633, DateTimeKind.Utc).AddTicks(4431), new DateTime(2025, 10, 21, 12, 40, 41, 633, DateTimeKind.Utc).AddTicks(4434), new DateTime(2026, 1, 21, 12, 40, 41, 633, DateTimeKind.Utc).AddTicks(4435) });
        }
    }
}
