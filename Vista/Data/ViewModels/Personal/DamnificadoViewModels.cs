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
        [Required, StringLength(255)]
        public string Dni { get; set; }
        public TipoSexo Sexo { get; set; }
        [Required, StringLength(255)]
        public string LugarDeNacimiento { get; set; }
        public int Edad { get; set; }
        public TipoDamnificado Estado { get; set; }

        public VehiculoDamnificado? VehiculoDamnificado { get; set; }
        [Required, StringLength(255)]
        public string Marca { get; set; }
        [Required, StringLength(255)]
        public string Modelo { get; set; }
        public int Año { get; set; }
        [Required, StringLength(255)]
        public string Patente { get; set; }
        [Required, StringLength(255)]
        public string Tipo { get; set; }

        [Required, StringLength(255)]
        public string Color { get; set; }
        public bool? Airbag { get; set; }
        public int SalidaId { get; set; }
        public Salida Salida { get; set; }

    }
}
