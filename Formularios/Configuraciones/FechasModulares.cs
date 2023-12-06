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
    public partial class FechasModulares : Form
    {
        public FechasModulares()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CargarDatos()
        {
            string query = "SELECT IdFecha, FechaInicio, FechaFin, Descripcion FROM FechasModulares";
            ConexionSql conexionSql = new();

            try
            {
                using SqlCommand command = new(query, conexionSql.AbrirConexion());
                using SqlDataAdapter adapter = new(command);
                DataTable table = new();
                adapter.Fill(table);
                dtgFechasModulares.DataSource = table;
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

        private void AjustarDgv()
        {

            dtgFechasModulares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgFechasModulares.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgFechasModulares.AllowUserToAddRows = false;
            dtgFechasModulares.AllowUserToDeleteRows = false;
            dtgFechasModulares.AllowUserToResizeColumns = false;
            dtgFechasModulares.AllowUserToResizeRows = false;
            dtgFechasModulares.MultiSelect = false;
            dtgFechasModulares.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FechasModulares_Load(object sender, EventArgs e)
        {
            CargarDatos();
            AjustarDgv();
        }
        private void LimpiarCampos()
        {
            dateTimePickerInicio.Value = DateTime.Now;
            dateTimePickerFin.Value = DateTime.Now;
            textBoxDescripcion.Clear();


        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {

        }

        private void DtgFechasModulares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGrid
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = this.dtgFechasModulares.Rows[e.RowIndex];

                // Mostrar los valores de las columnas seleccionadas en los campos correspondientes
                textBoxId.Text = row.Cells["IdFecha"].Value.ToString();
                dateTimePickerInicio.Text = row.Cells["FechaInicio"].Value.ToString();
                dateTimePickerFin.Text = row.Cells["FechaFin"].Value.ToString();
                textBoxDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Obtén los valores de los controles TextBox de tu formulario
            string FechaInicio = dateTimePickerInicio.Value.ToString();
            string FechaFin = dateTimePickerInicio.Value.ToString();
            string descripcion = textBoxDescripcion.Text.Trim();

            // Verifica que los campos necesarios estén llenos
            if (string.IsNullOrEmpty(FechaInicio) || string.IsNullOrEmpty(FechaFin) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Por favor, complete todos los campos necesarios.");
                return;
            }

            // Utiliza tu clase ConexionSql para obtener la conexión
            ConexionSql conexionSql = new();

            // Define la consulta SQL para insertar los datos
            string query = "INSERT INTO FechasModulares (FechaInicio, FechaFin, Descripcion) VALUES (@FechaInicio, @FechaFin, @Descripcion)";

            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
            // Agrega los parámetros al comando para evitar la inyección SQL
            command.Parameters.AddWithValue("@FechaInicio", FechaInicio);
            command.Parameters.AddWithValue("@FechaFin", FechaFin);
            command.Parameters.AddWithValue("@Descripcion", descripcion);

            try
            {
                // Ejecuta el comando y verifica el resultado
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Fecha Modular guardada con éxito.");
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
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show("Por favor, seleccione un registro para actualizar.");
                return;
            }

            if (!int.TryParse(textBoxId.Text, out int idFechaModular))
            {
                MessageBox.Show("El ID de Fecha Modular proporcionado no es válido.");
                return;
            }

            DateTime fechaInicio = dateTimePickerInicio.Value;
            DateTime fechaFin = dateTimePickerFin.Value;
            string descripcion = textBoxDescripcion.Text;

            string query = "UPDATE FechasModulares SET FechaInicio = @FechaInicio, FechaFin = @FechaFin, Descripcion = @Descripcion WHERE IdFecha = @IdFecha";

            ConexionSql conexionSql = new();
            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
            command.Parameters.AddWithValue("@IdFecha", idFechaModular);
            command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
            command.Parameters.AddWithValue("@FechaFin", fechaFin);
            command.Parameters.AddWithValue("@Descripcion", descripcion);

            try
            {
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Registro actualizada con éxito.");
                    CargarDatos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró la fecha modular o no se necesitó actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la fecha modular: " + ex.Message);
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

            if (!int.TryParse(textBoxId.Text, out int idFecha))
            {
                MessageBox.Show("El ID de cuenta proporcionado no es válido.");
                return;
            }

            // Pedir confirmación antes de eliminar
            if (MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE FROM FechasModulares WHERE idFecha = @idFecha";

                ConexionSql conexionSql = new();
                using SqlConnection conexion = conexionSql.AbrirConexion();
                using SqlCommand command = new(query, conexion);
                command.Parameters.AddWithValue("@idFecha", idFecha);

                try
                {
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Registro eliminada con éxito.");
                        CargarDatos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
            }
        }
    }
}
