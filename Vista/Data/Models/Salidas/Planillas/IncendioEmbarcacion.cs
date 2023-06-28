using Vista.Data.Enums;

namespace Vista.Data.Models.Salidas.Planillas
{
    public class IncendioEmbarcacion : Incendio
    {
        public TipoLugarSiniestroEmbarcacion TipoLugar { get; set; }
    }
}
