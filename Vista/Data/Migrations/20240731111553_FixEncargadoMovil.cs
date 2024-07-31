using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixEncargadoMovil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Personas_EncargadoId",
                table: "Vehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Personas_EncargadoId",
                table: "Vehiculo",
                column: "EncargadoId",
                principalTable: "Personas",
                principalColumn: "PersonaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Personas_EncargadoId",
                table: "Vehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Personas_EncargadoId",
                table: "Vehiculo",
                column: "EncargadoId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
