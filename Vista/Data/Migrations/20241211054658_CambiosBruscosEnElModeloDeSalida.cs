using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class CambiosBruscosEnElModeloDeSalida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salidas_Personas_ReceptorId",
                table: "Salidas");

            migrationBuilder.DropIndex(
                name: "IX_Salidas_ReceptorId",
                table: "Salidas");

            migrationBuilder.DropColumn(
                name: "CalleORuta",
                table: "Salidas");

            migrationBuilder.DropColumn(
                name: "EntreCalles",
                table: "Salidas");

            migrationBuilder.DropColumn(
                name: "ReceptorId",
                table: "Salidas");

            migrationBuilder.RenameColumn(
                name: "NumeroOKilometro",
                table: "Salidas",
                newName: "Direccion");

            migrationBuilder.AlterColumn<string>(
                name: "TelefonoSolicitante",
                table: "Salidas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreSolicitante",
                table: "Salidas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<double>(
                name: "Longitud",
                table: "Salidas",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Latitud",
                table: "Salidas",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DniSolicitante",
                table: "Salidas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ApellidoSolicitante",
                table: "Salidas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Salidas",
                newName: "NumeroOKilometro");

            migrationBuilder.UpdateData(
                table: "Salidas",
                keyColumn: "TelefonoSolicitante",
                keyValue: null,
                column: "TelefonoSolicitante",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "TelefonoSolicitante",
                table: "Salidas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Salidas",
                keyColumn: "NombreSolicitante",
                keyValue: null,
                column: "NombreSolicitante",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NombreSolicitante",
                table: "Salidas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<double>(
                name: "Longitud",
                table: "Salidas",
                type: "double",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<double>(
                name: "Latitud",
                table: "Salidas",
                type: "double",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.UpdateData(
                table: "Salidas",
                keyColumn: "DniSolicitante",
                keyValue: null,
                column: "DniSolicitante",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "DniSolicitante",
                table: "Salidas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Salidas",
                keyColumn: "ApellidoSolicitante",
                keyValue: null,
                column: "ApellidoSolicitante",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ApellidoSolicitante",
                table: "Salidas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CalleORuta",
                table: "Salidas",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "EntreCalles",
                table: "Salidas",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "ReceptorId",
                table: "Salidas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salidas_ReceptorId",
                table: "Salidas",
                column: "ReceptorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Salidas_Personas_ReceptorId",
                table: "Salidas",
                column: "ReceptorId",
                principalTable: "Personas",
                principalColumn: "PersonaId");
        }
    }
}
