using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class ActualizarRelacionBomberoSalidaMovilFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BomberosSalida_MovilesSalida_MovilAsignadoMovilSalidaId",
                table: "BomberosSalida");

            migrationBuilder.RenameColumn(
                name: "MovilAsignadoMovilSalidaId",
                table: "BomberosSalida",
                newName: "MovilAsignadoVehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_BomberosSalida_MovilAsignadoMovilSalidaId",
                table: "BomberosSalida",
                newName: "IX_BomberosSalida_MovilAsignadoVehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_BomberosSalida_Vehiculo_MovilAsignadoVehiculoId",
                table: "BomberosSalida",
                column: "MovilAsignadoVehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BomberosSalida_Vehiculo_MovilAsignadoVehiculoId",
                table: "BomberosSalida");

            migrationBuilder.RenameColumn(
                name: "MovilAsignadoVehiculoId",
                table: "BomberosSalida",
                newName: "MovilAsignadoMovilSalidaId");

            migrationBuilder.RenameIndex(
                name: "IX_BomberosSalida_MovilAsignadoVehiculoId",
                table: "BomberosSalida",
                newName: "IX_BomberosSalida_MovilAsignadoMovilSalidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_BomberosSalida_MovilesSalida_MovilAsignadoMovilSalidaId",
                table: "BomberosSalida",
                column: "MovilAsignadoMovilSalidaId",
                principalTable: "MovilesSalida",
                principalColumn: "MovilSalidaId");
        }
    }
}
