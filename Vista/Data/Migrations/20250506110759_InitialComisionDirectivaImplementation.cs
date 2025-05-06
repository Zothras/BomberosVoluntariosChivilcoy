using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialComisionDirectivaImplementation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_fuerzaIntervinientes_Persona_DamnificadoPersonaId",
                table: "fuerzaIntervinientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Salidas_SalidaId",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Persona_DamnificadoId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_DamnificadoId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Persona_SalidaId",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "SalidaId",
                table: "Persona");

            migrationBuilder.RenameColumn(
                name: "DamnificadoPersonaId",
                table: "fuerzaIntervinientes",
                newName: "Damnificado_SalidaId");

            migrationBuilder.RenameIndex(
                name: "IX_fuerzaIntervinientes_DamnificadoPersonaId",
                table: "fuerzaIntervinientes",
                newName: "IX_fuerzaIntervinientes_Damnificado_SalidaId");

            migrationBuilder.AddColumn<string>(
                name: "ComisionDirectiva_Grado",
                table: "Persona",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Damnificados",
                columns: table => new
                {
                    Damnificado_SalidaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sexo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LugarNacimiento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Documento = table.Column<int>(type: "int", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    SalidaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Damnificados", x => x.Damnificado_SalidaId);
                    table.ForeignKey(
                        name: "FK_Damnificados_Salidas_SalidaId",
                        column: x => x.SalidaId,
                        principalTable: "Salidas",
                        principalColumn: "SalidaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_DamnificadoId",
                table: "Vehiculo",
                column: "DamnificadoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Damnificados_SalidaId",
                table: "Damnificados",
                column: "SalidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_fuerzaIntervinientes_Damnificados_Damnificado_SalidaId",
                table: "fuerzaIntervinientes",
                column: "Damnificado_SalidaId",
                principalTable: "Damnificados",
                principalColumn: "Damnificado_SalidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Damnificados_DamnificadoId",
                table: "Vehiculo",
                column: "DamnificadoId",
                principalTable: "Damnificados",
                principalColumn: "Damnificado_SalidaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_fuerzaIntervinientes_Damnificados_Damnificado_SalidaId",
                table: "fuerzaIntervinientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Damnificados_DamnificadoId",
                table: "Vehiculo");

            migrationBuilder.DropTable(
                name: "Damnificados");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_DamnificadoId",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "ComisionDirectiva_Grado",
                table: "Persona");

            migrationBuilder.RenameColumn(
                name: "Damnificado_SalidaId",
                table: "fuerzaIntervinientes",
                newName: "DamnificadoPersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_fuerzaIntervinientes_Damnificado_SalidaId",
                table: "fuerzaIntervinientes",
                newName: "IX_fuerzaIntervinientes_DamnificadoPersonaId");

            migrationBuilder.AddColumn<int>(
                name: "SalidaId",
                table: "Persona",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_DamnificadoId",
                table: "Vehiculo",
                column: "DamnificadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_SalidaId",
                table: "Persona",
                column: "SalidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_fuerzaIntervinientes_Persona_DamnificadoPersonaId",
                table: "fuerzaIntervinientes",
                column: "DamnificadoPersonaId",
                principalTable: "Persona",
                principalColumn: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Salidas_SalidaId",
                table: "Persona",
                column: "SalidaId",
                principalTable: "Salidas",
                principalColumn: "SalidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Persona_DamnificadoId",
                table: "Vehiculo",
                column: "DamnificadoId",
                principalTable: "Persona",
                principalColumn: "PersonaId");
        }
    }
}
