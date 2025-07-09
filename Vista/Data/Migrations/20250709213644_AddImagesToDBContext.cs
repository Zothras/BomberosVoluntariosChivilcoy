using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddImagesToDBContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imagen_Persona_PersonalId",
                table: "Imagen");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Imagen_ImagenId",
                table: "Vehiculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Imagen",
                table: "Imagen");

            migrationBuilder.RenameTable(
                name: "Imagen",
                newName: "Imagenes");

            migrationBuilder.RenameIndex(
                name: "IX_Imagen_PersonalId",
                table: "Imagenes",
                newName: "IX_Imagenes_PersonalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Imagenes",
                table: "Imagenes",
                column: "ImagenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagenes_Persona_PersonalId",
                table: "Imagenes",
                column: "PersonalId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Imagenes_Persona_PersonalId",
                table: "Imagenes");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Imagenes_ImagenId",
                table: "Vehiculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Imagenes",
                table: "Imagenes");

            migrationBuilder.RenameTable(
                name: "Imagenes",
                newName: "Imagen");

            migrationBuilder.RenameIndex(
                name: "IX_Imagenes_PersonalId",
                table: "Imagen",
                newName: "IX_Imagen_PersonalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Imagen",
                table: "Imagen",
                column: "ImagenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagen_Persona_PersonalId",
                table: "Imagen",
                column: "PersonalId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Imagen_ImagenId",
                table: "Vehiculo",
                column: "ImagenId",
                principalTable: "Imagen",
                principalColumn: "ImagenId",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
