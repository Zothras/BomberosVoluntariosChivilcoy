using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class DatosReceptorYCombustibles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Receptor",
                table: "Salidas",
                newName: "TelefonoReceptor");

            migrationBuilder.AlterColumn<int>(
                name: "Año",
                table: "Vehiculo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "NombreYApellidoReceptor",
                table: "Salidas",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CantidadLitros",
                table: "MovilSalida",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FechaFactura",
                table: "MovilSalida",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NombreYApellidoRecpetor",
                table: "MovilSalida",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NumeroFactura",
                table: "MovilSalida",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "TelefonoReceptor",
                table: "MovilSalida",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "TipoConbustible",
                table: "MovilSalida",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "MovilSalida",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreYApellidoReceptor",
                table: "Salidas");

            migrationBuilder.DropColumn(
                name: "CantidadLitros",
                table: "MovilSalida");

            migrationBuilder.DropColumn(
                name: "FechaFactura",
                table: "MovilSalida");

            migrationBuilder.DropColumn(
                name: "NombreYApellidoRecpetor",
                table: "MovilSalida");

            migrationBuilder.DropColumn(
                name: "NumeroFactura",
                table: "MovilSalida");

            migrationBuilder.DropColumn(
                name: "TelefonoReceptor",
                table: "MovilSalida");

            migrationBuilder.DropColumn(
                name: "TipoConbustible",
                table: "MovilSalida");

            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "MovilSalida");

            migrationBuilder.RenameColumn(
                name: "TelefonoReceptor",
                table: "Salidas",
                newName: "Receptor");

            migrationBuilder.AlterColumn<int>(
                name: "Año",
                table: "Vehiculo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
