using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class SalidasFix1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetalleSuperficieAfectada",
                table: "Salidas");

            migrationBuilder.DropColumn(
                name: "DetalleSuperficieDañada",
                table: "Salidas");

            migrationBuilder.RenameColumn(
                name: "TipoRescatePersona",
                table: "Salidas",
                newName: "OtroLugarRescate");

            migrationBuilder.RenameColumn(
                name: "TipoRescateAnimal",
                table: "Salidas",
                newName: "OtroLugarIncendio");

            migrationBuilder.RenameColumn(
                name: "OtroLugar",
                table: "Salidas",
                newName: "LugarRescatePersona");

            migrationBuilder.RenameColumn(
                name: "Otro",
                table: "Salidas",
                newName: "LugarRescateAnimal");

            migrationBuilder.RenameColumn(
                name: "CantidadVehiculos",
                table: "Salidas",
                newName: "CantidadAfectadaMaterialPeligroso");

            migrationBuilder.AddColumn<int>(
                name: "CantidadAfectadaFactorClimatico",
                table: "Salidas",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadAfectadaFactorClimatico",
                table: "Salidas");

            migrationBuilder.RenameColumn(
                name: "OtroLugarRescate",
                table: "Salidas",
                newName: "TipoRescatePersona");

            migrationBuilder.RenameColumn(
                name: "OtroLugarIncendio",
                table: "Salidas",
                newName: "TipoRescateAnimal");

            migrationBuilder.RenameColumn(
                name: "LugarRescatePersona",
                table: "Salidas",
                newName: "OtroLugar");

            migrationBuilder.RenameColumn(
                name: "LugarRescateAnimal",
                table: "Salidas",
                newName: "Otro");

            migrationBuilder.RenameColumn(
                name: "CantidadAfectadaMaterialPeligroso",
                table: "Salidas",
                newName: "CantidadVehiculos");

            migrationBuilder.AddColumn<string>(
                name: "DetalleSuperficieAfectada",
                table: "Salidas",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DetalleSuperficieDañada",
                table: "Salidas",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
