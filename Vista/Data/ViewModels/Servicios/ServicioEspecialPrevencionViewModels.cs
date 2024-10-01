using System.ComponentModel.DataAnnotations;
using Vista.Data.Enums;
using Vista.Data.Models.Salidas.Componentes;

namespace Vista.Data.ViewModels.Servicios
{
    public class ServicioEspecialPrevencionViewModels : SalidasViewModels
    {
        [StringLength(255)]
        public TipoOrganizacionBeneficiada TipoOrganizacion { get; set; }
        [StringLength(255)]
        public TipoServicioPrevencion TipoPrevencion { get; set; }
    }
}
