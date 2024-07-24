using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Vista.Data;


namespace Vista.Services
{
    public interface IParteService
    {
        Task<int> ObtenerUltimoNumeroParteDelAnioAsync(int anio);
    }

    public class ParteService : IParteService
    {
        private readonly BomberosDbContext _context;

        public ParteService(BomberosDbContext context)
        {
            _context = context;
        }

        public async Task<int> ObtenerUltimoNumeroParteDelAnioAsync(int anio)
        {
            var ultimoParte = await _context.Salidas
                .Where(p => p.AnioNumeroParte == anio)
                .OrderByDescending(p => p.NumeroParte)
                .FirstOrDefaultAsync();

            return ultimoParte?.NumeroParte ?? 0;
        }
    }
}
