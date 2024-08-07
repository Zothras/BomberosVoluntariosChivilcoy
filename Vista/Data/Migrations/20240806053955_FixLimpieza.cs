using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixLimpieza : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Limpiezas_Vehiculo_MovilId",
                table: "Limpiezas");

            migrationBuilder.RenameColumn(
                name: "MovilId",
                table: "Limpiezas",
                newName: "VehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Limpiezas_MovilId",
                table: "Limpiezas",
                newName: "IX_Limpiezas_VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Limpiezas_Vehiculo_VehiculoId",
                table: "Limpiezas",
                column: "VehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Limpiezas_Vehiculo_VehiculoId",
                table: "Limpiezas");

            migrationBuilder.RenameColumn(
                name: "VehiculoId",
                table: "Limpiezas",
                newName: "MovilId");

            migrationBuilder.RenameIndex(
                name: "IX_Limpiezas_VehiculoId",
                table: "Limpiezas",
                newName: "IX_Limpiezas_MovilId");

            migrationBuilder.AddForeignKey(
                name: "FK_Limpiezas_Vehiculo_MovilId",
                table: "Limpiezas",
                column: "MovilId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
