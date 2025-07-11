using System.Data;
using System.Data.SqlClient;
using Prototipo_MarZel;

public class ClienteDAO
{
    private readonly ConexionBD conexion = new ConexionBD();

    public model_cliente BuscarPorRTN(string rtn)
    {
        string query = "SELECT RTN, Nombre, Direccion, Celular FROM TBL_Cliente WHERE RTN = @RTN";
        using (SqlConnection conn = conexion.AbrirConexion())
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@RTN", rtn);
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count == 0) return null;

                var row = dt.Rows[0];
                return new model_cliente
                {
                    RTN = row["RTN"]?.ToString(),
                    Nombre = row["Nombre"]?.ToString(),
                    Direccion = row["Direccion"]?.ToString(),
                    Celular = row["Celular"]?.ToString()
                };
            }
        }
    }

    public bool ModificarCliente(model_cliente cliente) 
    {
        string query = "UPDATE TBL_Cliente SET Nombre = @Nombre, Direccion = @Direccion, Celular = @Celular WHERE RTN = @RTN";
        using (SqlConnection conn = conexion.AbrirConexion())
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@RTN", cliente.RTN);
            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
            cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
            return cmd.ExecuteNonQuery() > 0;
        }
    }

    public bool ClienteExiste(string rtn)
    {
        string query = "SELECT COUNT(1) FROM dbo.Clientes WHERE RTN = @RTN";
        using (SqlConnection conn = conexion.AbrirConexion())
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@RTN", rtn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
    }
}