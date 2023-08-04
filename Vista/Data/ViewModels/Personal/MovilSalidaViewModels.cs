using Vista.Data.Models.Personales;

namespace Vista.Data.ViewModels.Personal
{
    public class MovilSalidaViewModels
    {
        public bool CargoCombustible { get; set; }
        public string? NumeroFactura { get; set; }
        public DateTime? FechaFactura { get; set; }
        public string? TipoConbustible { get; set; }
        public string? CantidadLitros { get; set; }
        public string? QuienLleno { get; set; }
        public string? TelefonoQuienLleno { get; set; }
        public Bombero Chofer { get; set; }
        public int NumeroLegajo { get; set; }
        public Movil MovilesSalida { get; set; }
        public string NumeroMovil { get; set; }
        public int KmLlegada { get; set; }

    }
}
