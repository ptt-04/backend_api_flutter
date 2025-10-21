using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BarberShopApi.Migrations
{
    /// <inheritdoc />
    public partial class FixCartItemPriceColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Branches_BranchId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Branches_BranchId",
                table: "Orders",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Branches_BranchId",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "CreatedAt", "Description", "IsActive", "Name", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "123 Nguyễn Huệ, Quận 1, TP.HCM", new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(5316), "Chi nhánh chính tại trung tâm thành phố", true, "Chi Nhánh Quận 1", "028-1234-5678", new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(4337) },
                    { 2, "456 Lê Văn Sỹ, Quận 3, TP.HCM", new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(5470), "Chi nhánh tại khu vực sầm uất", true, "Chi Nhánh Quận 3", "028-2345-6789", new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(5468) },
                    { 3, "789 Nguyễn Thị Thập, Quận 7, TP.HCM", new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(5471), "Chi nhánh tại khu đô thị mới", true, "Chi Nhánh Quận 7", "028-3456-7890", new DateTime(2025, 10, 21, 12, 55, 14, 936, DateTimeKind.Utc).AddTicks(5471) }
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Branches_BranchId",
                table: "Orders",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
