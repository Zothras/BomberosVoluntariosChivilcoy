using Vista.Data.Enums;

namespace Vista.Data.ViewModels.Personal
{
    public class BomberoSalidaViewModels
    {

        public bool Salio { get; set; }
        public EscalafonJerarquico Grado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NumeroLegajo { get; set; }
        public string ApellidoYNombre
        {
            get { return Apellido + "," + Nombre; }
        }
    }
}
