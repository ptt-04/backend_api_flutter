using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BarberShopApi.Migrations
{
    /// <inheritdoc />
    public partial class AddPaymentAndBranchSupport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HairStyleSuggestions");

            migrationBuilder.RenameColumn(
                name: "ShippingPhone",
                table: "Orders",
                newName: "DeliveryPhone");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress",
                table: "Orders",
                newName: "DeliveryAddress");

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryMethod",
                table: "Orders",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "Orders",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "CreatedAt", "Description", "IsActive", "Name", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "123 Nguyễn Huệ, Quận 1, TP.HCM", new DateTime(2025, 10, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(5405), "Chi nhánh chính tại trung tâm thành phố", true, "Chi nhánh Quận 1", "028-1234-5678", new DateTime(2025, 10, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(4629) },
                    { 2, "456 Lê Văn Sỹ, Quận 3, TP.HCM", new DateTime(2025, 10, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(5545), "Chi nhánh tại Quận 3", true, "Chi nhánh Quận 3", "028-2345-6789", new DateTime(2025, 10, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(5543) },
                    { 3, "789 Nguyễn Thị Thập, Quận 7, TP.HCM", new DateTime(2025, 10, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(5547), "Chi nhánh tại Quận 7", true, "Chi nhánh Quận 7", "028-3456-7890", new DateTime(2025, 10, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(5546) }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 48, 12, 999, DateTimeKind.Utc).AddTicks(3110), new DateTime(2025, 10, 21, 9, 48, 12, 999, DateTimeKind.Utc).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 48, 12, 999, DateTimeKind.Utc).AddTicks(3261), new DateTime(2025, 10, 21, 9, 48, 12, 999, DateTimeKind.Utc).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 48, 12, 999, DateTimeKind.Utc).AddTicks(3262), new DateTime(2025, 10, 21, 9, 48, 12, 999, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 48, 12, 999, DateTimeKind.Utc).AddTicks(3264), new DateTime(2025, 10, 21, 9, 48, 12, 999, DateTimeKind.Utc).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(1079), new DateTime(2025, 10, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(1211), new DateTime(2025, 10, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(1213), new DateTime(2025, 10, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(1212) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 48, 12, 999, DateTimeKind.Utc).AddTicks(9047), new DateTime(2025, 10, 21, 9, 48, 12, 999, DateTimeKind.Utc).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 48, 12, 999, DateTimeKind.Utc).AddTicks(9180), new DateTime(2025, 10, 21, 9, 48, 12, 999, DateTimeKind.Utc).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 48, 12, 999, DateTimeKind.Utc).AddTicks(9182), new DateTime(2025, 10, 21, 9, 48, 12, 999, DateTimeKind.Utc).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 48, 12, 999, DateTimeKind.Utc).AddTicks(9184), new DateTime(2025, 10, 21, 9, 48, 12, 999, DateTimeKind.Utc).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 48, 12, 999, DateTimeKind.Utc).AddTicks(9186), new DateTime(2025, 10, 21, 9, 48, 12, 999, DateTimeKind.Utc).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(3803), new DateTime(2025, 10, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(2155), new DateTime(2025, 10, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(3405), new DateTime(2026, 4, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Vouchers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(3932), new DateTime(2025, 10, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(3924), new DateTime(2025, 10, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(3927), new DateTime(2026, 1, 21, 9, 48, 13, 0, DateTimeKind.Utc).AddTicks(3928) });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BranchId",
                table: "Orders",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Branches_BranchId",
                table: "Orders",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Branches_BranchId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropIndex(
                name: "IX_Orders_BranchId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeliveryMethod",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "DeliveryPhone",
                table: "Orders",
                newName: "ShippingPhone");

            migrationBuilder.RenameColumn(
                name: "DeliveryAddress",
                table: "Orders",
                newName: "ShippingAddress");

            migrationBuilder.CreateTable(
                name: "HairStyleSuggestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    FaceShape = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HairLength = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HairType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuggestedStyles = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairStyleSuggestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HairStyleSuggestions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(8373), new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(8501), new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(8503), new DateTime(2025, 10, 20, 13, 57, 57, 633, DateTimeKind.Utc).AddTicks(8502) });

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

            migrationBuilder.CreateIndex(
                name: "IX_HairStyleSuggestions_UserId",
                table: "HairStyleSuggestions",
                column: "UserId");
        }
    }
}
