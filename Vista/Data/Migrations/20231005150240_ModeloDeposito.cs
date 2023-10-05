using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class ModeloDeposito : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depositos",
                columns: table => new
                {
                    DepositoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Alta = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Codigo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rubro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depositos", x => x.DepositoId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Movimientos",
                columns: table => new
                {
                    MovimientoMId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoMovimiento = table.Column<int>(type: "int", nullable: false),
                    DestinoBomberoPersonaId = table.Column<int>(type: "int", nullable: true),
                    DestinoMovilVehiculoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimientos", x => x.MovimientoMId);
                    table.ForeignKey(
                        name: "FK_Movimientos_Personas_DestinoBomberoPersonaId",
                        column: x => x.DestinoBomberoPersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId");
                    table.ForeignKey(
                        name: "FK_Movimientos_Vehiculo_DestinoMovilVehiculoId",
                        column: x => x.DestinoMovilVehiculoId,
                        principalTable: "Vehiculo",
                        principalColumn: "VehiculoId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Materiales",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DepositoId = table.Column<int>(type: "int", nullable: true),
                    MovimientoMId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materiales", x => x.MaterialId);
                    table.ForeignKey(
                        name: "FK_Materiales_Depositos_DepositoId",
                        column: x => x.DepositoId,
                        principalTable: "Depositos",
                        principalColumn: "DepositoId");
                    table.ForeignKey(
                        name: "FK_Materiales_Movimientos_MovimientoMId",
                        column: x => x.MovimientoMId,
                        principalTable: "Movimientos",
                        principalColumn: "MovimientoMId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Materiales_DepositoId",
                table: "Materiales",
                column: "DepositoId");

            migrationBuilder.CreateIndex(
                name: "IX_Materiales_MovimientoMId",
                table: "Materiales",
                column: "MovimientoMId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_DestinoBomberoPersonaId",
                table: "Movimientos",
                column: "DestinoBomberoPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_DestinoMovilVehiculoId",
                table: "Movimientos",
                column: "DestinoMovilVehiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materiales");

            migrationBuilder.DropTable(
                name: "Depositos");

            migrationBuilder.DropTable(
                name: "Movimientos");
        }
    }
}
