using Vista.Data.Models.Personales;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class VehiculoDamnificado : Vehiculo
    {
        public string Color { get; set; }
        public bool Airbag { get; set; }

        public int DamnificadoId { get; set; }
        [ForeignKey(nameof(DamnificadoId))]
        public Damnificado? Damnificado { get; set; }
    }
}
