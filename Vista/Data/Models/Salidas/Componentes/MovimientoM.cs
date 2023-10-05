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
        public int Cantidad { get; set; }
        public Material? Materiales { get; set; }    
    }
}
