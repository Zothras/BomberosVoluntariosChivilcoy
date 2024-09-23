using Vista.Data.Enums;

namespace Vista.Data.Models.Salidas.Planillas
{
    public class ServicioDeCapacitacion : ServicioEspecial
    {
        public NivelDeCapacitacion NivelDeCapacitacion { get; set; }
        public TipoCapacitacion TipoCapacitacion { get; set; }
        public List<DateTime> DiasCapacitacion { get; set; }
        public List<TimeSpan> HorariosCapacitacion { get; set; }
    }
}
