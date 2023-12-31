using Microsoft.EntityFrameworkCore;
using Vista.Data.Models.Salidas.Componentes;

namespace Vista.Data.Services
{
    public class StockService
    {
        private readonly BomberosDbContext Context;
        public StockService(BomberosDbContext context)
        {
            Context = context;
        }
        public async void ActulizarStock(MovimientoMaterial movimiento, Material material)
        {
            // Aquí va tu lógica para actualizar el stock
            var MaterialActulizar = await Context.Materiales.SingleOrDefaultAsync(m=>m.MaterialId == material.MaterialId);
            MaterialActulizar.Stock = MaterialActulizar.Stock - movimiento.Cantidad;
            await Context.SaveChangesAsync();
        }
    }
}
