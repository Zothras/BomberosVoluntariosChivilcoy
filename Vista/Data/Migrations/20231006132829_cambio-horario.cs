using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class cambiohorario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Periodo",
                table: "HorariosBomberos",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(TimeOnly),
                oldType: "time(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "HoraHasta",
                table: "HorariosBomberos",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HoraDesde",
                table: "HorariosBomberos",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time(6)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeOnly>(
                name: "Periodo",
                table: "HorariosBomberos",
                type: "time(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "HoraHasta",
                table: "HorariosBomberos",
                type: "time(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "HoraDesde",
                table: "HorariosBomberos",
                type: "time(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }
    }
}
