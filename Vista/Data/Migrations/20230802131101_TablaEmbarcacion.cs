using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class TablaEmbarcacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmbarcacionId",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Embarcacion_Estado",
                table: "Vehiculo",
                type: "int",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Embarcacion_ImagenId",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Embarcacion_NumeroMovil",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EncargadoId",
                table: "Vehiculo",
                type: "int",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmbarcacionVehiculoId",
                table: "Imagenes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_Embarcacion_ImagenId",
                table: "Vehiculo",
                column: "Embarcacion_ImagenId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_EncargadoId",
                table: "Vehiculo",
                column: "EncargadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Imagenes_EmbarcacionVehiculoId",
                table: "Imagenes",
                column: "EmbarcacionVehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagenes_Vehiculo_EmbarcacionVehiculoId",
                table: "Imagenes",
                column: "EmbarcacionVehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Imagenes_Vehiculo_EmbarcacionVehiculoId",
                table: "Imagenes");

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
                name: "IX_Imagenes_EmbarcacionVehiculoId",
                table: "Imagenes");

            migrationBuilder.DropColumn(
                name: "EmbarcacionId",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "Embarcacion_Estado",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "Embarcacion_ImagenId",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "Embarcacion_NumeroMovil",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "EncargadoId",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "EmbarcacionVehiculoId",
                table: "Imagenes");
        }
    }
}
