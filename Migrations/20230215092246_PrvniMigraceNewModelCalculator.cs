using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebCalculator.Migrations
{
    public partial class PrvniMigraceNewModelCalculator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calculator",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrvniCislo = table.Column<float>(type: "real", nullable: false),
                    DruheCislo = table.Column<float>(type: "real", nullable: false),
                    Vysledek = table.Column<float>(type: "real", nullable: false),
                    Result = table.Column<int>(type: "int", nullable: false),
                    Operace = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculator", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calculator");
        }
    }
}
