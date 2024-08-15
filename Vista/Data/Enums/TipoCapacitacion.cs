using System.ComponentModel.DataAnnotations;
namespace Vista.Data.Enums
{
    public enum TipoCapacitacion
    {
        [Display(Name = "Rescate con Cuerda")]
        RescateConCuerda,
        [Display(Name = "Rescate en Altura")]
        RescateEnAltura,
        [Display(Name = "Comando de Incidente")]
        ComandoDeIncidente,
        [Display(Name = "Estructuras Colapsadas")]
        EstructurasColapsadas,
        [Display(Name = "Incendios Estructurales")]
        IncendiosEstructurales,
        [Display(Name = "Incendios Forestales")]
        IncendiosForestales,
        [Display(Name = "Materiales Peligrosos")]
        MaterialesPeligrosos,
        [Display(Name = "Pedagogía")]
        PedagogiaYDidactiva,
        [Display(Name = "Psicologia de la Emergencia")]
        PscologiaDeLaEmergencia,
        [Display(Name = "Rescate Acuático")]
        RescateAcuatico,
        [Display(Name = "Rescate Vehicular")]
        RescateVehicular,
        [Display(Name = "Socorrismo")]
        Socorrismo,
        [Display(Name = "Departamento de Operaciones")]
        DepartamentoDeOperaciones,
        [Display(Name = "Escuela de Cadetes")]
        EscuelaDeCadetes,
        [Display(Name = "Seguridad del Bombero")]
        SeguridadDelBombero
    }
}
