using System.ComponentModel.DataAnnotations;
using Vista.Data.Enums;

namespace Vista.Data.ViewModels.Rescates
{
    public class RescateAnimaViewModels : RescateViewModels
    {
        public TipoLugarRescateAnimal TipoRescateAnimal { get; set; }

        
    }
}
