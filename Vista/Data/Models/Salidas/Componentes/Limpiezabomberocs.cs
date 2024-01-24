using Vista.Data.Models.Personales;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class BomberoLimpieza
    {
        public int LimpiezaId { get; set; }
        public Limpieza Limpieza { get; set; }
        public int PersonaId { get; set; }
        public Bombero Bombero { get; set; }
    }
}
