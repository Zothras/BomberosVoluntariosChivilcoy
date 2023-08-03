using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class MovilKmSalidaYKmLLegada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KmLlegada",
                table: "Salidas");

            migrationBuilder.DropColumn(
                name: "KmSalida",
                table: "Salidas");

            migrationBuilder.AddColumn<int>(
                name: "KmLlegada",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KmSalida",
                table: "Vehiculo",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KmLlegada",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "KmSalida",
                table: "Vehiculo");

            migrationBuilder.AddColumn<int>(
                name: "KmLlegada",
                table: "Salidas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KmSalida",
                table: "Salidas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
