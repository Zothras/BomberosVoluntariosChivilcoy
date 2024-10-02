using System.ComponentModel.DataAnnotations;

namespace Vista.Data.Models.Salidas.Planillas
{
    public class ServicioEspecialColaboraciónFuerzasSeguridad : ServicioEspecial
    {
        [StringLength(255)]
        public string? DetallesColaboFuerzasSeguridad { get; set; }
    }
}
