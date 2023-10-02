using System.ComponentModel.DataAnnotations;
using System.Configuration.Internal;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class Deposito
    {
        public int DepositoId { get; set; }
        [StringLength(255)]
        public string Materiales { get; set; }
        
        public DateTime SalidaMaterial {  get; set; }
        
        public DateTime EntradaMaterial { get; set; }
    }
}
