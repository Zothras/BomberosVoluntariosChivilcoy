using System.ComponentModel.DataAnnotations;
using Vista.Data.Enums;

namespace Vista.Data.ViewModels.FactorClimatico
{
    public class FactorClimaticoViewModels : SalidasViewModels
    {
        public TipoFactoresClimaticos Tipo { get; set; }

        //Daños superficie evacuada
        public TipoEvacuacion Evacuacion { get; set; }
        public TipoSuperficie Superficie { get; set; }
        public int Cantidad { get; set; }
    }
}
