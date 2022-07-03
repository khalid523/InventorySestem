using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryDataAccess.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "attributes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Totalvalue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "brand",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    VatCharge = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Availability = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerAddress = table.Column<string>(nullable: true),
                    CustomerPhone = table.Column<string>(nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    Rate = table.Column<double>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    GrossAmount = table.Column<double>(nullable: false),
                    Vat = table.Column<double>(nullable: false),
                    NetAmount = table.Column<double>(nullable: false),
                    PaidStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "attributesvalue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    attributes_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attributesvalue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_attributesvalue_attributes_attributes_Id",
                        column: x => x.attributes_Id,
                        principalTable: "attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    company_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_stores_Company_company_Id",
                        column: x => x.company_Id,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Sku = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Qty = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    category_Id = table.Column<int>(nullable: false),
                    brand_Id = table.Column<int>(nullable: false),
                    stores_Id = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    Size_Id = table.Column<int>(nullable: false),
                    Color_Id = table.Column<int>(nullable: false),
                    AttributesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_attributes_AttributesId",
                        column: x => x.AttributesId,
                        principalTable: "attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_products_attributesvalue_Color_Id",
                        column: x => x.Color_Id,
                        principalTable: "attributesvalue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_attributesvalue_Size_Id",
                        column: x => x.Size_Id,
                        principalTable: "attributesvalue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_products_brand_brand_Id",
                        column: x => x.brand_Id,
                        principalTable: "brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_products_Categories_category_Id",
                        column: x => x.category_Id,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_products_stores_stores_Id",
                        column: x => x.stores_Id,
                        principalTable: "stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Porduct_Order",
                columns: table => new
                {
                    product_Id = table.Column<int>(nullable: false),
                    orders_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Porduct_Order", x => new { x.product_Id, x.orders_Id });
                    table.ForeignKey(
                        name: "FK_Porduct_Order_orders_orders_Id",
                        column: x => x.orders_Id,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Porduct_Order_products_product_Id",
                        column: x => x.product_Id,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_attributesvalue_attributes_Id",
                table: "attributesvalue",
                column: "attributes_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Porduct_Order_orders_Id",
                table: "Porduct_Order",
                column: "orders_Id");

            migrationBuilder.CreateIndex(
                name: "IX_products_AttributesId",
                table: "products",
                column: "AttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_products_Color_Id",
                table: "products",
                column: "Color_Id");

            migrationBuilder.CreateIndex(
                name: "IX_products_Size_Id",
                table: "products",
                column: "Size_Id");

            migrationBuilder.CreateIndex(
                name: "IX_products_brand_Id",
                table: "products",
                column: "brand_Id");

            migrationBuilder.CreateIndex(
                name: "IX_products_category_Id",
                table: "products",
                column: "category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_products_stores_Id",
                table: "products",
                column: "stores_Id");

            migrationBuilder.CreateIndex(
                name: "IX_stores_company_Id",
                table: "stores",
                column: "company_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Porduct_Order");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "attributesvalue");

            migrationBuilder.DropTable(
                name: "brand");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "stores");

            migrationBuilder.DropTable(
                name: "attributes");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
