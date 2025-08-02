using Org.BouncyCastle.Asn1.X500;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Prototipo_MarZel
{
    public class Temp_Venta_DAO : Temp_Venta_Base
    {
        // Elimina registros de ambas tablas temporales
        public override void Eliminar_Registros_Temporales()
        {
            ConexionBD conexion = new ConexionBD();
            string query = string.Empty;

            query = "DELETE FROM TEMP_VENTAS";
            conexion.EjecutarComando(query, null);

            query = "DELETE FROM TEMP_DETALLES_VENTA";
            conexion.EjecutarComando(query, null);
        }

        // Agregar un registro en TEMP_VENTAS.
        public override void Agregar_Venta(int Id_Usuario, string Nombre_Usuario, int Id_Venta)
        {
            ConexionBD conexion = new ConexionBD();
            string query = string.Empty;

            if (Id_Venta == 0)
            {
                query = @"
                INSERT INTO TEMP_VENTAS (
                    ID_VENTA, ID_CLIENTE, RTN, NOMBRE_CLIENTE, DIRECCION, CELULAR, ID_USUARIO, 
                    NOMBRE_USUARIO, FECHA, SUBTOTAL, GRAVADO, ISV, EXENTO, TOTAL
                ) VALUES (
                    0, 0, 'N/A', 'N/A', 'N/A', 'N/A', @ID_USUARIO, @NOMBRE_USUARIO, GETDATE(), 
                    0.00, 0.00, 0.00, 0.00, 0.00
                )";
            }
            else
            {
                query = @"
                INSERT INTO TEMP_VENTAS (
                    ID_VENTA, ID_CLIENTE, RTN, NOMBRE_CLIENTE, DIRECCION, CELULAR, ID_USUARIO, 
                    NOMBRE_USUARIO, FECHA, FACTURA, SUBTOTAL, GRAVADO, ISV, EXENTO, TOTAL
                )
                SELECT 
                    V.ID_VENTA, V.ID_CLIENTE, C.RTN, C.NOMBRE, C.DIRECCION, C.CELULAR, V.ID_USUARIO,
                    U.NOMBRE, V.FECHA, V.FACTURA, V.SUBTOTAL, V.GRAVADO, V.ISV, V.EXENTO, V.TOTAL
                FROM TBL_VENTAS V
                INNER JOIN TBL_CLIENTES C ON V.ID_CLIENTE = C.ID_CLIENTE
                INNER JOIN TBL_USUARIOS U ON V.ID_USUARIO = U.ID_USUARIO
                WHERE V.ID_VENTA = @ID_VENTA";
            }
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_USUARIO", Id_Usuario),
                new SqlParameter("@NOMBRE_USUARIO", Nombre_Usuario),
                new SqlParameter("@ID_VENTA", Id_Venta)
            };
            conexion.EjecutarComando(query, parametros);
        }

        //Guarda los detalles de la Venta en TEMP_DETALLES_VENTAS
        public override void Capturar_Detalles(int Id_Venta)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                INSERT INTO TEMP_DETALLES_VENTA (
                    ID_VENTA, ID_PRODUCTO, CODIGO_BARRA, DESCRIPCION, CANTIDAD, 
                    PRECIO, PRECIO_COMPLETO, PRECIO_UNITARIO, ID_ISV, DESCUENTO, 
                    IMPORTE, EXISTENCIA, FECHA_CREACION
                )
                SELECT 
                    DV.ID_VENTA, DV.ID_PRODUCTO, P.CODIGO_BARRA, P.DESCRIPCION, DV.CANTIDAD, 
                    DV.PRECIO, P.PRECIO_COMPLETO, P.PRECIO_UNITARIO, P.ID_ISV, DV.DESCUENTO, 
                    DV.IMPORTE, P.EXISTENCIA, GETDATE()
                FROM TBL_DETALLES_VENTA DV
                INNER JOIN TBL_PRODUCTOS P ON DV.ID_PRODUCTO = P.ID_PRODUCTO
                WHERE DV.ID_VENTA = @ID_VENTA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_VENTA", Id_Venta)
            };
            conexion.EjecutarComando(query, parametros);
        }

        // Carga los detalles de Venta desde TEMP_DETALLES_Venta
        public override DataTable Cargar_Detalles()
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT  DV.ID_VENTA, DV.ID_PRODUCTO, DV.CODIGO_BARRA, DV.DESCRIPCION, DV.CANTIDAD,
                        DV.PRECIO, DV.PRECIO_COMPLETO, DV.PRECIO_UNITARIO, DV.ID_ISV, DV.DESCUENTO,
                        TI.DESCRIPCION AS ISV, DV.IMPORTE, DV.EXISTENCIA, DV.FECHA_CREACION
                FROM    TEMP_DETALLES_VENTA DV
                INNER JOIN TBL_TIPOS_ISV TI ON DV.ID_ISV = TI.ID_ISV";
            return conexion.EjecutarConsulta(query, null);
        }

        // Cargar los datos actualizados de la Venta desde TEMP_VENTA.
        public override DataTable Cargar_Venta()
        {
            string query = string.Empty;
            ConexionBD conexion = new ConexionBD();
            DataTable? resultado = null;
            SqlParameter[] parametros;

            query = @"
                SELECT  SUM(IMPORTE) AS TOTAL,
                        SUM(CASE WHEN ID_ISV = 2 THEN IMPORTE END) AS EXENTO
                FROM    TEMP_DETALLES_VENTA";
            DataTable result = conexion.EjecutarConsulta(query, null);

            if (result.Rows.Count > 0)
            {
                decimal Total = result.Rows[0].Field<decimal?>("TOTAL") ?? 0;
                decimal Exento = result.Rows[0].Field<decimal?>("EXENTO") ?? 0;
                decimal st = Total - Exento;
                decimal Gravado = st / 1.15m;
                decimal ISV = Gravado * 0.15m;
                decimal Subtotal = Gravado + Exento;

                query = @"
                UPDATE  TEMP_VentaS
                SET     SUBTOTAL = @SUBTOTAL,
                        GRAVADO = @GRAVADO,
                        ISV = @ISV,
                        EXENTO = @EXENTO,
                        TOTAL = @TOTAL";
                parametros = new SqlParameter[]
                {
                    new SqlParameter("@SUBTOTAL", Subtotal),
                    new SqlParameter("@GRAVADO", Gravado),
                    new SqlParameter("@ISV", ISV),
                    new SqlParameter("@EXENTO", Exento),
                    new SqlParameter("@TOTAL", Total)
                };
                conexion.EjecutarComando(query, parametros);

                query = @"
                SELECT  *
                FROM    TEMP_VENTAS";
                resultado = conexion.EjecutarConsulta(query, null);
            }
            return resultado;
        }

        public override bool Buscar_En_Detalles_Venta(string codigo_barra)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT  1 
                FROM    TEMP_DETALLES_VENTA
                WHERE   CODIGO_BARRA = @CODIGO_BARRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@CODIGO_BARRA", codigo_barra)
            };
            return conexion.EjecutarConsulta(query, parametros).Rows.Count > 0;
        }

        // Verifica si un producto existe en la tabla TBL_PRODUCTOS
        public override bool Buscar_En_Productos(string Codigo_Barra)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT  1 
                FROM    TBL_PRODUCTOS 
                WHERE   CODIGO_BARRA = @CODIGO_BARRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@CODIGO_BARRA", Codigo_Barra)
            };
            return conexion.EjecutarConsulta(query, parametros).Rows.Count > 0;
        }

        public override void Agregar_Detalle(int Id_Venta, int Id_Producto, string Codigo_Barra,
            string Descripcion, int Cantidad, decimal Precio, decimal Precio_Completo, decimal Precio_Unitario,
            int Id_ISV, decimal Descuento, decimal Importe, int Existencia, DateTime Fecha_Creacion)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                    INSERT INTO TEMP_DETALLES_VENTA (
                        ID_VENTA, ID_PRODUCTO, CODIGO_BARRA, DESCRIPCION, CANTIDAD, 
                        PRECIO, PRECIO_COMPLETO, PRECIO_UNITARIO, ID_ISV, DESCUENTO, 
                        IMPORTE, EXISTENCIA, FECHA_CREACION
                    ) VALUES (
                        @ID_VENTA, @ID_PRODUCTO, @CODIGO_BARRA, @DESCRIPCION, @CANTIDAD, 
                        @PRECIO, @PRECIO_COMPLETO, @PRECIO_UNITARIO, @ID_ISV, @DESCUENTO, 
                        @IMPORTE, @EXISTENCIA, @FECHA_CREACION
                    )";
            SqlParameter[] parametros = 
            {
                new SqlParameter("@ID_VENTA", Id_Venta),
                new SqlParameter("@ID_PRODUCTO", Id_Producto),
                new SqlParameter("@CODIGO_BARRA", Codigo_Barra),
                new SqlParameter("@DESCRIPCION", Descripcion),
                new SqlParameter("@CANTIDAD", Cantidad),
                new SqlParameter("@PRECIO", Precio),
                new SqlParameter("@PRECIO_COMPLETO", Precio_Completo),
                new SqlParameter("@PRECIO_UNITARIO", Precio_Unitario),
                new SqlParameter("@ID_ISV", Id_ISV),
                new SqlParameter("@DESCUENTO", Descuento),
                new SqlParameter("@IMPORTE", Importe),
                new SqlParameter("@EXISTENCIA", Existencia),
                new SqlParameter("@FECHA_CREACION", Fecha_Creacion)
            };
            conexion.EjecutarComando(query, parametros);
        }

        // Carga un producto desde TEMP_DETALLES_Venta usando el código de barras
        public override DataTable Cargar_Producto(string Codigo_Barra)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT  *
                FROM    TEMP_DETALLES_VENTA
                WHERE   CODIGO_BARRA = @CODIGO_BARRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@CODIGO_BARRA", Codigo_Barra)
            };
            return conexion.EjecutarConsulta(query, parametros);
        }

        // Actualiza un detalle de venta en TEMP_DETALLES_VENTA
        public override void Actualizar_Detalle(string Codigo_Barra, int Cantidad, decimal Precio,
            decimal Descuento, decimal Importe, int Existencia, DateTime Fecha_Creacion)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                UPDATE  TEMP_DETALLES_VENTA
                SET     CANTIDAD = @CANTIDAD,
                        PRECIO = @PRECIO,
                        DESCUENTO = @DESCUENTO,
                        IMPORTE = @IMPORTE,
                        EXISTENCIA = @EXISTENCIA,
                        FECHA_CREACION = @FECHA_CREACION
                WHERE   CODIGO_BARRA = @CODIGO_BARRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@CANTIDAD", Cantidad),
                new SqlParameter("@PRECIO", Precio),
                new SqlParameter("@DESCUENTO", Descuento),
                new SqlParameter("@IMPORTE", Importe),
                new SqlParameter("@EXISTENCIA", Existencia),
                new SqlParameter("@FECHA_CREACION", Fecha_Creacion),
                new SqlParameter("@CODIGO_BARRA", Codigo_Barra)
            };
            conexion.EjecutarComando(query, parametros);
        }

        // Genera un número de factura para la venta actual
        public override void Completar_Venta()
        {
            ConexionBD conexion = new ConexionBD();
            string query = string.Empty;

            query = "SELECT TOP 1 FACTURA FROM TBL_VENTAS ORDER BY ID_VENTA DESC";
            DataTable resultado = conexion.EjecutarConsulta(query, null);

            string Actual_Factura = $"FAC-{1:D6}";
            if (resultado.Rows.Count > 0)
            {
                string Ultima_Factura = resultado.Rows[0]["FACTURA"].ToString() ?? "";
                string[] partes = Ultima_Factura.Split('-');
                int Numero = int.Parse(partes[1]) + 1;
                Actual_Factura = $"FAC-{Numero.ToString("D6")}";
            }
            query = @"
                UPDATE TEMP_VENTAS
                SET FACTURA = @FACTURA,
                    FECHA = @FECHA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@FACTURA", Actual_Factura),
                new SqlParameter("@FECHA", DateTime.Now)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override void Asignar_Id_Cliente(int Id_Cliente)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                UPDATE TEMP_VENTAS
                SET ID_CLIENTE = @ID_CLIENTE";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_CLIENTE", Id_Cliente)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override void Asignar_Id_Venta(int Id_Venta)
        {
            ConexionBD conexion = new ConexionBD();
            string query = string.Empty;
            SqlParameter[] parametros;

            query = @"
                UPDATE TEMP_VENTAS
                SET ID_VENTA = @ID_VENTA";
            parametros = new SqlParameter[]
            {
                new SqlParameter("@ID_VENTA", Id_Venta)
            };
            conexion.EjecutarComando(query, parametros);

            query = @"
                UPDATE TEMP_DETALLES_VENTA
                SET ID_VENTA = @ID_VENTA";
            parametros = new SqlParameter[]
            {
                new SqlParameter("@ID_VENTA", Id_Venta)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override void Modificar_Cliente(int? Id_Cliente, string Rtn, string Nombre, string Direccion, string Celular)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                UPDATE TEMP_VENTAS
                SET ID_CLIENTE = @ID_CLIENTE,
                    RTN = @RTN,
                    NOMBRE_CLIENTE = @NOMBRE,
                    DIRECCION = @DIRECCION,
                    CELULAR = @CELULAR";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_CLIENTE", Id_Cliente ?? (object)DBNull.Value),
                new SqlParameter("@RTN", Rtn),
                new SqlParameter("@NOMBRE", Nombre),
                new SqlParameter("@DIRECCION", Direccion),
                new SqlParameter("@CELULAR", Celular)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override void Modificar_Detalle(int Id_Venta, int Id_Producto, int Cantidad, decimal Precio, 
            decimal Descuento, decimal Importe, int Existencia, DateTime Fecha_Creacion)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                UPDATE  TEMP_DETALLES_VENTA
                SET     CANTIDAD = @CANTIDAD,
                        PRECIO = @PRECIO,
                        DESCUENTO = @DESCUENTO,
                        IMPORTE = @IMPORTE,
                        EXISTENCIA = @EXISTENCIA,
                        FECHA_CREACION = @FECHA_CREACION
                WHERE   ID_VENTA = @ID_VENTA
                AND     ID_PRODUCTO = @ID_PRODUCTO";
            SqlParameter[] parametros =
            {
                new SqlParameter("@CANTIDAD", Cantidad),
                new SqlParameter("@PRECIO", Precio),
                new SqlParameter("@DESCUENTO", Descuento),
                new SqlParameter("@IMPORTE", Importe),
                new SqlParameter("@EXISTENCIA", Existencia),
                new SqlParameter("@FECHA_CREACION", Fecha_Creacion),
                new SqlParameter("@ID_VENTA", Id_Venta),
                new SqlParameter("@ID_PRODUCTO", Id_Producto)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override void Eliminar_Detalle(string Codigo_Barra)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                DELETE FROM TEMP_DETALLES_VENTA
                WHERE CODIGO_BARRA = @CODIGO_BARRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@CODIGO_BARRA", Codigo_Barra)
            };
            conexion.EjecutarComando(query, parametros);
        }

        /*public override bool Existe_Factura(string Factura)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT  1 
                FROM    TBL_VentaS 
                WHERE FACTURA = @FACTURA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@FACTURA", Factura)
            };
            DataTable resultado = conexion.EjecutarConsulta(query, parametros);
            return resultado.Rows.Count > 0;
        }

        public override void Completar_Venta(int Id_Venta, string Factura, DateTime Fecha)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                UPDATE TEMP_VentaS
                SET FACTURA = @FACTURA,
                    FECHA = @FECHA
                WHERE ID_Venta = @ID_Venta";
            SqlParameter[] parametros =
            {
                new SqlParameter("@FACTURA", Factura),
                new SqlParameter("@FECHA", Fecha),
                new SqlParameter("@ID_Venta", Id_Venta)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override void Asignar_ID_Producto(int Id_Producto, string Codigo_Barra)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                UPDATE  TEMP_DETALLES_Venta
                SET     ID_PRODUCTO = @ID_PRODUCTO
                WHERE   CODIGO_BARRA = @CODIGO_BARRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_PRODUCTO", Id_Producto),
                new SqlParameter("@CODIGO_BARRA", Codigo_Barra)
            };
            conexion.EjecutarComando(query, parametros);
        }

        

        public override void Modificar_Detalle(int Id_Venta, int? Id_Producto, string Codigo_Barra_1, string Codigo_Barra, string Descripcion, int Cantidad, decimal Costo,
        decimal Descuento, decimal Importe, int Id_ISV, decimal Precio_Completo, decimal Precio_Unitario, int Id_Categoria, DateTime Fecha_Creacion)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                UPDATE  TEMP_DETALLES_Venta
                SET     ID_PRODUCTO = @ID_PRODUCTO,
                        CODIGO_BARRA = @CODIGO_BARRA,   
                        DESCRIPCION = @DESCRIPCION,
                        CANTIDAD = @CANTIDAD,
                        COSTO = @COSTO,
                        DESCUENTO = @DESCUENTO,
                        IMPORTE = @IMPORTE, 
                        ID_ISV = @ID_ISV,
                        PRECIO_COMPLETO = @PRECIO_COMPLETO,
                        PRECIO_UNITARIO = @PRECIO_UNITARIO,
                        ID_CATEGORIA = @ID_CATEGORIA,
                        FECHA_CREACION = @FECHA_CREACION
                WHERE   ID_Venta = @ID_Venta
                AND     CODIGO_BARRA = @CODIGO_BARRA_1";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_PRODUCTO", (object)Id_Producto ?? DBNull.Value),
                new SqlParameter("@CODIGO_BARRA", Codigo_Barra),
                new SqlParameter("DESCRIPCION", Descripcion),
                new SqlParameter("CANTIDAD", Cantidad),
                new SqlParameter("COSTO", Costo),
                new SqlParameter("DESCUENTO", Descuento),
                new SqlParameter("IMPORTE", Importe),
                new SqlParameter("ID_ISV", Id_ISV),
                new SqlParameter("PRECIO_COMPLETO", Precio_Completo),
                new SqlParameter("PRECIO_UNITARIO", Precio_Unitario),
                new SqlParameter("ID_CATEGORIA", Id_Categoria),
                new SqlParameter("FECHA_CREACION", Fecha_Creacion),
                new SqlParameter("ID_Venta", Id_Venta),
                new SqlParameter("@CODIGO_BARRA_1", Codigo_Barra_1)
            };
            conexion.EjecutarComando(query, parametros);
        }

        */
    }
}