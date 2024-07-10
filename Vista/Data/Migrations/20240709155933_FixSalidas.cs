using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class FixSalidas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BomberosSalida_MovilesSalida_MovilSalidaId",
                table: "BomberosSalida");

            migrationBuilder.DropForeignKey(
                name: "FK_BomberosSalida_Salidas_SalidaId",
                table: "BomberosSalida");

            migrationBuilder.DropForeignKey(
                name: "FK_MovilesSalida_Salidas_SalidaId",
                table: "MovilesSalida");

            migrationBuilder.DropIndex(
                name: "IX_BomberosSalida_MovilSalidaId",
                table: "BomberosSalida");

            migrationBuilder.DropColumn(
                name: "MovilSalidaId",
                table: "BomberosSalida");

            migrationBuilder.AlterColumn<int>(
                name: "SalidaId",
                table: "MovilesSalida",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SalidaId",
                table: "BomberosSalida",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BomberosSalida_Salidas_SalidaId",
                table: "BomberosSalida",
                column: "SalidaId",
                principalTable: "Salidas",
                principalColumn: "SalidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovilesSalida_Salidas_SalidaId",
                table: "MovilesSalida",
                column: "SalidaId",
                principalTable: "Salidas",
                principalColumn: "SalidaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BomberosSalida_Salidas_SalidaId",
                table: "BomberosSalida");

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

            migrationBuilder.AlterColumn<int>(
                name: "SalidaId",
                table: "BomberosSalida",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovilSalidaId",
                table: "BomberosSalida",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BomberosSalida_MovilSalidaId",
                table: "BomberosSalida",
                column: "MovilSalidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_BomberosSalida_MovilesSalida_MovilSalidaId",
                table: "BomberosSalida",
                column: "MovilSalidaId",
                principalTable: "MovilesSalida",
                principalColumn: "MovilSalidaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BomberosSalida_Salidas_SalidaId",
                table: "BomberosSalida",
                column: "SalidaId",
                principalTable: "Salidas",
                principalColumn: "SalidaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovilesSalida_Salidas_SalidaId",
                table: "MovilesSalida",
                column: "SalidaId",
                principalTable: "Salidas",
                principalColumn: "SalidaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
