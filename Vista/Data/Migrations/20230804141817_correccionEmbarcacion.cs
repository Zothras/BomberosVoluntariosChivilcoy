using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class correccionEmbarcacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Embarcacion_NumeroMovil",
                table: "Vehiculo",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "EmbarcacionId",
                table: "MovilSalida",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmbarcacionId",
                table: "MovilBombero",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmbarcacionId",
                table: "Incidente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmbarcacionId",
                table: "Firmas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MovilSalida_EmbarcacionId",
                table: "MovilSalida",
                column: "EmbarcacionId");

            migrationBuilder.CreateIndex(
                name: "IX_MovilBombero_EmbarcacionId",
                table: "MovilBombero",
                column: "EmbarcacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidente_EmbarcacionId",
                table: "Incidente",
                column: "EmbarcacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Firmas_EmbarcacionId",
                table: "Firmas",
                column: "EmbarcacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Firmas_Vehiculo_EmbarcacionId",
                table: "Firmas",
                column: "EmbarcacionId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidente_Vehiculo_EmbarcacionId",
                table: "Incidente",
                column: "EmbarcacionId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovilBombero_Vehiculo_EmbarcacionId",
                table: "MovilBombero",
                column: "EmbarcacionId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovilSalida_Vehiculo_EmbarcacionId",
                table: "MovilSalida",
                column: "EmbarcacionId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Firmas_Vehiculo_EmbarcacionId",
                table: "Firmas");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidente_Vehiculo_EmbarcacionId",
                table: "Incidente");

            migrationBuilder.DropForeignKey(
                name: "FK_MovilBombero_Vehiculo_EmbarcacionId",
                table: "MovilBombero");

            migrationBuilder.DropForeignKey(
                name: "FK_MovilSalida_Vehiculo_EmbarcacionId",
                table: "MovilSalida");

            migrationBuilder.DropIndex(
                name: "IX_MovilSalida_EmbarcacionId",
                table: "MovilSalida");

            migrationBuilder.DropIndex(
                name: "IX_MovilBombero_EmbarcacionId",
                table: "MovilBombero");

            migrationBuilder.DropIndex(
                name: "IX_Incidente_EmbarcacionId",
                table: "Incidente");

            migrationBuilder.DropIndex(
                name: "IX_Firmas_EmbarcacionId",
                table: "Firmas");

            migrationBuilder.DropColumn(
                name: "EmbarcacionId",
                table: "MovilSalida");

            migrationBuilder.DropColumn(
                name: "EmbarcacionId",
                table: "MovilBombero");

            migrationBuilder.DropColumn(
                name: "EmbarcacionId",
                table: "Incidente");

            migrationBuilder.DropColumn(
                name: "EmbarcacionId",
                table: "Firmas");

            migrationBuilder.AlterColumn<int>(
                name: "Embarcacion_NumeroMovil",
                table: "Vehiculo",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
