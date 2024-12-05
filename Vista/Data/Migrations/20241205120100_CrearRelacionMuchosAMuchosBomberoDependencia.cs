using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class CrearRelacionMuchosAMuchosBomberoDependencia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BomberoDependencia_Dependencias_DependenciaId",
                table: "BomberoDependencia");

            migrationBuilder.DropForeignKey(
                name: "FK_BomberoDependencia_Personas_PersonaId",
                table: "BomberoDependencia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BomberoDependencia",
                table: "BomberoDependencia");

            migrationBuilder.DropIndex(
                name: "IX_BomberoDependencia_PersonaId",
                table: "BomberoDependencia");

            migrationBuilder.DropColumn(
                name: "Bombero_DependenciaId",
                table: "BomberoDependencia");

            migrationBuilder.AlterColumn<int>(
                name: "PersonaId",
                table: "BomberoDependencia",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DependenciaId",
                table: "BomberoDependencia",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BomberoDependencia",
                table: "BomberoDependencia",
                columns: new[] { "PersonaId", "DependenciaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BomberoDependencia_Dependencias_DependenciaId",
                table: "BomberoDependencia",
                column: "DependenciaId",
                principalTable: "Dependencias",
                principalColumn: "DependenciaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BomberoDependencia_Personas_PersonaId",
                table: "BomberoDependencia",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BomberoDependencia_Dependencias_DependenciaId",
                table: "BomberoDependencia");

            migrationBuilder.DropForeignKey(
                name: "FK_BomberoDependencia_Personas_PersonaId",
                table: "BomberoDependencia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BomberoDependencia",
                table: "BomberoDependencia");

            migrationBuilder.AlterColumn<int>(
                name: "DependenciaId",
                table: "BomberoDependencia",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PersonaId",
                table: "BomberoDependencia",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Bombero_DependenciaId",
                table: "BomberoDependencia",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BomberoDependencia",
                table: "BomberoDependencia",
                column: "Bombero_DependenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_BomberoDependencia_PersonaId",
                table: "BomberoDependencia",
                column: "PersonaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BomberoDependencia_Dependencias_DependenciaId",
                table: "BomberoDependencia",
                column: "DependenciaId",
                principalTable: "Dependencias",
                principalColumn: "DependenciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_BomberoDependencia_Personas_PersonaId",
                table: "BomberoDependencia",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId");
        }
    }
}
