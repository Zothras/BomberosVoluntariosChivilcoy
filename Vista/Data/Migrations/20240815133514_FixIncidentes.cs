using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixIncidentes : Migration
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
                name: "FK_Incidente_Dependencia_DependenciaId",
                table: "Incidente");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Incidente",
                table: "Incidente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dependencia",
                table: "Dependencia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BomberoDependencia",
                table: "BomberoDependencia");

            migrationBuilder.RenameTable(
                name: "Incidente",
                newName: "Incidentes");

            migrationBuilder.RenameTable(
                name: "Dependencia",
                newName: "Dependencias");

            migrationBuilder.RenameTable(
                name: "BomberoDependencia",
                newName: "BomberosDependencias");

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
                table: "Incidentes",
                newName: "VehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Incidente_VehiculoSalidaVehiculoId",
                table: "Incidentes",
                newName: "IX_Incidentes_VehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Incidente_PersonaId",
                table: "Incidentes",
                newName: "IX_Incidentes_PersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_Incidente_DependenciaId",
                table: "Incidentes",
                newName: "IX_Incidentes_DependenciaId");

            migrationBuilder.RenameIndex(
                name: "IX_BomberoDependencia_PersonaId",
                table: "BomberosDependencias",
                newName: "IX_BomberosDependencias_PersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_BomberoDependencia_DependenciaId",
                table: "BomberosDependencias",
                newName: "IX_BomberosDependencias_DependenciaId");

            migrationBuilder.AlterColumn<int>(
                name: "PersonaId",
                table: "Incidentes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Incidentes",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "PersonaId",
                table: "BomberosDependencias",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DependenciaId",
                table: "BomberosDependencias",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Incidentes",
                table: "Incidentes",
                column: "IncidenteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dependencias",
                table: "Dependencias",
                column: "DependenciaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BomberosDependencias",
                table: "BomberosDependencias",
                column: "BomberoDependenciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_BomberosDependencias_Dependencias_DependenciaId",
                table: "BomberosDependencias",
                column: "DependenciaId",
                principalTable: "Dependencias",
                principalColumn: "DependenciaId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_BomberosDependencias_Personas_PersonaId",
                table: "BomberosDependencias",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidentes_Dependencias_DependenciaId",
                table: "Incidentes",
                column: "DependenciaId",
                principalTable: "Dependencias",
                principalColumn: "DependenciaId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidentes_Personas_PersonaId",
                table: "Incidentes",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidentes_Vehiculo_VehiculoId",
                table: "Incidentes",
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
                name: "FK_BomberosDependencias_Dependencias_DependenciaId",
                table: "BomberosDependencias");

            migrationBuilder.DropForeignKey(
                name: "FK_BomberosDependencias_Personas_PersonaId",
                table: "BomberosDependencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidentes_Dependencias_DependenciaId",
                table: "Incidentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidentes_Personas_PersonaId",
                table: "Incidentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidentes_Vehiculo_VehiculoId",
                table: "Incidentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Limpiezas_Personas_BomberosPersonaId",
                table: "Limpiezas");

            migrationBuilder.DropForeignKey(
                name: "FK_Limpiezas_Vehiculo_MovilId",
                table: "Limpiezas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Incidentes",
                table: "Incidentes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dependencias",
                table: "Dependencias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BomberosDependencias",
                table: "BomberosDependencias");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Incidentes");

            migrationBuilder.RenameTable(
                name: "Incidentes",
                newName: "Incidente");

            migrationBuilder.RenameTable(
                name: "Dependencias",
                newName: "Dependencia");

            migrationBuilder.RenameTable(
                name: "BomberosDependencias",
                newName: "BomberoDependencia");

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
                name: "IX_Incidentes_VehiculoId",
                table: "Incidente",
                newName: "IX_Incidente_VehiculoSalidaVehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Incidentes_PersonaId",
                table: "Incidente",
                newName: "IX_Incidente_PersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_Incidentes_DependenciaId",
                table: "Incidente",
                newName: "IX_Incidente_DependenciaId");

            migrationBuilder.RenameIndex(
                name: "IX_BomberosDependencias_PersonaId",
                table: "BomberoDependencia",
                newName: "IX_BomberoDependencia_PersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_BomberosDependencias_DependenciaId",
                table: "BomberoDependencia",
                newName: "IX_BomberoDependencia_DependenciaId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Incidente",
                table: "Incidente",
                column: "IncidenteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dependencia",
                table: "Dependencia",
                column: "DependenciaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BomberoDependencia",
                table: "BomberoDependencia",
                column: "BomberoDependenciaId");

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
                name: "FK_Incidente_Dependencia_DependenciaId",
                table: "Incidente",
                column: "DependenciaId",
                principalTable: "Dependencia",
                principalColumn: "DependenciaId",
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
