namespace Vista.Data.Models.Salidas.Componentes
{
    public class GeorefResponse
    {
        public List<Direccion> direcciones { get; set; }
    }

    public class Direccion
    {
        public Calle calle { get; set; }
        // Omite propiedades no utilizadas
    }

    public class Calle
    {
        public string nombre { get; set; }
    }
}
