using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Brigadas",
                columns: table => new
                {
                    BrigadaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brigadas", x => x.BrigadaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Comunicacion",
                columns: table => new
                {
                    ComunicacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NroEquipo = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Marca = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Modelo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NroSerie = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comunicacion", x => x.ComunicacionId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                name: "Materiales",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaAlta = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Codigo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Rubro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materiales", x => x.MaterialId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Seguro",
                columns: table => new
                {
                    SeguroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    CompañiaAseguradora = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroDePoliza = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaDeVencimineto = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguro", x => x.SeguroId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AscensoBomberos",
                columns: table => new
                {
                    AscensoBomberoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaAscenso = table.Column<DateOnly>(type: "date", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroLibero = table.Column<int>(type: "int", nullable: false),
                    NumeroActa = table.Column<int>(type: "int", nullable: false),
                    GradoAntiguo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GradoAscenso = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AscensoBomberos", x => x.AscensoBomberoId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "bombero_dependencia",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    DependenciaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bombero_dependencia", x => new { x.PersonaId, x.DependenciaId });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "bomberoBrigadas",
                columns: table => new
                {
                    BomberoId = table.Column<int>(type: "int", nullable: false),
                    BrigadaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bomberoBrigadas", x => new { x.BomberoId, x.BrigadaId });
                    table.ForeignKey(
                        name: "FK_bomberoBrigadas_Brigadas_BrigadaId",
                        column: x => x.BrigadaId,
                        principalTable: "Brigadas",
                        principalColumn: "BrigadaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BomberosSalida",
                columns: table => new
                {
                    BomberoSalidaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SalidaId = table.Column<int>(type: "int", nullable: false),
                    MovilId = table.Column<int>(type: "int", nullable: true),
                    Grado = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BomberosSalida", x => x.BomberoSalidaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    ContactoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TelefonoCel = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TelefonoLaboral = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TelefonoFijo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.ContactoId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Dependencias",
                columns: table => new
                {
                    DependenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreDependencia = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EncargadoPersonaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependencias", x => x.DependenciaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EmbarcacionesAfectadas",
                columns: table => new
                {
                    EmbarcacionAfectadaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Intervinientes = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CantidadBarcos = table.Column<int>(type: "int", nullable: false),
                    CantidadBotes = table.Column<int>(type: "int", nullable: false),
                    CantidadFragatas = table.Column<int>(type: "int", nullable: false),
                    CantidadLanchas = table.Column<int>(type: "int", nullable: false),
                    Otro = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SalidaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmbarcacionesAfectadas", x => x.EmbarcacionAfectadaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Firmas",
                columns: table => new
                {
                    FirmaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaHora = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Detalle = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    VehiculoId = table.Column<int>(type: "int", nullable: false),
                    EmbarcacionVehiculoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmas", x => x.FirmaId);
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
                    DamnificadoPersonaId = table.Column<int>(type: "int", nullable: true),
                    Destino = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fuerzaIntervinientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_fuerzaIntervinientes_Fuerzas_FuerzaId",
                        column: x => x.FuerzaId,
                        principalTable: "Fuerzas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Imagen",
                columns: table => new
                {
                    ImagenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    NombreImagen = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Base64Imagen = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoImagen = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonalId = table.Column<int>(type: "int", nullable: true),
                    VehiculoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagen", x => x.ImagenId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Incidente",
                columns: table => new
                {
                    IncidenteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Observacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonaId = table.Column<int>(type: "int", nullable: true),
                    VehiculoId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "varchar(21)", maxLength: 21, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DependenciaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidente", x => x.IncidenteId);
                    table.ForeignKey(
                        name: "FK_Incidente_Dependencias_DependenciaId",
                        column: x => x.DependenciaId,
                        principalTable: "Dependencias",
                        principalColumn: "DependenciaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Licencias",
                columns: table => new
                {
                    LicenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoLicencia = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Desde = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Hasta = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EstadoLicencia = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licencias", x => x.LicenciaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Limpiezas",
                columns: table => new
                {
                    LimpiezaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Incidente = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MovilId = table.Column<int>(type: "int", nullable: true),
                    BomberosPersonaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Limpiezas", x => x.LimpiezaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MovilesSalida",
                columns: table => new
                {
                    Movil_SalidaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CargoCombustible = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NumeroFactura = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaFactura = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    TipoConbustible = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CantidadLitros = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QuienLleno = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TelefonoQuienLleno = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DotacionSalida = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SalidaId = table.Column<int>(type: "int", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    MovilId = table.Column<int>(type: "int", nullable: false),
                    KmLlegada = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovilesSalida", x => x.Movil_SalidaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Movimientos",
                columns: table => new
                {
                    MovimientoMaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaIngreso = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Observaciones = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoMovimiento = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DestinoBomberoPersonaId = table.Column<int>(type: "int", nullable: true),
                    DestinoMovilVehiculoId = table.Column<int>(type: "int", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    MaterialesMaterialId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimientos", x => x.MovimientoMaterialId);
                    table.ForeignKey(
                        name: "FK_Movimientos_Materiales_MaterialesMaterialId",
                        column: x => x.MaterialesMaterialId,
                        principalTable: "Materiales",
                        principalColumn: "MaterialId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NovedadBase",
                columns: table => new
                {
                    NovedadBaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Observacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonalId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "varchar(21)", maxLength: 21, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VehiculoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NovedadBase", x => x.NovedadBaseId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Sexo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Documento = table.Column<int>(type: "int", nullable: false),
                    Residencia = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    SalidaId = table.Column<int>(type: "int", nullable: true),
                    GrupoSanguineo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LugarNacimiento = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observaciones = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Profesion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NivelEstudios = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroIoma = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagenId = table.Column<int>(type: "int", nullable: true),
                    FechaAceptacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    NumeroLegajo = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dotacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Grado = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Altura = table.Column<int>(type: "int", nullable: true),
                    Peso = table.Column<int>(type: "int", nullable: true),
                    Chofer = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    VencimientoRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    BrigadaId = table.Column<int>(type: "int", nullable: true),
                    EquipoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.PersonaId);
                    table.ForeignKey(
                        name: "FK_Persona_Brigadas_BrigadaId",
                        column: x => x.BrigadaId,
                        principalTable: "Brigadas",
                        principalColumn: "BrigadaId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Persona_Comunicacion_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Comunicacion",
                        principalColumn: "ComunicacionId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Persona_Imagen_ImagenId",
                        column: x => x.ImagenId,
                        principalTable: "Imagen",
                        principalColumn: "ImagenId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Salidas",
                columns: table => new
                {
                    SalidaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoEmergencia = table.Column<int>(type: "int", nullable: false),
                    HoraSalida = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HoraLlegada = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NumeroParte = table.Column<int>(type: "int", nullable: false),
                    AnioNumeroParte = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Latitud = table.Column<double>(type: "double", nullable: false),
                    Longitud = table.Column<double>(type: "double", nullable: false),
                    CuartelRegion = table.Column<int>(type: "int", nullable: true),
                    PisoNumero = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Depto = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoZona = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreSolicitante = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApellidoSolicitante = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DniSolicitante = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TelefonoSolicitante = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreYApellidoReceptor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SeguroId = table.Column<int>(type: "int", nullable: true),
                    EncargadoId = table.Column<int>(type: "int", nullable: false),
                    QuienLlenoId = table.Column<int>(type: "int", nullable: false),
                    TipoServicio = table.Column<int>(type: "int", nullable: false),
                    Accidente_Tipo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CondicionesClimaticas = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtroCondicion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FactorClimatico_Tipo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FactorClimatico_Evacuacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Superficie = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CantidadAfectadaFactorClimatico = table.Column<int>(type: "int", nullable: true),
                    DeteccionAutomaticaId = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Extintor = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Hidrante = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    TipoEvacuacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoSuperficieAfectada = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DetalleSuperficieAfectadaIncendio = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SuperficieAfectadaCausa = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoAbertura = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtraAbertura = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoTecho = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtroTecho = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtroLugarIncendio = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreEstablecimiento = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CantidadPisos = table.Column<int>(type: "int", nullable: true),
                    PisoAfectado = table.Column<int>(type: "int", nullable: true),
                    CantidadAmbientes = table.Column<int>(type: "int", nullable: true),
                    TipoLugar = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IncendioEstablecimientoEducativo_TipoLugar = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IncendioEstablecimientoPublico_TipoLugar = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IncendioForestal_TipoLugar = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IncendioHospitalesYClinicas_TipoLugar = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IncendioIndustria_TipoLugar = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IncendioVivienda_TipoLugar = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sustancias = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Controlada = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Venteo = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    DilucionDeVapores = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Neutralizacion = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Trasvase = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    OtraAccionesMateriales = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    DetallesAccionesMateriales = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Evacuacion = table.Column<int>(type: "int", nullable: true),
                    Descontaminacion = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Confinamiento = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    SinAccion = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    OtraAccionesPersonas = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    DetallesAccionesPersonas = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoSuperficie = table.Column<int>(type: "int", nullable: true),
                    CantidadAfectadaMaterialPeligroso = table.Column<int>(type: "int", nullable: true),
                    TipoSituacion = table.Column<int>(type: "int", nullable: true),
                    LugarRescateAnimal = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtroLugarRescate = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LugarRescatePersona = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoOrganizacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DetallesColaboFuerzasSeguridad = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NivelDeCapacitacion = table.Column<int>(type: "int", nullable: true),
                    TipoCapacitacion = table.Column<int>(type: "int", nullable: true),
                    DiaHora = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    TipoCapacitacionOtra = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NivelDeCapacitacionOtro = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServicioEspecialColocaciónDriza_TipoLugar = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServicioEspecialColocaciónDriza_NombreEstablecimiento = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Detalles = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServicioEspecialFalsaAlarma_Detalles = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoPrevencion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoRepresentacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DetallesObito = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreEstablecimientoSuministroAgua = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DetallesSuministroAgua = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salidas", x => x.SalidaId);
                    table.ForeignKey(
                        name: "FK_Salidas_Persona_EncargadoId",
                        column: x => x.EncargadoId,
                        principalTable: "Persona",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Salidas_Persona_QuienLlenoId",
                        column: x => x.QuienLlenoId,
                        principalTable: "Persona",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Salidas_Seguro_SeguroId",
                        column: x => x.SeguroId,
                        principalTable: "Seguro",
                        principalColumn: "SeguroId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sanciones",
                columns: table => new
                {
                    SancionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaDesde = table.Column<DateOnly>(type: "date", nullable: false),
                    FechaHasta = table.Column<DateOnly>(type: "date", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    TipoSancion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SacionArea = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EncargadoAreaId = table.Column<int>(type: "int", nullable: false),
                    observaciones = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanciones", x => x.SancionId);
                    table.ForeignKey(
                        name: "FK_Sanciones_Persona_EncargadoAreaId",
                        column: x => x.EncargadoAreaId,
                        principalTable: "Persona",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sanciones_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    VehiculoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Discriminador = table.Column<int>(type: "int", nullable: false),
                    Marca = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Modelo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Año = table.Column<int>(type: "int", nullable: true),
                    Patente = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Color = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SeguroId = table.Column<int>(type: "int", nullable: true),
                    NumeroMovil = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EncargadoId = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagenId = table.Column<int>(type: "int", nullable: true),
                    NumeroMotor = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModeloBomba = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroChasis = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CantidadLitros = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kilometraje = table.Column<int>(type: "int", nullable: true),
                    EquipoId = table.Column<int>(type: "int", nullable: true),
                    VehiculoAfectado_Airbag = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    SalidaId = table.Column<int>(type: "int", nullable: true),
                    Airbag = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    DamnificadoId = table.Column<int>(type: "int", nullable: true),
                    PersonalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.VehiculoId);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Comunicacion_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Comunicacion",
                        principalColumn: "ComunicacionId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Imagen_ImagenId",
                        column: x => x.ImagenId,
                        principalTable: "Imagen",
                        principalColumn: "ImagenId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Persona_DamnificadoId",
                        column: x => x.DamnificadoId,
                        principalTable: "Persona",
                        principalColumn: "PersonaId");
                    table.ForeignKey(
                        name: "FK_Vehiculo_Persona_EncargadoId",
                        column: x => x.EncargadoId,
                        principalTable: "Persona",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Persona_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Persona",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Salidas_SalidaId",
                        column: x => x.SalidaId,
                        principalTable: "Salidas",
                        principalColumn: "SalidaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Seguro_SeguroId",
                        column: x => x.SeguroId,
                        principalTable: "Seguro",
                        principalColumn: "SeguroId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AscensoBomberos_PersonaId",
                table: "AscensoBomberos",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_bombero_dependencia_DependenciaId",
                table: "bombero_dependencia",
                column: "DependenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_bomberoBrigadas_BrigadaId",
                table: "bomberoBrigadas",
                column: "BrigadaId");

            migrationBuilder.CreateIndex(
                name: "IX_BomberosSalida_MovilId",
                table: "BomberosSalida",
                column: "MovilId");

            migrationBuilder.CreateIndex(
                name: "IX_BomberosSalida_PersonaId",
                table: "BomberosSalida",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_BomberosSalida_SalidaId",
                table: "BomberosSalida",
                column: "SalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Brigadas_Nombre",
                table: "Brigadas",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comunicacion_NroEquipo",
                table: "Comunicacion",
                column: "NroEquipo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_PersonalId",
                table: "Contactos",
                column: "PersonalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dependencias_EncargadoPersonaId",
                table: "Dependencias",
                column: "EncargadoPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_EmbarcacionesAfectadas_SalidaId",
                table: "EmbarcacionesAfectadas",
                column: "SalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Firmas_EmbarcacionVehiculoId",
                table: "Firmas",
                column: "EmbarcacionVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Firmas_PersonaId",
                table: "Firmas",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Firmas_VehiculoId",
                table: "Firmas",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_fuerzaIntervinientes_DamnificadoPersonaId",
                table: "fuerzaIntervinientes",
                column: "DamnificadoPersonaId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Imagen_PersonalId",
                table: "Imagen",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidente_DependenciaId",
                table: "Incidente",
                column: "DependenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidente_PersonaId",
                table: "Incidente",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidente_VehiculoId",
                table: "Incidente",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Licencias_PersonalId",
                table: "Licencias",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Limpiezas_BomberosPersonaId",
                table: "Limpiezas",
                column: "BomberosPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Limpiezas_MovilId",
                table: "Limpiezas",
                column: "MovilId");

            migrationBuilder.CreateIndex(
                name: "IX_MovilesSalida_MovilId",
                table: "MovilesSalida",
                column: "MovilId");

            migrationBuilder.CreateIndex(
                name: "IX_MovilesSalida_PersonaId",
                table: "MovilesSalida",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_MovilesSalida_SalidaId",
                table: "MovilesSalida",
                column: "SalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_DestinoBomberoPersonaId",
                table: "Movimientos",
                column: "DestinoBomberoPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_DestinoMovilVehiculoId",
                table: "Movimientos",
                column: "DestinoMovilVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_MaterialesMaterialId",
                table: "Movimientos",
                column: "MaterialesMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_NovedadBase_PersonalId",
                table: "NovedadBase",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_NovedadBase_VehiculoId",
                table: "NovedadBase",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_BrigadaId",
                table: "Persona",
                column: "BrigadaId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_EquipoId",
                table: "Persona",
                column: "EquipoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persona_ImagenId",
                table: "Persona",
                column: "ImagenId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persona_NumeroLegajo",
                table: "Persona",
                column: "NumeroLegajo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persona_SalidaId",
                table: "Persona",
                column: "SalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Salidas_EncargadoId",
                table: "Salidas",
                column: "EncargadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Salidas_QuienLlenoId",
                table: "Salidas",
                column: "QuienLlenoId");

            migrationBuilder.CreateIndex(
                name: "IX_Salidas_SeguroId",
                table: "Salidas",
                column: "SeguroId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sanciones_EncargadoAreaId",
                table: "Sanciones",
                column: "EncargadoAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Sanciones_PersonaId",
                table: "Sanciones",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_DamnificadoId",
                table: "Vehiculo",
                column: "DamnificadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_EncargadoId",
                table: "Vehiculo",
                column: "EncargadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_EquipoId",
                table: "Vehiculo",
                column: "EquipoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_ImagenId",
                table: "Vehiculo",
                column: "ImagenId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_NumeroMovil",
                table: "Vehiculo",
                column: "NumeroMovil",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_PersonalId",
                table: "Vehiculo",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_SalidaId",
                table: "Vehiculo",
                column: "SalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_SeguroId",
                table: "Vehiculo",
                column: "SeguroId",
                unique: true);

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
                name: "FK_BomberosSalida_Salidas_SalidaId",
                table: "BomberosSalida",
                column: "SalidaId",
                principalTable: "Salidas",
                principalColumn: "SalidaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BomberosSalida_Vehiculo_MovilId",
                table: "BomberosSalida",
                column: "MovilId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId");

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
                name: "FK_EmbarcacionesAfectadas_Salidas_SalidaId",
                table: "EmbarcacionesAfectadas",
                column: "SalidaId",
                principalTable: "Salidas",
                principalColumn: "SalidaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Firmas_Persona_PersonaId",
                table: "Firmas",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Firmas_Vehiculo_EmbarcacionVehiculoId",
                table: "Firmas",
                column: "EmbarcacionVehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Firmas_Vehiculo_VehiculoId",
                table: "Firmas",
                column: "VehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_fuerzaIntervinientes_Persona_DamnificadoPersonaId",
                table: "fuerzaIntervinientes",
                column: "DamnificadoPersonaId",
                principalTable: "Persona",
                principalColumn: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_fuerzaIntervinientes_Salidas_SalidaId",
                table: "fuerzaIntervinientes",
                column: "SalidaId",
                principalTable: "Salidas",
                principalColumn: "SalidaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_fuerzaIntervinientes_Vehiculo_VehiculoId",
                table: "fuerzaIntervinientes",
                column: "VehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Incidente_Vehiculo_VehiculoId",
                table: "Incidente",
                column: "VehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
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
                name: "FK_Limpiezas_Vehiculo_MovilId",
                table: "Limpiezas",
                column: "MovilId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovilesSalida_Persona_PersonaId",
                table: "MovilesSalida",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovilesSalida_Salidas_SalidaId",
                table: "MovilesSalida",
                column: "SalidaId",
                principalTable: "Salidas",
                principalColumn: "SalidaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovilesSalida_Vehiculo_MovilId",
                table: "MovilesSalida",
                column: "MovilId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Persona_DestinoBomberoPersonaId",
                table: "Movimientos",
                column: "DestinoBomberoPersonaId",
                principalTable: "Persona",
                principalColumn: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Vehiculo_DestinoMovilVehiculoId",
                table: "Movimientos",
                column: "DestinoMovilVehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_NovedadBase_Persona_PersonalId",
                table: "NovedadBase",
                column: "PersonalId",
                principalTable: "Persona",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_NovedadBase_Vehiculo_VehiculoId",
                table: "NovedadBase",
                column: "VehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Salidas_SalidaId",
                table: "Persona",
                column: "SalidaId",
                principalTable: "Salidas",
                principalColumn: "SalidaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imagen_Persona_PersonalId",
                table: "Imagen");

            migrationBuilder.DropForeignKey(
                name: "FK_Salidas_Persona_EncargadoId",
                table: "Salidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Salidas_Persona_QuienLlenoId",
                table: "Salidas");

            migrationBuilder.DropTable(
                name: "AscensoBomberos");

            migrationBuilder.DropTable(
                name: "bombero_dependencia");

            migrationBuilder.DropTable(
                name: "bomberoBrigadas");

            migrationBuilder.DropTable(
                name: "BomberosSalida");

            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropTable(
                name: "EmbarcacionesAfectadas");

            migrationBuilder.DropTable(
                name: "Firmas");

            migrationBuilder.DropTable(
                name: "fuerzaIntervinientes");

            migrationBuilder.DropTable(
                name: "Incidente");

            migrationBuilder.DropTable(
                name: "Licencias");

            migrationBuilder.DropTable(
                name: "Limpiezas");

            migrationBuilder.DropTable(
                name: "MovilesSalida");

            migrationBuilder.DropTable(
                name: "Movimientos");

            migrationBuilder.DropTable(
                name: "NovedadBase");

            migrationBuilder.DropTable(
                name: "Sanciones");

            migrationBuilder.DropTable(
                name: "Fuerzas");

            migrationBuilder.DropTable(
                name: "Dependencias");

            migrationBuilder.DropTable(
                name: "Materiales");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Brigadas");

            migrationBuilder.DropTable(
                name: "Comunicacion");

            migrationBuilder.DropTable(
                name: "Imagen");

            migrationBuilder.DropTable(
                name: "Salidas");

            migrationBuilder.DropTable(
                name: "Seguro");
        }
    }
}
