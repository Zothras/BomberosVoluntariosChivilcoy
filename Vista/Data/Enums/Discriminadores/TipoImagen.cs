using System.ComponentModel.DataAnnotations;

namespace Vista.Data.Enums.Discriminadores
{
    public enum TipoImagen
    {
        /// <summary>
        /// Imagen asociada a personal.
        /// </summary>
        [Display(Name = "Imagen de Personal")]
        ImagenPersonal = 1,

        /// <summary>
        /// Imagen asociada a un vehículo o salida.
        /// </summary>
        [Display(Name = "Imagen de Vehículo/Salida")]
        ImagenVehiculoSalida = 2
    }
}
