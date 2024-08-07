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
    public interface IVehiculoService
    {
        Task<VehiculoSalida> AgregarVehiculo(VehiculoSalida vehiculo);
        Task<VehiculoSalida> EditarVehiculo(VehiculoSalida vehiculo);
        Task<VehiculoSalida> CambiarEstado(int movilid, TipoEstadoMovil estado);
        Task<Limpieza> AgregarLimpieza(Limpieza limpieza);
        Task<Limpieza> BorrarLimpieza(Limpieza limpieza);
    }

    public class VehiculoService : IVehiculoService
    {
        private readonly BomberosDbContext _context;

        public VehiculoService(BomberosDbContext context)
        {
            _context = context;
        }
        public async Task<VehiculoSalida> AgregarVehiculo(VehiculoSalida vehiculo)
        {
            if (vehiculo.Encargado != null)
            {
                Bombero? Encargado = await _context.Bomberos.SingleOrDefaultAsync(b => b.PersonaId == vehiculo.Encargado.PersonaId);
                vehiculo.Encargado = Encargado;
            }
            if(vehiculo is Movil)
            {
                _context.Moviles.Add((Movil)vehiculo);
            }
            else
            {
                _context.Embarcacion.Add((Embarcacion)vehiculo);
            }
            await _context.SaveChangesAsync();
            return vehiculo;
        }
        public async Task<VehiculoSalida> EditarVehiculo(VehiculoSalida vehiculo)
        {
            try
            {
                VehiculoSalida Editar = await _context.Set<VehiculoSalida>().SingleOrDefaultAsync(e => e.VehiculoId == vehiculo.VehiculoId);
                foreach (var i in vehiculo.GetType().GetProperties())
                {
                    var propNombre = i.Name;
                    var propValor = i.GetValue(vehiculo);
                    var editarProp = Editar.GetType().GetProperty(propNombre);
                    //Validaciones.
                    //Encargado, EncargadoId se establecen a parte para evitar errores
                    if (editarProp != null && editarProp.CanWrite && propValor != null && propNombre != "Encargado" && propNombre != "SeguroId" && propNombre != "EncargadoId")
                    {
                        editarProp.SetValue(Editar, propValor);
                    }
                }
                if (vehiculo.Encargado != null) {
                    Bombero? Encargado = await _context.Bomberos.SingleOrDefaultAsync(b => b.PersonaId == vehiculo.Encargado.PersonaId);
                    Editar.Encargado = Encargado;
                    Editar.EncargadoId = Encargado.PersonaId;
                }
            await _context.SaveChangesAsync();
                return vehiculo;
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
        public async Task<VehiculoSalida> CambiarEstado(int movilid, TipoEstadoMovil estado)
        {
            VehiculoSalida vehiculo = await _context.Set<VehiculoSalida>().SingleOrDefaultAsync(e => e.VehiculoId == movilid);
            vehiculo.Estado = estado;
            await _context.SaveChangesAsync();
            return vehiculo;
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
            if (limpieza.Vehiculo != null)
            {
                VehiculoSalida? vehiculo = await _context.Set<VehiculoSalida>().SingleOrDefaultAsync(m => m.VehiculoId == limpieza.Vehiculo.VehiculoId);
                limpieza.Vehiculo = vehiculo;
                vehiculo.Limpieza.Add(limpieza);
            }
            _context.Limpiezas.Add(limpieza);
            await _context.SaveChangesAsync();
            return limpieza;
        }
        public async Task<Limpieza> BorrarLimpieza(Limpieza limpieza)
        {
            try
            {
                if (limpieza != null)
                {
                    Limpieza LimpiezaBorrar = await _context.Limpiezas.SingleOrDefaultAsync(l => l.LimpiezaId == limpieza.LimpiezaId);
                    _context.Limpiezas.Remove(LimpiezaBorrar);
                    await _context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"ERROR: Error al eliminar la novedad. {ex.Message}");
                return limpieza;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: Ocurrió un error inesperado. {ex.Message}");
                return limpieza;
            }
            return limpieza;
        }
    }
}