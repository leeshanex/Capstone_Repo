using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone_Proj.Data.Migrations
{
    public partial class ReviewRatingsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2277abb7-87bf-4c4d-93c7-93ec9c3c77cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40a09018-6f84-49f6-a1fb-731dbe2a9cc6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e8d25b0-6fad-4dc5-9651-c3f5dfef237e");

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerRatings = table.Column<double>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_Ratings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerReviews = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_CustomerId",
                table: "Ratings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Reviews");

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
                values: new object[] { "7e8d25b0-6fad-4dc5-9651-c3f5dfef237e", "2d1006c6-dfd3-455c-849c-f36a3a6aebae", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2277abb7-87bf-4c4d-93c7-93ec9c3c77cf", "f5455606-bddb-45e6-8202-5af91c580b89", "Guide", "GUIDE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "40a09018-6f84-49f6-a1fb-731dbe2a9cc6", "0c9de261-b587-41b8-99fc-eee2adcf9704", "Customer", "CUSTOMER" });
        }
    }
}
