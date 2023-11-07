using System.ComponentModel.DataAnnotations;
using System.Configuration.Internal;
using Vista.Data.Enums;

namespace Vista.Data.Models.Salidas.Componentes
{
        public class Deposito
        {
            public int DepositoId { get; set; }
            public int MaterialId { get; set; }
            public List<Material> Materiales { get; set; } = new();
        }
}
