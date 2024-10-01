using System.ComponentModel.DataAnnotations;

namespace Vista.Data.ViewModels.Servicios
{
    public class ServicioEspecialSuministroAguaViewModels : SalidasViewModels
    {
        [Required, StringLength(255)]
        public string NombreEstablecimientoSuministroAgua { get; set; }
        [StringLength(255)]
        public string? DetallesSuministroAgua { get; set; }
    }
}
