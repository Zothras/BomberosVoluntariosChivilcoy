using System.ComponentModel.DataAnnotations.Schema;

namespace Vista.Data.Models.Personales
{
    public class ImagenVehiculo : Imagen
    {
        public VehiculoSalida? Vehiculo { get; set; }
    }
}
