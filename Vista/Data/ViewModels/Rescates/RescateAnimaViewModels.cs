using System.ComponentModel.DataAnnotations;
using Vista.Data.Enums;

namespace Vista.Data.ViewModels.Rescates
{
    public class RescateAnimaViewModels : RescateViewModels
    {
        public TipoRescateAnimal TipoRescateAnimal { get; set; }

        
    }
}
