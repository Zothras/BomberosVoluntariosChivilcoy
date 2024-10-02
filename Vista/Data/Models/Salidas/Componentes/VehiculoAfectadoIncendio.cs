using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Models.Salidas.Planillas.Incendios;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class VehiculoAfectadoIncendio : VehiculoAfectado
    {
        [ForeignKey("SalidaId")]
        public Incendio Incendio { get; set; }
    }
}
