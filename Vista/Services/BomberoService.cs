using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using Vista.Data;
using Vista.Data.Enums;
using Vista.Data.Models.Personales;
using Vista.Data.Models.Salidas.Componentes;
using Vista.Data.ViewModels.Personal;

namespace Vista.Services
{
    public interface IBomberoService
    {
        Task<Bombero> CrearBombero(Bombero bombero);
        Task<bool> BorrarBombero(Bombero bombero);
        Task<Bombero> EditarBombero(Bombero bombero);
        Task<Sancion> SancionarBombero(Sancion sancion);
        Task<Bombero> CambiarEstado(Bombero bombero);
        Task<AscensoBombero> AscenderBombero(AscensoBombero ascenso);
        Task<List<BomberoViweModel>> GetAllBomberosAsync();
        Task<BomberoViweModel> ObtenerBomberoPorLegajoAsync(int numeroLegajo);
        Task<List<BomberoViweModel>> ObtenerBomberosChoferes();
    }

    public class BomberoService : IBomberoService
    {
        private readonly BomberosDbContext _context;

        public BomberoService(BomberosDbContext context)
        {
            _context = context;
        }

        public async Task<Bombero> CrearBombero(Bombero bombero)
        {
            // Asumiendo que Id es la clave primaria
            if (await _context.Bomberos.AnyAsync(b => b.PersonaId == bombero.PersonaId))
            {
                throw new InvalidOperationException("Ya existe un bombero con este ID.");
            }

            _context.Bomberos.Add(bombero);
            await _context.SaveChangesAsync();
            return bombero;
        }

        public async Task<Bombero> EditarBombero(Bombero bombero)
        {
            try
            {
                Bombero Editar = await _context.Bomberos.SingleOrDefaultAsync(e => e.PersonaId == bombero.PersonaId);
                foreach (var i in bombero.GetType().GetProperties())
                {
                    var propNombre = i.Name;
                    var propValor = i.GetValue(bombero);
                    var editarProp = Editar.GetType().GetProperty(propNombre);
                    if (editarProp != null && editarProp.CanWrite && propValor != null && propNombre != "Brigada" && propNombre != "BrigadaId")
                    {
                        editarProp.SetValue(Editar, propValor);
                    }
                }
                if (bombero.Brigada != null)
                {
                    Brigada? Brigada = await _context.Brigadas.SingleOrDefaultAsync(b => b.BrigadaId == bombero.Brigada.BrigadaId);
                    Editar.Brigada = Brigada;
                    Editar.BrigadaId = Brigada.BrigadaId;
                }
                await _context.SaveChangesAsync();
                return bombero;
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"Error al editar el bombero {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado {ex.Message}");
                return null;
            }
        }

        public async Task<Bombero> CambiarEstado(Bombero bombero)
        {
            Bombero BomberoBaja = await _context.Bomberos.SingleOrDefaultAsync(b => b.PersonaId == bombero.PersonaId);
            BomberoBaja.Estado = bombero.Estado;
            await _context.SaveChangesAsync();
            return bombero;
        }

        public async Task<bool> BorrarBombero(Bombero bombero)
        {
            if (bombero == null)
            {
                Console.WriteLine("ERROR: Bombero no puede ser nulo.");
                return false;
            }

            try
            {
                _context.Bomberos.Remove(bombero);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException ex)
            {
                // Manejo de excepción específico para errores de la base de datos
                Console.WriteLine($"ERROR: Error al eliminar el bombero. {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                // Manejo de excepción genérico
                Console.WriteLine($"ERROR: Ocurrió un error inesperado. {ex.Message}");
                return false;
            }
        }
        public async Task<Sancion> SancionarBombero(Sancion sancion)
        {
            Bombero? BomberoSancionado = await _context.Bomberos.Where(b => b.NumeroLegajo == sancion.PersonalSancionado.NumeroLegajo).SingleOrDefaultAsync();
            Bombero? BomberoEncargado = await _context.Bomberos.Where(b => b.NumeroLegajo == sancion.EncargadoArea.NumeroLegajo).SingleOrDefaultAsync();

            if (BomberoSancionado == null || BomberoEncargado == null)
            {
                throw new InvalidOperationException("No se pudieron encontrar los bomberos.");
            }

            sancion.PersonalSancionado = BomberoSancionado;
            sancion.EncargadoArea = BomberoEncargado;

            _context.Sanciones.Add(sancion);
            await _context.SaveChangesAsync();
            return sancion;
        }
        public async Task<AscensoBombero> AscenderBombero(AscensoBombero ascenso)
        {
            Bombero? BomberoAfectado = await _context.Bomberos.Where(b => b.NumeroLegajo == ascenso.PersonalAfectado.NumeroLegajo).SingleOrDefaultAsync();

            if (BomberoAfectado == null)
            {
                throw new InvalidOperationException("No se pudo encontrar el BomberoAfectado.");
            }

            ascenso.PersonalAfectado = BomberoAfectado;

            _context.AscensoBomberos.Add(ascenso);
            await _context.SaveChangesAsync();
            return ascenso;
        }

        public async Task<List<BomberoViweModel>> GetAllBomberosAsync()
        {
            return await _context.Bomberos
                .Select(b => new BomberoViweModel
                {
                    Nombre = b.Nombre,
                    Apellido = b.Apellido,
                    NumeroLegajo = b.NumeroLegajo
                })
                .ToListAsync();
        }

        public async Task<BomberoViweModel> ObtenerBomberoPorLegajoAsync(int numeroLegajo)
        {
            // Consulta el bombero según el número de legajo
            var bombero = await _context.Bomberos
                .FirstOrDefaultAsync(b => b.NumeroLegajo == numeroLegajo);

            if (bombero == null)
            {
                return null;
            }

            var bomberoViweModel = new BomberoViweModel
            {
                NumeroLegajo = bombero.NumeroLegajo,
                Nombre = bombero.Nombre,
                Apellido = bombero.Apellido
            };

            return bomberoViweModel;
        }

        public async Task<List<BomberoViweModel>> ObtenerBomberosChoferes()
        {
            // Traemos los bomberos que son choferes desde la base de datos de forma asincrónica
            var bomberosChoferes = await _context.Bomberos
                .Where(c => c.Chofer)
                .Select(c => new BomberoViweModel
                {
                    FechaNacimiento = c.FechaNacimiento,
                    Sexo = c.Sexo,
                    Nombre = c.Nombre,
                    Apellido = c.Apellido,
                    Documento = c.Documento,
                    NumeroLegajo = c.NumeroLegajo,
                    NumeroIoma = c.NumeroIoma,
                    LugarNacimiento = c.LugarNacimiento,
                    Grado = c.Grado,
                    Dotacion = c.Dotacion,
                    Estado = c.Estado,
                    Chofer = c.Chofer,
                    VencimientoRegistro = c.VencimientoRegistro,
                    Direccion = c.Direccion,
                    Observaciones = c.Observaciones,
                    Profesion = c.Profesion,
                    NivelEstudios = c.NivelEstudios,
                    FechaAceptacion = c.FechaAceptacion,
                })
                .ToListAsync();

            return bomberosChoferes;
        }


    }
}
