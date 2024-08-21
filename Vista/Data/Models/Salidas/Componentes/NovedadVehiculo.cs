using Vista.Data.Models.Personales;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Enums;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class NovedadVehiculo : NovedadBase
    {
        public int VehiculoId { get; set; }
        [ForeignKey(nameof(VehiculoId))]
        public VehiculoSalida? Vehiculo { get; set; }
    }
}
