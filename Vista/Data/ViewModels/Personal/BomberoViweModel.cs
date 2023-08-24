using System.ComponentModel.DataAnnotations;
using Vista.Data.Enums;

namespace Vista.Data.ViewModels.Personal
{
    public class BomberoViweModel
    {
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaAceptacion { get; set; }
        [Required, StringLength(255)]
        public string Nombre { get; set; }
        [Required, StringLength(255)]
        public string Apellido { get; set; }
        public string NombreYApellido
        {
            get { return Nombre + "," + Apellido; }
        }
        public EstadoBombero Estado { get; set; }
        public int NumeroLegajo { get; set; }
        public EscalafonJerarquico Grado { get; set; }
        public TipoDotaciones Dotacion { get; set; }
        [Required, StringLength(255)]
        public string Brigada { get; set; }
        public bool Chofer { get; set; }
        public DateTime? VencimientoRegistro { get; set; }
        public TipoSexo Sexo { get; set; }
        [Required, StringLength(255)]
        public string Direccion { get; set; }
        [Required, StringLength(255)]
        public string LugarNacimiento { get; set; }
        [Required, StringLength(255)]
        public string Documento { get; set; }
        [Required, StringLength(255)]
        public TipoGrupoSanguineo GrupoSanguineo { get; set; }
        [Required, StringLength(255)]
        public string Observaciones { get; set; }
        [Required, StringLength(255)]
        public string Profesion { get; set; }
        [Required, StringLength(255)]
        public string NivelEstudios { get; set; }
        [Required, StringLength(255)]
        public string NumeroIoma { get; set; }
        [Required, StringLength(255)]
        public string? Resolucion1 { get; set; }
        [Required, StringLength(255)]
        public string? Resolucion2 { get; set; }
        [Required, StringLength(255)]
        public string? Resolucion3 { get; set; }
        [Required, StringLength(255)]
        public string? Resolucion4 { get; set; }
        [Required, StringLength(255)]
        public string? Resolucion5 { get; set; }
        [Required, StringLength(255)]
        public string? Resolucion6 { get; set; }
        //Contacto-------------------------------
        [Required, StringLength(255)]
        public string? TelefonoCel { get; set; }
        [Required, StringLength(255)]
        public string? TelefonoLaboral { get; set; }
        [Required, StringLength(255)]
        public string? TelefonoFijo { get; set; }
        [Required, StringLength(255)]
        public string? Email { get; set; }
        //Imagen-------------------------------
        public string Base64 { get; set; }
        [Required, StringLength(255)]
        public string TipoImagen { get; set; }
        [Required, StringLength(255)]
        public string NombreImagen { get; set; }
        //Brigada-------------------------------
        public string NombreBrigada { get; set; }

        public bool Selected { get; set; }
    }
}
