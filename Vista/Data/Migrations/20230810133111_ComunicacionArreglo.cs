using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class ComunicacionArreglo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comunicacion_Personas_EquipoId",
                table: "Comunicacion");

            migrationBuilder.AlterColumn<string>(
                name: "NroEquipo",
                table: "Comunicacion",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "EquipoId",
                table: "Comunicacion",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EquipoId",
                table: "Personas",
                column: "EquipoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comunicacion_NroEquipo",
                table: "Comunicacion",
                column: "NroEquipo",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Comunicacion_EquipoId",
                table: "Personas",
                column: "EquipoId",
                principalTable: "Comunicacion",
                principalColumn: "EquipoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Comunicacion_EquipoId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_EquipoId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Comunicacion_NroEquipo",
                table: "Comunicacion");

            migrationBuilder.AlterColumn<string>(
                name: "NroEquipo",
                table: "Comunicacion",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "EquipoId",
                table: "Comunicacion",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Comunicacion_Personas_EquipoId",
                table: "Comunicacion",
                column: "EquipoId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
