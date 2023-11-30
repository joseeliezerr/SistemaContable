using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SistemaContable.Formularios;

namespace SistemaContable
{
    public partial class Login : Form
    {
        ConexionSql conexionSql;

        public Login()
        {
            InitializeComponent();
            conexionSql = new ConexionSql();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpass.Text;

            // Utiliza tu clase de conexi�n para abrir una conexi�n a la base de datos.
            var conexionSql = new ConexionSql();
            using (SqlConnection conexion = conexionSql.AbrirConexion())
            {
                // La consulta SQL verifica si existe un usuario con el nombre de usuario y la contrase�a dada.
                // NOTA: En un escenario de producci�n, deber�as tener las contrase�as hasheadas y no hacer una comparaci�n directa.
                string query = "SELECT COUNT(1) FROM CatalogoUsuarios WHERE NombreUsuario = @username AND Contrase�a = @password";

                // Crear un SqlCommand utilizando la conexi�n y la consulta.
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    // Agrega los par�metros para evitar la inyecci�n SQL.
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // Aseg�rate de hashear la contrase�a en la aplicaci�n real.

                    // Ejecuta la consulta y verifica si obtuviste alg�n resultado.
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Si userCount es mayor que 0, significa que existe el usuario.
                    if (userCount > 0)
                    {
                        // Usuario y contrase�a correctos.
                        // Aqu� pondr�as el c�digo para dirigir al usuario al MenuPrincipal.
                        MD menu = new MD(); // Asumiendo que tienes una forma llamada MenuPrincipal.
                        this.Hide();
                        menu.Show();
                    }
                    else
                    {
                        // Usuario o contrase�a incorrectos.
                        MessageBox.Show("El usuario o la contrase�a son incorrectos.");
                    }
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
