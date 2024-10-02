using System.ComponentModel.DataAnnotations;

namespace Vista.Data.ViewModels.Servicios
{
    public class ServicioEspecialRetiradoDeObitoViewModel : SalidasViewModels
    {
        [Required, StringLength(255)]
        public string DetallesObito { get; set; }
    }
}
