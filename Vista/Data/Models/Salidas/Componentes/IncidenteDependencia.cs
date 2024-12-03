using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Models.Grupos.Dependencias;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class IncidenteDependencia : Incidente
    {
        public int DependenciaId { get;set; }
        [ForeignKey(nameof(DependenciaId))]
        public Dependencia? Dependencia { get;set; }
    }
}
