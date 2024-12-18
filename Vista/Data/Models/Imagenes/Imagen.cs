using System.ComponentModel.DataAnnotations;
using Vista.Data.Enums.Discriminadores;

namespace Vista.Data.Models.Imagenes
{
    public abstract class Imagen
    {
        /// <summary>
        /// Identificador único de la imagen.
        /// </summary>
        public int ImagenId { get; set; }

        public TipoImagen Tipo { get; set; }

        /// <summary>
        /// Nombre de la imagen. Campo obligatorio con una longitud máxima de 255 caracteres.
        /// </summary>
        [Required, StringLength(255)]
        public string NombreImagen { get; set; } = null!;

        /// <summary>
        /// Contenido de la imagen en formato Base64. Campo obligatorio.
        /// </summary>
        public string Base64Imagen { get; set; } = null!;

        /// <summary>
        /// Tipo o formato de la imagen (por ejemplo, JPEG, PNG). 
        /// Campo obligatorio con una longitud máxima de 255 caracteres.
        /// </summary>
        [Required, StringLength(255)]
        public string TipoImagen { get; set; } = null!;
    }
}
