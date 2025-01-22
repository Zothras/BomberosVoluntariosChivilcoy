using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Models.Otros;

namespace Vista.Data.Models.Grupos.Dependencias
{
    public class IncidenteDependencia : Incidente
    {
        public int DependenciaId { get; set; }
        [ForeignKey(nameof(DependenciaId))]
        public Dependencia? Dependencia { get; set; }
    }
}
