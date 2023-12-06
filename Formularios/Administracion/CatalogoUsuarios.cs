using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaContable.Formularios.Administracion
{
    public partial class CatalogoUsuarios : Form
    {
        public CatalogoUsuarios()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            textBoxId.Clear();
            textBoxUsuario.Clear();
            textBoxPass.Clear();
            comboBoxRol.SelectedItem = null;
        }

        private void CatalogoUsuarios_Load(object sender, EventArgs e)
        {
            AjustarDgv();
            CargarDatos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén los valores de los controles TextBox de tu formulario
            string NombreUsuario = textBoxUsuario.Text.Trim();
            string Rol = comboBoxRol.Text.Trim();
            string Contraseña = textBoxPass.Text.Trim();

            // Verifica que los campos necesarios estén llenos
            if (string.IsNullOrEmpty(NombreUsuario) || string.IsNullOrEmpty(Contraseña) || string.IsNullOrEmpty(Rol))
            {
                MessageBox.Show("Por favor, complete todos los campos necesarios.");
                return;
            }

            // Utiliza tu clase ConexionSql para obtener la conexión
            ConexionSql conexionSql = new();

            // Define la consulta SQL para insertar los datos
            string query = "INSERT INTO CatalogoUsuarios (NombreUsuario, Contraseña, Rol) VALUES (@NombreUsuario, @Contraseña, @Rol)";

            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
            // Agrega los parámetros al comando para evitar la inyección SQL
            command.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
            command.Parameters.AddWithValue("@Contraseña", Contraseña);
            command.Parameters.AddWithValue("@Rol", Rol);

            try
            {
                // Ejecuta el comando y verifica el resultado
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Usuario guardada con éxito.");
                    CargarDatos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se insertaron registros.");
                }
            }
            catch (SqlException ex)
            {
                // Maneja cualquier excepción durante el proceso de inserción
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AjustarDgv()
        {

            dtgCatalogoUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCatalogoUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgCatalogoUsuarios.AllowUserToAddRows = false;
            dtgCatalogoUsuarios.AllowUserToDeleteRows = false;
            dtgCatalogoUsuarios.AllowUserToResizeColumns = false;
            dtgCatalogoUsuarios.AllowUserToResizeRows = false;
            dtgCatalogoUsuarios.MultiSelect = false;
            dtgCatalogoUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void CargarDatos()
        {
            string query = "SELECT IdUsuario, NombreUsuario, Contraseña, Rol FROM CatalogoUsuarios";
            ConexionSql conexionSql = new();

            try
            {
                using SqlCommand command = new(query, conexionSql.AbrirConexion());
                using SqlDataAdapter adapter = new(command);
                DataTable table = new();
                adapter.Fill(table);
                dtgCatalogoUsuarios.DataSource = table;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
            }
            finally
            {

                conexionSql.CerrarConexion();
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un registro (puedes ajustar esta parte según cómo determines qué registro está seleccionado)
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show("Por favor, seleccione un registro para actualizar.");
                return;
            }

            if (!int.TryParse(textBoxId.Text, out int IdUsuario))
            {
                MessageBox.Show("El ID del usuario proporcionado no es válido.");
                return;
            }

            string NombreUsuario = textBoxUsuario.Text.Trim();
            string Rol = comboBoxRol.Text.Trim();
            string Contraseña = textBoxPass.Text.Trim();

            string query = "UPDATE CatalogoUsuarios SET NombreUsuario = @NombreUsuario, Contraseña = @Contraseña, Rol = @Rol WHERE IdUsuario = @IdUsuario";

            ConexionSql conexionSql = new();
            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
            command.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            command.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
            command.Parameters.AddWithValue("@Contraseña", Contraseña);
            command.Parameters.AddWithValue("@Rol", Rol);

            try
            {
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Usuario actualizada con éxito.");
                    CargarDatos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario o no se necesitó actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la cuenta contable: " + ex.Message);
            }
        }

        private void dtgCatalogoUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGrid
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = this.dtgCatalogoUsuarios.Rows[e.RowIndex];

                // Mostrar los valores de las columnas seleccionadas en los campos correspondientes
                textBoxId.Text = row.Cells["IdUsuario"].Value.ToString();
                textBoxUsuario.Text = row.Cells["NombreUsuario"].Value.ToString();
                textBoxPass.Text = row.Cells["Contraseña"].Value.ToString();
                comboBoxRol.Text = row.Cells["Rol"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un registro
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show("Por favor, seleccione un registro para eliminar.");
                return;
            }

            if (!int.TryParse(textBoxId.Text, out int IdUsuario))
            {
                MessageBox.Show("El ID de cuenta proporcionado no es válido.");
                return;
            }

            // Pedir confirmación antes de eliminar
            if (MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE FROM CatalogoUsuarios WHERE IdUsuario = @IdUsuario";

                ConexionSql conexionSql = new();
                using SqlConnection conexion = conexionSql.AbrirConexion();
                using SqlCommand command = new(query, conexion);
                command.Parameters.AddWithValue("@IdUsuario", IdUsuario);

                try
                {
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Usuario eliminada con éxito.");
                        CargarDatos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar usuario: " + ex.Message);
                }
            }
        }
    }
}
