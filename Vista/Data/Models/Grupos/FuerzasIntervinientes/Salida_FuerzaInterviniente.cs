using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Models.Personas;
using Vista.Data.Models.Salidas.Planillas;
using Vista.Data.Models.Vehiculos;

namespace Vista.Data.Models.Grupos.FuerzasIntervinientes
{
    public class Salida_FuerzaInterviniente
    {
        public int Id { get; set; }
        // Relación con Salida
        public int SalidaId { get; set; }

        [ForeignKey(nameof(SalidaId))]
        public Salida Salida { get; set; } = null!;
        public int FuerzaId { get; set; }

        [ForeignKey(nameof(FuerzaId))]
        public FuerzaInterviniente Fuerza { get; set; } = null!;
        public string? Encargado { get; set; }
        public Vehiculo Vehiculo { get; set; } = null!;
        public Damnificado_Salida? Damnificado { get; set; }
        public string? Destino { get; set; }
    }
}
