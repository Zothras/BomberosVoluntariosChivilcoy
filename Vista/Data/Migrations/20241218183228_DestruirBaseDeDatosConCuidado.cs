using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class DestruirBaseDeDatosConCuidado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AscensoBombero_Personas_PersonaId",
                table: "AscensoBombero");

            migrationBuilder.DropForeignKey(
                name: "FK_bomberoBrigadas_Personas_BomberoId",
                table: "bomberoBrigadas");

            migrationBuilder.DropForeignKey(
                name: "FK_BomberoDependencia_Dependencias_DependenciaId",
                table: "BomberoDependencia");

            migrationBuilder.DropForeignKey(
                name: "FK_BomberoDependencia_Personas_PersonaId",
                table: "BomberoDependencia");

            migrationBuilder.DropForeignKey(
                name: "FK_BomberosSalida_Personas_PersonaId",
                table: "BomberosSalida");

            migrationBuilder.DropForeignKey(
                name: "FK_Contactos_Personas_PersonaId",
                table: "Contactos");

            migrationBuilder.DropForeignKey(
                name: "FK_Dependencias_Personas_EncargadoPersonaId",
                table: "Dependencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Firmas_Personas_PersonaId",
                table: "Firmas");

            migrationBuilder.DropForeignKey(
                name: "FK_fuerzaIntervinientes_Damnificados_DamnificadoId",
                table: "fuerzaIntervinientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidente_Personas_PersonaId",
                table: "Incidente");

            migrationBuilder.DropForeignKey(
                name: "FK_Licencias_Personas_PersonaId",
                table: "Licencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Limpiezas_Personas_BomberosPersonaId",
                table: "Limpiezas");

            migrationBuilder.DropForeignKey(
                name: "FK_MovilesSalida_Personas_PersonaId",
                table: "MovilesSalida");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Personas_DestinoBomberoPersonaId",
                table: "Movimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_NovedadBase_Personas_PersonalId",
                table: "NovedadBase");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Brigadas_BrigadaId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Comunicacion_EquipoId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Imagenes_ImagenId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Salidas_Personas_EncargadoId",
                table: "Salidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Salidas_Personas_QuienLlenoId",
                table: "Salidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Salidas_Seguros_SeguroId",
                table: "Salidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Sanciones_Personas_EncargadoAreaId",
                table: "Sanciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Sanciones_Personas_PersonaId",
                table: "Sanciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Damnificados_DamnificadoId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Imagenes_ImagenId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Personas_EncargadoId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Personas_PersonaId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Seguros_SeguroId",
                table: "Vehiculo");

            migrationBuilder.DropTable(
                name: "Damnificados");

            migrationBuilder.DropTable(
                name: "HorariosBomberos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_DamnificadoId",
                table: "Vehiculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seguros",
                table: "Seguros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Imagenes",
                table: "Imagenes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BomberoDependencia",
                table: "BomberoDependencia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AscensoBombero",
                table: "AscensoBombero");

            migrationBuilder.RenameTable(
                name: "Seguros",
                newName: "Seguro");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "Persona");

            migrationBuilder.RenameTable(
                name: "Imagenes",
                newName: "Imagen");

            migrationBuilder.RenameTable(
                name: "BomberoDependencia",
                newName: "bombero_dependencia");

            migrationBuilder.RenameTable(
                name: "AscensoBombero",
                newName: "AscensoBomberos");

            migrationBuilder.RenameColumn(
                name: "TipoVehiculo",
                table: "Vehiculo",
                newName: "Discriminador");

            migrationBuilder.RenameColumn(
                name: "PersonaId",
                table: "Vehiculo",
                newName: "PersonalId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculo_PersonaId",
                table: "Vehiculo",
                newName: "IX_Vehiculo_PersonalId");

            migrationBuilder.RenameColumn(
                name: "TipoSalida",
                table: "Salidas",
                newName: "TipoEmergencia");

            migrationBuilder.RenameColumn(
                name: "NovedadId",
                table: "NovedadBase",
                newName: "NovedadBaseId");

            migrationBuilder.RenameColumn(
                name: "PersonaId",
                table: "Licencias",
                newName: "PersonalId");

            migrationBuilder.RenameIndex(
                name: "IX_Licencias_PersonaId",
                table: "Licencias",
                newName: "IX_Licencias_PersonalId");

            migrationBuilder.RenameColumn(
                name: "DamnificadoId",
                table: "fuerzaIntervinientes",
                newName: "DamnificadoPersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_fuerzaIntervinientes_DamnificadoId",
                table: "fuerzaIntervinientes",
                newName: "IX_fuerzaIntervinientes_DamnificadoPersonaId");

            migrationBuilder.RenameColumn(
                name: "PersonaId",
                table: "Contactos",
                newName: "PersonalId");

            migrationBuilder.RenameIndex(
                name: "IX_Contactos_PersonaId",
                table: "Contactos",
                newName: "IX_Contactos_PersonalId");

            migrationBuilder.RenameColumn(
                name: "EquipoId",
                table: "Comunicacion",
                newName: "ComunicacionId");

            migrationBuilder.RenameColumn(
                name: "TipoSeguro",
                table: "Seguro",
                newName: "Tipo");

            migrationBuilder.RenameColumn(
                name: "TipoPersona",
                table: "Persona",
                newName: "Tipo");

            migrationBuilder.RenameIndex(
                name: "IX_Personas_NumeroLegajo",
                table: "Persona",
                newName: "IX_Persona_NumeroLegajo");

            migrationBuilder.RenameIndex(
                name: "IX_Personas_ImagenId",
                table: "Persona",
                newName: "IX_Persona_ImagenId");

            migrationBuilder.RenameIndex(
                name: "IX_Personas_EquipoId",
                table: "Persona",
                newName: "IX_Persona_EquipoId");

            migrationBuilder.RenameIndex(
                name: "IX_Personas_BrigadaId",
                table: "Persona",
                newName: "IX_Persona_BrigadaId");

            migrationBuilder.RenameColumn(
                name: "TipoImagenDiscriminador",
                table: "Imagen",
                newName: "Tipo");

            migrationBuilder.RenameIndex(
                name: "IX_BomberoDependencia_DependenciaId",
                table: "bombero_dependencia",
                newName: "IX_bombero_dependencia_DependenciaId");

            migrationBuilder.RenameColumn(
                name: "AscensoId",
                table: "AscensoBomberos",
                newName: "AscensoBomberoId");

            migrationBuilder.RenameIndex(
                name: "IX_AscensoBombero_PersonaId",
                table: "AscensoBomberos",
                newName: "IX_AscensoBomberos_PersonaId");

            migrationBuilder.AlterColumn<string>(
                name: "Observaciones",
                table: "Persona",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "GrupoSanguineo",
                table: "Persona",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Edad",
                table: "Persona",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Residencia",
                table: "Persona",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "SalidaId",
                table: "Persona",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonalId",
                table: "Imagen",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "Imagen",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seguro",
                table: "Seguro",
                column: "SeguroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persona",
                table: "Persona",
                column: "PersonaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Imagen",
                table: "Imagen",
                column: "ImagenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bombero_dependencia",
                table: "bombero_dependencia",
                columns: new[] { "PersonaId", "DependenciaId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AscensoBomberos",
                table: "AscensoBomberos",
                column: "AscensoBomberoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_DamnificadoId",
                table: "Vehiculo",
                column: "DamnificadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_SalidaId",
                table: "Persona",
                column: "SalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Imagen_PersonalId",
                table: "Imagen",
                column: "PersonalId");

            migrationBuilder.AddForeignKey(
                name: "FK_AscensoBomberos_Persona_PersonaId",
                table: "AscensoBomberos",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bombero_dependencia_Dependencias_DependenciaId",
                table: "bombero_dependencia",
                column: "DependenciaId",
                principalTable: "Dependencias",
                principalColumn: "DependenciaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bombero_dependencia_Persona_PersonaId",
                table: "bombero_dependencia",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bomberoBrigadas_Persona_BomberoId",
                table: "bomberoBrigadas",
                column: "BomberoId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BomberosSalida_Persona_PersonaId",
                table: "BomberosSalida",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contactos_Persona_PersonalId",
                table: "Contactos",
                column: "PersonalId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dependencias_Persona_EncargadoPersonaId",
                table: "Dependencias",
                column: "EncargadoPersonaId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Firmas_Persona_PersonaId",
                table: "Firmas",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_fuerzaIntervinientes_Persona_DamnificadoPersonaId",
                table: "fuerzaIntervinientes",
                column: "DamnificadoPersonaId",
                principalTable: "Persona",
                principalColumn: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagen_Persona_PersonalId",
                table: "Imagen",
                column: "PersonalId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidente_Persona_PersonaId",
                table: "Incidente",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Licencias_Persona_PersonalId",
                table: "Licencias",
                column: "PersonalId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Limpiezas_Persona_BomberosPersonaId",
                table: "Limpiezas",
                column: "BomberosPersonaId",
                principalTable: "Persona",
                principalColumn: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovilesSalida_Persona_PersonaId",
                table: "MovilesSalida",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Persona_DestinoBomberoPersonaId",
                table: "Movimientos",
                column: "DestinoBomberoPersonaId",
                principalTable: "Persona",
                principalColumn: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_NovedadBase_Persona_PersonalId",
                table: "NovedadBase",
                column: "PersonalId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Brigadas_BrigadaId",
                table: "Persona",
                column: "BrigadaId",
                principalTable: "Brigadas",
                principalColumn: "BrigadaId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Comunicacion_EquipoId",
                table: "Persona",
                column: "EquipoId",
                principalTable: "Comunicacion",
                principalColumn: "ComunicacionId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Imagen_ImagenId",
                table: "Persona",
                column: "ImagenId",
                principalTable: "Imagen",
                principalColumn: "ImagenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Salidas_SalidaId",
                table: "Persona",
                column: "SalidaId",
                principalTable: "Salidas",
                principalColumn: "SalidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Salidas_Persona_EncargadoId",
                table: "Salidas",
                column: "EncargadoId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Salidas_Persona_QuienLlenoId",
                table: "Salidas",
                column: "QuienLlenoId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Salidas_Seguro_SeguroId",
                table: "Salidas",
                column: "SeguroId",
                principalTable: "Seguro",
                principalColumn: "SeguroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sanciones_Persona_EncargadoAreaId",
                table: "Sanciones",
                column: "EncargadoAreaId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sanciones_Persona_PersonaId",
                table: "Sanciones",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Imagen_ImagenId",
                table: "Vehiculo",
                column: "ImagenId",
                principalTable: "Imagen",
                principalColumn: "ImagenId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Persona_DamnificadoId",
                table: "Vehiculo",
                column: "DamnificadoId",
                principalTable: "Persona",
                principalColumn: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Persona_EncargadoId",
                table: "Vehiculo",
                column: "EncargadoId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Persona_PersonalId",
                table: "Vehiculo",
                column: "PersonalId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Seguro_SeguroId",
                table: "Vehiculo",
                column: "SeguroId",
                principalTable: "Seguro",
                principalColumn: "SeguroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AscensoBomberos_Persona_PersonaId",
                table: "AscensoBomberos");

            migrationBuilder.DropForeignKey(
                name: "FK_bombero_dependencia_Dependencias_DependenciaId",
                table: "bombero_dependencia");

            migrationBuilder.DropForeignKey(
                name: "FK_bombero_dependencia_Persona_PersonaId",
                table: "bombero_dependencia");

            migrationBuilder.DropForeignKey(
                name: "FK_bomberoBrigadas_Persona_BomberoId",
                table: "bomberoBrigadas");

            migrationBuilder.DropForeignKey(
                name: "FK_BomberosSalida_Persona_PersonaId",
                table: "BomberosSalida");

            migrationBuilder.DropForeignKey(
                name: "FK_Contactos_Persona_PersonalId",
                table: "Contactos");

            migrationBuilder.DropForeignKey(
                name: "FK_Dependencias_Persona_EncargadoPersonaId",
                table: "Dependencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Firmas_Persona_PersonaId",
                table: "Firmas");

            migrationBuilder.DropForeignKey(
                name: "FK_fuerzaIntervinientes_Persona_DamnificadoPersonaId",
                table: "fuerzaIntervinientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Imagen_Persona_PersonalId",
                table: "Imagen");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidente_Persona_PersonaId",
                table: "Incidente");

            migrationBuilder.DropForeignKey(
                name: "FK_Licencias_Persona_PersonalId",
                table: "Licencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Limpiezas_Persona_BomberosPersonaId",
                table: "Limpiezas");

            migrationBuilder.DropForeignKey(
                name: "FK_MovilesSalida_Persona_PersonaId",
                table: "MovilesSalida");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Persona_DestinoBomberoPersonaId",
                table: "Movimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_NovedadBase_Persona_PersonalId",
                table: "NovedadBase");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Brigadas_BrigadaId",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Comunicacion_EquipoId",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Imagen_ImagenId",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Salidas_SalidaId",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Salidas_Persona_EncargadoId",
                table: "Salidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Salidas_Persona_QuienLlenoId",
                table: "Salidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Salidas_Seguro_SeguroId",
                table: "Salidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Sanciones_Persona_EncargadoAreaId",
                table: "Sanciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Sanciones_Persona_PersonaId",
                table: "Sanciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Imagen_ImagenId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Persona_DamnificadoId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Persona_EncargadoId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Persona_PersonalId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Seguro_SeguroId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_DamnificadoId",
                table: "Vehiculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seguro",
                table: "Seguro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persona",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_SalidaId",
                table: "Persona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Imagen",
                table: "Imagen");

            migrationBuilder.DropIndex(
                name: "IX_Imagen_PersonalId",
                table: "Imagen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bombero_dependencia",
                table: "bombero_dependencia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AscensoBomberos",
                table: "AscensoBomberos");

            migrationBuilder.DropColumn(
                name: "Edad",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Residencia",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "SalidaId",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "PersonalId",
                table: "Imagen");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "Imagen");

            migrationBuilder.RenameTable(
                name: "Seguro",
                newName: "Seguros");

            migrationBuilder.RenameTable(
                name: "Persona",
                newName: "Personas");

            migrationBuilder.RenameTable(
                name: "Imagen",
                newName: "Imagenes");

            migrationBuilder.RenameTable(
                name: "bombero_dependencia",
                newName: "BomberoDependencia");

            migrationBuilder.RenameTable(
                name: "AscensoBomberos",
                newName: "AscensoBombero");

            migrationBuilder.RenameColumn(
                name: "PersonalId",
                table: "Vehiculo",
                newName: "PersonaId");

            migrationBuilder.RenameColumn(
                name: "Discriminador",
                table: "Vehiculo",
                newName: "TipoVehiculo");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculo_PersonalId",
                table: "Vehiculo",
                newName: "IX_Vehiculo_PersonaId");

            migrationBuilder.RenameColumn(
                name: "TipoEmergencia",
                table: "Salidas",
                newName: "TipoSalida");

            migrationBuilder.RenameColumn(
                name: "NovedadBaseId",
                table: "NovedadBase",
                newName: "NovedadId");

            migrationBuilder.RenameColumn(
                name: "PersonalId",
                table: "Licencias",
                newName: "PersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_Licencias_PersonalId",
                table: "Licencias",
                newName: "IX_Licencias_PersonaId");

            migrationBuilder.RenameColumn(
                name: "DamnificadoPersonaId",
                table: "fuerzaIntervinientes",
                newName: "DamnificadoId");

            migrationBuilder.RenameIndex(
                name: "IX_fuerzaIntervinientes_DamnificadoPersonaId",
                table: "fuerzaIntervinientes",
                newName: "IX_fuerzaIntervinientes_DamnificadoId");

            migrationBuilder.RenameColumn(
                name: "PersonalId",
                table: "Contactos",
                newName: "PersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_Contactos_PersonalId",
                table: "Contactos",
                newName: "IX_Contactos_PersonaId");

            migrationBuilder.RenameColumn(
                name: "ComunicacionId",
                table: "Comunicacion",
                newName: "EquipoId");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Seguros",
                newName: "TipoSeguro");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Personas",
                newName: "TipoPersona");

            migrationBuilder.RenameIndex(
                name: "IX_Persona_NumeroLegajo",
                table: "Personas",
                newName: "IX_Personas_NumeroLegajo");

            migrationBuilder.RenameIndex(
                name: "IX_Persona_ImagenId",
                table: "Personas",
                newName: "IX_Personas_ImagenId");

            migrationBuilder.RenameIndex(
                name: "IX_Persona_EquipoId",
                table: "Personas",
                newName: "IX_Personas_EquipoId");

            migrationBuilder.RenameIndex(
                name: "IX_Persona_BrigadaId",
                table: "Personas",
                newName: "IX_Personas_BrigadaId");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Imagenes",
                newName: "TipoImagenDiscriminador");

            migrationBuilder.RenameIndex(
                name: "IX_bombero_dependencia_DependenciaId",
                table: "BomberoDependencia",
                newName: "IX_BomberoDependencia_DependenciaId");

            migrationBuilder.RenameColumn(
                name: "AscensoBomberoId",
                table: "AscensoBombero",
                newName: "AscensoId");

            migrationBuilder.RenameIndex(
                name: "IX_AscensoBomberos_PersonaId",
                table: "AscensoBombero",
                newName: "IX_AscensoBombero_PersonaId");

            migrationBuilder.AlterColumn<string>(
                name: "Observaciones",
                table: "Personas",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Personas",
                keyColumn: "GrupoSanguineo",
                keyValue: null,
                column: "GrupoSanguineo",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "GrupoSanguineo",
                table: "Personas",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seguros",
                table: "Seguros",
                column: "SeguroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "PersonaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Imagenes",
                table: "Imagenes",
                column: "ImagenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BomberoDependencia",
                table: "BomberoDependencia",
                columns: new[] { "PersonaId", "DependenciaId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AscensoBombero",
                table: "AscensoBombero",
                column: "AscensoId");

            migrationBuilder.CreateTable(
                name: "Damnificados",
                columns: table => new
                {
                    DamnificadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SalidaId = table.Column<int>(type: "int", nullable: false),
                    Apellido = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dni = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LugarDeNacimiento = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sexo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Damnificados", x => x.DamnificadoId);
                    table.ForeignKey(
                        name: "FK_Damnificados_Salidas_SalidaId",
                        column: x => x.SalidaId,
                        principalTable: "Salidas",
                        principalColumn: "SalidaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HorariosBomberos",
                columns: table => new
                {
                    HorarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BomberoId = table.Column<int>(type: "int", nullable: false),
                    DiaSemana = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HoraDesde = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HoraHasta = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModoRotativo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Periodo = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    VigenteDesde = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    VigenteHasta = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorariosBomberos", x => x.HorarioId);
                    table.ForeignKey(
                        name: "FK_HorariosBomberos_Personas_BomberoId",
                        column: x => x.BomberoId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_DamnificadoId",
                table: "Vehiculo",
                column: "DamnificadoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Damnificados_SalidaId",
                table: "Damnificados",
                column: "SalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_HorariosBomberos_BomberoId",
                table: "HorariosBomberos",
                column: "BomberoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AscensoBombero_Personas_PersonaId",
                table: "AscensoBombero",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bomberoBrigadas_Personas_BomberoId",
                table: "bomberoBrigadas",
                column: "BomberoId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BomberoDependencia_Dependencias_DependenciaId",
                table: "BomberoDependencia",
                column: "DependenciaId",
                principalTable: "Dependencias",
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
                name: "FK_BomberosSalida_Personas_PersonaId",
                table: "BomberosSalida",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contactos_Personas_PersonaId",
                table: "Contactos",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dependencias_Personas_EncargadoPersonaId",
                table: "Dependencias",
                column: "EncargadoPersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Firmas_Personas_PersonaId",
                table: "Firmas",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_fuerzaIntervinientes_Damnificados_DamnificadoId",
                table: "fuerzaIntervinientes",
                column: "DamnificadoId",
                principalTable: "Damnificados",
                principalColumn: "DamnificadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidente_Personas_PersonaId",
                table: "Incidente",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Licencias_Personas_PersonaId",
                table: "Licencias",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Limpiezas_Personas_BomberosPersonaId",
                table: "Limpiezas",
                column: "BomberosPersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovilesSalida_Personas_PersonaId",
                table: "MovilesSalida",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Personas_DestinoBomberoPersonaId",
                table: "Movimientos",
                column: "DestinoBomberoPersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_NovedadBase_Personas_PersonalId",
                table: "NovedadBase",
                column: "PersonalId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Brigadas_BrigadaId",
                table: "Personas",
                column: "BrigadaId",
                principalTable: "Brigadas",
                principalColumn: "BrigadaId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Comunicacion_EquipoId",
                table: "Personas",
                column: "EquipoId",
                principalTable: "Comunicacion",
                principalColumn: "EquipoId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Imagenes_ImagenId",
                table: "Personas",
                column: "ImagenId",
                principalTable: "Imagenes",
                principalColumn: "ImagenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Salidas_Personas_EncargadoId",
                table: "Salidas",
                column: "EncargadoId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Salidas_Personas_QuienLlenoId",
                table: "Salidas",
                column: "QuienLlenoId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Salidas_Seguros_SeguroId",
                table: "Salidas",
                column: "SeguroId",
                principalTable: "Seguros",
                principalColumn: "SeguroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sanciones_Personas_EncargadoAreaId",
                table: "Sanciones",
                column: "EncargadoAreaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sanciones_Personas_PersonaId",
                table: "Sanciones",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Damnificados_DamnificadoId",
                table: "Vehiculo",
                column: "DamnificadoId",
                principalTable: "Damnificados",
                principalColumn: "DamnificadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Imagenes_ImagenId",
                table: "Vehiculo",
                column: "ImagenId",
                principalTable: "Imagenes",
                principalColumn: "ImagenId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Personas_EncargadoId",
                table: "Vehiculo",
                column: "EncargadoId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Personas_PersonaId",
                table: "Vehiculo",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Seguros_SeguroId",
                table: "Vehiculo",
                column: "SeguroId",
                principalTable: "Seguros",
                principalColumn: "SeguroId");
        }
    }
}
