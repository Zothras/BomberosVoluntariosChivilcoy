using System.ComponentModel.DataAnnotations;
using Vista.Data.Enums;

namespace Vista.Data.ViewModels.Servicios
{
    public class ServicioEspecialRepresentacionViewModels : SalidasViewModels
    {
       
        public TipoServicioRepresentaciones TipoServicioRepresentacion { get; set; }

        public string? OtroRepresentacion { get; set; }
        public TipoOrganizacionBeneficiada TipoOrganizacion { get; set; }
    }
}
