using System.ComponentModel.DataAnnotations;
namespace Vista.Data.Enums
{
    public enum TipoIncendio
    {
        [Display(Name = "Aeronaves")]
        Aeronaves,
        [Display(Name = "Comercio")]
        Comercios,
        [Display(Name = "Embarcaciones")]
        Embarcaiones,
        [Display(Name = "Establecimiento Educativo")]
        EstablecimientoEducativo,
        [Display(Name = "Establecimiento Público")]
        EstablecimientoPublico,
        [Display(Name = "Forestal")]
        Forestal,
        [Display(Name = "Hospital")]
        Hospital,
        [Display(Name = "Clínica")]
        Clinica,
        [Display(Name = "Industria")]
        Industria,
        [Display(Name = "Vehicular")]
        Vehicular,
        [Display(Name = "Vivienda")]
        Vivienda,
        [Display(Name = "Otro")]
        Otro
    }
}
