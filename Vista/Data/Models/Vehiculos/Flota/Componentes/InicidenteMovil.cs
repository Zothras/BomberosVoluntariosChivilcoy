using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using Vista.Data.Models.Otros;
using Vista.Data.Models.Vehiculos.Flota;

namespace Vista.Data.Models.Vehiculos.Flota.Componentes
{
    public class InicidenteMovil : Incidente
    {
        public int VehiculoId { get; set; }
        [ForeignKey("VehiculoId")]
        public Movil Movil { get; set; }
    }
}
