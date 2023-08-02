using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Enums;
using Vista.Data.Models.Personales;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class Embarcacion : Vehiculo
    {
        public int EmbarcacionId {get; set;}

        public int NumeroMovil {get; set;}
        [Required, StringLength(255)]
        public TipoEstadoMovil Estado { get; set;}
        [Required, StringLength(255)]

        public int EncargadoId { get; set;}

        [ForeignKey("EncargadoId")]
        public Bombero Encargado { get; set;}

        public int ImagenId { get; set; }
        [ForeignKey("ImagenId")]
        public ImagenMovil Imagen { get; set; }

    }


}
