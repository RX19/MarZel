using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
        public void Capturar_Detalles(int Id_Compra)
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
            cmd.Parameters.AddWithValue("@ID_COMPRA", Id_Compra);
            cmd.ExecuteNonQuery();
        }

        // Muestra los detalles de compra almacenados en TEMP_DETALLES_COMPRA
        public List<Temp_Detalle_Compra> Cargar_Detalles(int Id_Compra)
        {

            List<Temp_Detalle_Compra> lista_Temp_Detalles_Compra = new();

            using SqlConnection con = conexion.AbrirConexion();
            string query = @"
                SELECT  * 
                FROM    TEMP_DETALLES_COMPRA
                WHERE   ID_COMPRA = @ID_COMPRA";
            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID_COMPRA", Id_Compra);
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

        // Muestra los calculos de la compra almacenados en TEMP_COMPRAS
        public Temp_Compra Mostrar_Calculos(int Id_Compra)
        {
            Temp_Compra? compra = null;

            using SqlConnection con = conexion.AbrirConexion();
            string query = @"
                SELECT  ID_COMPRA, SUBTOTAL, GRAVADO, ISV, EXENTO, TOTAL
                FROM    TEMP_COMPRAS
                WHERE   ID_COMPRA = @ID_COMPRA";
            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID_COMPRA", Id_Compra);
            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                compra = new Temp_Compra
                {
                    ID_COMPRA = reader.GetInt32(0),
                    SUBTOTAL = reader.GetDecimal(1),
                    GRAVADO = reader.GetDecimal(2),
                    ISV = reader.GetDecimal(3),
                    EXENTO = reader.GetDecimal(4),
                    TOTAL = reader.GetDecimal(5)
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

        // Agrega un detalle de compra a la tabla temporal TEMP_DETALLES_COMPRA
        public void Agregar_Nuevo_Detalle(Temp_Detalle_Compra Detalle_Compra)
        {
            using SqlConnection con = conexion.AbrirConexion();
            string query = @"
                INSERT INTO TEMP_DETALLES_COMPRA (
                    ID_COMPRA, CODIGO_BARRA, DESCRIPCION, CANTIDAD,
                    COSTO, DESCUENTO, IMPORTE, ID_ISV, PRECIO_COMPLETO, PRECIO_UNITARIO, ID_CATEGORIA, FECHA_CREACION
                ) VALUES (
                    @ID_COMPRA, @CODIGO_BARRA, @DESCRIPCION, @CANTIDAD,
                    @COSTO, @DESCUENTO, @IMPORTE, @ID_ISV, @PRECIO_COMPLETO, @PRECIO_UNITARIO, @ID_CATEGORIA, @FECHA_CREACION
                )";

            using SqlCommand cmd = new SqlCommand(query, con);
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
    }
}