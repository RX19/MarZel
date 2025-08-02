using System.Data;
using System.Data.SqlClient;

namespace Prototipo_MarZel
{
    public class Cliente_DAO : Cliente_Base
    {
        public override DataTable Cargar_Clientes()
        {
            ConexionBD conexion = new ConexionBD();
            string query = $"SELECT * FROM {Tabla}";
            return conexion.EjecutarConsulta(query, null);
        }

        public override void Eliminar_Cliente(int Id_Cliente)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @$"
                DELETE FROM {Tabla}
                WHERE ID_CLIENTE = @ID_CLIENTE";
            SqlParameter[] parametros =
            {
                new SqlParameter("ID_CLIENTE", Id_Cliente)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override DataTable Buscar_En_Clientes(string filtro)
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

        public override void Agregar_Cliente(string RTN, string Nombre, string Direccion, string Celular, int Cant_Compras, decimal Importe)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                INSERT INTO TBL_CLIENTES (
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

        public override void Modificar_Cliente(int Id_Cliente, string RTN, string Nombre, string Direccion, string Celular)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                UPDATE TBL_CLIENTES 
                SET RTN = @RTN,
                    NOMBRE = @NOMBRE,
                    DIRECCION = @DIRECCION,
                    CELULAR = @CELULAR
                WHERE ID_CLIENTE = @ID_CLIENTE";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_CLIENTE", Id_Cliente),
                new SqlParameter("@RTN", RTN),
                new SqlParameter("@NOMBRE", Nombre),
                new SqlParameter("@DIRECCION", Direccion),
                new SqlParameter("@CELULAR", Celular)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override void Modificar_Cliente(int Id_Cliente, string RTN, string Nombre, string Direccion, string Celular, int Cant_Compras, decimal Importe)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                UPDATE TBL_CLIENTES 
                SET RTN = @RTN,
                    NOMBRE = @NOMBRE,
                    DIRECCION = @DIRECCION,
                    CELULAR = @CELULAR,
                    CANT_COMPRAS = @CANT_COMPRAS,
                    IMPORTE = @IMPORTE
                WHERE ID_CLIENTE = @ID_CLIENTE";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_CLIENTE", Id_Cliente),
                new SqlParameter("@RTN", RTN),
                new SqlParameter("@NOMBRE", Nombre),
                new SqlParameter("@DIRECCION", Direccion),
                new SqlParameter("@CELULAR", Celular),
                new SqlParameter("@CANT_COMPRAS", Cant_Compras),
                new SqlParameter("@IMPORTE", Importe)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override DataTable Cargar_Cliente(int Id_Cliente)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @$"
                SELECT  *
                FROM    {Tabla}
                WHERE   ID_CLIENTE = @ID_CLIENTE";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_CLIENTE", Id_Cliente)
            };
            return conexion.EjecutarConsulta(query, parametros);
        }

        public override DataTable Cargar_Cliente(string RTN)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @$"
                SELECT  *
                FROM    {Tabla}
                WHERE   RTN = @RTN";
            SqlParameter[] parametros =
            {
                new SqlParameter("@RTN", RTN)
            };
            return conexion.EjecutarConsulta(query, parametros);
        }

        public override bool Existe_RTN(string RTN)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT  1 
                FROM    TBL_CLIENTES 
                WHERE RTN = @RTN";
            SqlParameter[] parametros =
            {
                new SqlParameter("@RTN", RTN)
            };
            DataTable resultado = conexion.EjecutarConsulta(query, parametros);
            return resultado.Rows.Count > 0;
        }
    }
}