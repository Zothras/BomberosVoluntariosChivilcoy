using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFuerzasFuerzasIntervinientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fuerzas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreFuerza = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuerzas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "fuerzaIntervinientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SalidaId = table.Column<int>(type: "int", nullable: false),
                    FuerzaId = table.Column<int>(type: "int", nullable: false),
                    Encargado = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VehiculoId = table.Column<int>(type: "int", nullable: false),
                    DamnificadoId = table.Column<int>(type: "int", nullable: true),
                    Destino = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fuerzaIntervinientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_fuerzaIntervinientes_Damnificados_DamnificadoId",
                        column: x => x.DamnificadoId,
                        principalTable: "Damnificados",
                        principalColumn: "DamnificadoId");
                    table.ForeignKey(
                        name: "FK_fuerzaIntervinientes_Fuerzas_FuerzaId",
                        column: x => x.FuerzaId,
                        principalTable: "Fuerzas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_fuerzaIntervinientes_Salidas_SalidaId",
                        column: x => x.SalidaId,
                        principalTable: "Salidas",
                        principalColumn: "SalidaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_fuerzaIntervinientes_Vehiculo_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculo",
                        principalColumn: "VehiculoId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_fuerzaIntervinientes_DamnificadoId",
                table: "fuerzaIntervinientes",
                column: "DamnificadoId");

            migrationBuilder.CreateIndex(
                name: "IX_fuerzaIntervinientes_FuerzaId",
                table: "fuerzaIntervinientes",
                column: "FuerzaId");

            migrationBuilder.CreateIndex(
                name: "IX_fuerzaIntervinientes_SalidaId",
                table: "fuerzaIntervinientes",
                column: "SalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_fuerzaIntervinientes_VehiculoId",
                table: "fuerzaIntervinientes",
                column: "VehiculoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fuerzaIntervinientes");

            migrationBuilder.DropTable(
                name: "Fuerzas");
        }
    }
}
