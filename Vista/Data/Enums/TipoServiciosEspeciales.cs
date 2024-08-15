namespace Vista.Data.Enums;
using System.ComponentModel.DataAnnotations;

public enum TipoServiciosEspeciales
    {
    [Display(Name = "Capacitación")]
    Capacitacion,
    [Display(Name = "Servicios Especiales")]
    ServiciosEspeciales,
    [Display(Name = "Prevención")]
    Prevencion,
    [Display(Name = "Falsa Alarma")]
    FalsaAlarma,
    [Display(Name = "Representación")]
    Representacion,
    [Display(Name = "Falso Aviso")]
    FalsoAviso,
    [Display(Name = "Suministro de Agua")]
    SuministroDeAgua,
    [Display(Name = "Extracción de Panales")]
    ExtraccionDePanales,
    [Display(Name = "Retirado de Obito")]
    RetiradoDeObito,
    [Display(Name = "Colaboración con Fuerzas de Seguridad")]
    ColaboracionConFuerzasDeSeguridad,
    [Display(Name = "Colaboración de Driza")]
    ColaboracionDeDriza,
    [Display(Name = "Escape de Gas (Auto)")]
    EscapeDeGasAuto,
    [Display(Name = "Escape de Gas (Casa)")]
    EscapeDeGasCasa,
    [Display(Name = "Otro")]
    Otro
}

