using Vista.Data.Models.Salidas.Componentes;
using System.ComponentModel.DataAnnotations;

namespace Vista.Data.Models.Personales
{
    public abstract class Vehiculo
    {
        public int VehiculoId { get; set; }

        [StringLength(255)]
        public string? Marca { get; set; }
        [StringLength(255)]
        public string? Modelo { get; set; }
        public int? Año { get; set; }
        [StringLength(255)]
        public string? Patente { get; set; }
        [StringLength(255)]
        public string? Tipo { get; set; }

        public int? SeguroId { get; set; }
        public SeguroVehiculo? Seguro { get; set; }
    }
}
