using Vista.Data.Enums;
using Vista.Data.ViewModels.Incendios;

namespace Vista.Data.Models.Salidas.Planillas
{
    public class IncendioEmbarcacionViewModels : IncendioViewModels
    {
        public TipoLugarSiniestroEmbarcacion TipoLugar { get; set; }
    }
}