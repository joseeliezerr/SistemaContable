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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaContable.Formularios.Administracion
{
    public partial class CatalogoClientesProveedores : Form
    {
        public CatalogoClientesProveedores()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBoxUsuario.Clear();
            textBoxDireccion.Clear();
            textBoxEmail.Clear();
            textBoxTelefono.Clear();
            comboBoxTipo.SelectedItem = null;

        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Obtén los valores de los controles TextBox de tu formulario
            string Nombre = textBoxUsuario.Text.Trim();
            string Direccion = textBoxDireccion.Text.Trim();
            string Telefono = textBoxTelefono.Text.Trim();
            string Email = textBoxEmail.Text.Trim();
            string Tipo = comboBoxTipo.Text.Trim();

            // Verifica que los campos necesarios estén llenos
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Tipo))
            {
                MessageBox.Show("Por favor, complete todos los campos necesarios.");
                return;
            }

            // Utiliza tu clase ConexionSql para obtener la conexión
            ConexionSql conexionSql = new();

            // Define la consulta SQL para insertar los datos
            string query = "INSERT INTO ClientesProveedores (Nombre, Direccion, Telefono,Email,Tipo) VALUES (@Nombre, @Direccion, @Telefono,@Email,@Tipo)";

            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
           
            command.Parameters.AddWithValue("@Nombre", Nombre);
            command.Parameters.AddWithValue("@Direccion", Direccion);
            command.Parameters.AddWithValue("@Telefono", Telefono);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Tipo", Tipo);

            try
            {
                // Ejecuta el comando y verifica el resultado
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Cliente o proveedor guardada con éxito.");
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

        private void Button2_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un registro (puedes ajustar esta parte según cómo determines qué registro está seleccionado)
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, seleccione un registro para actualizar.");
                return;
            }

            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("El ID de cuenta proporcionado no es válido.");
                return;
            }

            string Nombre = textBoxUsuario.Text.Trim();
            string Direccion = textBoxDireccion.Text.Trim();
            string Telefono = textBoxTelefono.Text.Trim();
            string Email = textBoxEmail.Text.Trim();
            string Tipo = comboBoxTipo.Text.Trim();

            string query = "UPDATE CatalogoContable SET Nombre = @Nombre, Direccion = @Direccion, Telefono = @Telefono, Email=@Email,Tipo=@Tipo WHERE IdClienteProveedor = @IdClienteProveedor";

            ConexionSql conexionSql = new();
            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
            command.Parameters.AddWithValue("@Nombre", Nombre);
            command.Parameters.AddWithValue("@Direccion", Direccion);
            command.Parameters.AddWithValue("@Telefono", Telefono);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Tipo", Tipo);

            try
            {
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Clientes o Proveedores actualizada con éxito.");
                    CargarDatos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró el registro o no se necesitó actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un registro
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, seleccione un registro para eliminar.");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int IdClienteProveedor))
            {
                MessageBox.Show("El ID del Cliente o Proveedor no es válido.");
                return;
            }

            // Pedir confirmación antes de eliminar
            if (MessageBox.Show("¿Está seguro de que desea eliminar este cliente o proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE FROM ClientesProveedores WHERE IdClienteProveedor = @IdClienteProveedor";

                ConexionSql conexionSql = new();
                using SqlConnection conexion = conexionSql.AbrirConexion();
                using SqlCommand command = new(query, conexion);
                command.Parameters.AddWithValue("@IdClienteProveedor", IdClienteProveedor);

                try
                {
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Cliente o Proveedor eliminada con éxito.");
                        CargarDatos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente o proveedor.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
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
            string query = "SELECT IdClienteProveedor, Nombre, Direccion, Telefono,Email,Tipo FROM ClientesProveedores";
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
                // Aquí deberías manejar la excepción, posiblemente registrándola o mostrando un mensaje al usuario
                MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
            }
            finally
            {
                // Asegúrate de cerrar la conexión cuando hayas terminado
                conexionSql.CerrarConexion();
            }
        }
        private void CatalogoClientesProveedores_Load(object sender, EventArgs e)
        {
            CargarDatos();
            AjustarDgv();
        }

        private void DtgCatalogoUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGrid
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = this.dtgCatalogoUsuarios.Rows[e.RowIndex];

                // Mostrar los valores de las columnas seleccionadas en los campos correspondientes
                textBox1.Text = row.Cells["IdClienteProveedor"].Value.ToString();
                textBoxUsuario.Text = row.Cells["Nombre"].Value.ToString();
                textBoxDireccion.Text = row.Cells["Direccion"].Value.ToString();
                textBoxTelefono.Text = row.Cells["Telefono"].Value.ToString();
                textBoxEmail.Text = row.Cells["Email"].Value.ToString();
                comboBoxTipo.Text = row.Cells["Tipo"].Value.ToString();
            }
        }
    }
}
