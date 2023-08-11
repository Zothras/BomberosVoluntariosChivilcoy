using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class ComunicacionSetNullFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Comunicacion_EquipoId",
                table: "Personas");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Comunicacion_EquipoId",
                table: "Personas",
                column: "EquipoId",
                principalTable: "Comunicacion",
                principalColumn: "EquipoId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Comunicacion_EquipoId",
                table: "Personas");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Comunicacion_EquipoId",
                table: "Personas",
                column: "EquipoId",
                principalTable: "Comunicacion",
                principalColumn: "EquipoId");
        }
    }
}
