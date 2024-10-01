using System.ComponentModel.DataAnnotations;

namespace Vista.Data.Models.Salidas.Planillas
{
    public class ServicioEspecialFalsaAlarma : ServicioEspecial
    {
        [Required,StringLength (255)]
        public string Detalles { get; set; }

    }
}
