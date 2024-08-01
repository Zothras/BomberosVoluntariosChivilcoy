using DocumentFormat.OpenXml.InkML;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vista.Data;
using Vista.Data.Enums;
using Vista.Data.Models.Personales;
using Vista.Data.Models.Salidas.Componentes;

namespace Vista.Services
{
    public interface IMovilService
    {
        Task<Movil> AgregarMovil(Movil movil);
        Task<Movil> EditarMovil(Movil movil);
        Task<Movil> CambiarEstado(int movilid, TipoEstadoMovil estado);
        Task<Limpieza> AgregarLimpieza(Limpieza limpieza);
    }

    public class MovilService : IMovilService
    {
        private readonly BomberosDbContext _context;

        public MovilService(BomberosDbContext context)
        {
            _context = context;
        }
        public async Task<Movil> AgregarMovil(Movil movil)
        {
            if (movil.Encargado != null)
            {
                Bombero? Encargado = await _context.Bomberos.SingleOrDefaultAsync(b => b.PersonaId == movil.Encargado.PersonaId);
                movil.Encargado = Encargado;
            }
            _context.Moviles.Add(movil);
            await _context.SaveChangesAsync();
            return movil;
        }
        public async Task<Movil> EditarMovil(Movil movil)
        {
            try
            {
                Movil Editar = await _context.Moviles.SingleOrDefaultAsync(e => e.VehiculoId == movil.VehiculoId);
                Bombero? Encargado = await _context.Bomberos.SingleOrDefaultAsync(b => b.PersonaId == movil.Encargado.PersonaId);
                foreach (var i in movil.GetType().GetProperties())
                {
                    var propNombre = i.Name;
                    var propValor = i.GetValue(movil);
                    var editarProp = Editar.GetType().GetProperty(propNombre);
                    //Validaciones.
                    //Encargado, EncargadoId se establecen a parte para evitar errores
                    //Consultar sobre Seguro, no esta implementado en la edición actualmente
                    if (editarProp != null && editarProp.CanWrite && propValor != null && propNombre != "Encargado" && propNombre != "SeguroId" && propNombre != "EncargadoId")
                    {
                        editarProp.SetValue(Editar, propValor);
                    }
                }
                Editar.Encargado = Encargado;
                Editar.EncargadoId = Encargado.PersonaId;
                await _context.SaveChangesAsync();
                return movil;
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"Error al editar el movil {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado {ex.Message}");
                return null;
            }
        }
        public async Task<Movil> CambiarEstado(int movilid, TipoEstadoMovil estado)
        {
            Movil movil = await _context.Moviles.SingleOrDefaultAsync(e => e.VehiculoId == movilid);
            movil.Estado = estado;
            await _context.SaveChangesAsync();
            return movil;
        }
        public async Task<Limpieza> AgregarLimpieza(Limpieza limpieza)
        {
            //PENDIENTE: Solucionar carga de datos en las List de las relaciones
            if (limpieza.Responsable != null)
            {
                Bombero? Responsable = await _context.Bomberos.SingleOrDefaultAsync(b => b.PersonaId == limpieza.Responsable.PersonaId);
                limpieza.Responsable = Responsable;
                Responsable.Limpieza.Add(limpieza);
            }
            if(limpieza.Movil != null)
            {
                Movil? Movil = await _context.Moviles.SingleOrDefaultAsync(m => m.VehiculoId == limpieza.Movil.VehiculoId);
                limpieza.Movil = Movil;
                Movil.Limpieza.Add(limpieza);
            }
            _context.Limpiezas.Add(limpieza);
            await _context.SaveChangesAsync();
            return limpieza;
        }
    }
}