using Vista.Data.Enums;
using Vista.Data.Models.Personales;
using Vista.Data.Models.Salidas.Componentes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vista.Data.Models.Salidas.Planillas
{
    public abstract class Salida
    {
        public int SalidaId { get; set; }

        public DateTime FechaSalida { get; set; }
        public DateTime FechaLLegada { get; set; }
        public int KmSalida { get; set; }
        public int KmLlegada { get; set; }
        public int NumeroParte { get; set; }
        [Required, StringLength(255)]
        public string Descripcion { get; set; }
        [Required, StringLength(255)]
        public string CalleORuta { get; set; }
        [Required, StringLength(255)]
        public string NumeroOKilometro { get; set; }
        [Required, StringLength(255)]
        public string? EntreCalles { get; set; }
        [StringLength(255)]
        public string? PisoNumero { get; set; }
        [StringLength(255)]
        public string? Depto { get; set; }
        public TipoZona TipoZona { get; set; }
        
        public string NombreSolicitante { get; set; }
        public string ApellidoSolicitante { get; set; }
        public string DniSolicitante { get; set; }
        public string TelefonoSolicitante { get; set; }
        
        public string? Receptor { get; set; }

        public int? ReceptorId { get; set; }

        [ForeignKey("ReceptorId")]
        public Bombero? ReceptorBombero { get; set; }

        //Si hay damnificados, entonces hay intervinientes
        public List<Damnificado> Damnificados { get; set; }

        public int? SeguroId { get; set; }
        public SeguroSalida? Seguro { get; set; }

        //relaciones con bomberos y moviles
        public List<MovilSalida> Moviles { get; set; }
        
        public List<BomberoSalida> CuerpoParticipante { get; set; }

        public int EncargadoId { get; set; }
        [ForeignKey("EncargadoId")]
        public Bombero Encargado { get; set; }

        public int QuienLlenoId { get; set; }
        [ForeignKey("QuienLlenoId")]
        public Bombero QuienLleno { get; set; }
        public TipoServicioSalida TipoServicio { get; set; }
    }
}
