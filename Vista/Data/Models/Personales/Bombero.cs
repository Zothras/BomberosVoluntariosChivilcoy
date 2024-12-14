using Vista.Data.Enums;
using Vista.Data.Models.Salidas.Componentes;
using Vista.Data.Models.Salidas.Planillas;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Models.Grupos.Dependencias;
using Vista.Data.Models.Grupos.Brigadas;
using Vista.Data.Models.Imagenes;
using Vista.Data.Models.Grupos.Dependencias.Comunicaciones;

namespace Vista.Data.Models.Personales
{
    [Index(nameof(NumeroLegajo))]
    [Index(nameof(EquipoId), IsUnique = true)]
    public class Bombero : Persona
    {
        [Required]
        public int NumeroLegajo { get; set; }
        public EstadoBombero Estado { get; set; }
        public TipoDotaciones Dotacion { get; set; }
        public DateTime? FechaAceptacion { get; set; }
        public EscalafonJerarquico Grado { get; set; }
        public bool Chofer { get; set; }
        public DateTime? VencimientoRegistro { get; set; }

        public List<Firma>? Firmas { get; set; }

        public ICollection<Bombero_Brigada> BomberoBrigadas { get; set; } = new List<Bombero_Brigada>();

        public int? BrigadaId { get; set; }
        public Brigada? Brigada { get; set; }
        public int? ImagenId { get; set; }
        [ForeignKey("ImagenId")]
        public ImagenBombero? Imagen { get; set; }

        public List<VehiculoPersonal> Vehiculos { get; set; } = new();

        public List<VehiculoSalida>? VehiculosEncargado { get; set; }

        public List<Bombero_Dependencia> Dependencias { get; set; } = new();

        public List<Incidente> Incidentes { get; set; } = new();

        public List<BomberoSalida> Salidas { get; set; } = new();

        public int? EquipoId { get; set; }
        public Comunicacion? Handie { get; set; }

        public List<AscensoBombero> Ascensos { get; set; } = new();
        public List<Licencia> Licencias { get; set; } = new();

        public List<MovimientoMaterial> DestinoMaterial { get; set; } = new();

        [InverseProperty("PersonalSancionado")]
        public List<Sancion> SancionesRecibidas { get; set; } = new();
        [InverseProperty("EncargadoArea")]
        public List<Sancion> SancionesAplicadas { get; set; } = new();

        public List<HorarioBombero> Horarios { get; set; } = new();
        public List<Limpieza> Limpieza { get; set; } = new();
        public List<NovedadBase>? Novedades { get; set; } = new();

    }
}
