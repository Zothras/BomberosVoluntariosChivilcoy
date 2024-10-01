using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddServicioFalsaAlarma_RemoveTipoServicioEspecial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServicioEspecial_Tipo",
                table: "Salidas",
                newName: "ServicioEspecialFalsaAlarma_Detalles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServicioEspecialFalsaAlarma_Detalles",
                table: "Salidas",
                newName: "ServicioEspecial_Tipo");
        }
    }
}
