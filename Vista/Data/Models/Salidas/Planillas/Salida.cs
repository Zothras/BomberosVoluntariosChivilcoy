using Vista.Data.Enums;
using Vista.Data.Models.Salidas.Componentes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using Vista.Data.Enums.Salidas;
using Vista.Data.Enums.Discriminadores;
using Vista.Data.Models.Personas;
using Vista.Data.Models.Personas.Personal;

namespace Vista.Data.Models.Salidas.Planillas
{

    public abstract class Salida
    {
        public int SalidaId { get; set; }
        public TipoDeEmergencia TipoEmergencia { get; set; }
        public DateTime HoraSalida { get; set; }
        public DateTime HoraLlegada { get; set; }
        public int NumeroParte { get; set; }
        public int AnioNumeroParte { get; set; }

        [Required, StringLength(255)]
        public string Descripcion { get; set; } = null!;

        //Dirección <-- Apartir de Ahora de Guarda la Dirrecion Entera (No Obligatoria por si es Rural)

        [StringLength(255)]
        public string? Direccion { get; set; }

        // Ubicación (Obligatoria) <-- Esto para hacer estadistica

        [Required]
        public double Latitud { get; set; }
        [Required]
        public double Longitud { get; set; }

        /// <summary>
        /// Representa a una región de Chivilcoy.
        /// </summary>
        public CuartelRegionChivilcoy? CuartelRegion { get; set; }

        /// <summary>
        /// Número de piso en caso de que la ubicación sea un departamento.
        /// </summary>
        [StringLength(255)]
        public string? PisoNumero { get; set; }

        /// <summary>
        /// Identificación o nombre del departamento.
        /// </summary>
        [StringLength(255)]
        public string? Depto { get; set; }

        /// <summary>
        /// Indica si la zona es rural o urbana.
        /// </summary>
        public TipoZona TipoZona { get; set; }

        // Datos del Solicitante

        /// <summary>
        /// Nombre de la persona que solicita la asistencia de los bomberos.
        /// </summary>
        public string? NombreSolicitante { get; set; }

        /// <summary>
        /// Apellido de la persona que solicita la asistencia de los bomberos.
        /// </summary>
        public string? ApellidoSolicitante { get; set; }

        /// <summary>
        /// Documento Nacional de Identidad (DNI) de la persona que solicita la asistencia de los bomberos.
        /// </summary>
        public string? DniSolicitante { get; set; }

        /// <summary>
        /// Teléfono de contacto de la persona que solicita la asistencia de los bomberos.
        /// </summary>
        public string? TelefonoSolicitante { get; set; }

        // Datos Receptor
        /// <summary>
        /// Nombre y apellido de la persona que recibe la solicitud de salida en el cuartel.
        /// </summary>
        public string? NombreYApellidoReceptor { get; set; }



        public List<Damnificado_Salida> Damnificados { get; set; } = new();

        public int? SeguroId { get; set; }
        public SeguroSalida? Seguro { get; set; }


        // Moviles que asistieron al Servicio
        public List<Movil_Salida> Moviles { get; set; } = new();

        // Bomberos que asistieron al Servico

        public List<BomberoSalida> CuerpoParticipante { get; set; } = new();


        // Encargado (Obligatorio)
        public int EncargadoId { get; set; }
        [ForeignKey("EncargadoId")]
        public Bombero Encargado { get; set; } = null!;


        // Quien Lleno la Planilla (Obligatorio)
        public int QuienLlenoId { get; set; }
        [ForeignKey("QuienLlenoId")]
        public Bombero QuienLleno { get; set; } = null!;

        // Tipo de Servicio (Servicio Especial - Accidente - Rescate - Incendio)
        public TipoServicioSalida TipoServicio { get; set; }
    }
}
