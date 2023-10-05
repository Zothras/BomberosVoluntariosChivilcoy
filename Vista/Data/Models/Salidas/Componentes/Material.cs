using System.ComponentModel.DataAnnotations;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class Material
    {
        public int MaterialId { get; set; }
        public int Cantidad { get; set; }
        [Required, StringLength(255)]
        public string Stock { get; set; }
    }
}
