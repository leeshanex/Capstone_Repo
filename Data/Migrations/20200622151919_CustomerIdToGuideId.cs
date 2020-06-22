using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone_Proj.Data.Migrations
{
    public partial class CustomerIdToGuideId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Guides",
                table: "Guides");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13872728-794a-491a-901a-8429e3edac09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afa17dec-9ca0-4f42-aafe-fc5d40627805");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1f75ece-f95f-4250-b9e3-4c77ba5680e5");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Guides");

            migrationBuilder.AddColumn<int>(
                name: "GuideId",
                table: "Guides",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guides",
                table: "Guides",
                column: "GuideId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b40762a2-6765-4b49-9346-664a2e491645", "7085f64a-8d7f-4297-8128-1e12b0b9c62b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "33694ade-b9a4-4106-be26-0649bbaef54d", "d1203827-2e81-42d2-a181-d03a23534702", "Guide", "GUIDE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e7c1b2a-a5d8-4df7-bf4b-5572e8c8d5ea", "ac90cfea-2593-48df-bf5c-92c99d771b99", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Guides",
                table: "Guides");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7c1b2a-a5d8-4df7-bf4b-5572e8c8d5ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33694ade-b9a4-4106-be26-0649bbaef54d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b40762a2-6765-4b49-9346-664a2e491645");

            migrationBuilder.DropColumn(
                name: "GuideId",
                table: "Guides");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Guides",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guides",
                table: "Guides",
                column: "CustomerId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f1f75ece-f95f-4250-b9e3-4c77ba5680e5", "b1537e0a-1bd1-499d-8c58-4be049a837be", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "afa17dec-9ca0-4f42-aafe-fc5d40627805", "dd2db911-76f7-4991-be39-b2db607d384a", "Guide", "GUIDE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "13872728-794a-491a-901a-8429e3edac09", "9e138e76-6f95-48db-94a3-f85495df0cb0", "Customer", "CUSTOMER" });
        }
    }
}
