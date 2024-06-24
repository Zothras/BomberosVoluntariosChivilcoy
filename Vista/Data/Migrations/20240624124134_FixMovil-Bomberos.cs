using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class FixMovilBomberos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Vehiculo_MovilId",
                table: "Personas");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Vehiculo_MovilId",
                table: "Personas",
                column: "MovilId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Vehiculo_MovilId",
                table: "Personas");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Vehiculo_MovilId",
                table: "Personas",
                column: "MovilId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
