using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class FixIncendioVehiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Damnificados_DamnificadoId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Seguros_SeguroId",
                table: "Vehiculo");

            migrationBuilder.AlterColumn<int>(
                name: "SeguroId",
                table: "Vehiculo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Vehiculo",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Damnificados_DamnificadoId",
                table: "Vehiculo",
                column: "DamnificadoId",
                principalTable: "Damnificados",
                principalColumn: "DamnificadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Seguros_SeguroId",
                table: "Vehiculo",
                column: "SeguroId",
                principalTable: "Seguros",
                principalColumn: "SeguroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Damnificados_DamnificadoId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Seguros_SeguroId",
                table: "Vehiculo");

            migrationBuilder.AlterColumn<int>(
                name: "SeguroId",
                table: "Vehiculo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Vehiculo",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Damnificados_DamnificadoId",
                table: "Vehiculo",
                column: "DamnificadoId",
                principalTable: "Damnificados",
                principalColumn: "DamnificadoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Seguros_SeguroId",
                table: "Vehiculo",
                column: "SeguroId",
                principalTable: "Seguros",
                principalColumn: "SeguroId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
