using System.ComponentModel.DataAnnotations;
using Vista.Data.Enums;

namespace Vista.Data.ViewModels.Incendios
{
    public class IncendioViewModels : SalidasViewModels
    {
        public TipoIncendio Tipo { get; set; }
        [Required, StringLength(255)]
        public bool DeteccionAutomaticaId { get; set; }
        public bool Extintor { get; set; }
        public bool Hidrante { get; set; }
        
        [StringLength(255)]
        public string? OtroLugarDeSiniestroEmbarcacion { get; set; }
        public TipoEvacuacion TipoEvacuacion { get; set; }
        public TipoSuperficie TipoSuperficieAfectada { get; set; }
        [Required, StringLength(255)]
        public string DetalleSuperficieAfectadaIncendio { get; set; }
        public TipoCausaIncendio SuperficieAfectadaCausa { get; set; }
        public TipoIncendioAbertura TipoAbertura { get; set; }
        [Required, StringLength(255)]
        public string OtraAbertura { get; set; }
        public TipoIncendioTecho TipoTecho { get; set; }
        [Required, StringLength(255)]
        public string OtroTecho { get; set; }
        [Required, StringLength(255)]
        public string OtroLugar { get; set; }
        [StringLength(255)]
        public string? NombreEstablecimiento { get; set; }
        public int? CantidadPisos { get; set; }
        public int? PisoAfectado { get; set; }
        public int? CantidadAmbientes { get; set; }
    }
}

