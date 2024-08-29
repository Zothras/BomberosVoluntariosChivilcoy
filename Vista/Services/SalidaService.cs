using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Presentation;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using Vista.Data;
using Vista.Data.Enums;
using Vista.Data.Models.Personales;
using Vista.Data.Models.Salidas.Componentes;
using Vista.Data.Models.Salidas.Planillas;
using Vista.Data.ViewModels.Personal;

namespace Vista.Services
{
    public interface ISalidaService
    {
        Task<Salida> CargarSalida<T>(T entidad) where T : Salida;

    }

    public class SalidaService : ISalidaService
    {
        private readonly BomberosDbContext _context;

        public SalidaService(BomberosDbContext context)
        {
            _context = context;
        }

        public async Task<Salida> CargarSalida<T>(T salida) where T : Salida
        {
            try
            {
                // Cargar datos de los bomberos
                var bomberoEncargado = await _context.Bomberos
                    .SingleOrDefaultAsync(b => b.NumeroLegajo == salida.Encargado.NumeroLegajo);
                var bomberoLlenoPlanilla = await _context.Bomberos
                    .SingleOrDefaultAsync(b => b.NumeroLegajo == salida.QuienLleno.NumeroLegajo);
                var bomberoReceptor = salida.ReceptorBombero != null
                    ? await _context.Bomberos
                        .SingleOrDefaultAsync(b => b.NumeroLegajo == salida.ReceptorBombero.NumeroLegajo)
                    : null;

                salida.ReceptorBombero = bomberoReceptor;
                salida.Encargado = bomberoEncargado;
                salida.QuienLleno = bomberoLlenoPlanilla;

                // Procesar cuerpo participante
                var bomberossalida = new List<BomberoSalida>();
                foreach (var bom in salida.CuerpoParticipante)
                {
                    var bomberoSalida = await _context.BomberosSalida
                        .SingleOrDefaultAsync(b => b.BomberoSalidaId == bom.BomberoSalidaId);
                    if (bomberoSalida == null) continue;

                    var bomSalida = new BomberoSalida
                    {
                        MovilAsignado = bom.MovilAsignado,
                        Bombero = bomberoSalida.Bombero
                    };
                    bomberossalida.Add(bomSalida);
                }
                salida.CuerpoParticipante = bomberossalida;

                // Procesar móviles
                var movilessalida = new List<MovilSalida>();
                if (salida.Moviles != null && salida.Moviles.Any())
                {
                    foreach (var m in salida.Moviles)
                    {
                        var bomberoChofer = await _context.Bomberos
                            .SingleOrDefaultAsync(b => b.NumeroLegajo == m.Chofer.NumeroLegajo);
                        var movilsalida = await _context.Moviles
                            .SingleOrDefaultAsync(mob => mob.NumeroMovil == m.Movil.NumeroMovil);

                        if (bomberoChofer == null || movilsalida == null) continue;

                        movilsalida.Kilometraje += m.KmLlegada; // Actualizar el kilometraje

                        var movilS = new MovilSalida
                        {
                            CargoCombustible = m.CargoCombustible,
                            NumeroFactura = m.NumeroFactura,
                            FechaFactura = m.FechaFactura,
                            TipoConbustible = m.TipoConbustible,
                            CantidadLitros = m.CantidadLitros,
                            QuienLleno = m.QuienLleno,
                            TelefonoQuienLleno = m.TelefonoQuienLleno,
                            KmLlegada = m.KmLlegada,
                            Chofer = bomberoChofer,
                            Movil = movilsalida,
                            SalidaId = salida.SalidaId // Asignar el ID de la salida
                        };
                        _context.MovilesSalida.Add(movilS); // Agregar al contexto
                    }
                }
                else
                {
                    Console.WriteLine($"ERROR: Error al cargar los moviles de salida. (¿Son Nulos?)");
                }
                salida.Moviles = movilessalida;


                // Procesar damnificados
                var damnificadossalida = new List<Damnificado>();
                foreach (var d in salida.Damnificados)
                {
                    var damn = new Damnificado
                    {
                        Nombre = d.Nombre,
                        Apellido = d.Apellido,
                        Dni = d.Dni,
                        Sexo = d.Sexo,
                        LugarDeNacimiento = d.LugarDeNacimiento,
                        Edad = d.Edad,
                        Estado = d.Estado
                    };
                    damnificadossalida.Add(damn);
                }
                salida.Damnificados = damnificadossalida;

                // Agregar la salida al contexto y guardar cambios
                _context.Set<T>().Add(salida);
                await _context.SaveChangesAsync();
                return salida;
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"ERROR: Error al cargar la salida. {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: Ocurrió un error inesperado. {ex.Message}");
                throw;
            }
        }
    }
}
