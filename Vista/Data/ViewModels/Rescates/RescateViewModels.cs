using System.ComponentModel.DataAnnotations;

namespace Vista.Data.ViewModels.Rescates
{
    public class RescateViewModels: SalidasViewModels
    {
        //Localización, Datos del solicitante, personas damnificadas y datos del seguro
        [Required, StringLength(255)]
        public string Otro { get; set; }
    }
}
