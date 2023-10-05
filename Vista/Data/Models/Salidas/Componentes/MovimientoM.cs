using Vista.Data.Models.Personales;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class MovimientoM
    {
        public int MovimientoMId { get; set; }

        public enum TipoMovimiento
        {
            Entrada,
            Salida,
            Baja,
            Entrada_Salida,
        }
        public Bombero Destino { get; set; }
        public List<Material> Materiales { get; set; } = new();
    }
}
