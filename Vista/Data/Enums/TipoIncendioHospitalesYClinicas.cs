using System.ComponentModel.DataAnnotations;
namespace Vista.Data.Enums
{
    public enum TipoIncendioHospitalesYClinicas
    {
        [Display(Name = "Hospital Público")]
        HospitalPublico,
        [Display(Name = "Clínica Privada")]
        ClinicaPrivada,
        [Display(Name = "Centro de Salud")]
        CentroDeSalud,
        [Display(Name = "Salitas")]
        Salitas,
        [Display(Name = "Laboratorios")]
        Laboratorios,
        [Display(Name = "Otro")]
        Otro
    }
}
