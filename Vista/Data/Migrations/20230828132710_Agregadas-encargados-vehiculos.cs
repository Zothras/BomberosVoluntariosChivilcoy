using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class Agregadasencargadosvehiculos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovilBombero");

            migrationBuilder.DropColumn(
                name: "Rol",
                table: "BomberoDependencia");

            migrationBuilder.RenameColumn(
                name: "kilometraje",
                table: "Vehiculo",
                newName: "Kilometraje");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Kilometraje",
                table: "Vehiculo",
                newName: "kilometraje");

            migrationBuilder.AddColumn<int>(
                name: "Rol",
                table: "BomberoDependencia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MovilBombero",
                columns: table => new
                {
                    MovilBomberoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    VehiculoId = table.Column<int>(type: "int", nullable: false),
                    Rol = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovilBombero", x => x.MovilBomberoId);
                    table.ForeignKey(
                        name: "FK_MovilBombero_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovilBombero_Vehiculo_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculo",
                        principalColumn: "VehiculoId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_MovilBombero_PersonaId",
                table: "MovilBombero",
                column: "PersonaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovilBombero_VehiculoId_PersonaId",
                table: "MovilBombero",
                columns: new[] { "VehiculoId", "PersonaId" });
        }
    }
}
