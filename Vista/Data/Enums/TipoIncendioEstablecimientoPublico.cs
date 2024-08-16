using System.ComponentModel.DataAnnotations;
namespace Vista.Data.Enums
{
    public enum TipoIncendioEstablecimientoPublico
    {
        [Display(Name = "Oficina Pública")]
        OficinaPublica,
        [Display(Name = "Ministerio")]
        Ministerio,
        [Display(Name = "Otro")]
        Otro
    }
}
