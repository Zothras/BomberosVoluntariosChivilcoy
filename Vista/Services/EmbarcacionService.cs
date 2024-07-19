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
    public interface IEmbarcacionService
    {
        Task<Embarcacion> AgregarEmbarcacion(Embarcacion embarcacion);
        Task<Embarcacion> EditarEmbarcacion(Embarcacion embarcacion);
        Task<Embarcacion> CambiarEstado(int embarcacionid, TipoEstadoMovil estado);
    }

    public class EmbarcacionService : IEmbarcacionService
    {
        private readonly BomberosDbContext _context;

        public EmbarcacionService(BomberosDbContext context)
        {
            _context = context;
        }
        public async Task<Embarcacion> AgregarEmbarcacion(Embarcacion embarcacion)
        {
            Bombero? Encargado = await _context.Bomberos.SingleOrDefaultAsync(b => b.PersonaId == embarcacion.Encargado.PersonaId);
            embarcacion.Encargado = Encargado;
            _context.Embarcacion.Add(embarcacion);
            await _context.SaveChangesAsync();
            return embarcacion;
        }
        public async Task<Embarcacion> EditarEmbarcacion(Embarcacion embarcacion)
        {
            try
            {
                Embarcacion Editar = await _context.Embarcacion.SingleOrDefaultAsync(e => e.VehiculoId == embarcacion.VehiculoId);
                Bombero? Encargado = await _context.Bomberos.SingleOrDefaultAsync(b => b.PersonaId == embarcacion.Encargado.PersonaId);
                foreach (var i in embarcacion.GetType().GetProperties())
                {
                    var propNombre = i.Name;
                    var propValor = i.GetValue(embarcacion);
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
                return embarcacion;
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
        public async Task<Embarcacion> CambiarEstado(int embarcacionid, TipoEstadoMovil estado)
        {
            Embarcacion embarcacion = await _context.Embarcacion.SingleOrDefaultAsync(e => e.VehiculoId == embarcacionid);
            embarcacion.Estado = estado;
            await _context.SaveChangesAsync();
            return embarcacion;
        }
    }
}