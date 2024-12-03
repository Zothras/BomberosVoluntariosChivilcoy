using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class AgregarEncargadoADependencias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EncargadoPersonaId",
                table: "Dependencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Dependencias_EncargadoPersonaId",
                table: "Dependencias",
                column: "EncargadoPersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dependencias_Personas_EncargadoPersonaId",
                table: "Dependencias",
                column: "EncargadoPersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dependencias_Personas_EncargadoPersonaId",
                table: "Dependencias");

            migrationBuilder.DropIndex(
                name: "IX_Dependencias_EncargadoPersonaId",
                table: "Dependencias");

            migrationBuilder.DropColumn(
                name: "EncargadoPersonaId",
                table: "Dependencias");
        }
    }
}
