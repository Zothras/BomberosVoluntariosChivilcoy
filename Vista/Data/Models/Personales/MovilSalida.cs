using Vista.Data.Models.Salidas.Planillas;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Models.Salidas.Componentes;

namespace Vista.Data.Models.Personales
{
    public class MovilSalida
    {
        public int MovilSalidaId { get; set; }

        public bool CargoCombustible { get; set; }
        //deberia ir aca si cargo conbustible 
        public string? NumeroFactura { get; set; }
        public DateTime? FechaFactura { get; set; }
        public string? TipoConbustible { get; set; }
        public string? CantidadLitros { get; set; }
        public string? QuienLleno { get; set; }
        public string? TelefonoQuienLleno { get; set; }
        public int PersonaId { get; set; }
        [ForeignKey("PersonaId")]
        public Bombero Chofer { get; set; }

        public int MovilId { get; set; }

        
        public Movil Movil { get; set; }
        public int EmbarcacionId { get; set; }
        public Embarcacion Embarcacion { get; set; }
        public int SalidaId { get; set; }
        public Salida Salida { get; set; }
        public int KmLlegada { get; set; }//Lo pusimos aca, porque el movil solo tiene la variables kilometraje, o le interesa tener el km de llegada, esta ultima es una variable auxiliar que sirve para incrementar el kilometraje de un movil
    }
}
