using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class MasDatosMovimientoMateriales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovimientoMId",
                table: "Movimientos",
                newName: "MovimientoMaterialId");

            migrationBuilder.AlterColumn<string>(
                name: "TipoMovimiento",
                table: "Movimientos",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaIngreso",
                table: "Movimientos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Observaciones",
                table: "Movimientos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaIngreso",
                table: "Movimientos");

            migrationBuilder.DropColumn(
                name: "Observaciones",
                table: "Movimientos");

            migrationBuilder.RenameColumn(
                name: "MovimientoMaterialId",
                table: "Movimientos",
                newName: "MovimientoMId");

            migrationBuilder.AlterColumn<int>(
                name: "TipoMovimiento",
                table: "Movimientos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
