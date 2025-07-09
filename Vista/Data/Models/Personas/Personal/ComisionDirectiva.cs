using Vista.Data.Enums.Personal.ComisionDirectiva;

namespace Vista.Data.Models.Personas.Personal
{
    /// <summary>
    /// Representa a un miembro de la Comisión Directiva de la Asociación de Bomberos Voluntarios.
    /// </summary>
    public class ComisionDirectiva : Personal
    {
        /// <summary>
        /// Rango Jerárquico del miembro de la Comisión Directiva.
        /// </summary>
        public GradoComisionDirectiva Grado { get; set; }
    }
}
