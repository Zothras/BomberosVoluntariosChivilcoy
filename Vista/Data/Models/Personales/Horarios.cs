
namespace Vista.Data.Models.Personales
{
    public class Horarios
    {
        public DateTime? vigente_desde { get; set; }
        public DateTime? vigente_hasta { get; set; }
        //public Dias dia_semana { get; set; }
        public TimeOnly hora_desde { get; set; }
        public TimeOnly hora_hasta { get; set; }
        public TimeOnly periodo { get; set; }
        public bool modo_rotativo { get; set; }
    }
}
