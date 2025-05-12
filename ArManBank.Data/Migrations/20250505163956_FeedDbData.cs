using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArManBank.Data.Migrations
{
    /// <inheritdoc />
    public partial class FeedDbData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Users",
                newName: "CreateDate");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Balance", "CreateDate", "FirstName", "LastName", "TypeOfBalance" },
                values: new object[,]
                {
                    { 1, 1340.75m, new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe", 0 },
                    { 2, 987.60m, new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emma", "Smith", 0 },
                    { 3, 2590.00m, new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liam", "Johnson", 2 },
                    { 4, 410.50m, new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olivia", "Brown", 1 },
                    { 5, 1325.25m, new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noah", "Williams", 0 },
                    { 6, 830.80m, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ava", "Jones", 1 },
                    { 7, 4200.00m, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", "Miller", 2 },
                    { 8, 1550.30m, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabella", "Davis", 0 },
                    { 9, 670.00m, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", "Garcia", 0 },
                    { 10, 2999.99m, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sophia", "Martinez", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Users",
                newName: "DateTime");
        }
    }
}
