using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixIncidentes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BomberoDependencia_Dependencia_DependenciaId",
                table: "BomberoDependencia");

            migrationBuilder.DropForeignKey(
                name: "FK_BomberoDependencia_Personas_PersonaId",
                table: "BomberoDependencia");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidente_Personas_PersonaId",
                table: "Incidente");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidente_Vehiculo_VehiculoSalidaVehiculoId",
                table: "Incidente");

            migrationBuilder.DropForeignKey(
                name: "FK_Limpiezas_Personas_ResponsableId",
                table: "Limpiezas");

            migrationBuilder.DropForeignKey(
                name: "FK_Limpiezas_Vehiculo_VehiculoId",
                table: "Limpiezas");

            migrationBuilder.RenameColumn(
                name: "VehiculoId",
                table: "Limpiezas",
                newName: "MovilId");

            migrationBuilder.RenameColumn(
                name: "ResponsableId",
                table: "Limpiezas",
                newName: "BomberosPersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_Limpiezas_VehiculoId",
                table: "Limpiezas",
                newName: "IX_Limpiezas_MovilId");

            migrationBuilder.RenameIndex(
                name: "IX_Limpiezas_ResponsableId",
                table: "Limpiezas",
                newName: "IX_Limpiezas_BomberosPersonaId");

            migrationBuilder.RenameColumn(
                name: "VehiculoSalidaVehiculoId",
                table: "Incidente",
                newName: "VehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Incidente_VehiculoSalidaVehiculoId",
                table: "Incidente",
                newName: "IX_Incidente_VehiculoId");

            migrationBuilder.AlterColumn<int>(
                name: "PersonaId",
                table: "Incidente",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Incidente",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "PersonaId",
                table: "BomberoDependencia",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DependenciaId",
                table: "BomberoDependencia",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BomberoDependencia_Dependencia_DependenciaId",
                table: "BomberoDependencia",
                column: "DependenciaId",
                principalTable: "Dependencia",
                principalColumn: "DependenciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_BomberoDependencia_Personas_PersonaId",
                table: "BomberoDependencia",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidente_Personas_PersonaId",
                table: "Incidente",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidente_Vehiculo_VehiculoId",
                table: "Incidente",
                column: "VehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Limpiezas_Personas_BomberosPersonaId",
                table: "Limpiezas",
                column: "BomberosPersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Limpiezas_Vehiculo_MovilId",
                table: "Limpiezas",
                column: "MovilId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BomberoDependencia_Dependencia_DependenciaId",
                table: "BomberoDependencia");

            migrationBuilder.DropForeignKey(
                name: "FK_BomberoDependencia_Personas_PersonaId",
                table: "BomberoDependencia");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidente_Personas_PersonaId",
                table: "Incidente");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidente_Vehiculo_VehiculoId",
                table: "Incidente");

            migrationBuilder.DropForeignKey(
                name: "FK_Limpiezas_Personas_BomberosPersonaId",
                table: "Limpiezas");

            migrationBuilder.DropForeignKey(
                name: "FK_Limpiezas_Vehiculo_MovilId",
                table: "Limpiezas");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Incidente");

            migrationBuilder.RenameColumn(
                name: "MovilId",
                table: "Limpiezas",
                newName: "VehiculoId");

            migrationBuilder.RenameColumn(
                name: "BomberosPersonaId",
                table: "Limpiezas",
                newName: "ResponsableId");

            migrationBuilder.RenameIndex(
                name: "IX_Limpiezas_MovilId",
                table: "Limpiezas",
                newName: "IX_Limpiezas_VehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Limpiezas_BomberosPersonaId",
                table: "Limpiezas",
                newName: "IX_Limpiezas_ResponsableId");

            migrationBuilder.RenameColumn(
                name: "VehiculoId",
                table: "Incidente",
                newName: "VehiculoSalidaVehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Incidente_VehiculoId",
                table: "Incidente",
                newName: "IX_Incidente_VehiculoSalidaVehiculoId");

            migrationBuilder.AlterColumn<int>(
                name: "PersonaId",
                table: "Incidente",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonaId",
                table: "BomberoDependencia",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DependenciaId",
                table: "BomberoDependencia",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BomberoDependencia_Dependencia_DependenciaId",
                table: "BomberoDependencia",
                column: "DependenciaId",
                principalTable: "Dependencia",
                principalColumn: "DependenciaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BomberoDependencia_Personas_PersonaId",
                table: "BomberoDependencia",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidente_Personas_PersonaId",
                table: "Incidente",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidente_Vehiculo_VehiculoSalidaVehiculoId",
                table: "Incidente",
                column: "VehiculoSalidaVehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Limpiezas_Personas_ResponsableId",
                table: "Limpiezas",
                column: "ResponsableId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Limpiezas_Vehiculo_VehiculoId",
                table: "Limpiezas",
                column: "VehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
