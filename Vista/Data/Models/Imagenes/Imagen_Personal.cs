using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Models.Personales;

namespace Vista.Data.Models.Imagenes
{
    public class Imagen_Personal : Imagen
    {
        /// <summary>
        /// Relación con la entidad `Personal`, que representa al personal asociado a esta imagen.
        /// </summary>
        [Required]
        public Personal Personal { get; set; } = null!;
        /// <summary>
        /// Identificador único del personal al que está asociada la imagen.
        /// </summary>
        public int PersonalId { get; set; }
    }
}
