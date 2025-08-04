using Prototipo_MarZel;
using Prototipo_MarZel.Recursos.Controlador;
using System.Data;
using System.IO;

public class FacturaService
{
    public static void EnviarFacturaPorCorreo(string numeroFactura, string correoCliente)
    {
        var ventaController = new Venta_Controller();
        DataTable datosFactura = ventaController.Cargar_Venta(numeroFactura);

        if (datosFactura.Rows.Count == 0)
        {
            throw new Exception("No se encontró la venta con ese número de factura.");
        }

        DataRow fila = datosFactura.Rows[0];
        string rutaPDF = Path.Combine(Path.GetTempPath(), $"Factura_{numeroFactura}.pdf");

        PDFHelper.GenerarFacturaPDF(fila, rutaPDF);
        CorreoHelper.EnviarCorreoFactura(correoCliente, numeroFactura, rutaPDF, Convert.ToDateTime(fila["FECHA"]));

        if (File.Exists(rutaPDF))
        {
            File.Delete(rutaPDF);
        }
    }

}

