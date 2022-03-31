using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 31, 15, 42, 32, 260, DateTimeKind.Local).AddTicks(5613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 31, 15, 28, 57, 677, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("5ffb8c27-8539-4acd-80ac-12f375a92f1c"), "7d5c5a60-06de-456e-ab02-9e1199744827", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("5ffb8c27-8539-4acd-80ac-12f375a92f1c"), new Guid("a2f01688-bcb2-436b-a904-4c676b4ac72c") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a2f01688-bcb2-436b-a904-4c676b4ac72c"), 0, "28b609ee-792e-4b70-8f3d-aa51c5546954", new DateTime(2000, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ngochuyle600@gmail.com", true, "Le", "Huy", false, null, "ngochuyle600@gmail.com", "admin", "AQAAAAEAACcQAAAAEIQLICzqmxpTp36dYg2Dy5Ltm5wYH9ylw3cVeoutfa6q258aZV7wrISOBu9fRlGNxQ==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 15, 42, 32, 273, DateTimeKind.Local).AddTicks(44));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("5ffb8c27-8539-4acd-80ac-12f375a92f1c"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumn: "RoleId",
                keyValue: new Guid("5ffb8c27-8539-4acd-80ac-12f375a92f1c"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2f01688-bcb2-436b-a904-4c676b4ac72c"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 31, 15, 28, 57, 677, DateTimeKind.Local).AddTicks(4518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 31, 15, 42, 32, 260, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 31, 15, 28, 57, 689, DateTimeKind.Local).AddTicks(9830));
        }
    }
}
