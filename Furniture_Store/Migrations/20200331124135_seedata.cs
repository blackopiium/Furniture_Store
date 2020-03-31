using Microsoft.EntityFrameworkCore.Migrations;

namespace Furniture_Store.Migrations
{
    public partial class seedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[] { 1, "The best coach for every person only here", "Coaches" });

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "FactoryId", "City", "Country", "Description", "Name" },
                values: new object[] { 2, "Kyiv", "Ukraine", "The Ukrainian Factory of the modern furniture", "Frankof" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "FactoryId",
                keyValue: 2);
        }
    }
}
