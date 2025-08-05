using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixSaveImagenBinaria_NotMappedBase64 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Base64Imagen",
                table: "Imagen");

            migrationBuilder.AddColumn<byte[]>(
                name: "DatosImagen",
                table: "Imagen",
                type: "longblob",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatosImagen",
                table: "Imagen");

            migrationBuilder.AddColumn<string>(
                name: "Base64Imagen",
                table: "Imagen",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
