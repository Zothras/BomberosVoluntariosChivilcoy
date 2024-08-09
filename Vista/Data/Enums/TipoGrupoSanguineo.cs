namespace Vista.Data.Enums;
using System.ComponentModel.DataAnnotations;
    public enum TipoGrupoSanguineo
    {
    [Display(Name = "A Positivo")]
    APositivo,
    [Display(Name = "A Negativo")]
    ANegativo,
    [Display(Name = "B Positivo")]
    BPositivo,
    [Display(Name = "B Negativo")]
    BNegativo,
    [Display(Name = "AB Positivo")]
    ABPositivo,
    [Display(Name = "AB Negativo")]
    ABNegativo,
    [Display(Name = "O Positivo")]
    OPositivo,
    [Display(Name = "O Negativo")]
    ONegativo
}