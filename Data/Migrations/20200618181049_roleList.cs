using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone_Proj.Data.Migrations
{
    public partial class roleList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0bda5a92-faf8-45ee-a826-1426313aebae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f489caa-99a0-46d8-a094-d0583b8d934a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "830ea2d8-c527-4b02-baf5-119d3fd885ca");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81fe82aa-780f-463d-834a-c09b078807ad", "5baf1c46-a910-4aee-9d7b-7a0b0d2aa609", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c927c2f-0f0c-41ae-b48d-57bbe7ebbf69", "cd13ea9b-2a7f-4927-b64e-5c850585ff47", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d80ce2e-8e9e-4cfc-b9c2-b8507c667bc1", "4ae87501-8698-4093-8027-1a0ea19d2e59", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d80ce2e-8e9e-4cfc-b9c2-b8507c667bc1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c927c2f-0f0c-41ae-b48d-57bbe7ebbf69");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81fe82aa-780f-463d-834a-c09b078807ad");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0bda5a92-faf8-45ee-a826-1426313aebae", "4626980e-437b-4ac9-9783-b4b3c0b13f04", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "830ea2d8-c527-4b02-baf5-119d3fd885ca", "26869133-92b6-4bce-90a8-5f92ed5e70cd", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7f489caa-99a0-46d8-a094-d0583b8d934a", "c576be08-3ea9-47c8-847e-ee56acc9a9fa", "Customer", "CUSTOMER" });
        }
    }
}
