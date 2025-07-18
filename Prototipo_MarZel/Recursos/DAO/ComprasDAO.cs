using System.Data;
using System.Data.SqlClient;

namespace Prototipo_MarZel
{
    public class CompraDAO
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public List<Compra> ObtenerCompras()
        {
            List<Compra> lista_compras = new();
            using SqlConnection con = conexion.AbrirConexion();
            string query = @"SELECT  A.*,
                                     B.NOMBRE AS NOMBRE_PROVEEDOR        
                             FROM    TBL_COMPRAS A,
                                     TBL_PROVEEDORES B
                             WHERE   A.ID_PROVEEDOR = B.ID_PROVEEDOR";
            using SqlCommand cmd = new SqlCommand(query, con);
            using SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista_compras.Add(new Compra
                {
                    ID_COMPRA = dr.GetInt32(dr.GetOrdinal("ID_COMPRA")),
                    ID_PROVEEDOR = dr.GetInt32(dr.GetOrdinal("ID_PROVEEDOR")),
                    FECHA = dr.GetDateTime(dr.GetOrdinal("FECHA")),
                    NOMBRE_PROVEEDOR = dr.GetString(dr.GetOrdinal("NOMBRE_PROVEEDOR")),
                    FACTURA = dr.GetString(dr.GetOrdinal("FACTURA")),
                    SUBTOTAL = dr.GetDecimal(dr.GetOrdinal("SUBTOTAL")),
                    GRAVADO = dr.GetDecimal(dr.GetOrdinal("GRAVADO")),
                    ISV = dr.GetDecimal(dr.GetOrdinal("ISV")),
                    EXENTO = dr.GetDecimal(dr.GetOrdinal("EXENTO")),
                    TOTAL = dr.GetDecimal(dr.GetOrdinal("TOTAL"))
                });
            }
            return lista_compras;

        }

    }
}
