using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class CambioDatosMovilSalida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreYApellidoRecpetor",
                table: "MovilSalida");

            migrationBuilder.RenameColumn(
                name: "Usuario",
                table: "MovilSalida",
                newName: "TelefonoQuienLleno");

            migrationBuilder.RenameColumn(
                name: "TelefonoReceptor",
                table: "MovilSalida",
                newName: "QuienLleno");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaFactura",
                table: "MovilSalida",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TelefonoQuienLleno",
                table: "MovilSalida",
                newName: "Usuario");

            migrationBuilder.RenameColumn(
                name: "QuienLleno",
                table: "MovilSalida",
                newName: "TelefonoReceptor");

            migrationBuilder.AlterColumn<string>(
                name: "FechaFactura",
                table: "MovilSalida",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NombreYApellidoRecpetor",
                table: "MovilSalida",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
