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
}
