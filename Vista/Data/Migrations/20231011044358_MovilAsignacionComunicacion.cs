using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class MovilAsignacionComunicacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EquipoId",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_EquipoId",
                table: "Vehiculo",
                column: "EquipoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Comunicacion_EquipoId",
                table: "Vehiculo",
                column: "EquipoId",
                principalTable: "Comunicacion",
                principalColumn: "EquipoId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Comunicacion_EquipoId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_EquipoId",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "EquipoId",
                table: "Vehiculo");
        }
    }
}
