using Vista.Data.Models.Personas.Personal;

namespace Vista.Data.Models.Grupos.Brigadas
{
    public class Bombero_Brigada
    {
        public int BomberoId { get; set; }
        public Bombero Bombero { get; set; }

        public int BrigadaId { get; set; }
        public Brigada Brigada { get; set; }
    }
}
