using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Models.Personas.Personal;

namespace Vista.Data.Models.Grupos.Dependencias
{
    public class Dependencia
    {
        public int DependenciaId { get; set; }

        [Required, StringLength(255)]
        public string NombreDependencia { get; set; } = null!;
        public Bombero Encargado { get; set; } = null!;
        public List<Bombero_Dependencia> Bomberos { get; set; } = new();
        public List<IncidenteDependencia> Incidentes { get; set; } = new();
    }
}
