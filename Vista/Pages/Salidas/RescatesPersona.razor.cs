using Microsoft.AspNetCore.Components.Forms;
using System.Text.Json;
using Vista.Data.Models.Personales;
using Vista.Data.Models.Salidas.Planillas;
using Vista.Data.ViewModels.Rescates;

namespace Vista.Pages.Salidas
{
    public partial class RescatesPersona
    {
        private RescatePersonaViewModels PersonaViewModel = new();

        //Steps

        public int current { get; set; } = 0;//Ubicacion del Step
        private string animationClass = "";

        public class StepItem
        {
            public string? Title { get; set; }
            public string? Content { get; set; }
        }

        public StepItem[] steps =
        {
        new StepItem {Title = " ", Content = ""}, /* Datos generales */
        new StepItem {Title = " ", Content = ""}, /* Solicitante / Receptor / Damnificado */
        new StepItem {Title = " ", Content = ""}, /* Vehiculos */
        new StepItem {Title = " ", Content = ""}, /* Personal */
        new StepItem {Title = " ", Content = ""}  /* Salida */
        };

        private void ToggleAnimationD()
        {
            animationClass = "slick-contenedor-D";
        }

        private void ToggleAnimationI()
        {
            animationClass = "slick-contenedor-I";
        }

        void OnPreClick()
        {
            current--;
            ToggleAnimationI();
        }

        void OnNextClick()
        {
            current++;
            ToggleAnimationD();
        }

        //Carga de Salida

        private async void OnFinish(EditContext editContext)
        {

            try
            {
                Bombero? bomberoEncargado = await BomberoService.ObtenerBomberoObjetoPorLegajoAsync(PersonaViewModel.LegajoEncargado);
                Bombero? BomberoLlenoPlanilla = await BomberoService.ObtenerBomberoObjetoPorLegajoAsync(PersonaViewModel.LegajoLLenoPlanilla);

                var numeroParteRescate = await SalidaService.ObtenerSalidaPorNumeroParteAsync<RescatePersona>(
                    PersonaViewModel.NumeroParte,
                    m => m.NumeroParte == PersonaViewModel.NumeroParte
                );

                if (numeroParteRescate != null)
                {
                    await message.Warning("Numero parte ya existente.");
                    return;
                }

                RescatePersona Rescates = new()
                {
                    NumeroParte = PersonaViewModel.NumeroParte,
                    AnioNumeroParte = PersonaViewModel.AnioNumeroParte,
                    HoraSalida = PersonaViewModel.HoraSalida,
                    HoraLlegada = PersonaViewModel.HoraLLegada,
                    Descripcion = PersonaViewModel.Descripcion,
                    CalleORuta = PersonaViewModel.CalleORuta,
                    NumeroOKilometro = PersonaViewModel.NumeroOKilometro,
                    EntreCalles = PersonaViewModel.EntreCalles,
                    PisoNumero = PersonaViewModel.PisoNumero,
                    Depto = PersonaViewModel.Depto,
                    NombreYApellidoReceptor = PersonaViewModel.NombreYApellidoReceptor,
                    TipoZona = PersonaViewModel.TipoZona,
                    NombreSolicitante = PersonaViewModel.NombreSolicitante,
                    ApellidoSolicitante = PersonaViewModel.ApellidoSolicitante,
                    DniSolicitante = PersonaViewModel.DniSolicitante,
                    TelefonoSolicitante = PersonaViewModel.TelefonoSolicitante,
                    TipoServicio = PersonaViewModel.TipoServicio,
                    QuienLleno = BomberoLlenoPlanilla,
                    Encargado = bomberoEncargado,
                    //Carga propio de rescates
                    TipoRescatePersona = PersonaViewModel.TipoRescatePersona,

                    //Seguro = new() <-- Consultar si es requerido
                    //{
                    //    CompañiaAseguradora = PersonaViewModel.CompaniaAseguradora,
                    //    NumeroDePoliza = PersonaViewModel.NumeroPoliza,
                    //    FechaDeVencimineto = PersonaViewModel.FechaVencimineto,
                    //},

                    //Iniciación de Listas
                    Damnificados = new(),
                    Moviles = new(),
                    CuerpoParticipante = new()

                };

                //Verifica si hay Bomberos en la Salida y los carga a el modelo de la salida.
                if (PersonaViewModel.CuerpoParticipante != null && PersonaViewModel.CuerpoParticipante.Any())
                {
                    Rescates.CuerpoParticipante = PersonaViewModel.CuerpoParticipante.ToList();
                }

                //Verifica si hay Moviles en la Salida y los carga a el modelo de la salida.
                if (PersonaViewModel.Moviles != null && PersonaViewModel.Moviles.Any())
                {
                    Rescates.Moviles = PersonaViewModel.Moviles.ToList();
                }

                //Verifica si hay Damnificados en la Salida y los carga a el modelo de la salida.
                if (PersonaViewModel.Damnificados != null && PersonaViewModel.Damnificados.Any())
                {
                    Rescates.Damnificados = PersonaViewModel.Damnificados.ToList();
                }

                await SalidaService.GuardarSalida(Rescates);
                HandleOk1(Rescates.AnioNumeroParte, Rescates.NumeroParte);
                Init();
                StateHasChanged();
            }
            catch (Exception e)
            {
                // Notificar al usuario
                if (e.InnerException != null)
                    await message.Error(e.InnerException.Message, 5);
                else
                    await message.Error(e.Message, 5);
            }
        }

        //Inicio
        protected override void OnInitialized()
        {
            Init();
        }

        private void Init()
        {
            PersonaViewModel = new();
        }

        //Finish Failed
        private void OnFinishFailed(EditContext editContext)
        {
            message.Error("Error al cargar, posible información ausente");
            Console.WriteLine($"Failed:{JsonSerializer.Serialize(PersonaViewModel)}");
        }

        //Impresión
        bool _visible1;

        public int ImprimirAnio;
        public int ImprimirNumeroParte;
        void HandleOk1(int _anio, int _numeroParte)
        {
            ImprimirAnio = _anio;
            ImprimirNumeroParte = _numeroParte;
            _visible1 = true;
        }
    }
}
