using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 31, 15, 42, 32, 260, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("5ffb8c27-8539-4acd-80ac-12f375a92f1c"),
                column: "ConcurrencyStamp",
                value: "fae63c0e-ac18-47eb-8682-fc8bc51e0efd");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2f01688-bcb2-436b-a904-4c676b4ac72c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "46a831b8-c1a3-45f5-bcd3-d666ddbc1f64", "AQAAAAEAACcQAAAAEM4fXSYjAzXV5simtGB+8JI+5JoVKiR3tz7gEqoUmTZKj3j7Ya7xsaT+UHMX1fI/HA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 4, 1, 10, 44, 4, 26, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 31, 15, 42, 32, 260, DateTimeKind.Local).AddTicks(5613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("5ffb8c27-8539-4acd-80ac-12f375a92f1c"),
                column: "ConcurrencyStamp",
                value: "7d5c5a60-06de-456e-ab02-9e1199744827");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2f01688-bcb2-436b-a904-4c676b4ac72c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "28b609ee-792e-4b70-8f3d-aa51c5546954", "AQAAAAEAACcQAAAAEIQLICzqmxpTp36dYg2Dy5Ltm5wYH9ylw3cVeoutfa6q258aZV7wrISOBu9fRlGNxQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 15, 42, 32, 273, DateTimeKind.Local).AddTicks(44));
        }
    }
}
