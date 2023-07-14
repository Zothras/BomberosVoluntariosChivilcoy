using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class seguroNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Salidas_IncendioSalidaId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_IncendioSalidaId",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "IncendioSalidaId",
                table: "Vehiculo");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroDePoliza",
                table: "Seguros",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CompañiaAseguradora",
                table: "Seguros",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IncendioSalidaId",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Seguros",
                keyColumn: "NumeroDePoliza",
                keyValue: null,
                column: "NumeroDePoliza",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroDePoliza",
                table: "Seguros",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Seguros",
                keyColumn: "CompañiaAseguradora",
                keyValue: null,
                column: "CompañiaAseguradora",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CompañiaAseguradora",
                table: "Seguros",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_IncendioSalidaId",
                table: "Vehiculo",
                column: "IncendioSalidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Salidas_IncendioSalidaId",
                table: "Vehiculo",
                column: "IncendioSalidaId",
                principalTable: "Salidas",
                principalColumn: "SalidaId");
        }
    }
}
