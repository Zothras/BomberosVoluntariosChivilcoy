using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Globalization;
using System.IO;
using static Vista.Pages.PlanillasIntervencion.ImprimirCC;

namespace Vista.Services
{
    public class PdfGenerator
    {
        public byte[] GeneratePdf(IntervencionViewModel model, bool includeCroquis)
        {
            // Crear un nuevo documento PDF
            PdfDocument document = new PdfDocument();
            document.Info.Title = $"Planilla de Intervención {model.NumeroParte}/{model.Fecha.Year}";

            // Crear una página en el documento
            PdfPage page = document.AddPage();
            page.Size = PdfSharp.PageSize.A4;

            // Crear un objeto para dibujar
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Definir fuentes
            XFont titleFont = new XFont("Verdana", 14, XFontStyleEx.BoldItalic);
            XFont headerFont = new XFont("Verdana", 10, XFontStyleEx.BoldItalic);
            XFont regularFont = new XFont("Verdana", 10, XFontStyleEx.Regular);
            XFont emFont = new XFont("Verdana", 15, XFontStyleEx.Regular); // 1.5em

            // Cargar el logo
            XImage logo = XImage.FromFile("wwwroot/imagenes/logoplanilla.png"); // Asegúrate de proporcionar la ruta correcta del archivo

            // Encabezado solo en la primera página
            DrawHeader(gfx, page, logo, model);

            // Dibujar el contenido de la página
            int yPoint = 160; // Ajustar la posición inicial del contenido para evitar solapamientos

            gfx.DrawString($"Fecha: {model.Fecha.ToString("dd/MM/yyyy")}", regularFont, XBrushes.Black,
                new XRect(40, yPoint, page.Width, page.Height),
                XStringFormats.TopLeft);
            gfx.DrawString($"Día: {model.Fecha.ToString("dddd", new CultureInfo("es-ES"))}", regularFont, XBrushes.Black,
                new XRect(300, yPoint, page.Width, page.Height),
                XStringFormats.TopLeft);
            yPoint += 20;

            gfx.DrawString($"Avisado por: {model.AvisadoPor}", regularFont, XBrushes.Black,
                new XRect(40, yPoint, page.Width, page.Height),
                XStringFormats.TopLeft);
            yPoint += 20;

            gfx.DrawString($"Recepcionado por: {model.Recepcionista}", regularFont, XBrushes.Black,
                new XRect(40, yPoint, page.Width, page.Height),
                XStringFormats.TopLeft);
            yPoint += 20;

            gfx.DrawString($"Tipo de Servicio: {model.TipoServicio}", regularFont, XBrushes.Black,
                new XRect(40, yPoint, page.Width, page.Height),
                XStringFormats.TopLeft);
            yPoint += 20;

            gfx.DrawString($"Hora de Salida: {model.HoraSalida}", regularFont, XBrushes.Black,
                new XRect(40, yPoint, page.Width, page.Height),
                XStringFormats.TopLeft);
            gfx.DrawString($"Hora de Regreso: {model.HoraLlegada}", regularFont, XBrushes.Black,
                new XRect(300, yPoint, page.Width, page.Height),
                XStringFormats.TopLeft);
            yPoint += 40;

            gfx.DrawString($"Jefe de la Intervención: {model.GraduadoCargo}", regularFont, XBrushes.Black,
                new XRect(40, yPoint, page.Width, page.Height),
                XStringFormats.TopLeft);
            yPoint += 20;

            gfx.DrawString($"Causa: {model.Causa}", regularFont, XBrushes.Black,
                new XRect(40, yPoint, page.Width, page.Height),
                XStringFormats.TopLeft);
            gfx.DrawString($"Zona: {model.Zona}", regularFont, XBrushes.Black,
                new XRect(300, yPoint, page.Width, page.Height),
                XStringFormats.TopLeft);
            yPoint += 20;

            gfx.DrawString($"Lugar: {model.Lugar}", regularFont, XBrushes.Black,
                new XRect(40, yPoint, page.Width, page.Height),
                XStringFormats.TopLeft);
            yPoint += 40;

            if (includeCroquis)
            {
                gfx.DrawRectangle(XPens.Black, new XRect(40, yPoint, 500, 200)); // Marco para croquis
                yPoint += 210;
            }

            gfx.DrawString("Observaciones: llamado de guardia Nº 2", regularFont, XBrushes.Black,
                new XRect(40, yPoint, page.Width, page.Height),
                XStringFormats.TopLeft);
            yPoint += 40;

            // Convertir el documento a un array de bytes y devolverlo
            using (MemoryStream stream = new MemoryStream())
            {
                document.Save(stream, false);
                return stream.ToArray();
            }
        }

        private void DrawHeader(XGraphics gfx, PdfPage page, XImage logo, IntervencionViewModel model)
        {
            // Definir fuentes
            XFont emFont = new XFont("Verdana", 15, XFontStyleEx.Regular); // 1.5em

            // Dibujar el logo en la esquina superior izquierda
            double logoWidth = 100;
            double logoHeight = 100;
            gfx.DrawImage(logo, 40, 20, logoWidth, logoHeight); // Ajusta la posición y el tamaño según sea necesario

            // Dibujar el texto "SOCIEDAD DE BOMBEROS VOLUNTARIOS CHIVILCOY" subrayado debajo del logo
            double textYPosition = 20 + logoHeight + 10; // Espacio debajo del logo
            gfx.DrawString("SOCIEDAD DE BOMBEROS VOLUNTARIOS CHIVILCOY", emFont, XBrushes.Black,
                new XRect(40, textYPosition, page.Width, page.Height),
                XStringFormats.TopLeft);
            gfx.DrawLine(XPens.Black, 40, textYPosition + 15, 40 + 400, textYPosition + 15); // Línea debajo del texto

            // Dibujar el texto "PLANILLA DE INTERVENCIÓN NRO: (NúmeroIntervención)" a la derecha
            gfx.DrawString($"PLANILLA DE INTERVENCIÓN", emFont, XBrushes.Black,
                new XRect(page.Width - 200, 20, 180, 40),
                XStringFormats.TopLeft);
            gfx.DrawString($"NRO: {model.NumeroParte}/{model.Fecha.Year}", emFont, XBrushes.Black,
                new XRect(page.Width - 200, 60, 180, 40),
                XStringFormats.TopLeft);
        }
    }
}
