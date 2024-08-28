using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class Agregar_relacion_MovilSalida_a_BomberoSalida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salio",
                table: "BomberosSalida");

            migrationBuilder.AddColumn<int>(
                name: "MovilAsignadoMovilSalidaId",
                table: "BomberosSalida",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BomberosSalida_MovilAsignadoMovilSalidaId",
                table: "BomberosSalida",
                column: "MovilAsignadoMovilSalidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_BomberosSalida_MovilesSalida_MovilAsignadoMovilSalidaId",
                table: "BomberosSalida",
                column: "MovilAsignadoMovilSalidaId",
                principalTable: "MovilesSalida",
                principalColumn: "MovilSalidaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BomberosSalida_MovilesSalida_MovilAsignadoMovilSalidaId",
                table: "BomberosSalida");

            migrationBuilder.DropIndex(
                name: "IX_BomberosSalida_MovilAsignadoMovilSalidaId",
                table: "BomberosSalida");

            migrationBuilder.DropColumn(
                name: "MovilAsignadoMovilSalidaId",
                table: "BomberosSalida");

            migrationBuilder.AddColumn<bool>(
                name: "Salio",
                table: "BomberosSalida",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
