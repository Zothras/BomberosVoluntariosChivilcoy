using Vista.Data.Models.Personas.Personal;

namespace Vista.Data.Models.Grupos.Brigadas
{
    public class Brigada
    {
        public int BrigadaId { get; set; }
        public string Nombre { get; set; }
        public List<Bombero> Bomberos { get; set; }
        public ICollection<Bombero_Brigada> BomberoBrigadas { get; set; } = new List<Bombero_Brigada>();

    }
}
