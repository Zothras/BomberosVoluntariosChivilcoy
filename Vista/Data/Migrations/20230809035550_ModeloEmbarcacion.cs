using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class ModeloEmbarcacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidente_Vehiculo_MovilVehiculoId",
                table: "Incidente");

            migrationBuilder.DropColumn(
                name: "KmLlegada",
                table: "Salidas");

            migrationBuilder.DropColumn(
                name: "KmSalida",
                table: "Salidas");

            migrationBuilder.RenameColumn(
                name: "MovilVehiculoId",
                table: "Incidente",
                newName: "VehiculoSalidaVehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Incidente_MovilVehiculoId",
                table: "Incidente",
                newName: "IX_Incidente_VehiculoSalidaVehiculoId");

            migrationBuilder.AddColumn<int>(
                name: "Embarcacion_ImagenId",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EncargadoId",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "kilometraje",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KmLlegada",
                table: "MovilSalida",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmbarcacionVehiculoId",
                table: "Firmas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_Embarcacion_ImagenId",
                table: "Vehiculo",
                column: "Embarcacion_ImagenId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_EncargadoId",
                table: "Vehiculo",
                column: "EncargadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Firmas_EmbarcacionVehiculoId",
                table: "Firmas",
                column: "EmbarcacionVehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Firmas_Vehiculo_EmbarcacionVehiculoId",
                table: "Firmas",
                column: "EmbarcacionVehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidente_Vehiculo_VehiculoSalidaVehiculoId",
                table: "Incidente",
                column: "VehiculoSalidaVehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Imagenes_Embarcacion_ImagenId",
                table: "Vehiculo",
                column: "Embarcacion_ImagenId",
                principalTable: "Imagenes",
                principalColumn: "ImagenId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Personas_EncargadoId",
                table: "Vehiculo",
                column: "EncargadoId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Firmas_Vehiculo_EmbarcacionVehiculoId",
                table: "Firmas");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidente_Vehiculo_VehiculoSalidaVehiculoId",
                table: "Incidente");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Imagenes_Embarcacion_ImagenId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Personas_EncargadoId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_Embarcacion_ImagenId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_EncargadoId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Firmas_EmbarcacionVehiculoId",
                table: "Firmas");

            migrationBuilder.DropColumn(
                name: "Embarcacion_ImagenId",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "EncargadoId",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "kilometraje",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "KmLlegada",
                table: "MovilSalida");

            migrationBuilder.DropColumn(
                name: "EmbarcacionVehiculoId",
                table: "Firmas");

            migrationBuilder.RenameColumn(
                name: "VehiculoSalidaVehiculoId",
                table: "Incidente",
                newName: "MovilVehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Incidente_VehiculoSalidaVehiculoId",
                table: "Incidente",
                newName: "IX_Incidente_MovilVehiculoId");

            migrationBuilder.AddColumn<int>(
                name: "KmLlegada",
                table: "Salidas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KmSalida",
                table: "Salidas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidente_Vehiculo_MovilVehiculoId",
                table: "Incidente",
                column: "MovilVehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId");
        }
    }
}
