using Microsoft.CodeAnalysis.Operations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Enums;
using Vista.Data.Models.Personas.Personal;

namespace Vista.Data.Models.Personales
{
    public abstract class NovedadBase
    {
        public int NovedadBaseId { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Observacion { get; set; }

        public int? PersonalId { get; set; }
        [ForeignKey(nameof(PersonalId))]
        public Bombero? Personal { get; set; }

        /* Deshabilitado temporalmente
        
        public int? DependenciaId { get; set; }
        [ForeignKey(nameof(DependenciaId))]
        public Dependencia? Dependencia { get; set; }
        */
    }
}
