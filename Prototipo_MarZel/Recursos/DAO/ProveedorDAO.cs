using System.Data;
using System.Data.SqlClient;

namespace Prototipo_MarZel
{
    public class ProveedorDAO
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public List<Proveedor> ObtenerProveedores()
        {
            List<Proveedor> lista_proveedores = new();
            using SqlConnection con = conexion.AbrirConexion();
            string query = @"SELECT  * 
                             FROM    TBL_PROVEEDORES";
            using SqlCommand cmd = new SqlCommand(query, con);
            using SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista_proveedores.Add(new Proveedor
                {
                    ID_PROVEEDOR = dr.GetInt32(dr.GetOrdinal("ID_PROVEEDOR")),
                    RTN = dr.GetString(dr.GetOrdinal("RTN")),
                    NOMBRE = dr.GetString(dr.GetOrdinal("NOMBRE")),
                    DIRECCION = dr.GetString(dr.GetOrdinal("DIRECCION")),
                    CELULAR = dr.GetString(dr.GetOrdinal("CELULAR")),
                    CANT_COMPRAS = dr.GetInt32(dr.GetOrdinal("CANT_COMPRAS")),
                    IMPORTE = dr.GetDecimal(dr.GetOrdinal("IMPORTE"))
                });
            }
            return lista_proveedores;

        }

        public bool ExisteRTN (string rtn)
        {
            using SqlConnection con = conexion.AbrirConexion();
            string query = @"SELECT  1 
                             FROM    TBL_PROVEEDORES 
                             WHERE RTN = @RTN";
            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@RTN", rtn);
            return cmd.ExecuteScalar() != null;
        }

        public void AgregarProveedor(Proveedor proveedor)
        {
            using SqlConnection con = conexion.AbrirConexion();
            string query = @"INSERT INTO TBL_PROVEEDORES (
                                RTN, NOMBRE, DIRECCION, CELULAR, CANT_COMPRAS, IMPORTE
                             ) VALUES (
                                @RTN, @NOMBRE, @DIRECCION, @CELULAR, @CANT_COMPRAS, @IMPORTE
                             )";
            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@RTN", proveedor.RTN);
            cmd.Parameters.AddWithValue("@NOMBRE", proveedor.NOMBRE);
            cmd.Parameters.AddWithValue("@DIRECCION", proveedor.DIRECCION);
            cmd.Parameters.AddWithValue("@CELULAR", proveedor.CELULAR);
            cmd.Parameters.AddWithValue("@CANT_COMPRAS", proveedor.CANT_COMPRAS);
            cmd.Parameters.AddWithValue("@IMPORTE", proveedor.IMPORTE);
            cmd.ExecuteNonQuery();
        }

        public void ActualizarProveedor(Proveedor proveedor)
        {
            using SqlConnection con = conexion.AbrirConexion();
            string query = @"UPDATE  TBL_PROVEEDORES 
                             SET     RTN = @RTN, 
                                     NOMBRE = @NOMBRE, 
                                     DIRECCION = @DIRECCION, 
                                     CELULAR = @CELULAR, 
                                     CANT_COMPRAS = @CANT_COMPRAS, 
                                     IMPORTE = @IMPORTE
                             WHERE   ID_PROVEEDOR = @ID_PROVEEDOR";
            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@RTN", proveedor.RTN);
            cmd.Parameters.AddWithValue("@NOMBRE", proveedor.NOMBRE);
            cmd.Parameters.AddWithValue("@DIRECCION", proveedor.DIRECCION);
            cmd.Parameters.AddWithValue("@CELULAR", proveedor.CELULAR);
            cmd.Parameters.AddWithValue("@CANT_COMPRAS", proveedor.CANT_COMPRAS);
            cmd.Parameters.AddWithValue("@IMPORTE", proveedor.IMPORTE);
            cmd.Parameters.AddWithValue("@ID_PROVEEDOR", proveedor.ID_PROVEEDOR);
            cmd.ExecuteNonQuery();
        }

    }
}
