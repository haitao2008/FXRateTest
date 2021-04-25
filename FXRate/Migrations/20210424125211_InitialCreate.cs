using Microsoft.EntityFrameworkCore.Migrations;

namespace FXRate.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FXRateItems",
                columns: table => new
                {
                    FXRateItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FXBase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FXSymbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FXRateValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FXRateItems", x => x.FXRateItemId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FXRateItems");
        }
    }
}
