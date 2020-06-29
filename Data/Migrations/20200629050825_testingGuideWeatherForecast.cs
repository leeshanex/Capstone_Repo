using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone_Proj.Data.Migrations
{
    public partial class testingGuideWeatherForecast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28d537da-f58e-473e-9686-8c12e48a612d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "add2dd22-100a-4c0c-8977-cf6362d1daf8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec6287a7-3967-4409-be7d-02e8be00e1fb");

            migrationBuilder.AddColumn<DateTime>(
                name: "TripDate",
                table: "FishingTrips",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "WeatherForecast",
                columns: table => new
                {
                },
                constraints: table =>
                {
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a868be99-8ca5-4abe-bc71-3b912cf44431", "d13db019-5b28-4f66-b458-a9e3afc310fc", "Guide", "GUIDE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19f97405-bb30-4933-ab85-f7402699f1d3", "40a3a27d-2fac-422b-a4b2-8ca1f4a8bfea", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherForecast");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19f97405-bb30-4933-ab85-f7402699f1d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a868be99-8ca5-4abe-bc71-3b912cf44431");

            migrationBuilder.DropColumn(
                name: "TripDate",
                table: "FishingTrips");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "add2dd22-100a-4c0c-8977-cf6362d1daf8", "a35fafc2-6d73-4b29-b48f-7da2b3a1a553", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "28d537da-f58e-473e-9686-8c12e48a612d", "53becd97-5b95-46fa-ba11-b044905b10d6", "Guide", "GUIDE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec6287a7-3967-4409-be7d-02e8be00e1fb", "09ba7fd7-46e1-4388-88bc-2d2ca7a31396", "Customer", "CUSTOMER" });
        }
    }
}
