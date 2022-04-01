using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("5ffb8c27-8539-4acd-80ac-12f375a92f1c"),
                column: "ConcurrencyStamp",
                value: "da93f811-1a32-4785-a471-99ef9669f9f6");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2f01688-bcb2-436b-a904-4c676b4ac72c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a34835d-ae73-4be2-9639-e0c0ce8b5dcb", "AQAAAAEAACcQAAAAEAOqQE0VVhq0VOaraAOkH97y8XfkqkFqdovjuR8xBoZFRWp9kaEpBm6ux9Ulc1JJBw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 4, 1, 11, 52, 16, 115, DateTimeKind.Local).AddTicks(8261));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

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
        }
    }
}
