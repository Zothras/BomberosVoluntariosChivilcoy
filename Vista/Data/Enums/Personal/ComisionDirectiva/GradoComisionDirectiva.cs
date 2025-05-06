using System.ComponentModel.DataAnnotations;

namespace Vista.Data.Enums.Personal.ComisionDirectiva
{
    public enum GradoComisionDirectiva
    {
        /// <summary>
        /// Presidente de la Comisión Directiva.
        /// </summary>
        [Display(Name = "Presidente")]
        Presidente,

        /// <summary>
        /// Vicepresidente de la Comisión Directiva.
        /// </summary>
        [Display(Name = "Vice-Presidente")]
        VicePresidente,

        /// <summary>
        /// Secretario de la Comisión Directiva.
        /// </summary>
        [Display(Name = "Secretario")]
        Secretario,

        /// <summary>
        /// Pro-Secretario de la Comisión Directiva.
        /// </summary>
        [Display(Name = "Pro-Secretario")]
        ProSecretario,

        /// <summary>
        /// Tesorero de la Comisión Directiva.
        /// </summary>
        [Display(Name = "Tesorero")]
        Tesorero,

        /// <summary>
        /// Pro-Tesorero de la Comisión Directiva.
        /// </summary>
        [Display(Name = "Pro-Tesorero")]
        ProTesorero,

        /// <summary>
        /// Secretario de Actas de la Comisión Directiva.
        /// </summary>
        [Display(Name = "Secretario de Actas")]
        SecretarioDeActas,

        /// <summary>
        /// Secretario de Prensa de la Comisión Directiva.
        /// </summary>
        [Display(Name = "Intendente de Sede")]
        IntendenteDeSede,

        /// <summary>
        /// Vocal Titular de la Comisión Directiva.
        /// </summary>
        [Display(Name = "Vocal Titular")]
        VocalTitular,

        /// <summary>
        /// Vocal Suplente de la Comisión Directiva.
        /// </summary>
        [Display(Name = "Vocal Suplente")]
        VocalSuplente,

        /// <summary>
        /// Revisor de Cuentas Titular de la Comisión Directiva.
        /// </summary>
        [Display(Name = "Revisor de Cuentas Titular")]
        RevisorCuentasTitular,

        /// <summary>
        /// Revisor de Cuentas Suplente de la Comisión Directiva.
        /// </summary>
        [Display(Name = "Revisor de Cuentas Suplente")]
        RevisorCuentasSuplente
    }
}
