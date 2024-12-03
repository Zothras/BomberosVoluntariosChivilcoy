using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Models.Personales;

namespace Vista.Data.Models.Imagenes
{
    public class ImagenVehiculo : Imagen
    {
        public VehiculoSalida? Vehiculo { get; set; }
    }
}
