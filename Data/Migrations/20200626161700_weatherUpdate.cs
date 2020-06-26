using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone_Proj.Data.Migrations
{
    public partial class weatherUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94d9ac3c-a984-4553-97d7-be3ce8265626");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99c3f777-43f6-403b-a0b5-220ec5b5a7f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7e454bd-a0bf-451b-ba83-6539960f431b");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "99c3f777-43f6-403b-a0b5-220ec5b5a7f5", "2e371610-ba7f-4f42-9a1a-b34294ea01a5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c7e454bd-a0bf-451b-ba83-6539960f431b", "7c3adb7d-8e19-40cf-818f-e8fffc066a67", "Guide", "GUIDE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94d9ac3c-a984-4553-97d7-be3ce8265626", "9f3f8277-0659-417a-9e99-ac10f2e7a7d1", "Customer", "CUSTOMER" });
        }
    }
}
