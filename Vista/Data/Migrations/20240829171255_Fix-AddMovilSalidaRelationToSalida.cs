using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixAddMovilSalidaRelationToSalida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovilesSalida_Salidas_SalidaId",
                table: "MovilesSalida");

            migrationBuilder.AlterColumn<int>(
                name: "SalidaId",
                table: "MovilesSalida",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MovilesSalida_Salidas_SalidaId",
                table: "MovilesSalida",
                column: "SalidaId",
                principalTable: "Salidas",
                principalColumn: "SalidaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovilesSalida_Salidas_SalidaId",
                table: "MovilesSalida");

            migrationBuilder.AlterColumn<int>(
                name: "SalidaId",
                table: "MovilesSalida",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MovilesSalida_Salidas_SalidaId",
                table: "MovilesSalida",
                column: "SalidaId",
                principalTable: "Salidas",
                principalColumn: "SalidaId");
        }
    }
}
