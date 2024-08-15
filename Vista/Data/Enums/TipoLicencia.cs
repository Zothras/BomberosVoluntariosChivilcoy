using System.ComponentModel.DataAnnotations;
namespace Vista.Data.Enums
{
    public enum TipoLicencia
    {
        [Display(Name = "Razones Laborales")]
        RazonesLaborales,
        [Display(Name = "Razones Personales")]
        RazonesPersonales,
        [Display(Name = "Razones Familiares")]
        RazonesFamiliares,
        [Display(Name = "Razones de Estudio")]
        RazonesDeEstudio,
        [Display(Name = "Razones de Salud")]
        RazonesDeSalud,
        [Display(Name = "Ausencia de la ciudad")]
        AusenciaDeLaCiudad
    }
}