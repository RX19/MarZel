using Org.BouncyCastle.Asn1.X500;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prototipo_MarZel
{
    public class Proveedor_DAO : Proveedor_Base
    {

        public override DataTable Cargar_Proveedores()
        {
            ConexionBD conexion = new ConexionBD();
            string query = $"SELECT * FROM {Tabla}";
            return conexion.EjecutarConsulta(query, null);
        }

        public override void Eliminar_Proveedor(int Id_Proveedor)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @$"
                DELETE FROM {Tabla}
                WHERE ID_PROVEEDOR = @ID_PROVEEDOR";
            SqlParameter[] parametros =
            {
                new SqlParameter("ID_PROVEEDOR", Id_Proveedor)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override DataTable Buscar_En_Proveedores(string filtro)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @$"
                SELECT  *
                FROM    {Tabla}
                WHERE   RTN LIKE @filtro 
                OR      NOMBRE LIKE @filtro";
            SqlParameter[] parametros =
            {
                new SqlParameter("@filtro", $"%{filtro}%")
            };
            return conexion.EjecutarConsulta(query, parametros);
        }

        public override void Agregar_Proveedor(string RTN, string Nombre, string Direccion, string Celular, int Cant_Compras, decimal Importe)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                INSERT INTO TBL_PROVEEDORES (
                    RTN, NOMBRE, DIRECCION, CELULAR, CANT_COMPRAS, IMPORTE
                ) VALUES (
                    @RTN, @NOMBRE, @DIRECCION, @CELULAR, @CANT_COMPRAS, @IMPORTE
                )";
            SqlParameter[] parametros =
            {
                new SqlParameter("@RTN", RTN),
                new SqlParameter("@NOMBRE", Nombre),
                new SqlParameter("@DIRECCION", Direccion),
                new SqlParameter("@CELULAR", Celular),
                new SqlParameter("@CANT_COMPRAS", Cant_Compras),
                new SqlParameter("@IMPORTE", Importe)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override void Modificar_Proveedor(int Id_Proveedor, string RTN, string Nombre, string Direccion, string Celular)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                UPDATE TBL_PROVEEDORES 
                SET RTN = @RTN,
                    NOMBRE = @NOMBRE,
                    DIRECCION = @DIRECCION,
                    CELULAR = @CELULAR
                WHERE ID_PROVEEDOR = @ID_PROVEEDOR";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_PROVEEDOR", Id_Proveedor),
                new SqlParameter("@RTN", RTN),
                new SqlParameter("@NOMBRE", Nombre),
                new SqlParameter("@DIRECCION", Direccion),
                new SqlParameter("@CELULAR", Celular)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override DataTable Cargar_Proveedor(int Id_Proveedor)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @$"
                SELECT  *
                FROM    {Tabla}
                WHERE   ID_PROVEEDOR = @ID_PROVEEDOR";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_PROVEEDOR", Id_Proveedor)
            };
            return conexion.EjecutarConsulta(query, parametros);
        }
    }
}
        /*public bool Existe_RTN(string rtn)
        {
            using SqlConnection con = conexion.AbrirConexion();
            string query = @"SELECT  1 
                             FROM    TBL_PROVEEDORES 
                             WHERE RTN = @RTN";
            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@RTN", rtn);
            return cmd.ExecuteScalar() != null;
        }*/

        /*public List<Proveedor> Buscar_Proveedor(String texto)
        {
            List<Proveedor> lista_proveedores = new();

            using SqlConnection con = conexion.AbrirConexion();
            string query = @"SELECT  * 
                             FROM    TBL_PROVEEDORES 
                             WHERE   RTN LIKE @Texto OR 
                                     NOMBRE LIKE @Texto";

            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Texto", $"%{texto}%");
            using SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                var proveedor = new Proveedor
                {
                    ID_PROVEEDOR = dr.GetInt32(dr.GetOrdinal("ID_PROVEEDOR")),
                    RTN = dr.GetString(dr.GetOrdinal("RTN")),
                    NOMBRE = dr.GetString(dr.GetOrdinal("NOMBRE")),
                    DIRECCION = dr.GetString(dr.GetOrdinal("DIRECCION")),
                    CELULAR = dr.GetString(dr.GetOrdinal("CELULAR")),
                    CANT_COMPRAS = dr.GetInt32(dr.GetOrdinal("CANT_COMPRAS")),
                    IMPORTE = dr.GetDecimal(dr.GetOrdinal("IMPORTE"))
                };
                lista_proveedores.Add(proveedor);
            }
            return lista_proveedores;
        }*/

        /*public Proveedor Cargar_Proveedor(string rtn)
        {
            using SqlConnection con = conexion.AbrirConexion();
            string query = @"SELECT  * 
                             FROM    TBL_PROVEEDORES 
                             WHERE   RTN = @RTN";
            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@RTN", rtn);
            using SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return new Proveedor
                {
                    ID_PROVEEDOR = dr.GetInt32(dr.GetOrdinal("ID_PROVEEDOR")),
                    RTN = dr.GetString(dr.GetOrdinal("RTN")),
                    NOMBRE = dr.GetString(dr.GetOrdinal("NOMBRE")),
                    DIRECCION = dr.GetString(dr.GetOrdinal("DIRECCION")),
                    CELULAR = dr.GetString(dr.GetOrdinal("CELULAR")),
                    CANT_COMPRAS = dr.GetInt32(dr.GetOrdinal("CANT_COMPRAS")),
                    IMPORTE = dr.GetDecimal(dr.GetOrdinal("IMPORTE"))
                };
            }
            return null;
        }*/

       /* public string Obtener_Nombre_Proveedor()
        {
            using SqlConnection con = conexion.AbrirConexion();
            string query = @"SELECT  NOMBRE 
                             FROM    TBL_PROVEEDORES";
            using SqlCommand cmd = new SqlCommand(query, con);
            return cmd.ExecuteScalar()?.ToString() ?? string.Empty;
        }*/