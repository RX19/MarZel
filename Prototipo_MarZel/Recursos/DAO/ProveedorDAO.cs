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
            string query = "SELECT * FROM TBL_PROVEEDORES";
            using SqlConnection con = conexion.AbrirConexion();
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
    }
}
