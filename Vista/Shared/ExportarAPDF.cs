using PdfSharp.Drawing.Layout;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace Vista.Shared
{
    public class ExportarAPDF
    {
        public byte[] CrearPDF<T>(IEnumerable<T> datos) where T : class
        {

            using (MemoryStream ms = new MemoryStream())
            {
                PdfDocument documento = new PdfDocument();
                PdfPage pagina = documento.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(pagina);

                DibujarTabla(gfx, datos, 50, 50, pagina.Width - 150, pagina.Height - 100);

                documento.Save(ms);
                return ms.ToArray();
            }
        }

        private void DibujarTabla<T>(XGraphics gfx, IEnumerable<T> datos, double x, double y, double ancho, double alto)
        {
            XFont fuenteNormal = new XFont("Arial", 8);
            XFont fuenteEncabezado = new XFont("Arial", 8, XFontStyleEx.Bold);

            var propiedades = typeof(T).GetProperties();
            int numColumnas = propiedades.Length;
            double anchoColumna = ancho / numColumnas;
            double altoFilaMinimo = 20;

            //encabezados
            var encabezados = propiedades.Select(p => p.Name).ToList();
            double altoEncabezado = DibujarFilaConAjuste(gfx, encabezados, fuenteEncabezado, x, y, anchoColumna, altoFilaMinimo);
            y += altoEncabezado;

            //filas
            foreach (var fila in datos)
            {
                if (y + altoFilaMinimo > alto)
                {
                    //nueva pagina
                    PdfPage nuevaPagina = gfx.PdfPage.Owner.AddPage();
                    gfx = XGraphics.FromPdfPage(nuevaPagina);
                    y = 50;
                }

                var valores = propiedades.Select(p => "" + p.GetValue(fila) ?? "").ToList();
                double altoFila = DibujarFilaConAjuste(gfx, valores, fuenteNormal, x, y, anchoColumna, altoFilaMinimo);
                y += altoFila;
            }
        }
        private double DibujarFilaConAjuste(XGraphics gfx, List<string> textos, XFont fuente, double x, double y, double anchoColumna, double altoMinimo)
        {
            const int caracteresMaxPorLinea = 12;
            const double margenHorizontal = 10;
            const double margenVertical = 6;
            double altoMaximo = altoMinimo;
            List<List<string>> lineasPorCelda = new List<List<string>>();

            foreach (string texto in textos)
            {
                List<string> lineas = DividirEnLineasFijas(texto, caracteresMaxPorLinea);
                lineasPorCelda.Add(lineas);
                double altoNecesario = Math.Max(altoMinimo, lineas.Count * fuente.Height + 2 * margenVertical);
                altoMaximo = Math.Max(altoMaximo, altoNecesario);
            }

            //celdas
            for (int i = 0; i < textos.Count; i++)
            {
                var rect = new XRect(x + i * anchoColumna, y, anchoColumna, altoMaximo);
                gfx.DrawRectangle(XPens.Black, rect);

                double totalAltoTexto = lineasPorCelda[i].Count * fuente.Height;
                double yInicial = y + (altoMaximo - totalAltoTexto) / 2;

                foreach (string linea in lineasPorCelda[i])
                {
                    var size = gfx.MeasureString(linea, fuente);
                    double anchoDisponible = anchoColumna - 2 * margenHorizontal;
                    double xTexto = rect.X + margenHorizontal + (anchoDisponible - size.Width) / 2;
                    var rectTexto = new XRect(xTexto, yInicial, size.Width, fuente.Height);

                    gfx.DrawString(linea, fuente, XBrushes.Black, rectTexto, XStringFormats.Center);
                    yInicial += fuente.Height;
                }
            }

            return altoMaximo;
        }

        private List<string> DividirEnLineasFijas(string texto, int caracteresMaxPorLinea)
        {
            List<string> lineas = new List<string>();
            for (int i = 0; i < texto.Length; i += caracteresMaxPorLinea)
            {
                if (i + caracteresMaxPorLinea <= texto.Length)
                {
                    lineas.Add(texto.Substring(i, caracteresMaxPorLinea));
                }
                else
                {
                    lineas.Add(texto.Substring(i));
                }
            }
            return lineas;
        }

    }
}
