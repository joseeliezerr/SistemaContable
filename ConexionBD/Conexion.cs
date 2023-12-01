using Microsoft.Data.SqlClient;

public class ConexionSql
{
    private readonly string connectionString;
    private SqlConnection conexion;

    public ConexionSql()
    {
        connectionString = "SERVER=JRIVERAPC\\SQLEXPRESS;DATABASE=SistemaContable;integrated security=true;TrustServerCertificate=True;";
    }

    public SqlConnection AbrirConexion()
    {
        if (conexion == null || conexion.State == System.Data.ConnectionState.Closed)
        {
            conexion = new SqlConnection(connectionString);
            conexion.Open();
        }

        return conexion;
    }

    public void CerrarConexion()
    {
        if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
        {
            conexion.Close();
        }
    }
}

