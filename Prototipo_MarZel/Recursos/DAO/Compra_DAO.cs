using Org.BouncyCastle.Asn1.X500;
using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prototipo_MarZel
{
    public class Compra_DAO : Compra_Base
    {
        public override DataTable Cargar_Compras()
        {
            ConexionBD conexion = new ConexionBD();
            string query = $"SELECT * FROM {Tabla}";
            return conexion.EjecutarConsulta(query, null);
        }

        public override DataTable Cargar_Compra(string Factura)
        {
            ConexionBD conexion = new ConexionBD();
            string query = $"SELECT * FROM TBL_COMPRAS WHERE FACTURA = @FACTURA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@FACTURA", Factura)
            };
            return conexion.EjecutarConsulta(query, parametros);
        }

        public override void Guardar_Proveedor()
        {
            Proveedor_Controller Proveedor_Controller = new Proveedor_Controller();
            Temp_Compra_Controller Temp_Compra_Controller = new Temp_Compra_Controller();

            //Obtener Datos de la Compra
            DataTable compra = Temp_Compra_Controller.Cargar_Compra();
            string RTN = compra.Rows[0]["RTN"].ToString() ?? "";
            string NOMBRE = compra.Rows[0]["NOMBRE"].ToString() ?? "";
            string DIRECCION = compra.Rows[0]["DIRECCION"].ToString() ?? "";
            string CELULAR = compra.Rows[0]["CELULAR"].ToString() ?? "";
            int CANT_COMPRAS = 1;
            decimal IMPORTE = Convert.ToDecimal(compra.Rows[0]["TOTAL"]);

            if (compra.Rows[0]["ID_PROVEEDOR"] == DBNull.Value)
            {
                // Agregar Nuevo Proveedor
                Proveedor_Controller.Agregar_Proveedor(RTN, NOMBRE, DIRECCION, CELULAR, CANT_COMPRAS, IMPORTE);

                // Actualiza Id_Proveedor en la tabla temporal.
                DataTable Proveedor = Proveedor_Controller.Cargar_Proveedor(RTN);
                int Id_Proveedor = Convert.ToInt32(Proveedor.Rows[0]["ID_PROVEEDOR"]);
                Temp_Compra_Controller.Asignar_ID_Proveedor(Id_Proveedor);
            }
            else
            {
                // Obtener y actualizar valores del Proveedor.
                int Id_Proveedor = Convert.ToInt32(compra.Rows[0]["ID_PROVEEDOR"]);
                DataTable Proveedor = Proveedor_Controller.Cargar_Proveedor(Id_Proveedor);
                int Cant_Compras = Proveedor.Rows[0].Field<int>("CANT_COMPRAS") + CANT_COMPRAS;
                decimal Importe = Proveedor.Rows[0].Field<decimal>("IMPORTE") + IMPORTE;

                //Actualizar Proveedor.
                Proveedor_Controller.Modificar_Proveedor(Id_Proveedor, RTN, NOMBRE, DIRECCION, CELULAR, Cant_Compras, Importe);
            }
        }

        public override void Guardar_Compra()
        {
            ConexionBD conexion = new ConexionBD();
            Temp_Compra_Controller Temp_Compra_Controller = new Temp_Compra_Controller();
            Compra_Controller Compra_Controller = new Compra_Controller();

            //Obtener Datos de la Compra
            DataTable compra = Temp_Compra_Controller.Cargar_Compra();
            int ID_PROVEEDOR = Convert.ToInt32(compra.Rows[0]["ID_PROVEEDOR"]);
            DateTime FECHA = Convert.ToDateTime(compra.Rows[0]["FECHA"]);
            string FACTURA = compra.Rows[0]["FACTURA"].ToString() ?? "";
            decimal SUBTOTAL = Convert.ToDecimal(compra.Rows[0]["SUBTOTAL"]);
            decimal GRAVADO = Convert.ToDecimal(compra.Rows[0]["GRAVADO"]);
            decimal ISV = Convert.ToDecimal(compra.Rows[0]["ISV"]);
            decimal EXENTO = Convert.ToDecimal(compra.Rows[0]["EXENTO"]);
            decimal TOTAL = Convert.ToDecimal(compra.Rows[0]["TOTAL"]);

            string query = @"
                INSERT INTO TBL_COMPRAS (
                    ID_PROVEEDOR, FECHA, FACTURA, SUBTOTAL, GRAVADO, ISV, EXENTO, TOTAL
                ) VALUES (
                    @ID_PROVEEDOR, @FECHA, @FACTURA, @SUBTOTAL, @GRAVADO, @ISV, @EXENTO, @TOTAL
                )";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_PROVEEDOR", ID_PROVEEDOR),
                new SqlParameter("@FECHA", FECHA),
                new SqlParameter("@FACTURA", FACTURA),
                new SqlParameter("@SUBTOTAL", SUBTOTAL),
                new SqlParameter("@GRAVADO", GRAVADO),
                new SqlParameter("@ISV", ISV),
                new SqlParameter("@EXENTO", EXENTO),
                new SqlParameter("@TOTAL", TOTAL)
            };
            conexion.EjecutarComando(query, parametros);

            // Actualiza Id_Compra en las tablas temporales
            DataTable Compra = Compra_Controller.Cargar_Compra(FACTURA);
            int Id_Compra = Convert.ToInt32(Compra.Rows[0]["ID_COMPRA"]);
            Temp_Compra_Controller.Asignar_ID_Compra(Id_Compra);
        }

        public override void Procesar_Detalles()
        {
            Temp_Compra_Controller Temp_Compra_Controller = new Temp_Compra_Controller();
            Producto_Controller Producto_Controller = new Producto_Controller();
            Compra_Controller Compra_Controller = new Compra_Controller();
            ConexionBD conexion = new ConexionBD();

            //Obtener Registros de Temp_Detalles_Compra
            DataTable detalles = Temp_Compra_Controller.Cargar_Detalles();
            foreach (DataRow row in detalles.Rows)
            {
                int Id_Producto;
                int Id_Compra = Convert.ToInt32(row["ID_COMPRA"]);
                string Codigo_Barra = row["CODIGO_BARRA"].ToString() ?? "";
                string Descripcion = row["DESCRIPCION"].ToString() ?? "";
                int Cantidad = Convert.ToInt32(row["CANTIDAD"]);
                decimal Costo = Convert.ToDecimal(row["COSTO"]);
                int Id_ISV = Convert.ToInt32(row["ID_ISV"]);
                decimal Descuento = Convert.ToDecimal(row["DESCUENTO"]);
                decimal Importe = Convert.ToDecimal(row["IMPORTE"]);
                decimal Precio_Completo = Convert.ToDecimal(row["PRECIO_COMPLETO"]);
                decimal Precio_Unitario = Convert.ToDecimal(row["PRECIO_UNITARIO"]);
                int Id_Categoria = Convert.ToInt32(row["ID_CATEGORIA"]);
                DateTime Fecha_Creacion = Convert.ToDateTime(row["FECHA_CREACION"]);
                
                if (row["ID_PRODUCTO"] == DBNull.Value)
                {
                    // Agregar Nuevo Producto
                    Producto_Controller.Agregar_Producto(Codigo_Barra, Descripcion, Id_ISV, Precio_Completo, Precio_Unitario, Id_Categoria, Cantidad);

                    // Actualiza Id_Producto en la tabla temporal.
                    DataTable Producto = Producto_Controller.Cargar_Producto(Codigo_Barra);
                    Id_Producto = Convert.ToInt32(Producto.Rows[0]["ID_PRODUCTO"]);
                    Temp_Compra_Controller.Asignar_ID_Producto(Id_Producto, Codigo_Barra);
                }
                else
                {
                    // Obtener y actualizar valores del producto.
                    Id_Producto = Convert.ToInt32(row["ID_PRODUCTO"]);
                    DataTable Producto = Producto_Controller.Cargar_Producto(Id_Producto);
                    int Existencia = Producto.Rows[0].Field<int>("EXISTENCIA") + Cantidad;

                    //Actualizar Producto.
                    Producto_Controller.Modificar_Producto(Id_Producto, Codigo_Barra, Descripcion, Id_ISV, Precio_Completo, Precio_Unitario, Id_Categoria, Existencia);
                }

                // Agregar a Detalles de Compra.
                MessageBox.Show($"pause, id_Compra: {Id_Compra}");
                Compra_Controller.Agregar_Detalle(Id_Compra, Id_Producto, Cantidad, Costo, Descuento, Importe);
            }
        }

        public override void Agregar_Detalle(int Id_Compra, int Id_Producto, int Cantidad, decimal Costo, decimal Descuento, decimal Importe)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                INSERT INTO TBL_DETALLES_COMPRA (
                    ID_COMPRA, ID_PRODUCTO, CANTIDAD, COSTO, DESCUENTO, IMPORTE
                ) VALUES (
                    @ID_COMPRA, @ID_PRODUCTO, @CANTIDAD, @COSTO, @DESCUENTO, @IMPORTE
                )";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_COMPRA", Id_Compra),
                new SqlParameter("@ID_PRODUCTO", Id_Producto),
                new SqlParameter("@CANTIDAD", Cantidad),
                new SqlParameter("@COSTO", Costo),
                new SqlParameter("@DESCUENTO", Descuento),
                new SqlParameter("@IMPORTE", Importe)
            };
            conexion.EjecutarComando(query, parametros);
        }
    }
}