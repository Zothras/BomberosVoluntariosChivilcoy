using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class BrigadasBomberosRelationFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bomberoBrigadas_Brigadas_BrigadaId",
                table: "bomberoBrigadas");

            migrationBuilder.DropForeignKey(
                name: "FK_bomberoBrigadas_Persona_BomberoId",
                table: "bomberoBrigadas");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Brigadas_BrigadaId",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Brigadas_Nombre",
                table: "Brigadas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bomberoBrigadas",
                table: "bomberoBrigadas");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Brigadas");

            migrationBuilder.RenameTable(
                name: "bomberoBrigadas",
                newName: "bombero_brigada");

            migrationBuilder.RenameColumn(
                name: "BomberoId",
                table: "bombero_brigada",
                newName: "PersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_bomberoBrigadas_BrigadaId",
                table: "bombero_brigada",
                newName: "IX_bombero_brigada_BrigadaId");

            migrationBuilder.AddColumn<string>(
                name: "NombreBrigada",
                table: "Brigadas",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bombero_brigada",
                table: "bombero_brigada",
                columns: new[] { "PersonaId", "BrigadaId" });

            migrationBuilder.CreateIndex(
                name: "IX_Brigadas_NombreBrigada",
                table: "Brigadas",
                column: "NombreBrigada",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_bombero_brigada_Brigadas_BrigadaId",
                table: "bombero_brigada",
                column: "BrigadaId",
                principalTable: "Brigadas",
                principalColumn: "BrigadaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bombero_brigada_Persona_PersonaId",
                table: "bombero_brigada",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Brigadas_BrigadaId",
                table: "Persona",
                column: "BrigadaId",
                principalTable: "Brigadas",
                principalColumn: "BrigadaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bombero_brigada_Brigadas_BrigadaId",
                table: "bombero_brigada");

            migrationBuilder.DropForeignKey(
                name: "FK_bombero_brigada_Persona_PersonaId",
                table: "bombero_brigada");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Brigadas_BrigadaId",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Brigadas_NombreBrigada",
                table: "Brigadas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bombero_brigada",
                table: "bombero_brigada");

            migrationBuilder.DropColumn(
                name: "NombreBrigada",
                table: "Brigadas");

            migrationBuilder.RenameTable(
                name: "bombero_brigada",
                newName: "bomberoBrigadas");

            migrationBuilder.RenameColumn(
                name: "PersonaId",
                table: "bomberoBrigadas",
                newName: "BomberoId");

            migrationBuilder.RenameIndex(
                name: "IX_bombero_brigada_BrigadaId",
                table: "bomberoBrigadas",
                newName: "IX_bomberoBrigadas_BrigadaId");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Brigadas",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bomberoBrigadas",
                table: "bomberoBrigadas",
                columns: new[] { "BomberoId", "BrigadaId" });

            migrationBuilder.CreateIndex(
                name: "IX_Brigadas_Nombre",
                table: "Brigadas",
                column: "Nombre",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_bomberoBrigadas_Brigadas_BrigadaId",
                table: "bomberoBrigadas",
                column: "BrigadaId",
                principalTable: "Brigadas",
                principalColumn: "BrigadaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bomberoBrigadas_Persona_BomberoId",
                table: "bomberoBrigadas",
                column: "BomberoId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Brigadas_BrigadaId",
                table: "Persona",
                column: "BrigadaId",
                principalTable: "Brigadas",
                principalColumn: "BrigadaId",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
