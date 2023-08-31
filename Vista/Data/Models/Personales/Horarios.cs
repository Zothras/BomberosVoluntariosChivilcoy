
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Enums;

namespace Vista.Data.Models.Personales
{
    public class HorarioBombero
    {
        public int HorarioId { get; set; }
        public DateTime? VigenteDesde { get; set; }
        public DateTime? VigenteHasta { get; set; }
        public Dias DiaSemana { get; set; }
        public TimeOnly HoraDesde { get; set; }
        public TimeOnly HoraHasta { get; set; }
        public TimeOnly? Periodo { get; set; }
        public TiposRotativos ModoRotativo { get; set; }      
        public int BomberoId { get; set; }
        Bombero? BomberoAsignado { get; set; }
    }
}
