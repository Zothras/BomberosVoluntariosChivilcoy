using Vista.Data.Enums;
using Vista.Data.Models.Salidas.Componentes;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Models.Grupos.Dependencias.Comunicaciones;

namespace Vista.Data.Models.Personales
{
    [Index(nameof(NumeroMovil))]
    public class Movil : VehiculoSalida
    { 
        [StringLength(255)]
        public string? NumeroMotor { get; set; }
        [StringLength(255)]
        public string? ModeloBomba { get; set; }
        [StringLength(255)]
        public string? NumeroChasis { get; set; }
        [StringLength(255)]
        public string? CantidadLitros { get; set; }
        public int Kilometraje { get; set; }
        public List<MovilSalida> Salidas { get; set; } = new();
        public int? EquipoId { get; set; }
        public Comunicacion? HandieMovil { get; set; }
    }
}
