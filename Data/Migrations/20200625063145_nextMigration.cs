using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone_Proj.Data.Migrations
{
    public partial class nextMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f01a2fd-e719-4069-8a55-cca0a5b54b5d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad0c6c04-8b36-4e10-9585-d5d17b2e8972");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec93ddd1-ad45-43f7-b816-27b624ac86c9");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "ec93ddd1-ad45-43f7-b816-27b624ac86c9", "f215f353-8dd2-4c82-bfa3-36d9308f4639", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f01a2fd-e719-4069-8a55-cca0a5b54b5d", "45617bf0-b5da-40f3-bd89-5734e96c0114", "Guide", "GUIDE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad0c6c04-8b36-4e10-9585-d5d17b2e8972", "6026929c-92aa-4373-bab3-6bbd34429f66", "Customer", "CUSTOMER" });
        }
    }
}
