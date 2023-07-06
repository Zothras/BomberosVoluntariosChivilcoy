using Vista.Data.Models.Personales;

namespace Vista.Data.ViewModels.Personal
{
    public class MovilSalidaViewModels
    {
        public bool CargoCombustible { get; set; }
        public string? NumeroFactura { get; set; }
        public string? FechaFactura { get; set; }
        public string? TipoConbustible { get; set; }
        public string? CantidadLitros { get; set; }
        public string? Usuario { get; set; }
        public string? NombreYApellidoRecpetor { get; set; }
        public string? TelefonoReceptor { get; set; }
        public Bombero Chofer { get; set; }
        public int NumeroLegajo { get; set; }
        public Movil MovilesSalida { get; set; }
        public string NumeroMovil { get; set; }


    }
}
