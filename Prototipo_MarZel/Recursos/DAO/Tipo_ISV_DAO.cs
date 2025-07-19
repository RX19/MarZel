using System.Data;
using System.Data.SqlClient;

namespace Prototipo_MarZel
{
    public class Tipo_ISV_DAO
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public List<Tipo_ISV> Cargar_Tipos_ISV()
        {
            List<Tipo_ISV> lista_tipos = new();
            using SqlConnection con = conexion.AbrirConexion();
            string query = @"SELECT  * 
                             FROM    TBL_TIPOS_ISV";
            using SqlCommand cmd = new SqlCommand(query, con);
            using SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                var tipo = new Tipo_ISV
                {
                    ID_TIPO = dr.GetInt32(dr.GetOrdinal("ID_ISV")),
                    DESCRIPCION = dr.GetString(dr.GetOrdinal("DESCRIPCION"))
                };

                lista_tipos.Add(tipo);
            }
            return lista_tipos;
        }
    }
}