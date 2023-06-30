using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class CambiosSiniestroEmbarcacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoLugarSiniestroEmbarcacion",
                table: "Salidas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TipoLugarSiniestroEmbarcacion",
                table: "Salidas",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
