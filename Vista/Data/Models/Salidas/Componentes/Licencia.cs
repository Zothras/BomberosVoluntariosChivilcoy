using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Enums;
using Vista.Data.Models.Personales;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class Licencia
    {
        public int LicenciaId { get; set; }
        [Required]
        public TipoLicencia TipoLicencia { get; set; }
        public string? Descripcion { get; set; }

        public DateTime Desde { get; set; } //Emision de la Licencia
        public DateTime Hasta { get; set; } //Finalizacion de la Licencia

        public TipoEstadoLicencia EstadoLicencia { get; set; }
        public int PersonaId { get; set; }
        [ForeignKey("PersonaId")]
        public Bombero? PersonalAfectado { get; set; }
    }
}
