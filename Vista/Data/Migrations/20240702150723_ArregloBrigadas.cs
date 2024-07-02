using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class ArregloBrigadas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Brigadas_BrigadaId",
                table: "Personas");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Brigadas_BrigadaId",
                table: "Personas",
                column: "BrigadaId",
                principalTable: "Brigadas",
                principalColumn: "BrigadaId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Brigadas_BrigadaId",
                table: "Personas");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Brigadas_BrigadaId",
                table: "Personas",
                column: "BrigadaId",
                principalTable: "Brigadas",
                principalColumn: "BrigadaId");
        }
    }
}
