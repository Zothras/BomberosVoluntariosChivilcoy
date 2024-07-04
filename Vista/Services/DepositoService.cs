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
    public interface IDepositoService
    {
        Task<Material> AgregarMaterial(Material material);
        Task<MovimientoMaterial> CargarMovimiento(MovimientoMaterial material);
        Task<bool> ActualizarStock(MovimientoMaterial movimiento, Material material);
    }

    public class DepositoService : IDepositoService
    {
        private readonly BomberosDbContext _context;

        public DepositoService(BomberosDbContext context)
        {
            _context = context;
        }
        public async Task<Material> AgregarMaterial(Material material)
        {
            try
            {
                if (await _context.Materiales.AnyAsync(b => b.MaterialId == material.MaterialId))
                {
                    throw new InvalidOperationException("Ya existe un material con este ID.");
                }
                _context.Materiales.Add(material);
                await _context.SaveChangesAsync();
                return material;
            }
            catch (Exception ex)
            {
                // Registrar el error en un log en el futuro
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public async Task<MovimientoMaterial> CargarMovimiento(MovimientoMaterial material)
        {
            try
            {
                var BomberoDestino = material.DestinoBombero != null ? await _context.Bomberos.SingleOrDefaultAsync(m => m.NumeroLegajo == material.DestinoBombero.NumeroLegajo) : null;
                var MovilDestino = material.DestinoMovil != null ? await _context.Moviles.SingleOrDefaultAsync(m => m.NumeroMovil == material.DestinoMovil.NumeroMovil) : null;
                var MaterialAsignado = await _context.Materiales.SingleOrDefaultAsync(ma => ma.MaterialId == material.Materiales.MaterialId);
                material.DestinoBombero = BomberoDestino;
                material.DestinoMovil = MovilDestino;
                material.Materiales = MaterialAsignado;

                _context.Movimientos.Add(material);
                await _context.SaveChangesAsync();
                return material;
            }
            catch (Exception ex)
            {
                // Registrar el error en un log en el futuro
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public async Task<bool> ActualizarStock(MovimientoMaterial movimiento, Material material)
        {
            try
            {
                var MaterialActulizar = await _context.Materiales.SingleOrDefaultAsync(m => m.MaterialId == material.MaterialId);

                if (MaterialActulizar == null)
                {
                    throw new Exception("Material no encontrado");
                }

                if(movimiento.TipoMovimiento == TipoMovimiento.Entrada)
                {
                    MaterialActulizar.Stock = MaterialActulizar.Stock + movimiento.Cantidad;
                }
                else //Consultar que se debe realizar en el caso de que ocurra los otros tipos de movimiento: Salida, Baja, Entrada_Salida
                {
                    MaterialActulizar.Stock = MaterialActulizar.Stock - movimiento.Cantidad;
                }

                if (MaterialActulizar.Stock < 0)
                {
                    throw new Exception("Stock insuficiente");
                }
                
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                // Registrar el error en un log en el futuro
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
