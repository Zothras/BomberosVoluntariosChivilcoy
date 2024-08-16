namespace Vista.Data.Enums;
using System.ComponentModel.DataAnnotations;


    public enum TipoServicioRepresentacion
    {
        [Display(Name = "Desfiles")]
        Desfiles,
        [Display(Name = "Honores Funerarios")]
        HonoresFunerarios,
        [Display(Name = "Aniversarios")]
        Aniversarios,
        [Display(Name = "Eventos Públicos")]
        EventosPublicos,
        [Display(Name = "Eventos Privados")]
        EventosPrivados,
        [Display(Name = "Ceremonias")]
        Ceremonias,
        [Display(Name = "Otro")]
        Otro
    }
