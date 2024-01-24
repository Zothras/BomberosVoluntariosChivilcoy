using Vista.Data.Enums;
using Vista.Data.Models.Personales;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class Limpieza
    {
        public int LimpiezaId { get; set; }
        public TipoIncidente Incidente { get; set; }
        public string? Descripcion  { get; set; }
        public int? MovilId  { get; set; }
        public Movil Movil { get; set; }
        public List<Bombero> Bomberos { get; set; }
    }
}
