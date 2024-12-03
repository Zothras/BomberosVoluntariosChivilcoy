using Vista.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Models.Dependencias;

namespace Vista.Data.Models.Personales
{
    public class Bombero_Dependencia
    {
        public int Bombero_DependenciaId { get; set; }
        public int? PersonaId { get; set; }
        [ForeignKey(nameof(PersonaId))]
        public Bombero? Bombero { get; set; }
        public int? DependenciaId { get; set; }
        [ForeignKey(nameof(DependenciaId))]
        public Dependencia? Dependencia { get; set; }
    }
}
