using Vista.Data.Models.Salidas.Planillas;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Models.Salidas.Componentes;
using Vista.Data.Enums;

namespace Vista.Data.Models.Personales
{
    public class MovilSalida
    {
        public int MovilSalidaId { get; set; }

        public bool CargoCombustible { get; set; }

        // Datos de factura (opcional si se cargo combustible)
        public string? NumeroFactura { get; set; }
        public DateTime? FechaFactura { get; set; }
        public string? TipoConbustible { get; set; }
        public string? CantidadLitros { get; set; }
        public string? QuienLleno { get; set; }
        public string? TelefonoQuienLleno { get; set; }

        public DotacionesSalidas DotacionSalida { get; set; }

        // Relación con Salida
        public int SalidaId { get; set; }

        [ForeignKey(nameof(SalidaId))]
        public Salida Salida { get; set; }

        // Relación con el Chofer
        public int PersonaId { get; set; }

        [ForeignKey(nameof(PersonaId))]
        public Bombero? Chofer { get; set; }

        // Relación con el Movil
        public int MovilId { get; set; }

        public Movil Movil { get; set; }

        public int KmLlegada { get; set; }
    }
}
