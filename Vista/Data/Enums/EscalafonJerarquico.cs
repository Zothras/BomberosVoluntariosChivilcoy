namespace Vista.Data.Enums;
using System.ComponentModel.DataAnnotations;

    public enum EscalafonJerarquico
{
        [Display(Name = "Jefe")]
        Jefe,
        [Display(Name = "2° Jefe")]
        Segundojefe,
        [Display(Name = "1° Oficial")]
        PrimerOficial,
        [Display(Name = "2° Ofical")]
        SegundoOficial,
        [Display(Name = "3° Oficial")]
        TercerOficial,
        [Display(Name = "Auxiliar Mayor")]
        AuxiliarMayor,
        [Display(Name = "1° Auxiliar")]
        PrimerAuxiliar,
        [Display(Name = "2° Auxiliar")]
        SegundoAuxiliar,
        [Display(Name = "1° Ayudante")]
        PrimerAyudante,
        [Display(Name = "2° Ayudante")]
        SegundoAyudante,
        [Display(Name = "Bombero")]
        Bombero,
        [Display(Name = "Aspirante")]
        Aspirante,
}

