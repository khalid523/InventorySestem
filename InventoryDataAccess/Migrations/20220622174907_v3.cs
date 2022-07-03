using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryDataAccess.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Totalvalue",
                table: "attributes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Totalvalue",
                table: "attributes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
