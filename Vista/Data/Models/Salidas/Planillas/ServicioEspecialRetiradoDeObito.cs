using System.ComponentModel.DataAnnotations;

namespace Vista.Data.Models.Salidas.Planillas
{
    public class ServicioEspecialRetiradoDeObito : ServicioEspecial
    {
        [Required,StringLength (255)]
        public string DetallesObito {  get; set; }
    }
}
