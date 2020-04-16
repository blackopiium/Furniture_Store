using Microsoft.EntityFrameworkCore.Migrations;

namespace Furniture_Store.Migrations
{
    public partial class iditem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Charachteristics_Item_Item_ItemId",
                table: "Charachteristics_Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Items_Item_ItemId",
                table: "Order_Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Item");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Item",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "CategoryId", "FactoryId", "Name", "Price" },
                values: new object[] { 1, 1, 2, "Marsek", 27000f });

            migrationBuilder.AddForeignKey(
                name: "FK_Charachteristics_Item_Item_ItemId",
                table: "Charachteristics_Item",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Items_Item_ItemId",
                table: "Order_Items",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Charachteristics_Item_Item_ItemId",
                table: "Charachteristics_Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Items_Item_ItemId",
                table: "Order_Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Item");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "ItemId");

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "CategoryId", "FactoryId", "Name", "Price" },
                values: new object[] { 1, 1, 2, "Marsek", 27000f });

            migrationBuilder.AddForeignKey(
                name: "FK_Charachteristics_Item_Item_ItemId",
                table: "Charachteristics_Item",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Items_Item_ItemId",
                table: "Order_Items",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
