using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class TablaLimpieza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Limpieza",
                columns: table => new
                {
                    LimpiezaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Incidente = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MovilId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Limpieza", x => x.LimpiezaId);
                    table.ForeignKey(
                        name: "FK_Limpieza_Vehiculo_MovilId",
                        column: x => x.MovilId,
                        principalTable: "Vehiculo",
                        principalColumn: "VehiculoId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BomberoLimpieza",
                columns: table => new
                {
                    BomberosPersonaId = table.Column<int>(type: "int", nullable: false),
                    LimpiezaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BomberoLimpieza", x => new { x.BomberosPersonaId, x.LimpiezaId });
                    table.ForeignKey(
                        name: "FK_BomberoLimpieza_Limpieza_LimpiezaId",
                        column: x => x.LimpiezaId,
                        principalTable: "Limpieza",
                        principalColumn: "LimpiezaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BomberoLimpieza_Personas_BomberosPersonaId",
                        column: x => x.BomberosPersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_BomberoLimpieza_LimpiezaId",
                table: "BomberoLimpieza",
                column: "LimpiezaId");

            migrationBuilder.CreateIndex(
                name: "IX_Limpieza_MovilId",
                table: "Limpieza",
                column: "MovilId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BomberoLimpieza");

            migrationBuilder.DropTable(
                name: "Limpieza");
        }
    }
}
