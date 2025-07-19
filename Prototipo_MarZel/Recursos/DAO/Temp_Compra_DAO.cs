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

            // 1. Eliminar TEMP_DETALLES_COMPRA
            query = "DELETE FROM TEMP_DETALLES_COMPRA";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            // 2. Eliminar TEMP_COMPRAS
            query = "DELETE FROM TEMP_COMPRAS";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        // Agregar un registro en TEMP_COMPRAS con ID_COMPRA = 0
        public void Agregar_Compra()
        {
            using SqlConnection con = conexion.AbrirConexion();
            string query = @"
                INSERT INTO TEMP_COMPRAS (
                    ID_COMPRA, SUBTOTAL, GRAVADO, ISV, EXENTO, TOTAL
                ) VALUES (
                    0, 0.00, 0.00, 0.00, 0.00, 0.00)";
            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        // Muestra los datos de la compra almacenados en TEMP_COMPRAS
        public Temp_Compra Cargar_Compra()
        {
            Temp_Compra? compra = null;

            using SqlConnection con = conexion.AbrirConexion();
            string query = @"
                SELECT  ID_COMPRA, SUBTOTAL, GRAVADO, ISV, EXENTO, TOTAL
                FROM    TEMP_COMPRAS
                WHERE   ID_COMPRA = 0";
            using SqlCommand cmd = new SqlCommand(query, con);
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

        // Muestra los detalles de compra almacenados en TEMP_DETALLES_COMPRA
        public List<Temp_Detalle_Compra> Cargar_Detalles(int Id_Compra)
        {
            
            List<Temp_Detalle_Compra> lista_Temp_Detalles_Compra = new();

            using SqlConnection con = conexion.AbrirConexion();
            string query = @"
                SELECT  * 
                FROM    TEMP_DETALLES_COMPRA";
            using SqlCommand cmd = new SqlCommand(query, con);
            using SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                var detalle = new Temp_Detalle_Compra
                {
                    ID_COMPRA = dr["ID_COMPRA"] as int?,
                    ID_PRODUCTO = dr["ID_PRODUCTO"] as int?,
                    CODIGO_BARRA = dr["CODIGO_BARRA"] as string,
                    DESCRIPCION = dr["DESCRIPCION"] as string,
                    CANTIDAD = dr["CANTIDAD"] as int?,
                    COSTO = dr["COSTO"] as decimal?,
                    ID_ISV = dr["ID_ISV"] as int?,
                    DESCUENTO = dr["DESCUENTO"] as decimal?,
                    IMPORTE = dr["IMPORTE"] as decimal?,
                    PRECIO_COMPLETO = dr["PRECIO_COMPLETO"] as decimal?,
                    PRECIO_UNITARIO = dr["PRECIO_UNITARIO"] as decimal?,
                    ID_CATEGORIA = dr["ID_CATEGORIA"] as int?,
                    FECHA_CRACION = dr["FECHA_CREACION"] as DateTime?
                };

                lista_Temp_Detalles_Compra.Add(detalle);
            }
            return lista_Temp_Detalles_Compra;
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
            cmd.Parameters.AddWithValue("@FECHA_CREACION", Detalle_Compra.FECHA_CRACION);
            cmd.ExecuteNonQuery();
        }
    }
}