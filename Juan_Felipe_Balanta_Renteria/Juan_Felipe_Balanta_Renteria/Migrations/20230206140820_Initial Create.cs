using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Juan_Felipe_Balanta_Renteria.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tablero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pais = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Arranque = table.Column<int>(type: "int", nullable: false),
                    Envion = table.Column<int>(type: "int", nullable: false),
                    TotalPeso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tablero", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tablero",
                columns: new[] { "Id", "Arranque", "Envion", "Nombre", "Pais", "TotalPeso" },
                values: new object[] { 1, 134, 177, " Carlos Alvis", "AUS", 311 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tablero");
        }
    }
}
