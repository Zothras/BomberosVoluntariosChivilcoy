using System.ComponentModel.DataAnnotations;

namespace Vista.Data.Enums
{
    public enum NivelDeCapacitacion
    {
        [Display(Name = "Cuartel")]
        Cuartel,        // Cuartel - Internacional
        [Display(Name = "Federativa")]
        Federativa,  // Federativa - Regional
        [Display(Name = "Nacional")]
        Nacional,       // Nacional - Otra
    }
}
