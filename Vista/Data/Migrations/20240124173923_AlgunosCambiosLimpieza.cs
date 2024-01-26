using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class AlgunosCambiosLimpieza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Limpieza_Vehiculo_MovilId",
                table: "Limpieza");

            migrationBuilder.DropTable(
                name: "BomberoLimpieza");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Limpieza",
                table: "Limpieza");

            migrationBuilder.RenameTable(
                name: "Limpieza",
                newName: "Limpiezas");

            migrationBuilder.RenameIndex(
                name: "IX_Limpieza_MovilId",
                table: "Limpiezas",
                newName: "IX_Limpiezas_MovilId");

            migrationBuilder.AddColumn<int>(
                name: "MovilId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovilId",
                table: "Limpiezas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Incidente",
                table: "Limpiezas",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "BomberosPersonaId",
                table: "Limpiezas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Limpiezas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Limpiezas",
                table: "Limpiezas",
                column: "LimpiezaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_MovilId",
                table: "Personas",
                column: "MovilId");

            migrationBuilder.CreateIndex(
                name: "IX_Limpiezas_BomberosPersonaId",
                table: "Limpiezas",
                column: "BomberosPersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Limpiezas_Personas_BomberosPersonaId",
                table: "Limpiezas",
                column: "BomberosPersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Limpiezas_Vehiculo_MovilId",
                table: "Limpiezas",
                column: "MovilId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Vehiculo_MovilId",
                table: "Personas",
                column: "MovilId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Limpiezas_Personas_BomberosPersonaId",
                table: "Limpiezas");

            migrationBuilder.DropForeignKey(
                name: "FK_Limpiezas_Vehiculo_MovilId",
                table: "Limpiezas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Vehiculo_MovilId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_MovilId",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Limpiezas",
                table: "Limpiezas");

            migrationBuilder.DropIndex(
                name: "IX_Limpiezas_BomberosPersonaId",
                table: "Limpiezas");

            migrationBuilder.DropColumn(
                name: "MovilId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "BomberosPersonaId",
                table: "Limpiezas");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Limpiezas");

            migrationBuilder.RenameTable(
                name: "Limpiezas",
                newName: "Limpieza");

            migrationBuilder.RenameIndex(
                name: "IX_Limpiezas_MovilId",
                table: "Limpieza",
                newName: "IX_Limpieza_MovilId");

            migrationBuilder.AlterColumn<int>(
                name: "MovilId",
                table: "Limpieza",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Incidente",
                table: "Limpieza",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Limpieza",
                table: "Limpieza",
                column: "LimpiezaId");

            migrationBuilder.CreateTable(
                name: "BomberoLimpieza",
                columns: table => new
                {
                    BomberosPersonaId = table.Column<int>(type: "int", nullable: false),
                    LimpiezaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BomberoLimpieza", x => new { x.BomberosPersonaId, x.LimpiezaId });
                    table.ForeignKey(
                        name: "FK_BomberoLimpieza_Limpieza_LimpiezaId",
                        column: x => x.LimpiezaId,
                        principalTable: "Limpieza",
                        principalColumn: "LimpiezaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BomberoLimpieza_Personas_BomberosPersonaId",
                        column: x => x.BomberosPersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_BomberoLimpieza_LimpiezaId",
                table: "BomberoLimpieza",
                column: "LimpiezaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Limpieza_Vehiculo_MovilId",
                table: "Limpieza",
                column: "MovilId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
