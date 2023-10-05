using System.ComponentModel.DataAnnotations;
using System.Configuration.Internal;
using Vista.Data.Enums;

namespace Vista.Data.Models.Salidas.Componentes
{
        public class Deposito
        {
            public int DepositoId { get; set; }

            public DateTime Alta { get; set; }

            [Required, StringLength(255)]
            public string? Descripcion { get; set; }
            [Required, StringLength(255)]
            public string? Codigo { get; set; }
            

            public TipoRubro Rubro { get; set; }

            public List<Material> Materiales { get; set; } = new();
        }
}
