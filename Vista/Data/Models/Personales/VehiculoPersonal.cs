using Vista.Data.Models.Salidas.Componentes;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Models.Vehiculos;

namespace Vista.Data.Models.Personales
{
    public class VehiculoPersonal : Vehiculo
    {
        public int PersonaId { get; set; }
        [ForeignKey("PersonaId")]
        public Bombero Bombero { get; set; }
    }
}
