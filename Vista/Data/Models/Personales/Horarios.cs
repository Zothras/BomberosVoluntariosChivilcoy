using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        [DataType(DataType.Time)]
        public DateTime HoraDesde { get; set; }
        [DataType(DataType.Time)]
        public DateTime HoraHasta { get; set; }
        [DataType(DataType.Time)]
        public DateTime? Periodo { get; set; }
        public TiposRotativos ModoRotativo { get; set; }
        public int BomberoId { get; set; }
        Bombero? BomberoAsignado { get; set; }
    }
}