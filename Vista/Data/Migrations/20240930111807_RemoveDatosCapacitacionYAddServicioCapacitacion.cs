using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDatosCapacitacionYAddServicioCapacitacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatosCapacitaciones");

            migrationBuilder.AddColumn<DateTime>(
                name: "DiaHora",
                table: "Salidas",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NivelDeCapacitacion",
                table: "Salidas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NivelDeCapacitacionOtro",
                table: "Salidas",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "TipoCapacitacion",
                table: "Salidas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoCapacitacionOtra",
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
                name: "DiaHora",
                table: "Salidas");

            migrationBuilder.DropColumn(
                name: "NivelDeCapacitacion",
                table: "Salidas");

            migrationBuilder.DropColumn(
                name: "NivelDeCapacitacionOtro",
                table: "Salidas");

            migrationBuilder.DropColumn(
                name: "TipoCapacitacion",
                table: "Salidas");

            migrationBuilder.DropColumn(
                name: "TipoCapacitacionOtra",
                table: "Salidas");

            migrationBuilder.CreateTable(
                name: "DatosCapacitaciones",
                columns: table => new
                {
                    DatosCapacitacionId = table.Column<int>(type: "int", nullable: false),
                    CapacitacionOtra = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DiasCapacitacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HorariosCapacitacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NivelCapacitacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NivelCapacitacionOtro = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SalidaId = table.Column<int>(type: "int", nullable: false),
                    TipoCapacitacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosCapacitaciones", x => x.DatosCapacitacionId);
                    table.ForeignKey(
                        name: "FK_DatosCapacitaciones_Salidas_DatosCapacitacionId",
                        column: x => x.DatosCapacitacionId,
                        principalTable: "Salidas",
                        principalColumn: "SalidaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
