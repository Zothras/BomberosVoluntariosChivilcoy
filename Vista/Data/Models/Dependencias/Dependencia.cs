using Vista.Data.Models.Salidas.Componentes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Models.Personales;

namespace Vista.Data.Models.Dependencias
{
    public class Dependencia
    {
        public int DependenciaId { get; set; }

        [Required, StringLength(255)]
        public string? NombreDependencia { get; set; }
        public List<Bombero_Dependencia> Bomberos { get; set; } = new();
        public List<IncidenteDependencia> Incidentes { get; set; } = new();
    }
}
