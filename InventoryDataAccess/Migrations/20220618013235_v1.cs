using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryDataAccess.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Company");

            migrationBuilder.AddColumn<string>(
                name: "Availability",
                table: "products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Company",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Company");

            migrationBuilder.AddColumn<string>(
                name: "Availability",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
