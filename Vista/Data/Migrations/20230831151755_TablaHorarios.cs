using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class TablaHorarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HorariosBomberos",
                columns: table => new
                {
                    HorarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VigenteDesde = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    VigenteHasta = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DiaSemana = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HoraDesde = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    HoraHasta = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    Periodo = table.Column<TimeOnly>(type: "time(6)", nullable: true),
                    ModoRotativo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BomberoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorariosBomberos", x => x.HorarioId);
                    table.ForeignKey(
                        name: "FK_HorariosBomberos_Personas_BomberoId",
                        column: x => x.BomberoId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_HorariosBomberos_BomberoId",
                table: "HorariosBomberos",
                column: "BomberoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HorariosBomberos");
        }
    }
}
