using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Enums;
using Vista.Data.Models.Personales;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class Embarcacion : Vehiculo
    {

        [Required, StringLength(255)]
        public string NumeroMovil {get; set;}
        [Required, StringLength(255)]
        public TipoEstadoMovil Estado { get; set;}

        public int EncargadoId { get; set;}

        [ForeignKey("EncargadoId")]
        public Bombero Encargado { get; set;}

        public int ImagenId { get; set; }
        [ForeignKey("ImagenId")]
        public ImagenMovil Imagen { get; set; }

        public List<Firma> Firmas { get; set; }

        public List<MovilBombero> Bomberos { get; set; } = new();

        public List<MovilSalida> Salidas { get; set; } = new();

        public List<Incidente> Incidentes { get; set; } = new();
    }


}
