using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;
using Vista.Data.Enums;

namespace Vista.Data.ViewModels.MaterialesPeligrosos
{
    public class MaterialPeligrosoViewModels : SalidasViewModels
    {
        public TipoMaterialPeligroso Tipo { get; set; }
        [Required, StringLength(255)]
        public string Sustancias { get; set; }
        public int Kmssalida { get; set; }  
        public int Kilometraje { get; set; }
        //Acciones sobre los materiales
        public bool Controlada { get; set; }
        public bool Venteo { get; set; }
        public bool DilucionDeVapores { get; set; }
        public bool Neutralizacion { get; set; }
        public bool Trasvase { get; set; }
        public bool OtraAccionesMateriales { get; set; }
        [Required, StringLength(255)]
        public string DetallesAccionesMateriales { get; set; }

        //Acciones sobre las personas
        public TipoEvacuacion Evacuacion { get; set; }
        public bool Descontaminacion { get; set; }
        public bool Confinamiento { get; set; }
        public bool SinAccion { get; set; }
        public bool OtraAccionesPersonas { get; set; }
        [Required, StringLength(255)]
        public string DetallesAccionesPersonas { get; set; }

        //Superficie Aferctada
        public TipoSuperficie TipoSuperficie { get; set; }
        [Required, StringLength(255)]
        public string DetalleSuperficieAfectada { get; set; }

        //Situación
        public TipoSituacionExplosion TipoSituacion { get; set; }
    }
}
