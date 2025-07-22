using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Prototipo_MarZel
{
    public class Temp_Compra_DAO
    {
        private readonly ConexionBD conexion = new ConexionBD();

        // Elimina registros de ambas tablas temporales
        public void Eliminar_Registros_Temporales()
        {
            using SqlConnection con = conexion.AbrirConexion();
            string query = string.Empty;
            SqlCommand cmd = new SqlCommand();

            query = "DELETE FROM TEMP_DETALLES_COMPRA";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            query = "DELETE FROM TEMP_COMPRAS";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        // Agregar un registro en TEMP_COMPRAS.
        public void Agregar_Compra(Compra Compra)
        {
            using SqlConnection con = conexion.AbrirConexion();
            String query = string.Empty;

            if (Compra.ID_COMPRA == 0)
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
                DECLARE @RTN VARCHAR(14), 
                        @NOMBRE VARCHAR(50), 
                        @DIRECCION VARCHAR(50), 
                        @CELULAR VARCHAR(8);

                SELECT 
                    @RTN = RTN,
                    @NOMBRE = NOMBRE,
                    @DIRECCION = DIRECCION,
                    @CELULAR = CELULAR
                FROM TBL_PROVEEDORES
                WHERE ID_PROVEEDOR = @ID_PROVEEDOR;

                INSERT INTO TEMP_COMPRAS (
                    ID_COMPRA, ID_PROVEEDOR, RTN, NOMBRE, DIRECCION, CELULAR, 
                    FECHA, FACTURA, SUBTOTAL, GRAVADO, ISV, EXENTO, TOTAL
                ) VALUES (
                    @ID_COMPRA, @ID_PROVEEDOR, @RTN, @NOMBRE, @DIRECCION, @CELULAR, 
                    @FECHA, @FACTURA, @SUBTOTAL, @GRAVADO, @ISV, @EXENTO, @TOTAL
                )";
            }

            using SqlCommand cmd = new SqlCommand(query, con);
            if (Compra.ID_COMPRA != 0)
            {
                cmd.Parameters.AddWithValue("@ID_COMPRA", Compra.ID_COMPRA);
                cmd.Parameters.AddWithValue("@ID_PROVEEDOR", Compra.ID_PROVEEDOR);
                cmd.Parameters.AddWithValue("@FECHA", Compra.FECHA);
                cmd.Parameters.AddWithValue("@FACTURA", Compra.FACTURA);
                cmd.Parameters.AddWithValue("@SUBTOTAL", Compra.SUBTOTAL);
                cmd.Parameters.AddWithValue("@GRAVADO", Compra.GRAVADO);
                cmd.Parameters.AddWithValue("@ISV", Compra.ISV);
                cmd.Parameters.AddWithValue("@EXENTO", Compra.EXENTO);
                cmd.Parameters.AddWithValue("@TOTAL", Compra.TOTAL);
            }
            cmd.ExecuteNonQuery();
        }

        //Guarda los detalles de la compra en TEMP_DETALLES_COMPRAS
        public void Capturar_Detalles(Compra Compra)
        {
            using SqlConnection con = conexion.AbrirConexion();
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
            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID_COMPRA", Compra.ID_COMPRA);
            cmd.ExecuteNonQuery();
        }

        // Muestra los detalles de compra almacenados en TEMP_DETALLES_COMPRA
        public List<Temp_Detalle_Compra> Cargar_Detalles()
        {

            List<Temp_Detalle_Compra> lista_Temp_Detalles_Compra = new();

            using SqlConnection con = conexion.AbrirConexion();
            string query = @"
                SELECT  * 
                FROM    TEMP_DETALLES_COMPRA";
            using SqlCommand cmd = new SqlCommand(query, con);
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var detalle = new Temp_Detalle_Compra
                {
                    ID_COMPRA = reader.IsDBNull(0) ? null : reader.GetInt32(0),
                    ID_PRODUCTO = reader.IsDBNull(1) ? null : reader.GetInt32(1),
                    CODIGO_BARRA = reader.IsDBNull(2) ? null : reader.GetString(2),
                    DESCRIPCION = reader.IsDBNull(3) ? null : reader.GetString(3),
                    CANTIDAD = reader.IsDBNull(4) ? null : reader.GetInt32(4),
                    COSTO = reader.IsDBNull(5) ? null : reader.GetDecimal(5),
                    ID_ISV = reader.IsDBNull(6) ? null : reader.GetInt32(6),
                    DESCUENTO = reader.IsDBNull(7) ? null : reader.GetDecimal(7),
                    IMPORTE = reader.IsDBNull(8) ? null : reader.GetDecimal(8),
                    PRECIO_COMPLETO = reader.IsDBNull(9) ? null : reader.GetDecimal(9),
                    PRECIO_UNITARIO = reader.IsDBNull(10) ? null : reader.GetDecimal(10),
                    ID_CATEGORIA = reader.IsDBNull(11) ? null : reader.GetInt32(11),
                    FECHA_CREACION = reader.IsDBNull(12) ? null : reader.GetDateTime(12)
                };
                lista_Temp_Detalles_Compra.Add(detalle);
            }
            return lista_Temp_Detalles_Compra;
        }

        // Actualiza los calculos de la compra almacenados en TEMP_COMPRAS
        public Temp_Compra Cargar_Calculos()
        {
            Temp_Compra? compra = null;
            decimal GRAVADO = 0, EXENTO = 0;
            string query = string.Empty;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            using SqlConnection con = conexion.AbrirConexion();
            query = @"
                SELECT  SUM(CASE WHEN ID_ISV = 1 THEN IMPORTE END) AS GRAVADO,
                        SUM(CASE WHEN ID_ISV = 2 THEN IMPORTE END) AS EXENTO
                FROM    TEMP_DETALLES_COMPRA";
            cmd = new SqlCommand(query, con);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                GRAVADO = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                EXENTO = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
            }

            decimal SUBTOTAL = GRAVADO + EXENTO;
            decimal ISV = GRAVADO * 0.15m;
            decimal TOTAL = SUBTOTAL + ISV;

            reader.Close();
            query = @"
                UPDATE  TEMP_COMPRAS
                SET     SUBTOTAL = @SUBTOTAL,
                        GRAVADO = @GRAVADO,
                        ISV = @ISV,
                        EXENTO = @EXENTO,
                        TOTAL = @TOTAL";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@SUBTOTAL", SUBTOTAL);
            cmd.Parameters.AddWithValue("@GRAVADO", GRAVADO);
            cmd.Parameters.AddWithValue("@ISV", ISV);
            cmd.Parameters.AddWithValue("@EXENTO", EXENTO);
            cmd.Parameters.AddWithValue("@TOTAL", TOTAL);
            cmd.ExecuteNonQuery();

            reader.Close();
            query = @"
                SELECT  SUBTOTAL, GRAVADO, ISV, EXENTO, TOTAL
                FROM    TEMP_COMPRAS";
            cmd = new SqlCommand(query, con);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                compra = new Temp_Compra
                {
                    SUBTOTAL = reader.GetDecimal(0),
                    GRAVADO = reader.GetDecimal(1),
                    ISV = reader.GetDecimal(2),
                    EXENTO = reader.GetDecimal(3),
                    TOTAL = reader.GetDecimal(4)
                };
            }
            return compra;
        }

        // Verifica si un producto ya está en TEMP_DETALLES_COMPRA
        public bool Buscar_En_Detalles_Compra(string codigo_barra)
        {
            using SqlConnection con = conexion.AbrirConexion();
            string query = @"SELECT  1 
                             FROM    TEMP_DETALLES_COMPRA 
                             WHERE CODIGO_BARRA = @CODIGO_BARRA";
            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CODIGO_BARRA", codigo_barra);
            return cmd.ExecuteScalar() != null;
        }

        // Carga un producto desde TEMP_DETALLES_COMPRA usando el código de barras
        public Temp_Detalle_Compra Cargar_Producto(string Codigo_Barra)
        {
            using SqlConnection con = conexion.AbrirConexion();
            string query = @"
                SELECT  *
                FROM    TEMP_DETALLES_COMPRA
                WHERE   CODIGO_BARRA = @CODIGO_BARRA
            ";
            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CODIGO_BARRA", Codigo_Barra);
            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Temp_Detalle_Compra
                {
                    CODIGO_BARRA = reader.GetString(reader.GetOrdinal("CODIGO_BARRA")),
                    DESCRIPCION = reader.GetString(reader.GetOrdinal("DESCRIPCION")),
                    COSTO = reader.GetDecimal(reader.GetOrdinal("COSTO")),
                    ID_ISV = reader.GetInt32(reader.GetOrdinal("ID_ISV")),
                    PRECIO_UNITARIO = reader.GetDecimal(reader.GetOrdinal("PRECIO_UNITARIO")),
                    PRECIO_COMPLETO = reader.GetDecimal(reader.GetOrdinal("PRECIO_COMPLETO")),
                    ID_CATEGORIA = reader.GetInt32(reader.GetOrdinal("ID_CATEGORIA"))
                };
            }
            return null;
        }

        // Verifica si un existe el producto
        public bool Buscar_En_Productos(string codigo_barra)
        {
            using SqlConnection con = conexion.AbrirConexion();
            string query = @"SELECT  1 
                             FROM    TBL_PRODUCTOS 
                             WHERE CODIGO_BARRA = @CODIGO_BARRA";
            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CODIGO_BARRA", codigo_barra);
            return cmd.ExecuteScalar() != null;
        }

        // Agrega o actualiza un detalle de compra en la tabla temporal TEMP_DETALLES_COMPRA
        public void Agregar_Detalle(Temp_Detalle_Compra Detalle_Compra)
        {
            using SqlConnection con = conexion.AbrirConexion();
            string query = string.Empty;
            SqlCommand cmd = null;

            // Verificar si existe el detalle
            query = @"
                SELECT  CANTIDAD, DESCUENTO, IMPORTE
                FROM    TEMP_DETALLES_COMPRA
                WHERE   ID_COMPRA = @ID_COMPRA 
                AND     CODIGO_BARRA = @CODIGO_BARRA";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID_COMPRA", Detalle_Compra.ID_COMPRA);
            cmd.Parameters.AddWithValue("@CODIGO_BARRA", Detalle_Compra.CODIGO_BARRA);

            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // Si existe, actualizar el detalle
                int cantidad = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                decimal descuento = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                decimal importe = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                Detalle_Compra.CANTIDAD += cantidad;
                Detalle_Compra.DESCUENTO += descuento;
                Detalle_Compra.IMPORTE += importe;

                reader.Close();
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
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID_COMPRA", Detalle_Compra.ID_COMPRA);
                cmd.Parameters.AddWithValue("@CODIGO_BARRA", Detalle_Compra.CODIGO_BARRA);
                cmd.Parameters.AddWithValue("@DESCRIPCION", Detalle_Compra.DESCRIPCION);
                cmd.Parameters.AddWithValue("@CANTIDAD", Detalle_Compra.CANTIDAD);
                cmd.Parameters.AddWithValue("@COSTO", Detalle_Compra.COSTO);
                cmd.Parameters.AddWithValue("@DESCUENTO", Detalle_Compra.DESCUENTO);
                cmd.Parameters.AddWithValue("@IMPORTE", Detalle_Compra.IMPORTE);
                cmd.Parameters.AddWithValue("@ID_ISV", Detalle_Compra.ID_ISV);
                cmd.Parameters.AddWithValue("@PRECIO_COMPLETO", Detalle_Compra.PRECIO_COMPLETO);
                cmd.Parameters.AddWithValue("@PRECIO_UNITARIO", Detalle_Compra.PRECIO_UNITARIO);
                cmd.Parameters.AddWithValue("@ID_CATEGORIA", Detalle_Compra.ID_CATEGORIA);
                cmd.Parameters.AddWithValue("@FECHA_CREACION", Detalle_Compra.FECHA_CREACION);
                cmd.ExecuteNonQuery();
            }
            else
            {
                // Si no existe, insertar un nuevo detalle
                reader.Close();
                query = @"
                    INSERT INTO TEMP_DETALLES_COMPRA (
                        ID_COMPRA, ID_PRODUCTO, CODIGO_BARRA, DESCRIPCION, CANTIDAD,
                        COSTO, DESCUENTO, IMPORTE, ID_ISV, PRECIO_COMPLETO, PRECIO_UNITARIO, ID_CATEGORIA, FECHA_CREACION
                    ) VALUES (
                        @ID_COMPRA, @ID_PRODUCTO, @CODIGO_BARRA, @DESCRIPCION, @CANTIDAD,
                        @COSTO, @DESCUENTO, @IMPORTE, @ID_ISV, @PRECIO_COMPLETO, @PRECIO_UNITARIO, @ID_CATEGORIA, @FECHA_CREACION
                    )";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID_COMPRA", Detalle_Compra.ID_COMPRA);
                cmd.Parameters.AddWithValue("@ID_PRODUCTO", Detalle_Compra.ID_PRODUCTO ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CODIGO_BARRA", Detalle_Compra.CODIGO_BARRA);
                cmd.Parameters.AddWithValue("@DESCRIPCION", Detalle_Compra.DESCRIPCION);
                cmd.Parameters.AddWithValue("@CANTIDAD", Detalle_Compra.CANTIDAD);
                cmd.Parameters.AddWithValue("@COSTO", Detalle_Compra.COSTO);
                cmd.Parameters.AddWithValue("@DESCUENTO", Detalle_Compra.DESCUENTO);
                cmd.Parameters.AddWithValue("@IMPORTE", Detalle_Compra.IMPORTE);
                cmd.Parameters.AddWithValue("@ID_ISV", Detalle_Compra.ID_ISV);
                cmd.Parameters.AddWithValue("@PRECIO_COMPLETO", Detalle_Compra.PRECIO_COMPLETO);
                cmd.Parameters.AddWithValue("@PRECIO_UNITARIO", Detalle_Compra.PRECIO_UNITARIO);
                cmd.Parameters.AddWithValue("@ID_CATEGORIA", Detalle_Compra.ID_CATEGORIA);
                cmd.Parameters.AddWithValue("@FECHA_CREACION", Detalle_Compra.FECHA_CREACION);
                cmd.ExecuteNonQuery();

            }
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
}