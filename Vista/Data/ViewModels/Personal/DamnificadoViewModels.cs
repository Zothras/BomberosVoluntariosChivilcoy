using System.ComponentModel.DataAnnotations;
using Vista.Data.Enums;
using Vista.Data.Models.Salidas.Componentes;
using Vista.Data.Models.Salidas.Planillas;

namespace Vista.Data.ViewModels.Personal
{
    public class DamnificadoViewModels 
    {
        [Required, StringLength(255)]
        public string Nombre { get; set; }
        [Required, StringLength(255)]
        public string Apellido { get; set; }
        public string NombreYApellido { get { return Nombre + "," + Apellido; } }
        [Required, StringLength(255)]
        public string Dni { get; set; }
        public TipoSexo Sexo { get; set; }
        [Required, StringLength(255)]
        public string LugarDeNacimiento { get; set; }
        public int Edad { get; set; }
        public TipoDamnificado Estado { get; set; }

        public VehiculoDamnificadoViewModels? VehiculoDamnificado { get; set; }

    }
}
