using System.ComponentModel.DataAnnotations;
namespace Vista.Data.Enums
{
    public enum TipoIncendioEstablecimientoEducativo
    {
        [Display(Name = "Jardín")]
        Jardin,
        [Display(Name = "Escuela Primaria")]
        EscuelaPrimaria,
        [Display(Name = "Escuela Secundaria")]
        EscuelaSecundaria,
        [Display(Name = "Terciario")]
        Terciario,
        [Display(Name = "Universidad")]
        Universidad,
        [Display(Name = "Otro")]
        Otro
    }
}
