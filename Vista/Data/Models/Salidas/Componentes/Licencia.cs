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
        public string Descripcion { get; set; }
        //desde = emicion de licencia
        //Hasta = finalizacion de la licencia
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
    
        public TipoEstadoLicencia EstadoLicencia { get; set; }
        public int PersonaId { get; set; }
        [ForeignKey("PersonaId")]
        public Bombero? PersonalAfectado { get; set; }
    }
}
