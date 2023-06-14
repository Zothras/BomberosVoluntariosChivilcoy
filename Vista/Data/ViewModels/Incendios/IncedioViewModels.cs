using System.ComponentModel.DataAnnotations;
using Vista.Data.Enums;

namespace Vista.Data.ViewModels.Incendios
{
    public class IncedioViewModels : SalidasViewModels
    {
        public TipoIncendio Tipo { get; set; }
        [Required, StringLength(255)]
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraSalida { get; set; }
        public DateTime HoraLlegada { get; set; }
        public int KmSalida { get; set; }
        public int KmLLegada { get; set; }
        public int NumeroParte { get; set; }
        [Required, StringLength(255)]
        public string CalleORuta { get; set; }
        [Required, StringLength(255)]
        public string NumeroOKilometro { get; set; }
        [StringLength(255)]
        public string? EntreCalles { get; set; }
        [StringLength(255)]
        public string? PisoNumero { get; set; }
        [StringLength(255)]
        public string? Depto { get; set; }
        public TipoZona TipoZona { get; set; }
        [Required, StringLength(255)]
        public string NombreSolicitante { get; set; }
        [Required, StringLength(255)]
        public string ApellidoSolicitante { get; set; }
        [Required, StringLength(255)]
        public string DniSolicitante { get; set; }
        [Required, StringLength(255)]
        public string TelefonoSolicitante { get; set; }
        [StringLength(255)]
        public string? Receptor { get; set; }
        public bool DeteccionAutomaticaId { get; set; }
        public bool? Extintor { get; set; }
        public bool? Hidrante { get; set; }
        public TipoLugarSiniestroEmbarcacion TipoLugarSiniestroEmbarcacion { get; set; }
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

