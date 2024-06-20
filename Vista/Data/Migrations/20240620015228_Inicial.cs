using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class Inicial : Migration
    {
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
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
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
                    EquipoId = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Comunicacion", x => x.EquipoId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Dependencia",
                columns: table => new
                {
                    DependenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreDependencia = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependencia", x => x.DependenciaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Imagenes",
                columns: table => new
                {
                    ImagenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreImagen = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Base64Imagen = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoImagen = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoImagenDiscriminador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagenes", x => x.ImagenId);
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
                name: "Seguros",
                columns: table => new
                {
                    SeguroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompañiaAseguradora = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroDePoliza = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaDeVencimineto = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    TipoSeguro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguros", x => x.SeguroId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AscensoBombero",
                columns: table => new
                {
                    AscensoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaEmision = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GradoAntiguo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GradoAscenso = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AscensoBombero", x => x.AscensoId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BomberoDependencia",
                columns: table => new
                {
                    BomberoDependenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    DependenciaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BomberoDependencia", x => x.BomberoDependenciaId);
                    table.ForeignKey(
                        name: "FK_BomberoDependencia_Dependencia_DependenciaId",
                        column: x => x.DependenciaId,
                        principalTable: "Dependencia",
                        principalColumn: "DependenciaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BomberosSalida",
                columns: table => new
                {
                    BomberoSalidaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Salio = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Grado = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    SalidaId = table.Column<int>(type: "int", nullable: false),
                    MovilSalidaId = table.Column<int>(type: "int", nullable: false)
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
                    PersonaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.ContactoId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Damnificados",
                columns: table => new
                {
                    DamnificadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dni = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sexo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LugarDeNacimiento = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SalidaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Damnificados", x => x.DamnificadoId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DatosCapacitaciones",
                columns: table => new
                {
                    DatosCapacitacionId = table.Column<int>(type: "int", nullable: false),
                    NivelCapacitacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NivelCapacitacionOtro = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoCapacitacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CapacitacionOtra = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DiasCapacitacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HorariosCapacitacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SalidaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosCapacitaciones", x => x.DatosCapacitacionId);
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
                name: "HorariosBomberos",
                columns: table => new
                {
                    HorarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VigenteDesde = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    VigenteHasta = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DiaSemana = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HoraDesde = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HoraHasta = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Periodo = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModoRotativo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BomberoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorariosBomberos", x => x.HorarioId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Incidente",
                columns: table => new
                {
                    IncidenteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Observacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VehiculoSalidaVehiculoId = table.Column<int>(type: "int", nullable: true),
                    DependenciaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidente", x => x.IncidenteId);
                    table.ForeignKey(
                        name: "FK_Incidente_Dependencia_DependenciaId",
                        column: x => x.DependenciaId,
                        principalTable: "Dependencia",
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
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Desde = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Hasta = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EstadoLicencia = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonaId = table.Column<int>(type: "int", nullable: false)
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
                    BomberosPersonaId = table.Column<int>(type: "int", nullable: false)
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
                    MovilSalidaId = table.Column<int>(type: "int", nullable: false)
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
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    MovilId = table.Column<int>(type: "int", nullable: false),
                    SalidaId = table.Column<int>(type: "int", nullable: false),
                    KmLlegada = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovilesSalida", x => x.MovilSalidaId);
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
                name: "Personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Sexo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LugarNacimiento = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Documento = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GrupoSanguineo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observaciones = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Profesion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NivelEstudios = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroIoma = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoPersona = table.Column<int>(type: "int", nullable: false),
                    NumeroLegajo = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dotacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaAceptacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Grado = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Resolucion1 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Resolucion2 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Resolucion3 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Resolucion4 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Resolucion5 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Resolucion6 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Chofer = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    VencimientoRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    BrigadaId = table.Column<int>(type: "int", nullable: true),
                    ImagenId = table.Column<int>(type: "int", nullable: true),
                    EquipoId = table.Column<int>(type: "int", nullable: true),
                    MovilId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaId);
                    table.ForeignKey(
                        name: "FK_Personas_Brigadas_BrigadaId",
                        column: x => x.BrigadaId,
                        principalTable: "Brigadas",
                        principalColumn: "BrigadaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personas_Comunicacion_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Comunicacion",
                        principalColumn: "EquipoId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Personas_Imagenes_ImagenId",
                        column: x => x.ImagenId,
                        principalTable: "Imagenes",
                        principalColumn: "ImagenId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Salidas",
                columns: table => new
                {
                    SalidaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HoraSalida = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HoraLlegada = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NumeroParte = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CalleORuta = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroOKilometro = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EntreCalles = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PisoNumero = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Depto = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoZona = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreSolicitante = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApellidoSolicitante = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DniSolicitante = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TelefonoSolicitante = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreYApellidoReceptor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TelefonoReceptor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReceptorId = table.Column<int>(type: "int", nullable: true),
                    SeguroId = table.Column<int>(type: "int", nullable: true),
                    EncargadoId = table.Column<int>(type: "int", nullable: false),
                    QuienLlenoId = table.Column<int>(type: "int", nullable: false),
                    TipoServicio = table.Column<int>(type: "int", nullable: false),
                    TipoSalida = table.Column<int>(type: "int", nullable: false),
                    Accidente_Tipo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CantidadVehiculos = table.Column<int>(type: "int", nullable: true),
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
                    DetalleSuperficieDañada = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                    Incendio_Tipo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoAbertura = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtraAbertura = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoTecho = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtroTecho = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtroLugar = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
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
                    DetalleSuperficieAfectada = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoSituacion = table.Column<int>(type: "int", nullable: true),
                    TipoRescateAnimal = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Otro = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoRescatePersona = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServicioEspecial_Tipo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoOrganizacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtroRepresentacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoPrevencion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoRepresentacion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salidas", x => x.SalidaId);
                    table.ForeignKey(
                        name: "FK_Salidas_Personas_EncargadoId",
                        column: x => x.EncargadoId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Salidas_Personas_QuienLlenoId",
                        column: x => x.QuienLlenoId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Salidas_Personas_ReceptorId",
                        column: x => x.ReceptorId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId");
                    table.ForeignKey(
                        name: "FK_Salidas_Seguros_SeguroId",
                        column: x => x.SeguroId,
                        principalTable: "Seguros",
                        principalColumn: "SeguroId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sanciones",
                columns: table => new
                {
                    SancionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaDesde = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaHasta = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    TipoSancion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SacionArea = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EncargadoAreaId = table.Column<int>(type: "int", nullable: false),
                    observaciones = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanciones", x => x.SancionId);
                    table.ForeignKey(
                        name: "FK_Sanciones_Personas_EncargadoAreaId",
                        column: x => x.EncargadoAreaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sanciones_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
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
                    Marca = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Modelo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Año = table.Column<int>(type: "int", nullable: true),
                    Patente = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SeguroId = table.Column<int>(type: "int", nullable: false),
                    TipoVehiculo = table.Column<int>(type: "int", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: true),
                    NumeroMovil = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EncargadoId = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroMotor = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModeloBomba = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroChasis = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kilometraje = table.Column<int>(type: "int", nullable: true),
                    ImagenId = table.Column<int>(type: "int", nullable: true),
                    EquipoId = table.Column<int>(type: "int", nullable: true),
                    Embarcacion_ImagenId = table.Column<int>(type: "int", nullable: true),
                    Airbag = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    SalidaId = table.Column<int>(type: "int", nullable: true),
                    Color = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VehiculoDamnificado_Airbag = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    DamnificadoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.VehiculoId);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Comunicacion_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Comunicacion",
                        principalColumn: "EquipoId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Damnificados_DamnificadoId",
                        column: x => x.DamnificadoId,
                        principalTable: "Damnificados",
                        principalColumn: "DamnificadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Imagenes_Embarcacion_ImagenId",
                        column: x => x.Embarcacion_ImagenId,
                        principalTable: "Imagenes",
                        principalColumn: "ImagenId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Imagenes_ImagenId",
                        column: x => x.ImagenId,
                        principalTable: "Imagenes",
                        principalColumn: "ImagenId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Personas_EncargadoId",
                        column: x => x.EncargadoId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Salidas_SalidaId",
                        column: x => x.SalidaId,
                        principalTable: "Salidas",
                        principalColumn: "SalidaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Seguros_SeguroId",
                        column: x => x.SeguroId,
                        principalTable: "Seguros",
                        principalColumn: "SeguroId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AscensoBombero_PersonaId",
                table: "AscensoBombero",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_BomberoDependencia_DependenciaId",
                table: "BomberoDependencia",
                column: "DependenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_BomberoDependencia_PersonaId",
                table: "BomberoDependencia",
                column: "PersonaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BomberosSalida_MovilSalidaId",
                table: "BomberosSalida",
                column: "MovilSalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_BomberosSalida_PersonaId",
                table: "BomberosSalida",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_BomberosSalida_SalidaId",
                table: "BomberosSalida",
                column: "SalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Comunicacion_NroEquipo",
                table: "Comunicacion",
                column: "NroEquipo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_PersonaId",
                table: "Contactos",
                column: "PersonaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Damnificados_SalidaId",
                table: "Damnificados",
                column: "SalidaId");

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
                name: "IX_HorariosBomberos_BomberoId",
                table: "HorariosBomberos",
                column: "BomberoId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidente_DependenciaId",
                table: "Incidente",
                column: "DependenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidente_PersonaId",
                table: "Incidente",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidente_VehiculoSalidaVehiculoId",
                table: "Incidente",
                column: "VehiculoSalidaVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Licencias_PersonaId",
                table: "Licencias",
                column: "PersonaId");

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
                name: "IX_Personas_BrigadaId",
                table: "Personas",
                column: "BrigadaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EquipoId",
                table: "Personas",
                column: "EquipoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_ImagenId",
                table: "Personas",
                column: "ImagenId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_MovilId",
                table: "Personas",
                column: "MovilId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_NumeroLegajo",
                table: "Personas",
                column: "NumeroLegajo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salidas_EncargadoId",
                table: "Salidas",
                column: "EncargadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Salidas_QuienLlenoId",
                table: "Salidas",
                column: "QuienLlenoId");

            migrationBuilder.CreateIndex(
                name: "IX_Salidas_ReceptorId",
                table: "Salidas",
                column: "ReceptorId");

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
                column: "DamnificadoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_Embarcacion_ImagenId",
                table: "Vehiculo",
                column: "Embarcacion_ImagenId",
                unique: true);

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
                name: "IX_Vehiculo_PersonaId",
                table: "Vehiculo",
                column: "PersonaId");

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
                name: "FK_AscensoBombero_Personas_PersonaId",
                table: "AscensoBombero",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BomberoDependencia_Personas_PersonaId",
                table: "BomberoDependencia",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BomberosSalida_MovilesSalida_MovilSalidaId",
                table: "BomberosSalida",
                column: "MovilSalidaId",
                principalTable: "MovilesSalida",
                principalColumn: "MovilSalidaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BomberosSalida_Personas_PersonaId",
                table: "BomberosSalida",
                column: "PersonaId",
                principalTable: "Personas",
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
                name: "FK_Contactos_Personas_PersonaId",
                table: "Contactos",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Damnificados_Salidas_SalidaId",
                table: "Damnificados",
                column: "SalidaId",
                principalTable: "Salidas",
                principalColumn: "SalidaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DatosCapacitaciones_Salidas_DatosCapacitacionId",
                table: "DatosCapacitaciones",
                column: "DatosCapacitacionId",
                principalTable: "Salidas",
                principalColumn: "SalidaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmbarcacionesAfectadas_Salidas_SalidaId",
                table: "EmbarcacionesAfectadas",
                column: "SalidaId",
                principalTable: "Salidas",
                principalColumn: "SalidaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Firmas_Personas_PersonaId",
                table: "Firmas",
                column: "PersonaId",
                principalTable: "Personas",
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
                name: "FK_HorariosBomberos_Personas_BomberoId",
                table: "HorariosBomberos",
                column: "BomberoId",
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
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Limpiezas_Vehiculo_MovilId",
                table: "Limpiezas",
                column: "MovilId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovilesSalida_Personas_PersonaId",
                table: "MovilesSalida",
                column: "PersonaId",
                principalTable: "Personas",
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
                name: "FK_Movimientos_Personas_DestinoBomberoPersonaId",
                table: "Movimientos",
                column: "DestinoBomberoPersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Vehiculo_DestinoMovilVehiculoId",
                table: "Movimientos",
                column: "DestinoMovilVehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Vehiculo_MovilId",
                table: "Personas",
                column: "MovilId",
                principalTable: "Vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salidas_Personas_EncargadoId",
                table: "Salidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Salidas_Personas_QuienLlenoId",
                table: "Salidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Salidas_Personas_ReceptorId",
                table: "Salidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Personas_EncargadoId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Personas_PersonaId",
                table: "Vehiculo");

            migrationBuilder.DropTable(
                name: "AscensoBombero");

            migrationBuilder.DropTable(
                name: "BomberoDependencia");

            migrationBuilder.DropTable(
                name: "BomberosSalida");

            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropTable(
                name: "DatosCapacitaciones");

            migrationBuilder.DropTable(
                name: "EmbarcacionesAfectadas");

            migrationBuilder.DropTable(
                name: "Firmas");

            migrationBuilder.DropTable(
                name: "HorariosBomberos");

            migrationBuilder.DropTable(
                name: "Incidente");

            migrationBuilder.DropTable(
                name: "Licencias");

            migrationBuilder.DropTable(
                name: "Limpiezas");

            migrationBuilder.DropTable(
                name: "Movimientos");

            migrationBuilder.DropTable(
                name: "Sanciones");

            migrationBuilder.DropTable(
                name: "MovilesSalida");

            migrationBuilder.DropTable(
                name: "Dependencia");

            migrationBuilder.DropTable(
                name: "Materiales");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Brigadas");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DropTable(
                name: "Comunicacion");

            migrationBuilder.DropTable(
                name: "Damnificados");

            migrationBuilder.DropTable(
                name: "Imagenes");

            migrationBuilder.DropTable(
                name: "Salidas");

            migrationBuilder.DropTable(
                name: "Seguros");
        }
    }
}
