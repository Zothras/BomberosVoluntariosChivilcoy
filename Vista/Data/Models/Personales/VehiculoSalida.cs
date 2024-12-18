using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Vista.Data.Models.Salidas.Componentes;
using Vista.Data.Enums;
using Vista.Data.Models.Imagenes;
using Vista.Data.Models.Vehiculos;

namespace Vista.Data.Models.Personales
{
    public abstract class VehiculoSalida:Vehiculo
    {
        [StringLength(255)]
        public string? NumeroMovil { get; set; }
        public int? EncargadoId { get; set; }
        [ForeignKey("EncargadoId")]
        public Bombero? Encargado { get; set; }
        public TipoEstadoMovil Estado { get; set; }
        public List<Firma> Firmas { get; set; } = new();
        public List<Incidente> Incidentes { get; set; } = new();
        public int? ImagenId { get; set; }
        public Imagen_VehiculoSalida? Imagen { get; set; }
        public List<NovedadVehiculo>? Novedades { get; set; }
    }
}
