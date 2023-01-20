using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerceApplication.Server.Migrations
{
    /// <inheritdoc />
    public partial class productListSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, " 7+ Specialized Nutrition Drink Powder", "https://m.media-amazon.com/images/I/71FM2dBCaVL._AC_UL320_.jpg", 390.9m, "Pediasure0g" },
                    { 2, "Health & Nutrition Drink for Toddlers & Young Kids", "https://m.media-amazon.com/images/I/61ptL7H+M4L._AC_UL320_.jpg", 444.9m, "Junior Horlicks" },
                    { 3, "Kellogg's Chocos Moons & Stars 1.2kg with Whole Grain", "https://m.media-amazon.com/images/I/61hm-b9tZ9L._AC_UL320_.jpg", 399.0m, "Kellogg's Chocos" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);
        }
    }
}
