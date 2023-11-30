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

            // Utiliza tu clase de conexión para abrir una conexión a la base de datos.
            var conexionSql = new ConexionSql();
            using (SqlConnection conexion = conexionSql.AbrirConexion())
            {
                // La consulta SQL verifica si existe un usuario con el nombre de usuario y la contraseña dada.
                // NOTA: En un escenario de producción, deberías tener las contraseñas hasheadas y no hacer una comparación directa.
                string query = "SELECT COUNT(1) FROM CatalogoUsuarios WHERE NombreUsuario = @username AND Contraseña = @password";

                // Crear un SqlCommand utilizando la conexión y la consulta.
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    // Agrega los parámetros para evitar la inyección SQL.
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // Asegúrate de hashear la contraseña en la aplicación real.

                    // Ejecuta la consulta y verifica si obtuviste algún resultado.
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Si userCount es mayor que 0, significa que existe el usuario.
                    if (userCount > 0)
                    {
                        // Usuario y contraseña correctos.
                        // Aquí pondrías el código para dirigir al usuario al MenuPrincipal.
                        MD menu = new MD(); // Asumiendo que tienes una forma llamada MenuPrincipal.
                        this.Hide();
                        menu.Show();
                    }
                    else
                    {
                        // Usuario o contraseña incorrectos.
                        MessageBox.Show("El usuario o la contraseña son incorrectos.");
                    }
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
