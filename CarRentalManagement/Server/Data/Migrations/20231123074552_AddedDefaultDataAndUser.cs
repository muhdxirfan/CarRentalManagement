using Microsoft.EntityFrameworkCore.Migrations;

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "7665ab67-58ea-493c-b5eb-73db1f9972c1", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEI+SOCtuJIXRZ6UMxR+Jv7LuEjNZnpcPDE4f535ZnnxKK81Yu1uprvEhY25X6WOrsQ==", null, false, "68e7fdfc-2dda-46b7-ab40-d3bb0cefae22", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 23, 15, 45, 52, 498, DateTimeKind.Local).AddTicks(8963), new DateTime(2023, 11, 23, 15, 45, 52, 498, DateTimeKind.Local).AddTicks(8977), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 23, 15, 45, 52, 498, DateTimeKind.Local).AddTicks(8981), new DateTime(2023, 11, 23, 15, 45, 52, 498, DateTimeKind.Local).AddTicks(8981), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 23, 15, 45, 52, 498, DateTimeKind.Local).AddTicks(9346), new DateTime(2023, 11, 23, 15, 45, 52, 498, DateTimeKind.Local).AddTicks(9347), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 23, 15, 45, 52, 498, DateTimeKind.Local).AddTicks(9349), new DateTime(2023, 11, 23, 15, 45, 52, 498, DateTimeKind.Local).AddTicks(9349), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 23, 15, 45, 52, 498, DateTimeKind.Local).AddTicks(9533), new DateTime(2023, 11, 23, 15, 45, 52, 498, DateTimeKind.Local).AddTicks(9534), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 23, 15, 45, 52, 498, DateTimeKind.Local).AddTicks(9536), new DateTime(2023, 11, 23, 15, 45, 52, 498, DateTimeKind.Local).AddTicks(9536), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 23, 15, 45, 52, 498, DateTimeKind.Local).AddTicks(9537), new DateTime(2023, 11, 23, 15, 45, 52, 498, DateTimeKind.Local).AddTicks(9538), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 23, 15, 45, 52, 498, DateTimeKind.Local).AddTicks(9539), new DateTime(2023, 11, 23, 15, 45, 52, 498, DateTimeKind.Local).AddTicks(9539), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
