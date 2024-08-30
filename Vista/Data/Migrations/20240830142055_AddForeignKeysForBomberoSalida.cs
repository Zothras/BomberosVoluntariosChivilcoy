using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeysForBomberoSalida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BomberosSalida_Salidas_SalidaId",
                table: "BomberosSalida");

            migrationBuilder.DropForeignKey(
                name: "FK_BomberosSalida_Vehiculo_MovilAsignadoVehiculoId",
                table: "BomberosSalida");

            migrationBuilder.RenameColumn(
                name: "MovilAsignadoVehiculoId",
                table: "BomberosSalida",
                newName: "MovilId");

            migrationBuilder.RenameIndex(
                name: "IX_BomberosSalida_MovilAsignadoVehiculoId",
                table: "BomberosSalida",
                newName: "IX_BomberosSalida_MovilId");

            migrationBuilder.AlterColumn<int>(
                name: "SalidaId",
                table: "BomberosSalida",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BomberosSalida_Salidas_SalidaId",
                table: "BomberosSalida",
                column: "SalidaId",
                principalTable: "Salidas",
                principalColumn: "SalidaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BomberosSalida_Vehiculo_MovilId",
                table: "BomberosSalida",
                column: "MovilId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BomberosSalida_Salidas_SalidaId",
                table: "BomberosSalida");

            migrationBuilder.DropForeignKey(
                name: "FK_BomberosSalida_Vehiculo_MovilId",
                table: "BomberosSalida");

            migrationBuilder.RenameColumn(
                name: "MovilId",
                table: "BomberosSalida",
                newName: "MovilAsignadoVehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_BomberosSalida_MovilId",
                table: "BomberosSalida",
                newName: "IX_BomberosSalida_MovilAsignadoVehiculoId");

            migrationBuilder.AlterColumn<int>(
                name: "SalidaId",
                table: "BomberosSalida",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BomberosSalida_Salidas_SalidaId",
                table: "BomberosSalida",
                column: "SalidaId",
                principalTable: "Salidas",
                principalColumn: "SalidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_BomberosSalida_Vehiculo_MovilAsignadoVehiculoId",
                table: "BomberosSalida",
                column: "MovilAsignadoVehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId");
        }
    }
}
