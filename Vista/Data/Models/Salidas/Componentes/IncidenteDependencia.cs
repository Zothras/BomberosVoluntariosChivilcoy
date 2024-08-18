using Vista.Data.Models.Personales;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class IncidenteDependencia : Incidente
    {
        public int DependenciaId { get;set; }
        [ForeignKey(nameof(DependenciaId))]
        public Dependencia? Dependencia { get;set; }
    }
}
