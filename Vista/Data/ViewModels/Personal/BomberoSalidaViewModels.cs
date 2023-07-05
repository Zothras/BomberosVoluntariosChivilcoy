using Vista.Data.Enums;
using Vista.Data.Migrations;

namespace Vista.Data.ViewModels.Personal
{
    public class BomberoSalidaViewModels
    {
        public bool Salio { get; set; }
        public EscalafonJerarquico Grado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NumeroLegajo { get; set; }
        public string NombreYApellido
        {
            get 
            {
                return Nombre + "" + Apellido;
            }
        }


    }
}
