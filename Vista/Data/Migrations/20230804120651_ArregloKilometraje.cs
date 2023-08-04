using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class ArregloKilometraje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KmLlegada",
                table: "Vehiculo");

            migrationBuilder.RenameColumn(
                name: "KmSalida",
                table: "Vehiculo",
                newName: "kilometraje");

            migrationBuilder.AddColumn<int>(
                name: "KmLlegada",
                table: "MovilSalida",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KmLlegada",
                table: "MovilSalida");

            migrationBuilder.RenameColumn(
                name: "kilometraje",
                table: "Vehiculo",
                newName: "KmSalida");

            migrationBuilder.AddColumn<int>(
                name: "KmLlegada",
                table: "Vehiculo",
                type: "int",
                nullable: true);
        }
    }
}
