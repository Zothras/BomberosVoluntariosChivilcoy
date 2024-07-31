using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixImagenMovil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Imagenes_ImagenId",
                table: "Vehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Imagenes_ImagenId",
                table: "Vehiculo",
                column: "ImagenId",
                principalTable: "Imagenes",
                principalColumn: "ImagenId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Imagenes_ImagenId",
                table: "Vehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Imagenes_ImagenId",
                table: "Vehiculo",
                column: "ImagenId",
                principalTable: "Imagenes",
                principalColumn: "ImagenId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
