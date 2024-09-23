using Vista.Data.Enums;

namespace Vista.Data.ViewModels.Servicios
{
    public class ServicioDeCapacitacionViewModel : SalidasViewModels 
    {
        public NivelDeCapacitacion NivelDeCapacitacion { get; set; }
        public TipoCapacitacion TipoCapacitacion { get; set; }

       
        public List<DateTime> DiasCapacitacion { get; set; } = new List<DateTime>();
        public List<TimeSpan> HorariosCapacitacion { get; set; } = new List<TimeSpan>();
    }
}
