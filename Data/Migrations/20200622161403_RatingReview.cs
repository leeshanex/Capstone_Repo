using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone_Proj.Data.Migrations
{
    public partial class RatingReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_PaymentMethod_PaymentMethodId",
                table: "Accounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentMethod",
                table: "PaymentMethod");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d4169a5-434a-4736-a244-dc9a9f0d7118");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a05ce80-1694-45fe-a2cd-87342bbd06ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83702d9b-75ff-4d2b-bb0f-582f2c82dca2");

            migrationBuilder.RenameTable(
                name: "PaymentMethod",
                newName: "PaymentMethods");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentMethods",
                table: "PaymentMethods",
                column: "PaymentMethodId");

            migrationBuilder.CreateTable(
                name: "FishingTrips",
                columns: table => new
                {
                    TripId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripPhoto = table.Column<string>(nullable: true),
                    TripHistory = table.Column<string>(nullable: true),
                    GuideId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishingTrips", x => x.TripId);
                    table.ForeignKey(
                        name: "FK_FishingTrips_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FishingTrips_Guides_GuideId",
                        column: x => x.GuideId,
                        principalTable: "Guides",
                        principalColumn: "GuideId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inboxes",
                columns: table => new
                {
                    InboxId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessagesReceived = table.Column<string>(nullable: true),
                    MessagesSent = table.Column<string>(nullable: true),
                    GuideId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inboxes", x => x.InboxId);
                    table.ForeignKey(
                        name: "FK_Inboxes_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inboxes_Guides_GuideId",
                        column: x => x.GuideId,
                        principalTable: "Guides",
                        principalColumn: "GuideId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spots",
                columns: table => new
                {
                    AreaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PinLocation = table.Column<double>(nullable: false),
                    GuideId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spots", x => x.AreaId);
                    table.ForeignKey(
                        name: "FK_Spots_Guides_GuideId",
                        column: x => x.GuideId,
                        principalTable: "Guides",
                        principalColumn: "GuideId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_FishingTrips_CustomerId",
                table: "FishingTrips",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_FishingTrips_GuideId",
                table: "FishingTrips",
                column: "GuideId");

            migrationBuilder.CreateIndex(
                name: "IX_Inboxes_CustomerId",
                table: "Inboxes",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Inboxes_GuideId",
                table: "Inboxes",
                column: "GuideId");

            migrationBuilder.CreateIndex(
                name: "IX_Spots_GuideId",
                table: "Spots",
                column: "GuideId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_PaymentMethods_PaymentMethodId",
                table: "Accounts",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "PaymentMethodId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_PaymentMethods_PaymentMethodId",
                table: "Accounts");

            migrationBuilder.DropTable(
                name: "FishingTrips");

            migrationBuilder.DropTable(
                name: "Inboxes");

            migrationBuilder.DropTable(
                name: "Spots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentMethods",
                table: "PaymentMethods");

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

            migrationBuilder.RenameTable(
                name: "PaymentMethods",
                newName: "PaymentMethod");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentMethod",
                table: "PaymentMethod",
                column: "PaymentMethodId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d4169a5-434a-4736-a244-dc9a9f0d7118", "b45f9ff6-6ae8-455b-b019-79ed9ddd66f7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "83702d9b-75ff-4d2b-bb0f-582f2c82dca2", "6c0cdbc5-ec3b-410f-9928-735498b9d796", "Guide", "GUIDE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a05ce80-1694-45fe-a2cd-87342bbd06ee", "b0b82536-0562-4a68-b5a7-f4466d984350", "Customer", "CUSTOMER" });

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_PaymentMethod_PaymentMethodId",
                table: "Accounts",
                column: "PaymentMethodId",
                principalTable: "PaymentMethod",
                principalColumn: "PaymentMethodId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
