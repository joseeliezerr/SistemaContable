using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaContable.Formularios.Historicos.HistoricoValorConversion;

namespace SistemaContable.Formularios.Historicos
{
    public partial class HistoricoValorConversion : Form
    {
        public HistoricoValorConversion()
        {
            InitializeComponent();
        }


        private void CargarDatos()
        {
            string query = "SELECT h.IdConversión, m.NombreMoneda, h.Fecha, h.TasaCambio FROM HistoricoValorConversion h JOIN CatalogoMonedas m ON h.IdMoneda = m.IdMoneda";
            ConexionSql conexionSql = new();

            try
            {
                using SqlCommand command = new(query, conexionSql.AbrirConexion());
                using SqlDataAdapter adapter = new(command);
                DataTable table = new();
                adapter.Fill(table);
                dtgHistoricoVC.DataSource = table;  // Asegúrate de que el nombre de este control sea el correcto para tu DataGridView
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

            dtgHistoricoVC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgHistoricoVC.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgHistoricoVC.AllowUserToAddRows = false;
            dtgHistoricoVC.AllowUserToDeleteRows = false;
            dtgHistoricoVC.AllowUserToResizeColumns = false;
            dtgHistoricoVC.AllowUserToResizeRows = false;
            dtgHistoricoVC.MultiSelect = false;
            dtgHistoricoVC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LimpiarCampos()
        {
            textBoxId.Clear();
            comboBoxMoneda.SelectedItem = null;
            textBoxTasaCambio.Clear();
            dateTimePickerFecha.Value = DateTime.Now;
        }
        public class Moneda
        {
            public int IdMoneda { get; set; }
            public string? NombreMoneda { get; set; }
        }
        private void Monedas()
        {
            string query = "SELECT IdMoneda, NombreMoneda FROM CatalogoMonedas";
            ConexionSql conexionSql = new();

            try
            {
                using SqlCommand command = new(query, conexionSql.AbrirConexion());
                using SqlDataAdapter adapter = new(command);
                DataTable table = new();
                adapter.Fill(table);

                // Convertir DataTable a una lista de objetos Moneda
                List<Moneda> CatalogoMonedas = table.AsEnumerable().Select(row => new Moneda
                {
                    IdMoneda = row.Field<int>("IdMoneda"),
                    NombreMoneda = row.Field<string>("NombreMoneda")
                }).ToList();

                // Configurar el ComboBox
                comboBoxMoneda.DisplayMember = "NombreMoneda";
                comboBoxMoneda.ValueMember = "IdMoneda";
                comboBoxMoneda.DataSource = CatalogoMonedas;
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
        private void HistoricoValorConversion_Load(object sender, EventArgs e)
        {
            CargarDatos();
            AjustarDgv();
            Monedas();
        }

        private void DtgHistoricoVC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGrid
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = this.dtgHistoricoVC.Rows[e.RowIndex];

                // Mostrar los valores de las columnas seleccionadas en los campos correspondientes
                textBoxId.Text = row.Cells["IdConversión"].Value.ToString();
                comboBoxMoneda.Text = row.Cells["NombreMoneda"].Value.ToString();
                dateTimePickerFecha.Text = row.Cells["Fecha"].Value.ToString();
                textBoxTasaCambio.Text = row.Cells["TasaCambio"].Value.ToString();
            }
        }
        private static bool EsTasaValida(string tasaCambioStr, out float tasaCambio)
        {
            // Intenta convertir la entrada a un número float. Usa CultureInfo apropiado según sea necesario.
            bool esValido = float.TryParse(tasaCambioStr, NumberStyles.Any, CultureInfo.InvariantCulture, out tasaCambio);
            return esValido && tasaCambio > 0;  // La tasa de cambio debe ser un número positivo
        }

        public static bool GuardarRegistro(int? idMoneda, DateTime? fecha, string tasaCambioStr)
        {
            // Validación de campos vacíos
            if (!idMoneda.HasValue || fecha == null || string.IsNullOrWhiteSpace(tasaCambioStr))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return false;
            }

            // Validar y convertir la tasa de cambio
            if (!EsTasaValida(tasaCambioStr, out float tasaCambio))
            {
                MessageBox.Show("La tasa de cambio debe ser un número decimal positivo.");
                return false;
            }

            // Confirmación del usuario
            if (MessageBox.Show("¿Estás seguro de que deseas guardar esta información?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return false;
            }

            string query = "INSERT INTO HistoricoValorConversion (IdMoneda, Fecha, TasaCambio) VALUES (@IdMoneda, @Fecha, @TasaCambio)";
            ConexionSql conexionSql = new();

            try
            {
                using SqlCommand command = new(query, conexionSql.AbrirConexion());
                command.Parameters.AddWithValue("@IdMoneda", idMoneda);
                command.Parameters.AddWithValue("@Fecha", fecha);
                command.Parameters.AddWithValue("@TasaCambio", tasaCambio);
                command.Parameters["@TasaCambio"].Precision = 18; // Suponiendo que tienes una precisión de 18
                command.Parameters["@TasaCambio"].Scale = 2; // Suponiendo que quieres 2 decimales
                command.Parameters["@TasaCambio"].Value = tasaCambio;

                int result = command.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar los datos: " + ex.Message);
                return false;
            }
            finally
            {
                conexionSql.CerrarConexion();
            }
        }
        public static bool ModificarTasaDeCambio(int idConversion, int? idMoneda, DateTime? fecha, string tasaCambioStr)
        {
            // Validación de campos vacíos
            if (!idMoneda.HasValue || fecha == null || string.IsNullOrWhiteSpace(tasaCambioStr))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return false;
            }

            // Validar y convertir la tasa de cambio
            if (!EsTasaValida(tasaCambioStr, out float tasaCambio))
            {
                MessageBox.Show("La tasa de cambio debe ser un número decimal positivo.");
                return false;
            }

            // Confirmación del usuario
            if (MessageBox.Show("¿Estás seguro de que deseas modificar esta información?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return false;
            }

            string query = "UPDATE HistoricoValorConversion SET IdMoneda = @IdMoneda, Fecha = @Fecha, TasaCambio = @TasaCambio WHERE IdConversión = @IdConversión";
            ConexionSql conexionSql = new();

            try
            {
                using SqlCommand command = new(query, conexionSql.AbrirConexion());
                command.Parameters.AddWithValue("@IdConversión", idConversion);
                command.Parameters.AddWithValue("@IdMoneda", idMoneda);
                command.Parameters.AddWithValue("@Fecha", fecha);
                command.Parameters.AddWithValue("@TasaCambio", tasaCambio);

                int result = command.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar los datos: " + ex.Message);
                return false;
            }
            finally
            {
                conexionSql.CerrarConexion();
            }
        }
        public static bool EliminarTasaDeCambio(int idConversion)
        {
            // Confirmación del usuario
            if (MessageBox.Show("¿Estás seguro de que deseas eliminar esta información?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return false;
            }

            string query = "DELETE FROM HistoricoValorConversion WHERE IdConversión = @IdConversión";
            ConexionSql conexionSql = new();

            try
            {
                using SqlCommand command = new(query, conexionSql.AbrirConexion());
                command.Parameters.AddWithValue("@IdConversión", idConversion);

                int result = command.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar los datos: " + ex.Message);
                return false;
            }
            finally
            {
                conexionSql.CerrarConexion();
            }
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            // Obtener el ID de la moneda seleccionada del ComboBox
            if (comboBoxMoneda.SelectedItem is Moneda selectedMoneda)
            {
                int idMoneda = selectedMoneda.IdMoneda;
                DateTime fecha = dateTimePickerFecha.Value; // Asegúrate de que dateTimePickerFecha es el nombre de tu DateTimePicker.
                string tasaCambioStr = textBoxTasaCambio.Text; // Asegúrate de que textBoxTasaCambio es el nombre de tu TextBox para la tasa de cambio.

                bool resultado = GuardarRegistro(idMoneda, fecha, tasaCambioStr);
                if (resultado)
                {
                    MessageBox.Show("La tasa de cambio se guardó correctamente.");
                    CargarDatos();
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una moneda.");
            }



        }

        private void Button2_Click(object sender, EventArgs e)
        {

            // Asegúrate de que textBoxIdConversion es el nombre de tu TextBox que contiene el ID de conversión.
            if (int.TryParse(textBoxId.Text, out int idConversion))
            {
                // Obtener el ID de la moneda seleccionada del ComboBox
                if (comboBoxMoneda.SelectedItem is Moneda selectedMoneda)
                {
                    int idMoneda = selectedMoneda.IdMoneda;
                    DateTime fecha = dateTimePickerFecha.Value; // Asegúrate de que dateTimePickerFecha es el nombre de tu DateTimePicker.
                    string tasaCambioStr = textBoxTasaCambio.Text; // Asegúrate de que textBoxTasaCambio es el nombre de tu TextBox para la tasa de cambio.

                    if (EsTasaValida(tasaCambioStr, out _))
                    {
                        // Confirmación del usuario antes de proceder con la modificación
                        if (MessageBox.Show("¿Estás seguro de que deseas modificar esta información?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            bool resultado = ModificarTasaDeCambio(idConversion, idMoneda, fecha, tasaCambioStr);
                            if (resultado)
                            {
                                MessageBox.Show("La tasa de cambio se modificó correctamente.");
                                CargarDatos();
                                LimpiarCampos();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo modificar la tasa de cambio.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, revisa que todos los campos tengan información válida.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una moneda.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID de conversión válido.");
            }
        }
    


        private void Button3_Click(object sender, EventArgs e)
        {
            // Asegúrate de tener manejo de errores para la conversión en caso de que el input no sea un número
            if (int.TryParse(textBoxId.Text, out int idConversion))
            {
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar esta tasa de cambio?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool resultado = EliminarTasaDeCambio(idConversion);
                    if (resultado)
                    {
                        MessageBox.Show("La tasa de cambio se eliminó correctamente.");
                        CargarDatos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la tasa de cambio.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número de identificación válido.");
            }
        }
    }
}
