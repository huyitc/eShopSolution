using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class DataBaseNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("5ffb8c27-8539-4acd-80ac-12f375a92f1c"),
                column: "ConcurrencyStamp",
                value: "ffcc1019-15bc-4eb1-bedd-52a46114ea21");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2f01688-bcb2-436b-a904-4c676b4ac72c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f804446-2a82-42a4-8ed9-a1876fb2cb3c", "AQAAAAEAACcQAAAAENYv5p51Foz3rUhhO78IlA/mIWU95A5d1vFXpJbTR5gr9u8QuVCUtIcjwafHOX2iBQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 4, 4, 8, 45, 55, 959, DateTimeKind.Local).AddTicks(5924));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
