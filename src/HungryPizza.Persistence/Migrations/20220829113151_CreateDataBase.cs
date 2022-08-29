using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HungryPizza.Persistence.Migrations
{
    public partial class CreateDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Telephone = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Complement = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Neighborhood = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Register = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "PizzaFlavor",
                columns: table => new
                {
                    PizzaFlavorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flavor = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Ingredients = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Available = table.Column<bool>(type: "bit", nullable: true),
                    Register = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaFlavor", x => x.PizzaFlavorID);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    PriceTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Register = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PizzaFlavorsPrice",
                columns: table => new
                {
                    PizzaFlavorsPriceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PizzaFlavorEntityID = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Register = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaFlavorsPrice", x => x.PizzaFlavorsPriceID);
                    table.ForeignKey(
                        name: "FK_PizzaFlavorsPrice_PizzaFlavor_PizzaFlavorEntityID",
                        column: x => x.PizzaFlavorEntityID,
                        principalTable: "PizzaFlavor",
                        principalColumn: "PizzaFlavorID");
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    OrderItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    PriceItem = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Register = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.OrderItemID);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemFlavors",
                columns: table => new
                {
                    ItemFlavorsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderItemID = table.Column<int>(type: "int", nullable: false),
                    PizzaFlavorID = table.Column<int>(type: "int", nullable: false),
                    Register = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemFlavors", x => x.ItemFlavorsID);
                    table.ForeignKey(
                        name: "FK_ItemFlavors_OrderItem_OrderItemID",
                        column: x => x.OrderItemID,
                        principalTable: "OrderItem",
                        principalColumn: "OrderItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemFlavors_PizzaFlavor_PizzaFlavorID",
                        column: x => x.PizzaFlavorID,
                        principalTable: "PizzaFlavor",
                        principalColumn: "PizzaFlavorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_Telephone",
                table: "Client",
                column: "Telephone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemFlavors_OrderItemID",
                table: "ItemFlavors",
                column: "OrderItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemFlavors_PizzaFlavorID",
                table: "ItemFlavors",
                column: "PizzaFlavorID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientID",
                table: "Order",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaFlavorsPrice_PizzaFlavorEntityID",
                table: "PizzaFlavorsPrice",
                column: "PizzaFlavorEntityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemFlavors");

            migrationBuilder.DropTable(
                name: "PizzaFlavorsPrice");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "PizzaFlavor");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
