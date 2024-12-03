using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class AgregarDependencias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BomberoDependencia_Dependencia_DependenciaId",
                table: "BomberoDependencia");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidente_Dependencia_DependenciaId",
                table: "Incidente");

            migrationBuilder.DropTable(
                name: "Dependencia");

            migrationBuilder.RenameColumn(
                name: "BomberoDependenciaId",
                table: "BomberoDependencia",
                newName: "Bombero_DependenciaId");

            migrationBuilder.CreateTable(
                name: "Dependencias",
                columns: table => new
                {
                    DependenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreDependencia = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependencias", x => x.DependenciaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_BomberoDependencia_Dependencias_DependenciaId",
                table: "BomberoDependencia",
                column: "DependenciaId",
                principalTable: "Dependencias",
                principalColumn: "DependenciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidente_Dependencias_DependenciaId",
                table: "Incidente",
                column: "DependenciaId",
                principalTable: "Dependencias",
                principalColumn: "DependenciaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BomberoDependencia_Dependencias_DependenciaId",
                table: "BomberoDependencia");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidente_Dependencias_DependenciaId",
                table: "Incidente");

            migrationBuilder.DropTable(
                name: "Dependencias");

            migrationBuilder.RenameColumn(
                name: "Bombero_DependenciaId",
                table: "BomberoDependencia",
                newName: "BomberoDependenciaId");

            migrationBuilder.CreateTable(
                name: "Dependencia",
                columns: table => new
                {
                    DependenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreDependencia = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependencia", x => x.DependenciaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_BomberoDependencia_Dependencia_DependenciaId",
                table: "BomberoDependencia",
                column: "DependenciaId",
                principalTable: "Dependencia",
                principalColumn: "DependenciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidente_Dependencia_DependenciaId",
                table: "Incidente",
                column: "DependenciaId",
                principalTable: "Dependencia",
                principalColumn: "DependenciaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
