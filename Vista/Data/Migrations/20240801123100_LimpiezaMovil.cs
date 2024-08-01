using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class LimpiezaMovil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Limpiezas_BomberosPersonaId",
                table: "Limpiezas");

            migrationBuilder.DropColumn(
                name: "MovilId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "BomberosPersonaId",
                table: "Limpiezas");

            migrationBuilder.AddColumn<string>(
                name: "Observaciones",
                table: "Limpiezas",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "ResponsableId",
                table: "Limpiezas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Limpiezas_ResponsableId",
                table: "Limpiezas",
                column: "ResponsableId");

            migrationBuilder.AddForeignKey(
                name: "FK_Limpiezas_Personas_ResponsableId",
                table: "Limpiezas",
                column: "ResponsableId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Limpiezas_Vehiculo_MovilId",
                table: "Limpiezas",
                column: "MovilId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Limpiezas_Personas_ResponsableId",
                table: "Limpiezas");

            migrationBuilder.DropForeignKey(
                name: "FK_Limpiezas_Vehiculo_MovilId",
                table: "Limpiezas");

            migrationBuilder.DropIndex(
                name: "IX_Limpiezas_ResponsableId",
                table: "Limpiezas");

            migrationBuilder.DropColumn(
                name: "Observaciones",
                table: "Limpiezas");

            migrationBuilder.DropColumn(
                name: "ResponsableId",
                table: "Limpiezas");

            migrationBuilder.AddColumn<int>(
                name: "MovilId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BomberosPersonaId",
                table: "Limpiezas",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                principalColumn: "VehiculoId");
        }
    }
}
