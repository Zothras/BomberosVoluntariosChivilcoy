using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Enums;
using Vista.Data.Models.Personales;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class AscensoBombero
    {
        public int AscensoId { get; set; }
        
        public DateTime FechaEmision { get; set; }

        [StringLength(255)]
        public string? Descripcion { get; set; }

        public EscalafonJerarquico  GradoAntiguo { get; set; }

        public EscalafonJerarquico GradoAscenso { get; set; }
        public int PersonaId { get; set; }
        [ForeignKey("PersonaId")]
        public Bombero PersonalAfectado { get; set; }

    }


}
