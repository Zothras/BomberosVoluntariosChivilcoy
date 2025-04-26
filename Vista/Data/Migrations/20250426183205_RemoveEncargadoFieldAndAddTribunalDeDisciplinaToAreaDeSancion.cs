using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveEncargadoFieldAndAddTribunalDeDisciplinaToAreaDeSancion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sanciones_Persona_EncargadoAreaId",
                table: "Sanciones");

            migrationBuilder.DropIndex(
                name: "IX_Sanciones_EncargadoAreaId",
                table: "Sanciones");

            migrationBuilder.DropColumn(
                name: "EncargadoAreaId",
                table: "Sanciones");

            migrationBuilder.DropColumn(
                name: "observaciones",
                table: "Sanciones");

            migrationBuilder.AddColumn<string>(
                name: "DescripcionSancion",
                table: "Sanciones",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescripcionSancion",
                table: "Sanciones");

            migrationBuilder.AddColumn<int>(
                name: "EncargadoAreaId",
                table: "Sanciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "observaciones",
                table: "Sanciones",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Sanciones_EncargadoAreaId",
                table: "Sanciones",
                column: "EncargadoAreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sanciones_Persona_EncargadoAreaId",
                table: "Sanciones",
                column: "EncargadoAreaId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
