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
                Bombero? bomberoEncargado = await _context.Bomberos.Where(b => b.NumeroLegajo == salida.Encargado.NumeroLegajo).SingleOrDefaultAsync();
                Bombero? BomberoLlenoPlanilla = await _context.Bomberos.Where(b => b.NumeroLegajo == salida.QuienLleno.NumeroLegajo).SingleOrDefaultAsync();
                Bombero? bomberoReceptor = salida.ReceptorBombero != null ? await _context.Bomberos.Where(b => b.NumeroLegajo == salida.ReceptorBombero.NumeroLegajo).SingleOrDefaultAsync() : null;
                salida.ReceptorBombero = bomberoReceptor;
                salida.Encargado = bomberoEncargado;
                salida.QuienLleno = BomberoLlenoPlanilla;

                //Cuerpo participante
                List<BomberoSalida> bomberossalida = new List<BomberoSalida>();
                foreach (BomberoSalida bom in salida.CuerpoParticipante)
                {
                    BomberoSalida? bomberoSalida = await _context.BomberosSalida.Where(b => b.BomberoSalidaId == bom.BomberoSalidaId).SingleOrDefaultAsync();
                    if (bomberoSalida == null) break;
                    BomberoSalida BomSalida = new()
                    {
                        MovilAsignado = bom.MovilAsignado,
                        Bombero = bomberoSalida.Bombero,
                    };
                    bomberossalida.Add(BomSalida);
                }
                salida.CuerpoParticipante = bomberossalida;

                //Moviles
                List<MovilSalida> movilessalida = new List<MovilSalida>();
                foreach (MovilSalida m in salida.Moviles)
                {
                    Bombero? bomberoChofer = await _context.Bomberos.SingleOrDefaultAsync(b => b.NumeroLegajo == m.Chofer.NumeroLegajo);
                    Movil? Movilsalida = await _context.Moviles.SingleOrDefaultAsync(mob => mob.NumeroMovil == m.Movil.NumeroMovil);

                    if (bomberoChofer == null || Movilsalida == null) break;
                    Movilsalida.Kilometraje = m.KmLlegada;
                    MovilSalida movilS = new()
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
                        Movil = Movilsalida
                    };
                    movilessalida.Add(movilS);
                }
                salida.Moviles = movilessalida;

                //Damnificados
                List<Damnificado> damnificadossalida = new List<Damnificado>();
                foreach (Damnificado d in salida.Damnificados)
                {

                    Damnificado damn = new()
                    {
                        Nombre = d.Nombre,
                        Apellido = d.Apellido,
                        Dni = d.Dni,
                        Sexo = d.Sexo,
                        LugarDeNacimiento = d.LugarDeNacimiento,
                        Edad = d.Edad,
                        Estado = d.Estado,
                    };
                    damnificadossalida.Add(damn);
                }
                salida.Damnificados = damnificadossalida;

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
