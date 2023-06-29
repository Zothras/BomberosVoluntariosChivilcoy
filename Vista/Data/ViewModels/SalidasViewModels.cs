using Vista.Data.Enums;
using Vista.Data.Models.Personales;
using Vista.Data.Models.Salidas.Componentes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Vista.Data.ViewModels
{
    //fecha
    public abstract class SalidasViewModels
    {
        public DateTime HoraSalida { get; set; }
        public DateTime HoraLLegada { get; set; }
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

        //Datos del bombero receptor
        public string NombreReceptor { get; set; }
        public string ApellidoReceptor { get; set; }
        public int LegajoReceptor { get; set; }

        public List<Damnificado> Damnificados { get; set; }

        //datos del seguro 
        public string CompaniaAseguradora { get; set; }
        public string NumeroPoliza { get; set; }
        public DateTime FechaVencimineto { get; set; }

        public List<MovilSalida> Moviles { get; set; }
        public List<BomberoSalida> CuerpoParticipante { get; set; }
        //Bombero encargado
        public string NombreEncargado { get; set; }
        public string ApellidoEncargado { get; set; }
        public int LegajoEncargado{ get; set; }
        //bombero que lleno la planilla
        public string NombreLLenoPlanilla { get; set; }
        public string ApllidoLLenoPlanilla { get; set; }
        public int LegajoLLenoPlanilla { get; set; }
        public TipoServicioSalida TipoServicio { get; set; }
    }
}
