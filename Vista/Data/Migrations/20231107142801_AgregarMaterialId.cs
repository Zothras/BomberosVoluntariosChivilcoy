using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class AgregarMaterialId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Stock",
                table: "Materiales",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "Depositos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "Depositos");

            migrationBuilder.UpdateData(
                table: "Materiales",
                keyColumn: "Stock",
                keyValue: null,
                column: "Stock",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Stock",
                table: "Materiales",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
