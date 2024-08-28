using Vista.Data.Enums;
using Vista.Data.Models.Salidas.Planillas;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vista.Data.Models.Personales
{
    public class BomberoSalida
    {
        public int BomberoSalidaId { get; set; }

        public MovilSalida? MovilAsignado { get; set; }
        public EscalafonJerarquico Grado { get; set; }

        public int PersonaId { get; set; }
        [ForeignKey("PersonaId")]
        public Bombero Bombero { get; set; }
    }
}
