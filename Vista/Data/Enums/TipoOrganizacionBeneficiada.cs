using System.ComponentModel.DataAnnotations;
namespace Vista.Data.Enums
{
    public enum TipoOrganizacionBeneficiada
    {
        [Display(Name = "Otras Fuerzas")]
        OtrasFuerzas,
        [Display(Name = "Entidades Gubernamentales")]
        EntidadesGubernamentales,
        [Display(Name = "Empresa Privada")]
        EmpresaPrivada,
        [Display(Name = "Otra")]
        Otra
    }
}
