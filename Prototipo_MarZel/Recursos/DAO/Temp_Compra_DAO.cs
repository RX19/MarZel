using Org.BouncyCastle.Asn1.X500;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Prototipo_MarZel
{
    public class Temp_Compra_DAO : Temp_Compra_Base
    {
        // Elimina registros de ambas tablas temporales
        public override void Eliminar_Registros_Temporales()
        {
            ConexionBD conexion = new ConexionBD();
            string query = string.Empty;

            query = "DELETE FROM TEMP_COMPRAS";
            conexion.EjecutarComando(query, null);

            query = "DELETE FROM TEMP_DETALLES_COMPRA";
            conexion.EjecutarComando(query, null);

        }

        // Agregar un registro en TEMP_COMPRAS.
        public override void Agregar_Compra(int Id_Compra)
        {
            ConexionBD conexion = new ConexionBD();
            string query = string.Empty;

            if (Id_Compra == 0)
            {
                query = @"
                INSERT INTO TEMP_COMPRAS (
                    ID_COMPRA, FECHA, SUBTOTAL, GRAVADO, ISV, EXENTO, TOTAL
                ) VALUES (
                    0, GETDATE(), 0.00, 0.00, 0.00, 0.00, 0.00
                )";
            }
            else
            {
                query = @"
                INSERT INTO TEMP_COMPRAS (
                    ID_COMPRA, ID_PROVEEDOR, RTN, NOMBRE, DIRECCION, CELULAR, 
                    FECHA, FACTURA, SUBTOTAL, GRAVADO, ISV, EXENTO, TOTAL
                )
                SELECT 
                    C.ID_COMPRA, C.ID_PROVEEDOR, P.RTN, P.NOMBRE, P.DIRECCION, P.CELULAR,
                    C.FECHA, C.FACTURA, C.SUBTOTAL, C.GRAVADO, C.ISV, C.EXENTO, C.TOTAL
                FROM TBL_COMPRAS C
                INNER JOIN TBL_PROVEEDORES P ON C.ID_PROVEEDOR = P.ID_PROVEEDOR
                WHERE C.ID_COMPRA = @ID_COMPRA";
            }
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_COMPRA", Id_Compra)
            };
            conexion.EjecutarComando(query, parametros);
        }

        //Guarda los detalles de la compra en TEMP_DETALLES_COMPRAS
        public override void Capturar_Detalles(int Id_Compra)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                INSERT INTO TEMP_DETALLES_COMPRA (
                    ID_COMPRA, ID_PRODUCTO, CODIGO_BARRA, DESCRIPCION, CANTIDAD, 
                    COSTO, ID_ISV, DESCUENTO, IMPORTE, PRECIO_COMPLETO, 
                    PRECIO_UNITARIO, ID_CATEGORIA, FECHA_CREACION
                )
                SELECT 
                    A.ID_COMPRA, A.ID_PRODUCTO, B.CODIGO_BARRA, B.DESCRIPCION, A.CANTIDAD, 
                    A.COSTO, B.ID_ISV, A.DESCUENTO, A.IMPORTE, B.PRECIO_COMPLETO, 
                    B.PRECIO_UNITARIO, B.ID_CATEGORIA, GETDATE()
                FROM TBL_DETALLES_COMPRA A
                INNER JOIN TBL_PRODUCTOS B ON A.ID_PRODUCTO = B.ID_PRODUCTO
                WHERE ID_COMPRA = @ID_COMPRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_COMPRA", Id_Compra)
            };
            conexion.EjecutarComando(query, parametros);
        }

        // Carga los detalles de compra desde TEMP_DETALLES_COMPRA
        public override DataTable Cargar_Detalles(int Id_Compra)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT  *
                FROM    TEMP_DETALLES_COMPRA
                WHERE   ID_COMPRA = @ID_COMPRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_COMPRA", Id_Compra)
            };
            return conexion.EjecutarConsulta(query, parametros);
        }

        // Cargar los datos actualizados de la compra desde TEMP_COMPRA.
        public override DataTable Cargar_Compra(int Id_Compra)
        {
            string query = string.Empty;
            ConexionBD conexion = new ConexionBD();
            DataTable? resultado = null;
            SqlParameter[] parametros;
            
            query = @"
                SELECT  SUM(CASE WHEN ID_ISV = 1 THEN IMPORTE END) AS GRAVADO,
                        SUM(CASE WHEN ID_ISV = 2 THEN IMPORTE END) AS EXENTO
                FROM    TEMP_DETALLES_COMPRA
                WHERE   ID_COMPRA = @ID_COMPRA";
            parametros = new SqlParameter[]
            {
                new SqlParameter("@ID_COMPRA", Id_Compra)
            };
            DataTable result = conexion.EjecutarConsulta(query, parametros);

            if (result.Rows.Count > 0)
            {
                decimal Gravado = result.Rows[0].Field<decimal?>("GRAVADO") ?? 0;
                decimal Exento = result.Rows[0].Field<decimal?>("EXENTO") ?? 0;
                decimal Subtotal = Gravado + Exento;
                decimal ISV = Gravado * 0.15m;
                decimal Total = Subtotal + ISV;

                query = @"
                UPDATE  TEMP_COMPRAS
                SET     SUBTOTAL = @SUBTOTAL,
                        GRAVADO = @GRAVADO,
                        ISV = @ISV,
                        EXENTO = @EXENTO,
                        TOTAL = @TOTAL
                WHERE   ID_COMPRA = @ID_COMPRA";
                parametros = new SqlParameter[]
                {
                    new SqlParameter("@SUBTOTAL", Subtotal),
                    new SqlParameter("@GRAVADO", Gravado),
                    new SqlParameter("@ISV", ISV),
                    new SqlParameter("@EXENTO", Exento),
                    new SqlParameter("@TOTAL", Total),
                    new SqlParameter("@ID_COMPRA", Id_Compra),
                };
                conexion.EjecutarComando(query, parametros);

                query = @"
                SELECT  *
                FROM    TEMP_COMPRAS
                WHERE   ID_COMPRA = @ID_COMPRA";
                parametros = new SqlParameter[]
                {
                    new SqlParameter("@ID_COMPRA", Id_Compra)
                };
                resultado = conexion.EjecutarConsulta(query, parametros);
            }
            return resultado;
        }

        public override bool Buscar_En_Detalles_Compra(string codigo_barra)
        {
            ConexionBD conexion = new ConexionBD(); 
            string query = @"
                SELECT  1 
                FROM    TEMP_DETALLES_COMPRA 
                WHERE   CODIGO_BARRA = @CODIGO_BARRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@CODIGO_BARRA", codigo_barra)
            };
            return conexion.EjecutarConsulta(query, parametros).Rows.Count > 0;
        }

        // Carga un producto desde TEMP_DETALLES_COMPRA usando el código de barras
        public override DataTable Cargar_Producto(string Codigo_Barra)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT  *
                FROM    TEMP_DETALLES_COMPRA
                WHERE   CODIGO_BARRA = @CODIGO_BARRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@CODIGO_BARRA", Codigo_Barra)
            };
            return conexion.EjecutarConsulta(query, parametros);
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

        public override void Agregar_Detalle(int Id_Compra, int? Id_Producto, string Codigo_Barra, string Descripcion, int Cantidad, decimal Costo, 
        decimal Descuento, decimal Importe, int Id_ISV, decimal Precio_Completo, decimal Precio_Unitario, int Id_Categoria, DateTime Fecha_Creacion)
        {
            ConexionBD conexion = new ConexionBD();
            string query = string.Empty;
            SqlParameter[] parametros;

            // Verificar si existe el detalle
            query = @"
                SELECT  CANTIDAD, DESCUENTO, COSTO
                FROM    TEMP_DETALLES_COMPRA
                WHERE   ID_COMPRA = @ID_COMPRA 
                AND     CODIGO_BARRA = @CODIGO_BARRA";
            parametros = new SqlParameter[]
            {
                new SqlParameter("@ID_COMPRA", Id_Compra),
                new SqlParameter("@CODIGO_BARRA", Codigo_Barra)
            };

            DataTable resultado = conexion.EjecutarConsulta(query, parametros);
            if (resultado.Rows.Count > 0) 
            {
                Cantidad += resultado.Rows[0].Field<int>("CANTIDAD");
                Descuento += resultado.Rows[0].Field<decimal>("DESCUENTO");
                Importe = (Cantidad * Costo) - Descuento;

                //Actualizar el detalle de la compra.
                query = @"
                    UPDATE  TEMP_DETALLES_COMPRA
                    SET     DESCRIPCION = @DESCRIPCION,
                            CANTIDAD = @CANTIDAD,
                            COSTO = @COSTO,
                            DESCUENTO = @DESCUENTO,
                            IMPORTE = @IMPORTE, 
                            ID_ISV = @ID_ISV,
                            PRECIO_COMPLETO = @PRECIO_COMPLETO,
                            PRECIO_UNITARIO = @PRECIO_UNITARIO,
                            ID_CATEGORIA = @ID_CATEGORIA,
                            FECHA_CREACION = @FECHA_CREACION
                    WHERE   ID_COMPRA = @ID_COMPRA 
                    AND     CODIGO_BARRA = @CODIGO_BARRA";
                parametros = new SqlParameter[]
                {
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
                    new SqlParameter("ID_COMPRA", Id_Compra),
                    new SqlParameter("@CODIGO_BARRA", Codigo_Barra)
                };
                conexion.EjecutarComando(query, parametros);

            }
            else
            {
                // Si no existe, insertar un nuevo detalle
                query = @"
                    INSERT INTO TEMP_DETALLES_COMPRA (
                        ID_COMPRA, ID_PRODUCTO, CODIGO_BARRA, DESCRIPCION, CANTIDAD,
                        COSTO, DESCUENTO, IMPORTE, ID_ISV, PRECIO_COMPLETO, PRECIO_UNITARIO, ID_CATEGORIA, FECHA_CREACION
                    ) VALUES (
                        @ID_COMPRA, @ID_PRODUCTO, @CODIGO_BARRA, @DESCRIPCION, @CANTIDAD,
                        @COSTO, @DESCUENTO, @IMPORTE, @ID_ISV, @PRECIO_COMPLETO, @PRECIO_UNITARIO, @ID_CATEGORIA, @FECHA_CREACION
                    )";
                parametros = new SqlParameter[]
                {
                    new SqlParameter("ID_COMPRA", Id_Compra),
                    new SqlParameter("@ID_PRODUCTO", Id_Producto ?? (object)DBNull.Value),
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
                };
                conexion.EjecutarComando(query, parametros);
            }

        }

        public override void Modificar_Proveedor(int Id_Compra, int? Id_Proveedor, string RTN, string Nombre, string Direccion, string Celular)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                UPDATE TEMP_COMPRAS
                SET ID_PROVEEDOR = @ID_PROVEEDOR,
                    RTN = @RTN,
                    NOMBRE = @NOMBRE,
                    DIRECCION = @DIRECCION,
                    CELULAR = @CELULAR
                WHERE ID_COMPRA = @ID_COMPRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_PROVEEDOR", (object)Id_Proveedor ?? DBNull.Value),
                new SqlParameter("@RTN", RTN),
                new SqlParameter("@NOMBRE", Nombre),
                new SqlParameter("@DIRECCION", Direccion),
                new SqlParameter("@CELULAR", Celular),
                new SqlParameter("@ID_COMPRA", Id_Compra)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override bool Existe_Factura(string Factura)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT  1 
                FROM    TBL_COMPRAS 
                WHERE FACTURA = @FACTURA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@FACTURA", Factura)
            };
            DataTable resultado = conexion.EjecutarConsulta(query, parametros);
            return resultado.Rows.Count > 0;
        }

        public override void Completar_Compra(int Id_Compra, string Factura, DateTime Fecha)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                UPDATE TEMP_COMPRAS
                SET FACTURA = @FACTURA,
                    FECHA = @FECHA
                WHERE ID_COMPRA = @ID_COMPRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@FACTURA", Factura),
                new SqlParameter("@FECHA", Fecha),
                new SqlParameter("@ID_COMPRA", Id_Compra)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override void Asignar_ID_Proveedor(int Id_Compra, int Id_Proveedor)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                UPDATE TEMP_COMPRAS
                SET ID_PROVEEDOR = @ID_PROVEEDOR
                WHERE ID_COMPRA = @ID_COMPRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_PROVEEDOR", Id_Proveedor),
                new SqlParameter("@ID_COMPRA", Id_Compra)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override void Asignar_ID_Producto(int Id_Compra, int Id_Producto, string Codigo_Barra)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                UPDATE TEMP_DETALLES_COMPRA
                SET     ID_PRODUCTO = @ID_PRODUCTO
                WHERE   ID_COMPRA = @ID_COMPRA
                AND     CODIGO_BARRA = @CODIGO_BARRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_PRODUCTO", Id_Producto),
                new SqlParameter("@ID_COMPRA", Id_Compra),
                new SqlParameter("@CODIGO_BARRA", Codigo_Barra)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override void Modificar_Detalle(int Id_Compra, int? Id_Producto, string Codigo_Barra, string Descripcion, int Cantidad, decimal Costo,
        decimal Descuento, decimal Importe, int Id_ISV, decimal Precio_Completo, decimal Precio_Unitario, int Id_Categoria, DateTime Fecha_Creacion)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                UPDATE  TEMP_DETALLES_COMPRA
                SET     ID_PRODUCTO = @ID_PRODUCTO,
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
                WHERE   ID_COMPRA = @ID_COMPRA
                AND     CODIGO_BARRA = @CODIGO_BARRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_PRODUCTO", (object)Id_Producto ?? DBNull.Value),
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
                new SqlParameter("ID_COMPRA", Id_Compra),
                new SqlParameter("@CODIGO_BARRA", Codigo_Barra)
            };
            conexion.EjecutarComando(query, parametros);
        }
    }
}