using AntDesign;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using Vista.Data;
using Vista.Data.Enums;
using Vista.Data.Models.Grupos.Brigadas;
using Vista.Data.Models.Salidas.Componentes;


namespace Vista.Services
{
    public interface IBrigadaService 
    {
        Task EliminarBrigada(Brigada brigada);
    }
    public class BrigadaService : IBrigadaService
    {
        private readonly BomberosDbContext _context;

        public BrigadaService(BomberosDbContext context)
        {
            _context = context;
        }

        public async Task EliminarBrigada(Brigada brigada)
        {
            if (brigada == null)
            {
                throw new ArgumentNullException(nameof(brigada), "La brigada proporcionada es nula.");
            }

            try
            {
                var existingBrigada = await _context.Brigadas.FindAsync(brigada.BrigadaId);

                if (existingBrigada != null)
                {
                    _context.Brigadas.Remove(existingBrigada);
                    await _context.SaveChangesAsync();
                    Console.WriteLine($"Brigada '{existingBrigada.Nombre}' eliminada exitosamente.");
                }
                else
                {
                    Console.WriteLine($"Error: La brigada con ID {brigada.BrigadaId} no fue encontrada en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la brigada: {ex.Message}");
                throw;
            }
        }
    }
}
