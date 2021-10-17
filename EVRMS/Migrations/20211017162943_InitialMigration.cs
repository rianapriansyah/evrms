using Microsoft.EntityFrameworkCore.Migrations;

namespace EVRMS.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductStocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStocks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProductStocks",
                columns: new[] { "Id", "ProductName", "UnitStock" },
                values: new object[] { 1, "Panci Tahan Banting", 10 });

            migrationBuilder.InsertData(
                table: "ProductStocks",
                columns: new[] { "Id", "ProductName", "UnitStock" },
                values: new object[] { 2, "Ember Serba Guna", 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductStocks");
        }
    }
}
