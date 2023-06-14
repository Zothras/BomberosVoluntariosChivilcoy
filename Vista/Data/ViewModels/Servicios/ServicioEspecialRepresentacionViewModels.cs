using System.ComponentModel.DataAnnotations;
using Vista.Data.Enums;

namespace Vista.Data.ViewModels.Servicios
{
    public class ServicioEspecialRepresentacionViewModels : SalidasViewModels
    {
        public TipoServicioRepresentacion TipoRepresentacion { get; set; }
        //Datos de la capacitacion
        public TipoNivelCapacitacion? NivelCapacitacion { get; set; }
        [StringLength(255)]
        public string? NivelCapacitacionOtro { get; set; }
        public TipoCapacitacion? TipoCapacitacion { get; set; }
        [StringLength(255)]
        public string? CapacitacionOtra { get; set; }
        [Required, StringLength(255)]
        public string DiasCapacitacion { get; set; }
        [Required, StringLength(255)]
        public string HorariosCapacitacion { get; set; }
    }
}
