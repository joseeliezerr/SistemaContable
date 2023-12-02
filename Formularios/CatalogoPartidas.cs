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

namespace SistemaContable.Formularios
{
    public partial class CatalogoPartidas : Form
    {
        public CatalogoPartidas()
        {
            InitializeComponent();
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            textBoxId.Clear();
            comboBoxtipoPartida.SelectedItem = null;
            textBoxDescripcion.Clear();
        }

        private void CargarDatos()
        {
            string query = "SELECT IdPartida, Descripcion, TipoPartida FROM CatalogoPartidas";
            ConexionSql conexionSql = new();

            try
            {
                using SqlCommand command = new(query, conexionSql.AbrirConexion());
                using SqlDataAdapter adapter = new(command);
                DataTable table = new();
                adapter.Fill(table);
                dtgCatalogoPartidas.DataSource = table;
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
        private void AjustarDtagridview()
        {
            // Asumiendo que 'dataGridViewCategorias' es el nombre de tu DataGridView
            dtgCatalogoPartidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCatalogoPartidas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgCatalogoPartidas.AllowUserToAddRows = false;
            dtgCatalogoPartidas.AllowUserToDeleteRows = false;
            dtgCatalogoPartidas.AllowUserToResizeColumns = false;
            dtgCatalogoPartidas.AllowUserToResizeRows = false;
            dtgCatalogoPartidas.MultiSelect = false;
            dtgCatalogoPartidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Obtén los valores de los controles TextBox de tu formulario

            string tipoPartida = comboBoxtipoPartida.Text.Trim();
            string descripcion = textBoxDescripcion.Text.Trim();

            // Verifica que los campos necesarios estén llenos
            if (string.IsNullOrEmpty(tipoPartida) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Por favor, complete todos los campos necesarios.");
                return;
            }

            // Utiliza tu clase ConexionSql para obtener la conexión
            ConexionSql conexionSql = new();

            // Define la consulta SQL para insertar los datos
            string query = "INSERT INTO CatalogoPartidas (Descripcion, TipoPartida) VALUES (@Descripcion, @TipoPartida)";

            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
            // Agrega los parámetros al comando para evitar la inyección SQL
            command.Parameters.AddWithValue("@Descripcion", descripcion);
            command.Parameters.AddWithValue("@TipoPartida", tipoPartida);


            try
            {
                // Ejecuta el comando y verifica el resultado
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Partida contable guardada con éxito.");
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

        private void CatalogoPartidas_Load(object sender, EventArgs e)
        {
            CargarDatos();
            AjustarDtagridview();
        }

        private void dtgCatalogoPartidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGrid
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = this.dtgCatalogoPartidas.Rows[e.RowIndex];

                // Mostrar los valores de las columnas seleccionadas en los campos correspondientes
                textBoxId.Text = row.Cells["IdPartida"].Value.ToString();
                comboBoxtipoPartida.Text = row.Cells["TipoPartida"].Value.ToString();
                textBoxDescripcion.Text = row.Cells["Descripcion"].Value.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un registro (puedes ajustar esta parte según cómo determines qué registro está seleccionado)
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show("Por favor, seleccione un registro para actualizar.");
                return;
            }

            if (!int.TryParse(textBoxId.Text, out int idPartida))
            {
                MessageBox.Show("El ID de cuenta proporcionado no es válido.");
                return;
            }


            string tipoPartida = comboBoxtipoPartida.Text;
            string descripcion = textBoxDescripcion.Text;

            string query = "UPDATE CatalogoPartidas SET Descripcion = @Descripcion, TipoPartida = @TipoPartida WHERE IdPartida = @IdPartida";

            ConexionSql conexionSql = new();
            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
            command.Parameters.AddWithValue("@IdPartida", idPartida);
            command.Parameters.AddWithValue("@Descripcion", descripcion);
            command.Parameters.AddWithValue("@TipoPartida", tipoPartida);


            try
            {
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Partida contable actualizada con éxito.");
                    CargarDatos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró la Partida contable o no se necesitó actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la Partida contable: " + ex.Message);
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

            if (!int.TryParse(textBoxId.Text, out int idCuenta))
            {
                MessageBox.Show("El ID de la partida proporcionado no es válido.");
                return;
            }

            // Pedir confirmación antes de eliminar
            if (MessageBox.Show("¿Está seguro de que desea eliminar esta Partida contable?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE FROM CatalogoPartidas WHERE IdPartida = @IdPartida";

                ConexionSql conexionSql = new();
                using SqlConnection conexion = conexionSql.AbrirConexion();
                using SqlCommand command = new(query, conexion);
                command.Parameters.AddWithValue("@IdPartida", idCuenta);

                try
                {
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Partida contable eliminada con éxito.");
                        CargarDatos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la Partida contable.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la Partida contable: " + ex.Message);
                }
            }

        }
    }
}
