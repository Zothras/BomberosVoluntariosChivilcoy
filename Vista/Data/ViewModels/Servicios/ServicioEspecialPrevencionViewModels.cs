using System.ComponentModel.DataAnnotations;
using Vista.Data.Enums;
using Vista.Data.Models.Salidas.Componentes;

namespace Vista.Data.ViewModels.Servicios
{
    public class ServicioEspecialPrevencionViewModels : SalidasViewModels
    {
        public TipoServiciosEspeciales Tipo { get; set; }
        public TipoOrganizacionBeneficiada TipoOrganizacion { get; set; }
        [StringLength(255)]
        public string? OtroRepresentacion { get; set; }
        
        //Datos de capacitaciones
        public string? NivelCapacitacion { get; set; }
        [StringLength(255)]
        public string? NivelCapacitacionOtro { get; set; }
        public string? TipoCapacitacion { get; set; }
        [StringLength(255)]
        public string? CapacitacionOtra { get; set; }
        [Required, StringLength(255)]
        public string DiasCapacitacion { get; set; }
        [Required, StringLength(255)]
        public string HorariosCapacitacion { get; set; }
        public TipoServicioPrevencion TipoPrevencion { get; set; }
    }
}
