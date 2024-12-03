using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Models.Personales;

namespace Vista.Data.Models.Imagenes
{
    public class ImagenBombero : Imagen
    {
        public Bombero Bombero { get; set; }
    }
}
