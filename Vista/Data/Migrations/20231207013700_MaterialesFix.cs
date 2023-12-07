using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class MaterialesFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materiales_Depositos_DepositoId",
                table: "Materiales");

            migrationBuilder.DropTable(
                name: "Depositos");

            migrationBuilder.DropIndex(
                name: "IX_Materiales_DepositoId",
                table: "Materiales");

            migrationBuilder.DropColumn(
                name: "DepositoId",
                table: "Materiales");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepositoId",
                table: "Materiales",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Depositos",
                columns: table => new
                {
                    DepositoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depositos", x => x.DepositoId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Materiales_DepositoId",
                table: "Materiales",
                column: "DepositoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materiales_Depositos_DepositoId",
                table: "Materiales",
                column: "DepositoId",
                principalTable: "Depositos",
                principalColumn: "DepositoId");
        }
    }
}
