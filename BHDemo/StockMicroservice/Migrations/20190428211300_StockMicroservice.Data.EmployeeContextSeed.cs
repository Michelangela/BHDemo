using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMicroservice.Migrations
{
    public partial class StockMicroserviceDataEmployeeContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stock",
                table: "Stock");

            migrationBuilder.RenameTable(
                name: "Stock",
                newName: "Stocks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "Date", "Price", "Symbol" },
                values: new object[] { 1, new DateTime(2019, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1923.77m, "AMZN" });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "Date", "Price", "Symbol" },
                values: new object[] { 2, new DateTime(2019, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1902.00m, "AMZN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "Stocks",
                newName: "Stock");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stock",
                table: "Stock",
                column: "Id");
        }
    }
}
