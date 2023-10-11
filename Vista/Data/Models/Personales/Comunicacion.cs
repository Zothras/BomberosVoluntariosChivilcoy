using Vista.Data.Enums;
using Vista.Data.Models.Salidas.Componentes;
using Vista.Data.Models.Salidas.Planillas;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Vista.Data.Models.Personales
{
    [Index(nameof(NroEquipo), IsUnique = true)]
    public class Comunicacion
    {
        public int EquipoId { get; set; }
        [Required]
        public string NroEquipo { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? NroSerie { get; set; }
        public TipoEstadoHandie Estado { get; set; }
        public Bombero? Bombero { get; set; } 
        public Movil? Movil { get; set; } 
    }
}
