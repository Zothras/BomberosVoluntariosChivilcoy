using System.ComponentModel.DataAnnotations;
namespace Vista.Data.Enums
{
    public enum TipoIncendioIndustria
    {
        [Display(Name = "Automotriz")]
        Automotriz,
        [Display(Name = "Textil")]
        Textil,
        [Display(Name = "Metalúrgica")]
        Metalurgica,
        [Display(Name = "Química")]
        Quimica,
        [Display(Name = "Alimentación")]
        Alimentacion,
        [Display(Name = "Petroquímica")]
        Petroquimica,
        [Display(Name = "Otro")]
        Otro
    }
}
