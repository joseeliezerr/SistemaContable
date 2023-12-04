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
    public partial class CatalogoTransacciones : Form
    {
        public CatalogoTransacciones()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            textBoxId.Clear();
            dateTimePickerFecha.Value = DateTime.Now;
            textBoxDescripcion.Clear();
            comboBoxtipoTransaccion.SelectedItem = null;
        }

        private void CargarDatos()
        {
            string query = "SELECT IdTransaccion, Fecha, TipoTransaccion, Descripcion FROM CatalogoTransacciones";
            ConexionSql conexionSql = new();

            try
            {
                using SqlCommand command = new(query, conexionSql.AbrirConexion());
                using SqlDataAdapter adapter = new(command);
                DataTable table = new();
                adapter.Fill(table);
                dtgCatalogoTransacciones.DataSource = table;
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

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePickerFecha.Value;
            string tipoTransaccion = comboBoxtipoTransaccion.Text.Trim();
            string descripcion = textBoxDescripcion.Text.Trim();

            // Verifica que los campos necesarios estén llenos
            if (string.IsNullOrEmpty(tipoTransaccion) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Por favor, complete todos los campos necesarios.");
                return;
            }

            // Utiliza tu clase ConexionSql para obtener la conexión
            ConexionSql conexionSql = new();

            // Define la consulta SQL para insertar los datos
            string query = "INSERT INTO CatalogoTransacciones (Fecha, TipoTransaccion, Descripcion) VALUES (@Fecha, @TipoTransaccion, @Descripcion)";

            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
            // Agrega los parámetros al comando para evitar la inyección SQL
            command.Parameters.AddWithValue("@Fecha", fecha); // Aquí se pasa el objeto DateTime directamente
            command.Parameters.AddWithValue("@TipoTransaccion", tipoTransaccion);
            command.Parameters.AddWithValue("@Descripcion", descripcion);

            try
            {
                // Ejecuta el comando y verifica el resultado
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Transacción guardada con éxito.");
                    CargarDatos();  // Asumiendo que este método recarga los datos en algún control de la interfaz de usuario
                    Limpiar(); // Asumiendo que este método limpia los campos después de guardar
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

            dtgCatalogoTransacciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCatalogoTransacciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgCatalogoTransacciones.AllowUserToAddRows = false;
            dtgCatalogoTransacciones.AllowUserToDeleteRows = false;
            dtgCatalogoTransacciones.AllowUserToResizeColumns = false;
            dtgCatalogoTransacciones.AllowUserToResizeRows = false;
            dtgCatalogoTransacciones.MultiSelect = false;
            dtgCatalogoTransacciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CatalogoTransacciones_Load(object sender, EventArgs e)
        {
            CargarDatos();
            AjustarDgv();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un registro 
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show("Por favor, seleccione un registro para actualizar.");
                return;
            }

            if (!int.TryParse(textBoxId.Text, out int idTransaccion))
            {
                MessageBox.Show("El ID de Catalogo Transaccion no es válido.");
                return;
            }

            DateTime Fecha = dateTimePickerFecha.Value;
            string TipoTransaccion = comboBoxtipoTransaccion.Text;
            string Descripcion = textBoxDescripcion.Text;

            string query = "UPDATE CatalogoTransacciones SET Fecha = @Fecha, TipoTransaccion = @TipoTransaccion, Descripcion = @Descripcion WHERE IdTransaccion = @IdTransaccion";

            ConexionSql conexionSql = new();
            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
            command.Parameters.AddWithValue("@IdTransaccion", idTransaccion);
            command.Parameters.AddWithValue("@Fecha", Fecha);
            command.Parameters.AddWithValue("@TipoTransaccion", TipoTransaccion);
            command.Parameters.AddWithValue("@Descripcion", Descripcion);

            try
            {
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Catalogo de transaccion actualizada con éxito.");
                    CargarDatos();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se encontró el catalogo de transaccion o no se necesitó actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el catalogo de transaccion: " + ex.Message);
            }
        }

        private void DtgCatalogoContable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGrid
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = this.dtgCatalogoTransacciones.Rows[e.RowIndex];

                // Mostrar los valores de las columnas seleccionadas en los campos correspondientes
                textBoxId.Text = row.Cells["IdTransaccion"].Value.ToString();
                dateTimePickerFecha.Text = row.Cells["Fecha"].Value.ToString();
                comboBoxtipoTransaccion.Text = row.Cells["TipoTransaccion"].Value.ToString();
                textBoxDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
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

            if (!int.TryParse(textBoxId.Text, out int IdCatalogoTransaccion))
            {
                MessageBox.Show("El ID del Catalogo de transaccion proporcionado no es válido.");
                return;
            }

            // Pedir confirmación antes de eliminar
            if (MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE FROM CatalogoTransacciones WHERE IdTransaccion = @IdCatalogoTransaccion";

                ConexionSql conexionSql = new();
                using SqlConnection conexion = conexionSql.AbrirConexion();
                using SqlCommand command = new(query, conexion);
                command.Parameters.AddWithValue("@IdCatalogoTransaccion", IdCatalogoTransaccion);

                try
                {
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Catalogo de Transaccion eliminada con éxito.");
                        CargarDatos();
                        Limpiar();
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
