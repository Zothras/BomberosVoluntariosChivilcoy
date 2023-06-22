using Vista.Data.Models.Personales;

namespace Vista.Data.ViewModels.Personal
{
    public class MovilSalidaViewModels
    {
        public bool CargoCombustible { get; set; }
        public Bombero Chofer { get; set; }
        public int NumeroLegajo { get; set; }
        public Movil MovilesSalida { get; set; }
        public string NumeroMovil { get; set; }


    }
}
