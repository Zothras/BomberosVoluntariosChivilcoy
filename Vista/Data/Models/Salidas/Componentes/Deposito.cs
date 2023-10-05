using System.ComponentModel.DataAnnotations;
using System.Configuration.Internal;

namespace Vista.Data.Models.Salidas.Componentes
{
        public class Deposito
        {
            public int DepositoId { get; set; }

            public DateTime Alta { get; set; }

            [Required, StringLength(255)]
            public string Descripcion { get; set; }
            [Required, StringLength(255)]
            public string Codigo { get; set; }
            public enum Rubro
            {
                NoAsignado,
                Taller,
                Personal,
                Seguridad
            }

            public Rubro rubro { get; set; }

            public List<Material> Materiales { get; set; } = new();
        }
}
