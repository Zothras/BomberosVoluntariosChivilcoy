using Vista.Data.Enums;
using Vista.Data.Models.Salidas.Componentes;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vista.Data.Models.Personales
{
    [Index(nameof(NumeroMovil))]
    public class Movil : VehiculoSalida
    {
      
        [Required, StringLength(255)]
        public string NumeroMotor { get; set; }
        [Required, StringLength(255)]
        public string ModeloBomba { get; set; }
        [Required, StringLength(255)]
        public string NumeroChasis { get; set; }
       
        public int Kilometraje { get; set; }
        public int ImagenId { get; set; }
        [ForeignKey("ImagenId")]
        public ImagenMovil Imagen { get; set; }
        public List<MovilSalida> Salidas { get; set; } = new();
        //public List<MovilBombero> Bomberos { get; set; } = new();  
        public int? EquipoId { get; set; }
        public Comunicacion? HandieMovil { get; set; }
        public List<Bombero> PersonalLimpieza { get; set; }
    }
}
