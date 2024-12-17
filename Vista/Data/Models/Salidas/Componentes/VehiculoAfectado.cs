using Vista.Data.Models.Vehiculos;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class VehiculoAfectado : Vehiculo
    {
        public bool Airbag { get; set; }

        public int SalidaId { get; set; }
    }
}
