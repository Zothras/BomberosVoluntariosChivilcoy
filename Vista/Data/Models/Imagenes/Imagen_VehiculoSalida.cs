using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Models.Personales;

namespace Vista.Data.Models.Imagenes
{
    public class Imagen_VehiculoSalida : Imagen
    {
        /// <summary>
        /// Identificador único del vehículo de salida al que está asociada la imagen.
        /// </summary>
        public int VehiculoId { get; set; }

        /// <summary>
        /// Relación con la entidad `VehiculoSalida`, que representa el vehículo asociado a esta imagen.
        /// </summary>
        [ForeignKey("VehiculoId")]
        public VehiculoSalida Vehiculo { get; set; } = null!;
    }
}
