using System.ComponentModel.DataAnnotations;
namespace Vista.Data.Enums
{
    public enum TipoIncendioForestal
    {
        [Display(Name = "Campo")]
        Campo,
        [Display(Name = "Bosque")]
        Bosque,
        [Display(Name = "Isla")]
        Isla,
        [Display(Name = "Montaña")]
        Montaña,
        [Display(Name = "Bosque Nativo")]
        BosqueNativo,
        [Display(Name = "Bosque Cultivado")]
        BosqueCultivado,
        [Display(Name = "Pastizal")]
        Pastizal,
        [Display(Name = "Arbustal o Matorral")]
        ArbustalOMatorral,
        [Display(Name = "Interfase")]
        Interfase,
        [Display(Name = "Basural")]
        Basural,
        [Display(Name = "Otro")]
        Otro
    }
}
