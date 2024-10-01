using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class DrizaFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detalles",
                table: "Salidas",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ServicioEspecialColocaciónDriza_NombreEstablecimiento",
                table: "Salidas",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ServicioEspecialColocaciónDriza_TipoLugar",
                table: "Salidas",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detalles",
                table: "Salidas");

            migrationBuilder.DropColumn(
                name: "ServicioEspecialColocaciónDriza_NombreEstablecimiento",
                table: "Salidas");

            migrationBuilder.DropColumn(
                name: "ServicioEspecialColocaciónDriza_TipoLugar",
                table: "Salidas");
        }
    }
}
