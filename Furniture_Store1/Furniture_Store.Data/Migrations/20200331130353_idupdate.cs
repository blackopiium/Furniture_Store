using Microsoft.EntityFrameworkCore.Migrations;

namespace Furniture_Store.Migrations
{
    public partial class idupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Category_CategoryId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Factory_FactoryId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Client_ClientId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Items_Order_OrderId",
                table: "Order_Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Factory",
                table: "Factory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "FactoryId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "FactoryId",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Category");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Order",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Factory",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Client",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Category",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Factory",
                table: "Factory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "The best coach for every person only here", "Coaches" });

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "Id", "City", "Country", "Description", "Name" },
                values: new object[] { 2, "Kyiv", "Ukraine", "The Ukrainian Factory of the modern furniture", "Frankof" });

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Category_CategoryId",
                table: "Item",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Factory_FactoryId",
                table: "Item",
                column: "FactoryId",
                principalTable: "Factory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Client_ClientId",
                table: "Order",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Items_Order_OrderId",
                table: "Order_Items",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Category_CategoryId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Factory_FactoryId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Client_ClientId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Items_Order_OrderId",
                table: "Order_Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Factory",
                table: "Factory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Factory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Category");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "FactoryId",
                table: "Factory",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Factory",
                table: "Factory",
                column: "FactoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[] { 1, "The best coach for every person only here", "Coaches" });

            migrationBuilder.InsertData(
                table: "Factory",
                columns: new[] { "FactoryId", "City", "Country", "Description", "Name" },
                values: new object[] { 2, "Kyiv", "Ukraine", "The Ukrainian Factory of the modern furniture", "Frankof" });

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Category_CategoryId",
                table: "Item",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Factory_FactoryId",
                table: "Item",
                column: "FactoryId",
                principalTable: "Factory",
                principalColumn: "FactoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Client_ClientId",
                table: "Order",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Items_Order_OrderId",
                table: "Order_Items",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
