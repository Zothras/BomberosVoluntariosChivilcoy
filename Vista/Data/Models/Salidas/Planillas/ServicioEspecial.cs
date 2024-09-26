using Vista.Data.Enums;
using Vista.Data.Models.Salidas.Componentes;
using System.ComponentModel.DataAnnotations;

namespace Vista.Data.Models.Salidas.Planillas
{
    public class ServicioEspecial : Salida
    {
        public TipoServiciosEspeciales Tipo { get; set; } // TODO: Quitar
        public TipoOrganizacionBeneficiada TipoOrganizacion { get; set; }        
    }
}
