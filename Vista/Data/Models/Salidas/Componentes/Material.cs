using System.ComponentModel.DataAnnotations;
using Vista.Data.Enums;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class Material
    {
        public int MaterialId { get; set; }

		public DateTime FechaAlta { get; set; }
		public string? Descripcion { get; set; }
		public string? Codigo { get; set; }
        public string Stock { get; set; }

		public TipoRubro Rubro { get; set; }
	}
}
