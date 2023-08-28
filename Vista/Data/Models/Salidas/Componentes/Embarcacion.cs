using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Enums;
using Vista.Data.Models.Personales;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class Embarcacion : VehiculoSalida
    {
        public int ImagenId { get; set; }
        [ForeignKey("ImagenId")]
        public ImagenEmbarcacion ImagenEmbarcacion { get; set; }
    }


}
