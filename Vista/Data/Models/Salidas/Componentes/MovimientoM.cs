using Vista.Data.Enums;
using Vista.Data.Models.Personales;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class MovimientoM
    {
        public int MovimientoMId { get; set; }
        public TipoMovimiento TipoMovimiento {get; set;}
        public Bombero? DestinoBombero { get; set; }
        public Movil? DestinoMovil { get; set; }
        public List<Material> Materiales { get; set; } = new();
    }
}
