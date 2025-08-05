using Microsoft.EntityFrameworkCore;
using Vista.Data;
using Vista.DTOs;

namespace Vista.Services
{
    public interface IImagenService
    {
       Task<ImagenResultado?> ObtenerImagenAsync(int id);
    }

    public class ImagenService : IImagenService
    {
        private readonly BomberosDbContext _context;

        public ImagenService(BomberosDbContext context)
        {
            _context = context;
        }

        public async Task<ImagenResultado?> ObtenerImagenAsync(int id)
        {
            var imagen = await _context.Imagen.FindAsync(id);
            if (imagen == null)
                return null;

            return new ImagenResultado
            {
                Datos = imagen.DatosImagen,
                Formato = imagen.TipoImagen
            };
        }
    }
}
