using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            String query = string.Empty;

            if (Id_Compra == 0)
            {
                query = @"
                INSERT INTO TEMP_COMPRAS (
                    ID_COMPRA, SUBTOTAL, GRAVADO, ISV, EXENTO, TOTAL
                ) VALUES (
                    0, 0.00, 0.00, 0.00, 0.00, 0.00
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
                SELECT  CANTIDAD, DESCUENTO, IMPORTE
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
                Importe += resultado.Rows[0].Field<decimal>("IMPORTE");
            
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
    }
}
        /*/ Actualiza los calculos de la compra almacenados en TEMP_COMPRAS
        public Temp_Compra Cargar_Calculos()
        {
            
        }

        public Temp_Compra Cargar_Compra()
        {
            using SqlConnection con = conexion.AbrirConexion();
            Temp_Compra? compra = null;
            string query = @"
                SELECT  ID_PROVEEDOR, RTN, NOMBRE, DIRECCION, CELULAR
                FROM    TEMP_COMPRAS";
            using SqlCommand cmd = new SqlCommand(query, con);
            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                compra = new Temp_Compra
                {
                    ID_PROVEEDOR = reader.IsDBNull(0) ? null : reader.GetInt32(0),
                    RTN = reader.IsDBNull(1) ? null : reader.GetString(1),
                    NOMBRE = reader.IsDBNull(2) ? null : reader.GetString(2),
                    DIRECCION = reader.IsDBNull(3) ? null : reader.GetString(3),
                    CELULAR = reader.IsDBNull(4) ? null : reader.GetString(4)
                };
            }
            return compra;
        }

        // Actualiza el proveedor en TEMP_COMPRAS
        public void Actualizar_Proveedor(Temp_Compra compra)
        {
            using SqlConnection con = conexion.AbrirConexion();
            string query = @"
                UPDATE  TEMP_COMPRAS
                SET     ID_PROVEEDOR = @ID_PROVEEDOR,
                        RTN = @RTN,
                        NOMBRE = @NOMBRE,
                        DIRECCION = @DIRECCION,
                        CELULAR = @CELULAR";

            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID_PROVEEDOR", compra.ID_PROVEEDOR ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@RTN", compra.RTN);
            cmd.Parameters.AddWithValue("@NOMBRE", compra.NOMBRE);
            cmd.Parameters.AddWithValue("@DIRECCION", compra.DIRECCION);
            cmd.Parameters.AddWithValue("@CELULAR", compra.CELULAR);
            cmd.ExecuteNonQuery();
        }
    }
}*/