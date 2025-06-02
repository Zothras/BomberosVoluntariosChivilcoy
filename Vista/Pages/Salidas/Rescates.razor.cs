using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Text.Json;
using Vista.Data.Models.Personas.Personal;
using Vista.Data.Models.Salidas.Planillas;
using Vista.Data.ViewModels.Rescates;
using Vista.Services;
using AntDesign;
using Vista.Data.Models.Vehiculos.Flota;
using DocumentFormat.OpenXml.Office2010.Drawing;
using System.Threading.Tasks;

namespace Vista.Pages.Salidas
{
    public partial class Rescates
    {
        /// <summary>
        /// ViewModel para la carga de Rescates de Personas.
        /// </summary>
        private RescatePersonaViewModels PersonaViewModel = new();

        /// <summary>
        /// Lista con todos los Bomberos del sistema.
        /// </summary>
        private List<Bombero> BomberosTodos = new();

        /// <summary>
        /// Lista con todos los Moviles del sistema.
        /// </summary>
        private List<Movil> MovilesTodos = new();


        /// <summary>
        /// Numero de Salida del Año en Seleccionado.
        /// </summary>
        [Parameter]
        public int? NumeroSalida { get; set; } = 0;
        /// <summary>
        /// Año de Salida
        /// </summary>
        [Parameter]
        public int? AnioSalida { get; set; } = 0;
        /// <summary>
        /// Tipo de Rescate
        /// </summary>

        [Parameter]
        public int TipoRescate { get; set; }


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
                    await message.WarningAsync("Numero parte ya existente.");
                    return;
                }

                RescatePersona Rescates = new()
                {
                    NumeroParte = PersonaViewModel.NumeroParte,
                    AnioNumeroParte = PersonaViewModel.AnioNumeroParte,
                    HoraSalida = PersonaViewModel.HoraSalida,
                    HoraLlegada = PersonaViewModel.HoraLLegada,
                    Descripcion = PersonaViewModel.Descripcion,
                    Direccion = PersonaViewModel.CalleORuta,
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
                    LugarRescatePersona = PersonaViewModel.TipoRescatePersona,

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
                    await message.ErrorAsync(e.InnerException.Message, 5);
                else
                    await message.ErrorAsync(e.Message, 5);
            }
        }

        //Inicio
        protected override void OnInitialized()
        {
            Init();
        }

        private async Task Init()
        {
            PersonaViewModel = new();

            if (NumeroSalida.HasValue && NumeroSalida > 0)
            {
                PersonaViewModel.NumeroParte = NumeroSalida.Value;
            }

            if (AnioSalida.HasValue && AnioSalida > 0)
            {
                PersonaViewModel.AnioNumeroParte = AnioSalida.Value;
            }

            BomberosTodos = await BomberoService.ObtenerTodosLosBomberosAsync();

            MovilesTodos = await VehiculoService.ObtenerTodosLosMoviles();
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
