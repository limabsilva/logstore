using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HungryPizza.Persistence.Migrations
{
    public partial class IncluindoPriceItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaFlavorsPrice_PizzaFlavor_PizzaFlavorEntityID",
                table: "PizzaFlavorsPrice");

            migrationBuilder.AlterColumn<int>(
                name: "PizzaFlavorEntityID",
                table: "PizzaFlavorsPrice",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "PriceItem",
                table: "OrderItem",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaFlavorsPrice_PizzaFlavor_PizzaFlavorEntityID",
                table: "PizzaFlavorsPrice",
                column: "PizzaFlavorEntityID",
                principalTable: "PizzaFlavor",
                principalColumn: "PizzaFlavorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaFlavorsPrice_PizzaFlavor_PizzaFlavorEntityID",
                table: "PizzaFlavorsPrice");

            migrationBuilder.DropColumn(
                name: "PriceItem",
                table: "OrderItem");

            migrationBuilder.AlterColumn<int>(
                name: "PizzaFlavorEntityID",
                table: "PizzaFlavorsPrice",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaFlavorsPrice_PizzaFlavor_PizzaFlavorEntityID",
                table: "PizzaFlavorsPrice",
                column: "PizzaFlavorEntityID",
                principalTable: "PizzaFlavor",
                principalColumn: "PizzaFlavorID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
