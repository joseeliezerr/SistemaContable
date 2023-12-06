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

namespace SistemaContable.Formularios.Configuraciones
{
    public partial class PeriodosContables : Form
    {
        public PeriodosContables()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            textBoxId.Clear();
            dateTimePickerInicio.Value = DateTime.Now;
            dateTimePickerFin.Value = DateTime.Now;
            comboBoxEstado.SelectedItem = null;

        }
        private void CargarDatos()
        {
            string query = "SELECT IdPeriodo, FechaInicio, FechaFin, Estado FROM PeriodosContables";
            ConexionSql conexionSql = new();

            try
            {
                using SqlCommand command = new(query, conexionSql.AbrirConexion());
                using SqlDataAdapter adapter = new(command);
                DataTable table = new();
                adapter.Fill(table);
                dtgPeriodosContables.DataSource = table;
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
        private void AjustarDtgv()
        {

            dtgPeriodosContables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgPeriodosContables.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgPeriodosContables.AllowUserToAddRows = false;
            dtgPeriodosContables.AllowUserToDeleteRows = false;
            dtgPeriodosContables.AllowUserToResizeColumns = false;
            dtgPeriodosContables.AllowUserToResizeRows = false;
            dtgPeriodosContables.MultiSelect = false;
            dtgPeriodosContables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Obtén los valores de los controles TextBox de tu formulario
            string FechaInicio = dateTimePickerInicio.Value.ToString();
            string FechaFin = dateTimePickerInicio.Value.ToString();
            string Estado = comboBoxEstado.Text.Trim();

            // Verifica que los campos necesarios estén llenos
            if (string.IsNullOrEmpty(FechaInicio) || string.IsNullOrEmpty(FechaFin) || string.IsNullOrEmpty(Estado))
            {
                MessageBox.Show("Por favor, complete todos los campos necesarios.");
                return;
            }

            // Utiliza tu clase ConexionSql para obtener la conexión
            ConexionSql conexionSql = new();

            // Define la consulta SQL para insertar los datos
            string query = "INSERT INTO PeriodosContables (FechaInicio, FechaFin, Estado) VALUES (@FechaInicio, @FechaFin, @Estado)";

            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
            // Agrega los parámetros al comando para evitar la inyección SQL
            command.Parameters.AddWithValue("@FechaInicio", FechaInicio);
            command.Parameters.AddWithValue("@FechaFin", FechaFin);
            command.Parameters.AddWithValue("@Estado", Estado);

            try
            {
                // Ejecuta el comando y verifica el resultado
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Periodo contable guardada con éxito.");
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

        private void PeriodosContables_Load(object sender, EventArgs e)
        {
            CargarDatos();
            AjustarDtgv();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un registro (puedes ajustar esta parte según cómo determines qué registro está seleccionado)
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show("Por favor, seleccione un registro para actualizar.");
                return;
            }

            if (!int.TryParse(textBoxId.Text, out int idPeriodo))
            {
                MessageBox.Show("El ID del Periodo Contable proporcionado no es válido.");
                return;
            }

            DateTime FechaInicio = dateTimePickerInicio.Value;
            DateTime FechaFin = dateTimePickerFin.Value;
            string Estado = comboBoxEstado.Text;

            string query = "UPDATE PeriodosContables SET FechaInicio = @FechaInicio, FechaFin = @FechaFin, Estado = @Estado WHERE idPeriodo = @idPeriodo";

            ConexionSql conexionSql = new();
            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
            command.Parameters.AddWithValue("@idPeriodo", idPeriodo);
            command.Parameters.AddWithValue("@FechaInicio", FechaInicio);
            command.Parameters.AddWithValue("@FechaFin", FechaFin);
            command.Parameters.AddWithValue("@Estado", Estado);

            try
            {
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Periodo contable actualizada con éxito.");
                    CargarDatos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró el periodo contable o no se necesitó actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la cuenta contable: " + ex.Message);
            }
        }

        private void DtgPeriodosContables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGrid
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = this.dtgPeriodosContables.Rows[e.RowIndex];

                // Mostrar los valores de las columnas seleccionadas en los campos correspondientes
                textBoxId.Text = row.Cells["IdPeriodo"].Value.ToString();
                dateTimePickerInicio.Text = row.Cells["FechaInicio"].Value.ToString();
                dateTimePickerFin.Text = row.Cells["FechaFin"].Value.ToString();
                comboBoxEstado.Text = row.Cells["Estado"].Value.ToString();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un registro
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show("Por favor, seleccione un registro para eliminar.");
                return;
            }

            if (!int.TryParse(textBoxId.Text, out int idPeriodo))
            {
                MessageBox.Show("El ID del Periodo proporcionado no es válido.");
                return;
            }

            // Pedir confirmación antes de eliminar
            if (MessageBox.Show("¿Está seguro de que desea eliminar este Periodo contable?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE FROM PeriodosContables WHERE idPeriodo = @idPeriodo";

                ConexionSql conexionSql = new();
                using SqlConnection conexion = conexionSql.AbrirConexion();
                using SqlCommand command = new(query, conexion);
                command.Parameters.AddWithValue("@idPeriodo", idPeriodo);

                try
                {
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Periodo contable eliminada con éxito.");
                        CargarDatos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el Periodo contable.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el periodo contable: " + ex.Message);
                }
            }
        }
    }
}
