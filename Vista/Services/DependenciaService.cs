using Microsoft.EntityFrameworkCore;
using System;
using Vista.Data;
using Vista.Data.Models.Grupos.Dependencias;
using Vista.Data.Models.Personales;

namespace Vista.Services
{
    public interface IDependenciaService
    {
        Task<List<Dependencia>> ObtenerTodasLasDependenciasAsync();
        Task<Dependencia?> ObtenerDependenciaPorIdAsync(int id);
        Task<List<Bombero>> ObtenerBomberosDeDependenciaAsync(int dependenciaId);
        Task AgregarDependenciaAsync(Dependencia dependencia);
        Task EditarDependenciaAsync(Dependencia dependencia);
        Task EliminarDependenciaAsync(int id);
    }

    public class DependenciaService : IDependenciaService
    {
        private readonly BomberosDbContext _context;

        public DependenciaService(BomberosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Dependencia>> ObtenerTodasLasDependenciasAsync()
        {
            return await _context.Dependencias.Include(d => d.Encargado).ToListAsync();
        }

        public async Task<Dependencia?> ObtenerDependenciaPorIdAsync(int id)
        {
            return await _context.Dependencias.FindAsync(id);
        }

        public async Task AgregarDependenciaAsync(Dependencia dependencia)
        {
            _context.Dependencias.Add(dependencia);
            await _context.SaveChangesAsync();
        }

        public async Task EditarDependenciaAsync(Dependencia dependencia)
        {
            var dependenciaExistente = await _context.Dependencias.FindAsync(dependencia.DependenciaId);

            if (dependenciaExistente != null)
            {
                dependenciaExistente.NombreDependencia = dependencia.NombreDependencia;
                dependenciaExistente.Encargado = dependencia.Encargado;

                _context.Dependencias.Update(dependenciaExistente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task EliminarDependenciaAsync(int id)
        {
            var dependencia = await _context.Dependencias.FindAsync(id);
            if (dependencia != null)
            {
                _context.Dependencias.Remove(dependencia);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Bombero>> ObtenerBomberosDeDependenciaAsync(int dependenciaId)
        {
            var dependencia = await _context.Dependencias
                .Include(d => d.Bomberos) // Aquí Bomberos es de tipo List<Bombero_Dependencia>
                .FirstOrDefaultAsync(d => d.DependenciaId == dependenciaId);

            return dependencia?.Bomberos
                .Select(bd => bd.Bombero) // Proyecta los bomberos reales
                .ToList() ?? new List<Bombero>();
        }
    }
}
