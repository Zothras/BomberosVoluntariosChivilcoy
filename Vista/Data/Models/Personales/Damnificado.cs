using Vista.Data.Enums;
using Vista.Data.Models.Salidas.Planillas;
using System.ComponentModel.DataAnnotations;
using Vista.Data.Models.Salidas.Componentes;

namespace Vista.Data.Models.Personales
{
    public class Damnificado : Persona
    {
        public override int Edad { get; set; }
        /*
        public TipoDamnificado Estado { get; set; }
        public VehiculoDamnificado? VehiculoDamnificado { get; set; }
        public int SalidaId { get; set; }
        public Salida Salida { get; set; }
        */
    }
}
