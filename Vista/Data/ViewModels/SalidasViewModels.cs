using Vista.Data.Enums;
using Vista.Data.Models.Personales;
using Vista.Data.Models.Salidas.Componentes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vista.Data.ViewModels
{
    public abstract class SalidasViewModels
    {
        public int NumeroParte { get; set; }
        public int AnioNumeroParte { get; set; }

        // Otras propiedades

        //Fechas y Tiempo
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada
        {
            get
            {
                return TimeLlegada < TimeSalida ? FechaSalida.AddDays(1) : FechaSalida;
            }
        }
        public TimeOnly TimeSalida { get; set; }
        public TimeOnly TimeLlegada { get; set; }

        // HoraSalida - HoraLLegada Completas (Fecha y Hora)
        public DateTime HoraSalida
        {
            get
            {
                // Combina FechaSalida con TimeSalida
                return FechaSalida.Date.Add(TimeSalida.ToTimeSpan());
            }
        }

        public DateTime HoraLLegada
        {
            get
            {
                // Combina FechaLlegada con TimeLlegada
                return FechaLlegada.Date.Add(TimeLlegada.ToTimeSpan());
            }
        }

        public int KmLlegada { get; set; }
        public int Kilometraje { get; set; }


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
        public string? NombreYApellidoReceptor { get; set; }
        public int LegajoReceptor { get; set; }

        public List<Damnificado>? Damnificados { get; set; }

        //datos del seguro 
        public string? CompaniaAseguradora { get; set; }
        public string? NumeroPoliza { get; set; }
        public DateTime? FechaVencimineto { get; set; }

        public List<MovilSalida> Moviles { get; set; }
        public List<BomberoSalida> CuerpoParticipante { get; set; }
        //Bombero encargado
        public string NombreEncargado { get; set; }
        public string ApellidoEncargado { get; set; }
        public int LegajoEncargado { get; set; }
        //bombero que lleno la planilla
        public string NombreLLenoPlanilla { get; set; }
        public string ApllidoLLenoPlanilla { get; set; }
        public string NombreYApellidoLlenoPlanilla
        {
            get { return NombreLLenoPlanilla + " " + ApllidoLLenoPlanilla; }
        }
        public int LegajoLLenoPlanilla { get; set; }
        public TipoServicioSalida TipoServicio { get; set; }
    }
}
