using Vista.Data.Enums;
using Vista.Data.Models.Personales;
using Vista.Data.Models.Vehiculos.Moviles;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class MovimientoMaterial
    {
        public int MovimientoMaterialId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string? Observaciones { get; set; }
        public TipoMovimiento TipoMovimiento {get; set;}
        public Bombero? DestinoBombero { get; set; }
        public Movil? DestinoMovil { get; set; }
        public int Cantidad { get; set; }
        public Material? Materiales { get; set; }    
    }
}
