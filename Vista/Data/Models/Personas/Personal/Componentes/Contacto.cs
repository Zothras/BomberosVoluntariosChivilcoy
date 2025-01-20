using System.ComponentModel.DataAnnotations;
using Vista.Data.Models.Personas.Personal;

namespace Vista.Data.Models.Personas.Personal.Componentes
{
    /// <summary>
    /// Representa los datos de contacto de una persona.
    /// </summary>
    public class Contacto
    {
        /// <summary>
        /// Identificador único del contacto.
        /// </summary>
        public int ContactoId { get; set; }

        /// <summary>
        /// Número de teléfono celular del contacto. Longitud máxima de 255 caracteres.
        /// </summary>
        [StringLength(255)]
        public string? TelefonoCel { get; set; }

        /// <summary>
        /// Número de teléfono laboral del contacto. Longitud máxima de 255 caracteres.
        /// </summary>
        [StringLength(255)]
        public string? TelefonoLaboral { get; set; }

        /// <summary>
        /// Número de teléfono fijo del contacto. Longitud máxima de 255 caracteres.
        /// </summary>
        [StringLength(255)]
        public string? TelefonoFijo { get; set; }

        /// <summary>
        /// Dirección de correo electrónico del contacto. Longitud máxima de 255 caracteres.
        /// </summary>
        [StringLength(255)]
        public string? Email { get; set; }

        /// <summary>
        /// Identificador de la persona asociada a este contacto.
        /// </summary>
        public int PersonalId { get; set; }

        /// <summary>
        /// Relación con la entidad `Personal`, que representa a la persona asociada a este contacto.
        /// </summary>
        public Personal Persona { get; set; } = null!;
    }
}
