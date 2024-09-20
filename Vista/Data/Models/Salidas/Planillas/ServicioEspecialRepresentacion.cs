using Vista.Data.Enums;
using Vista.Data.Models.Salidas.Componentes;
namespace Vista.Data.Models.Salidas.Planillas
{
    public class ServicioEspecialRepresentacion : ServicioEspecial
    {
        public TipoServicioRepresentaciones TipoRepresentacion { get; set; }
        public DatosCapacitacion? DatosCapacitacion { get; set; }
    }
}
