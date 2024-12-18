using Vista.Data.Enums;
using System.ComponentModel.DataAnnotations;
using Vista.Data.Enums.Discriminadores;

namespace Vista.Data.Models.Personales
{
    public abstract class Persona
    {
        /// <summary>
        /// Identificador único de la persona.
        /// </summary>
        public int PersonaId { get; set; }

        /// <summary>
        /// Tipo de persona, que puede ser Bombero, Comisión Directiva o Damnificado.
        /// </summary>
        public TipoPersona Tipo { get; set; }

        /// <summary>
        /// Sexo de la persona.
        /// </summary>
        public TipoSexo Sexo { get; set; }

        /// <summary>
        /// Nombre de la persona. Campo obligatorio con una longitud máxima de 255 caracteres.
        /// </summary>
        [Required, StringLength(255)]
        public string Nombre { get; set; } = null!;

        /// <summary>
        /// Apellido de la persona. Campo obligatorio con una longitud máxima de 255 caracteres.
        /// </summary>
        [Required, StringLength(255)]
        public string Apellido { get; set; } = null!;

        /// <summary>
        /// Número de documento de identidad de la persona. Campo obligatorio.
        /// </summary>
        [Required]
        public int Documento { get; set; }


        /// <summary>
        /// Residencia habitual de la persona. Longitud máxima de 255 caracteres.
        /// </summary>
        [StringLength(255)]
        public string? Residencia { get; set; }

        /// <summary>
        /// Dirección donde reside la persona. Longitud máxima de 255 caracteres.
        /// </summary>
        [StringLength(255)]
        public string? Direccion { get; set; }

        /// <summary>
        /// Edad de la persona. Calculada o asignada manualmente.
        /// </summary>
        public virtual int Edad { get; set; }
    }
}
