using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class RealcionDeMovilSalidaYBomberoSalida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovilSalidaId",
                table: "BomberosSalida",
                type: "int",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.Sql("UPDATE BomberosSalida  SET MovilSalidaId = '105'");

            migrationBuilder.CreateIndex(
                name: "IX_BomberosSalida_MovilSalidaId",
                table: "BomberosSalida",
                column: "MovilSalidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_BomberosSalida_MovilesSalida_MovilSalidaId",
                table: "BomberosSalida",
                column: "MovilSalidaId",
                principalTable: "MovilesSalida",
                principalColumn: "MovilSalidaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BomberosSalida_MovilesSalida_MovilSalidaId",
                table: "BomberosSalida");

            migrationBuilder.DropIndex(
                name: "IX_BomberosSalida_MovilSalidaId",
                table: "BomberosSalida");

            migrationBuilder.DropColumn(
                name: "MovilSalidaId",
                table: "BomberosSalida");
        }
    }
}
