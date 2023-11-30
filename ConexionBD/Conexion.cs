using Microsoft.Data.SqlClient;

public class ConexionSql
{
    private readonly string connectionString;
    private SqlConnection conexion;

    public ConexionSql()
    {
        // Agregar TrustServerCertificate=True; para evitar la verificación del certificado SSL.
        connectionString = "SERVER=JRIVERAPC\\SQLEXPRESS;DATABASE=SistemaContable;integrated security=true;TrustServerCertificate=True;";
    }

    public SqlConnection AbrirConexion()
    {
        if (conexion == null)
        {
            conexion = new SqlConnection(connectionString);
        }

        if (conexion.State != System.Data.ConnectionState.Open)
        {
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
