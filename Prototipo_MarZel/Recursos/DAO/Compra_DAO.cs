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

        public override void Guardar_Proveedor(int Id_Compra)
        {
            Proveedor_Controller Proveedor_Controller = new Proveedor_Controller();
            Temp_Compra_Controller Temp_Compra_Controller = new Temp_Compra_Controller();

            //Obtener Datos de la Compra
            DataTable compra = Temp_Compra_Controller.Cargar_Compra(Id_Compra);
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
                Temp_Compra_Controller.Asignar_ID_Proveedor(Id_Compra, Id_Proveedor);
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

        public override void Guardar_Compra(int Id_Compra)
        {
            ConexionBD conexion = new ConexionBD();
            Temp_Compra_Controller Temp_Compra_Controller = new Temp_Compra_Controller();

            //Obtener Datos de la Compra
            DataTable compra = Temp_Compra_Controller.Cargar_Compra(Id_Compra);
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
        }

        public override void Procesar_Detalles(int Id_Compra)
        {
            Temp_Compra_Controller Temp_Compra_Controller = new Temp_Compra_Controller();
            Producto_Controller Producto_Controller = new Producto_Controller();
            ConexionBD conexion = new ConexionBD();

            //Obtener Registros de Temp_Detalles_Compra
            DataTable detalles = Temp_Compra_Controller.Cargar_Detalles(Id_Compra);

            foreach (DataRow row in detalles.Rows)
            {
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
                    // Agregar Nuevo Proveedor
                    MessageBox.Show(@$"
                    Codigo_Barra = {Codigo_Barra}
                    Descripcion = {Descripcion}
                    Id_ISV = {Id_ISV}
                    Precio_Completo = {Precio_Completo}
                    Precio_Unitario = {Precio_Unitario}
                    Id_Categoria = {Id_Categoria}
                    Cantidad = {Cantidad}
                    ");
                    Producto_Controller.Agregar_Producto(Codigo_Barra, Descripcion, Id_ISV, Precio_Completo, Precio_Unitario, Id_Categoria, Cantidad);

                    // Actualiza Id_Producto en la tabla temporal.
                    DataTable Producto = Producto_Controller.Cargar_Producto(Codigo_Barra);
                    int Id_Producto = Convert.ToInt32(Producto.Rows[0]["ID_PRODUCTO"]);
                    Temp_Compra_Controller.Asignar_ID_Producto(Id_Compra, Id_Producto, Codigo_Barra);
                }
                else
                {
                   
                    //Me tengo que ir... Falta que actualice el producto si ya existen y que se añada a la tabla de detalles.
                    
                    
                    
                    /*// Producto existente: actualizar en TBL_PRODUCTOS
                    idProducto = Convert.ToInt32(idProductoObj);

                    string updateProducto = @"
                UPDATE TBL_PRODUCTOS
                SET CODIGO_BARRA = @CODIGO_BARRA,
                    DESCRIPCION = @DESCRIPCION,
                    PRECIO_COSTO = @PRECIO_COSTO
                WHERE ID_PRODUCTO = @ID_PRODUCTO";

                    SqlParameter[] updateParams = {
                new SqlParameter("@CODIGO_BARRA", (object?)codigoBarra ?? DBNull.Value),
                new SqlParameter("@DESCRIPCION", descripcion),
                new SqlParameter("@PRECIO_COSTO", costo),
                new SqlParameter("@ID_PRODUCTO", idProducto)
            };

                    conexion.EjecutarConsulta(updateProducto, updateParams);
                }

                // Insertar en TBL_DETALLES_COMPRA
                string insertDetalle = @"
            INSERT INTO TBL_DETALLES_COMPRA
            (ID_COMPRA, ID_PRODUCTO, CODIGO_BARRA, CANTIDAD, COSTO, DESCUENTO, IMPORTE)
            VALUES
            (@ID_COMPRA, @ID_PRODUCTO, @CODIGO_BARRA, @CANTIDAD, @COSTO, @DESCUENTO, @IMPORTE)";

                SqlParameter[] detalleParams = {
            new SqlParameter("@ID_COMPRA", idCompra),
            new SqlParameter("@ID_PRODUCTO", idProducto),
            new SqlParameter("@CODIGO_BARRA", (object?)codigoBarra ?? DBNull.Value),
            new SqlParameter("@CANTIDAD", cantidad),
            new SqlParameter("@COSTO", costo),
            new SqlParameter("@DESCUENTO", descuento),
            new SqlParameter("@IMPORTE", importe)
        };

                conexion.EjecutarConsulta(insertDetalle, detalleParams);*/
                }
            }

            /*MessageBox.Show(@$" ID_COMPRA = {Id_Compra} \n
                        Actualiza Provedor \n
                        Id_Proveedor = {Id_Proveedor} \n
                        RTN = {compra.Rows[0]["RTN"]} \n
                        NOMBRE = {compra.Rows[0]["NOMBRE"]} \n
                        DIRECCION = {compra.Rows[0]["DIRECCION"]} \n
                        CELULAR = {compra.Rows[0]["CELULAR"]} \n
                        IMPORTE = {compra.Rows[0]["TOTAL"]} \n
                        CANT_COMPRAS = {} \n
                        IMPORTE = ");*/
        }
    }
}