namespace Vista.Data.Enums;
using System.ComponentModel.DataAnnotations;

public enum TipoEvacuacion
{
    [Display(Name = "No evacuó")]
    NoEvacuo,
    [Display(Name = "Evacuación Parcial")]
    EvacuacionParcial,
    [Display(Name = "Evacuación Total")]
    EvacuacionTotal
}

