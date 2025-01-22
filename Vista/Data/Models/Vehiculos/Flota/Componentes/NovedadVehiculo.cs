using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Enums;
using Vista.Data.Models.Vehiculos.Flota;
using Vista.Data.Models.Otros;

namespace Vista.Data.Models.Vehiculos.Flota.Componentes
{
    public class NovedadVehiculo : NovedadBase
    {
        public int VehiculoId { get; set; }
        [ForeignKey(nameof(VehiculoId))]
        public VehiculoSalida? Vehiculo { get; set; }
    }
}
