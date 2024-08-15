using System.ComponentModel.DataAnnotations;
namespace Vista.Data.Enums
{
    public enum TipoIncendioAbertura
    {
        [Display(Name = "Madera")]
        Madera,
        [Display(Name = "Acero/Hierro")]
        AceroHierro,
        [Display(Name = "Aluminio")]
        Aluminio,
        [Display(Name = "Plástico")]
        Plastica,
        [Display(Name = "Otro")]
        Otro
    }
}
