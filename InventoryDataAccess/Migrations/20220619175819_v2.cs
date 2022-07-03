using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryDataAccess.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_stores_Company_company_Id",
                table: "stores");

            migrationBuilder.DropIndex(
                name: "IX_stores_company_Id",
                table: "stores");

            migrationBuilder.DropColumn(
                name: "company_Id",
                table: "stores");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "company_Id",
                table: "stores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_stores_company_Id",
                table: "stores",
                column: "company_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_stores_Company_company_Id",
                table: "stores",
                column: "company_Id",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
