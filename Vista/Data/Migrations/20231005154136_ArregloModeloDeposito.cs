using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class ArregloModeloDeposito : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materiales_Movimientos_MovimientoMId",
                table: "Materiales");

            migrationBuilder.DropIndex(
                name: "IX_Materiales_MovimientoMId",
                table: "Materiales");

            migrationBuilder.DropColumn(
                name: "MovimientoMId",
                table: "Materiales");

            migrationBuilder.DropColumn(
                name: "Alta",
                table: "Depositos");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Depositos");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Depositos");

            migrationBuilder.DropColumn(
                name: "Rubro",
                table: "Depositos");

            migrationBuilder.RenameColumn(
                name: "Cantidad",
                table: "Materiales",
                newName: "Rubro");

            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "Movimientos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaterialesMaterialId",
                table: "Movimientos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Stock",
                table: "Materiales",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Materiales",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Materiales",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaAlta",
                table: "Materiales",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_MaterialesMaterialId",
                table: "Movimientos",
                column: "MaterialesMaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Materiales_MaterialesMaterialId",
                table: "Movimientos",
                column: "MaterialesMaterialId",
                principalTable: "Materiales",
                principalColumn: "MaterialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Materiales_MaterialesMaterialId",
                table: "Movimientos");

            migrationBuilder.DropIndex(
                name: "IX_Movimientos_MaterialesMaterialId",
                table: "Movimientos");

            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "Movimientos");

            migrationBuilder.DropColumn(
                name: "MaterialesMaterialId",
                table: "Movimientos");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Materiales");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Materiales");

            migrationBuilder.DropColumn(
                name: "FechaAlta",
                table: "Materiales");

            migrationBuilder.RenameColumn(
                name: "Rubro",
                table: "Materiales",
                newName: "Cantidad");

            migrationBuilder.AlterColumn<string>(
                name: "Stock",
                table: "Materiales",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "MovimientoMId",
                table: "Materiales",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Alta",
                table: "Depositos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Depositos",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Depositos",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Rubro",
                table: "Depositos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Materiales_MovimientoMId",
                table: "Materiales",
                column: "MovimientoMId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materiales_Movimientos_MovimientoMId",
                table: "Materiales",
                column: "MovimientoMId",
                principalTable: "Movimientos",
                principalColumn: "MovimientoMId");
        }
    }
}
