using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vista.Data.Enums;
using Vista.Data.Models.Personales;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class Limpieza
    {
        public int LimpiezaId { get; set; }
        public DateTime Fecha { get; set; }
        public TipoIncidente Incidente { get; set; }
        public string? Descripcion { get; set; }
        public int? MovilId { get; set; }
        public Movil? Movil { get; set; }
        public Bombero? Bomberos { get; set; }
    }
}
