using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HepsiSln.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 52, 51, 600, DateTimeKind.Local).AddTicks(3180), "Books" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 52, 51, 600, DateTimeKind.Local).AddTicks(6578), "Movies & Jewelery" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 52, 51, 600, DateTimeKind.Local).AddTicks(6617), "Books" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 52, 51, 605, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 52, 51, 605, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 52, 51, 605, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 52, 51, 605, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 52, 51, 611, DateTimeKind.Local).AddTicks(4426), "Quia expedita enim nesciunt consequuntur.", "İmpedit eligendi." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 52, 51, 611, DateTimeKind.Local).AddTicks(4776), "Animi magnam ratione unde culpa.", "Repellendus quos." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 52, 51, 611, DateTimeKind.Local).AddTicks(4853), "Rerum sed neque sunt voluptatum.", "Omnis id." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 52, 51, 617, DateTimeKind.Local).AddTicks(223), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", -7.0752701084289410m, 622.92m, "Gorgeous Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 52, 51, 617, DateTimeKind.Local).AddTicks(553), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", -5.3042052245770070m, 298.45m, "Unbranded Steel Pants" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 51, 18, 417, DateTimeKind.Local).AddTicks(5538), "Grocery, Outdoors & Games" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 51, 18, 417, DateTimeKind.Local).AddTicks(5576), "Garden, Home & Books" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 51, 18, 417, DateTimeKind.Local).AddTicks(5590), "Health" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 20, 51, 18, 420, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 20, 51, 18, 420, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 20, 51, 18, 420, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 20, 51, 18, 420, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 51, 18, 423, DateTimeKind.Local).AddTicks(8498), "Omnis et est accusamus repudiandae.", "Quam quibusdam." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 51, 18, 423, DateTimeKind.Local).AddTicks(8709), "Exercitationem rerum deleniti delectus pariatur.", "Sunt et." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 51, 18, 423, DateTimeKind.Local).AddTicks(8816), "Facere nesciunt tenetur praesentium nostrum.", "Molestiae enim." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 51, 18, 427, DateTimeKind.Local).AddTicks(3136), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", -6.3510328265259380m, -721.26m, "Ergonomic Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 51, 18, 427, DateTimeKind.Local).AddTicks(3338), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", -5.8074387574130080m, 938.27m, "Licensed Metal Hat" });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");
        }
    }
}
