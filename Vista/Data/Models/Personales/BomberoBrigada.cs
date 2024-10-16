namespace Vista.Data.Models.Personales
{
    public class BomberoBrigada
    {
        public int BomberoId { get; set; }
        public Bombero Bombero { get; set; }

        public int BrigadaId { get; set; }
        public Brigada Brigada { get; set; }
    }
}
