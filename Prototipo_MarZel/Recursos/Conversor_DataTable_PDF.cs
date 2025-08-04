using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;

public static class PDFHelper
{
    public static string GenerarPDFDesdeDataTable(DataTable tabla, string rutaArchivo)
    {
        Document doc = new Document(PageSize.A4);
        PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
        doc.Open();

        PdfPTable pdfTable = new PdfPTable(tabla.Columns.Count);

        // Encabezados
        foreach (DataColumn columna in tabla.Columns)
        {
            pdfTable.AddCell(new Phrase(columna.ColumnName));
        }

        // Datos
        foreach (DataRow fila in tabla.Rows)
        {
            foreach (var celda in fila.ItemArray)
            {
                pdfTable.AddCell(new Phrase(celda.ToString()));
            }
        }

        doc.Add(pdfTable);
        doc.Close();

        return rutaArchivo;
    }

    public static string GenerarFacturaPDF(DataRow datosVenta, string rutaArchivo)
    {
        Document doc = new Document(PageSize.A4, 50, 50, 80, 50);
        PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
        doc.Open();

        var fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
        var fuenteEtiqueta = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
        var fuenteValor = FontFactory.GetFont(FontFactory.HELVETICA, 12);

        // Título
        Paragraph titulo = new Paragraph("Factura - MarZel", fuenteTitulo);
        titulo.Alignment = Element.ALIGN_CENTER;
        titulo.SpacingAfter = 20f;
        doc.Add(titulo);

        // Tabla de factura
        PdfPTable tabla = new PdfPTable(2);
        tabla.WidthPercentage = 80;
        tabla.HorizontalAlignment = Element.ALIGN_CENTER;

        void AddRow(string etiqueta, object valor)
        {
            tabla.AddCell(new PdfPCell(new Phrase(etiqueta, fuenteEtiqueta)) { Border = 0 });
            tabla.AddCell(new PdfPCell(new Phrase(valor.ToString(), fuenteValor)) { Border = 0 });
        }

        AddRow("Fecha:", Convert.ToDateTime(datosVenta["FECHA"]).ToString("dd/MM/yyyy"));
        AddRow("Número de Factura:", datosVenta["FACTURA"]);
        AddRow("Subtotal (L.):", Convert.ToDecimal(datosVenta["SUBTOTAL"]).ToString("N2"));
        AddRow("Gravado (L.):", Convert.ToDecimal(datosVenta["GRAVADO"]).ToString("N2"));
        AddRow("ISV (L.):", Convert.ToDecimal(datosVenta["ISV"]).ToString("N2"));
        AddRow("Exento (L.):", Convert.ToDecimal(datosVenta["EXENTO"]).ToString("N2"));
        AddRow("Total (L.):", Convert.ToDecimal(datosVenta["TOTAL"]).ToString("N2"));

        doc.Add(tabla);

        // Pie
        Paragraph gracias = new Paragraph("\n¡Gracias por su compra!", fuenteValor);
        gracias.Alignment = Element.ALIGN_CENTER;
        gracias.SpacingBefore = 20f;
        doc.Add(gracias);

        doc.Close();
        return rutaArchivo;
    }


}
