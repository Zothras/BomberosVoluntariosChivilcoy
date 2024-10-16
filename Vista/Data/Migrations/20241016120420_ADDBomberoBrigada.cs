using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class ADDBomberoBrigada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bomberoBrigadas",
                columns: table => new
                {
                    BomberoId = table.Column<int>(type: "int", nullable: false),
                    BrigadaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bomberoBrigadas", x => new { x.BomberoId, x.BrigadaId });
                    table.ForeignKey(
                        name: "FK_bomberoBrigadas_Brigadas_BrigadaId",
                        column: x => x.BrigadaId,
                        principalTable: "Brigadas",
                        principalColumn: "BrigadaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bomberoBrigadas_Personas_BomberoId",
                        column: x => x.BomberoId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_bomberoBrigadas_BrigadaId",
                table: "bomberoBrigadas",
                column: "BrigadaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bomberoBrigadas");
        }
    }
}
