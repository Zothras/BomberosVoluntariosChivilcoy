using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixImagenesMovYEmb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Imagenes_Embarcacion_ImagenId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Imagenes_ImagenId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_Embarcacion_ImagenId",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "Embarcacion_ImagenId",
                table: "Vehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Imagenes_ImagenId",
                table: "Vehiculo",
                column: "ImagenId",
                principalTable: "Imagenes",
                principalColumn: "ImagenId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Imagenes_ImagenId",
                table: "Vehiculo");

            migrationBuilder.AddColumn<int>(
                name: "Embarcacion_ImagenId",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_Embarcacion_ImagenId",
                table: "Vehiculo",
                column: "Embarcacion_ImagenId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Imagenes_Embarcacion_ImagenId",
                table: "Vehiculo",
                column: "Embarcacion_ImagenId",
                principalTable: "Imagenes",
                principalColumn: "ImagenId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Imagenes_ImagenId",
                table: "Vehiculo",
                column: "ImagenId",
                principalTable: "Imagenes",
                principalColumn: "ImagenId");
        }
    }
}
