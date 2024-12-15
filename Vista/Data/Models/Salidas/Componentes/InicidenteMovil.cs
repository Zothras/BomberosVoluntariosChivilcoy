using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using Vista.Data.Models.Vehiculos.Moviles;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class InicidenteMovil : Incidente
    {
        public int VehiculoId { get; set; }
        [ForeignKey("VehiculoId")]
        public Movil Movil { get; set; }
    }
}
