using AntDesign;
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
    }
}
