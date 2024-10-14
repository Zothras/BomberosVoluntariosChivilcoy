using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class UPDATEFechaAscenso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaEmision",
                table: "AscensoBombero");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "FechaHasta",
                table: "Sanciones",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "FechaDesde",
                table: "Sanciones",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddColumn<DateOnly>(
                name: "FechaAscenso",
                table: "AscensoBombero",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<int>(
                name: "NumeroActa",
                table: "AscensoBombero",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumeroLibero",
                table: "AscensoBombero",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaAscenso",
                table: "AscensoBombero");

            migrationBuilder.DropColumn(
                name: "NumeroActa",
                table: "AscensoBombero");

            migrationBuilder.DropColumn(
                name: "NumeroLibero",
                table: "AscensoBombero");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaHasta",
                table: "Sanciones",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaDesde",
                table: "Sanciones",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaEmision",
                table: "AscensoBombero",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
