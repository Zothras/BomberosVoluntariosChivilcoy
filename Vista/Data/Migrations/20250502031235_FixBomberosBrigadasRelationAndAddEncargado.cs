using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixBomberosBrigadasRelationAndAddEncargado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Brigadas_BrigadaId",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_BrigadaId",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "BrigadaId",
                table: "Persona");

            migrationBuilder.AddColumn<int>(
                name: "EncargadoPersonaId",
                table: "Brigadas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Brigadas_EncargadoPersonaId",
                table: "Brigadas",
                column: "EncargadoPersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Brigadas_Persona_EncargadoPersonaId",
                table: "Brigadas",
                column: "EncargadoPersonaId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brigadas_Persona_EncargadoPersonaId",
                table: "Brigadas");

            migrationBuilder.DropIndex(
                name: "IX_Brigadas_EncargadoPersonaId",
                table: "Brigadas");

            migrationBuilder.DropColumn(
                name: "EncargadoPersonaId",
                table: "Brigadas");

            migrationBuilder.AddColumn<int>(
                name: "BrigadaId",
                table: "Persona",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persona_BrigadaId",
                table: "Persona",
                column: "BrigadaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Brigadas_BrigadaId",
                table: "Persona",
                column: "BrigadaId",
                principalTable: "Brigadas",
                principalColumn: "BrigadaId");
        }
    }
}
