using AntDesign;
using Microsoft.EntityFrameworkCore;
using System;
using Vista.Data;
using Vista.Data.Models.Salidas.Componentes;


namespace Vista.Services
{
    public class StockService
    {
        private readonly BomberosDbContext Context;
        public StockService(BomberosDbContext context)
        {
            Context = context;
        }

        public async Task ActulizarStock(MovimientoMaterial movimiento, Material material)
        {
            try
            {
                var MaterialActulizar = await Context.Materiales.SingleOrDefaultAsync(m => m.MaterialId == material.MaterialId);

                if (MaterialActulizar == null)
                {
                    throw new Exception("Material no encontrado");
                }

                MaterialActulizar.Stock = MaterialActulizar.Stock - movimiento.Cantidad;

                if (MaterialActulizar.Stock < 0)
                {
                    throw new Exception("Stock insuficiente");
                }

                await Context.SaveChangesAsync();
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
