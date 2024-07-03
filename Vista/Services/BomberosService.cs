using AntDesign;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using Vista.Data;
using Vista.Data.Enums;
using Vista.Data.Models.Personales;
using Vista.Data.Models.Salidas.Componentes;

namespace Vista.Services
{
    public interface IBomberosService
    {
        Task<Bombero> CrearBombero(Bombero bombero);
        Task <bool>BorrarBombero(Bombero bombero);
        Task<bool> EditarBombero(Bombero bombero);
    }

    public class BomberosService : IBomberosService
    {
        private readonly BomberosDbContext _context;

        public BomberosService(BomberosDbContext context)
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

        public async Task<bool> EditarBombero(Bombero bombero)
        {
            try
            {
                var existingBombero = await _context.Bomberos
                    .Include(b => b.Contacto)
                    .Include(b => b.Imagen)
                    .FirstOrDefaultAsync(b => b.PersonaId == bombero.PersonaId);

                if (existingBombero is not null)
                {
                    // Actualizar propiedades del bombero
                    existingBombero.FechaNacimiento = bombero.FechaNacimiento;
                    existingBombero.Sexo = bombero.Sexo;
                    existingBombero.Nombre = bombero.Nombre;
                    existingBombero.Apellido = bombero.Apellido;
                    existingBombero.Documento = bombero.Documento;
                    existingBombero.NumeroLegajo = bombero.NumeroLegajo;
                    existingBombero.NumeroIoma = bombero.NumeroIoma;
                    existingBombero.LugarNacimiento = bombero.LugarNacimiento;
                    existingBombero.Grado = bombero.Grado;
                    existingBombero.Dotacion = bombero.Dotacion;
                    existingBombero.Resolucion1 = bombero.Resolucion1;
                    existingBombero.Resolucion2 = bombero.Resolucion2;
                    existingBombero.Resolucion3 = bombero.Resolucion3;
                    existingBombero.Resolucion4 = bombero.Resolucion4;
                    existingBombero.Resolucion5 = bombero.Resolucion5;
                    existingBombero.Resolucion6 = bombero.Resolucion6;
                    existingBombero.GrupoSanguineo = bombero.GrupoSanguineo;
                    existingBombero.Altura = bombero.Altura;
                    existingBombero.Peso = bombero.Peso;
                    existingBombero.Estado = bombero.Estado;
                    existingBombero.Chofer = bombero.Chofer;
                    existingBombero.VencimientoRegistro = bombero.VencimientoRegistro;
                    existingBombero.Direccion = bombero.Direccion;
                    existingBombero.Observaciones = bombero.Observaciones;
                    existingBombero.Profesion = bombero.Profesion;
                    existingBombero.NivelEstudios = bombero.NivelEstudios;
                    existingBombero.FechaAceptacion = bombero.FechaAceptacion;

                    /* Actualizar imagen si se ha subido una nueva
                    if (bombero.Imagen != null && !string.IsNullOrEmpty(bombero.Imagen.Base64Imagen))
                    {
                        if (existingBombero.Imagen == null)
                        {
                            existingBombero.Imagen = new Imagen();
                        }
                        existingBombero.Imagen.NombreImagen = bombero.Imagen.NombreImagen;
                        existingBombero.Imagen.TipoImagen = bombero.Imagen.TipoImagen;
                        existingBombero.Imagen.Base64Imagen = bombero.Imagen.Base64Imagen;
                    }*/

                    // Actualizar o crear contacto
                    if (existingBombero.Contacto == null)
                    {
                        existingBombero.Contacto = new Contacto();
                    }
                    existingBombero.Contacto.TelefonoCel = bombero.Contacto.TelefonoCel;
                    existingBombero.Contacto.TelefonoFijo = bombero.Contacto.TelefonoFijo;
                    existingBombero.Contacto.TelefonoLaboral = bombero.Contacto.TelefonoLaboral;
                    existingBombero.Contacto.Email = bombero.Contacto.Email;

                    await _context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    Console.WriteLine($"No se encontró el bombero con PersonaId {bombero.PersonaId}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar el bombero: {ex.Message}");
                return false;
            }
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
    }
}
