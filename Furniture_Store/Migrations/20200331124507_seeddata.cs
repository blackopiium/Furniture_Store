using Microsoft.EntityFrameworkCore.Migrations;

namespace Furniture_Store.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "CategoryId", "FactoryId", "Name", "Price" },
                values: new object[] { 1, 1, 2, "Marsek", 27000f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 1);
        }
    }
}
