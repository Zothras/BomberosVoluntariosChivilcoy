using System.ComponentModel.DataAnnotations;
namespace Vista.Data.Enums
{
    public enum TipoIncendioTecho
    {
        [Display(Name = "Madera/Paja")]
        MaderaPaja,
        [Display(Name = "Yeso")]
        Yeso,
        [Display(Name = "Tejas")]
        Tejas,
        [Display(Name = "Chapa Metálica")]
        ChapaMetalica,
        [Display(Name = "Chapa/Cartón")]
        ChapaCarton,
        [Display(Name = "Otro")]
        Otro
    }
}
