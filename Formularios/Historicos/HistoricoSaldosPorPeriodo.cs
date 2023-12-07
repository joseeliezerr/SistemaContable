using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
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
using static SistemaContable.Historicos.HistoricoSaldosPorPeriodo;

namespace SistemaContable.Historicos
{


    public partial class HistoricoSaldosPorPeriodo : Form
    {

        List<Cuenta> CuentasContables = new List<Cuenta>();
        List<Periodo> periodoscontables = new List<Periodo>();


        public HistoricoSaldosPorPeriodo()
        {
            InitializeComponent();
        }
        public class Periodo
        {
            public int IdPeriodo { get; set; }
            public string Descripcion { get; set; }


            public Periodo(int idPeriodo, string descripcion)
            {
                IdPeriodo = idPeriodo;
                Descripcion = descripcion;
            }


            public override string ToString()
            {
                return Descripcion;
            }
        }
        public class Cuenta
        {
            public int IdCuenta { get; set; }
            public string NombreCuenta { get; set; }

            public Cuenta(int idCuenta, string nombreCuenta)
            {
                IdCuenta = idCuenta;
                NombreCuenta = nombreCuenta;
            }

            public override string ToString()
            {
                return NombreCuenta;
            }
        }

        private void CargarDatos()
        {
            string query = @"
SELECT 
    h.IdHistorico,
    c.NombreCuenta,
    p.FechaInicio,
    p.FechaFin,
    h.SaldoInicial,
    h.SaldoFinal
FROM 
    HistoricoSaldosPorPeriodo h
INNER JOIN 
    CatalogoContable c ON h.IdCuenta = c.IdCuenta
INNER JOIN 
    PeriodosContables p ON h.IdPeriodo = p.IdPeriodo";

            ConexionSql conexionSql = new();

            try
            {
                using SqlCommand command = new(query, conexionSql.AbrirConexion());
                using SqlDataAdapter adapter = new(command);
                DataTable table = new();
                adapter.Fill(table);
                dtgHistoricoSPP.DataSource = table; // Asegúrate de que 'dtgCatalogoContable' sea el nombre correcto de tu DataGridView
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
        private void AjustarDgv()
        {

            dtgHistoricoSPP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgHistoricoSPP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgHistoricoSPP.AllowUserToAddRows = false;
            dtgHistoricoSPP.AllowUserToDeleteRows = false;
            dtgHistoricoSPP.AllowUserToResizeColumns = false;
            dtgHistoricoSPP.AllowUserToResizeRows = false;
            dtgHistoricoSPP.MultiSelect = false;
            dtgHistoricoSPP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void LimpiarCampos()
        {
            comboBoxCuenta.SelectedItem = null;
            comboBoxPeriodo.SelectedItem = null;
            textBoxSaldoInicial.Clear();
            textBoxSaldoFinal.Clear();
        }
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }
        private void CargarPeriodo()
        {



            periodoscontables.Clear();

            string query = "SELECT IdPeriodo, FechaInicio, FechaFin FROM PeriodosContables";

            ConexionSql conexionSql = new ConexionSql();
            using (SqlConnection conexion = conexionSql.AbrirConexion())
            {
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idPeriodo = reader.GetInt32(reader.GetOrdinal("IdPeriodo"));
                            string fechaInicio = reader.GetDateTime(reader.GetOrdinal("FechaInicio")).ToString("dd/MM/yyyy");
                            string fechaFin = reader.GetDateTime(reader.GetOrdinal("FechaFin")).ToString("dd/MM/yyyy");
                            string displayValue = $"{fechaInicio} a {fechaFin}";
                            periodoscontables.Add(new Periodo(idPeriodo, displayValue));
                        }
                    }
                }
            }

            comboBoxPeriodo.DataSource = periodoscontables;
            comboBoxPeriodo.DisplayMember = "Descripcion";
            comboBoxPeriodo.ValueMember = "IdPeriodo";


        }
        private void CargarCuenta()
        {
            string query = "SELECT IdCuenta, NombreCuenta FROM CatalogoContable";

            ConexionSql conexionSql = new ConexionSql();
            using (SqlConnection conexion = conexionSql.AbrirConexion())
            {
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idCuenta = reader.GetInt32(reader.GetOrdinal("IdCuenta"));
                            string nombreCuenta = reader.GetString(reader.GetOrdinal("NombreCuenta"));
                            CuentasContables.Add(new Cuenta(idCuenta, nombreCuenta));
                        }
                    }
                }
            }
            comboBoxCuenta.DataSource = CuentasContables;
            comboBoxCuenta.DisplayMember = "NombreCuenta";
            comboBoxCuenta.ValueMember = "IdCuenta";

        }
        private void HistoricoSaldosPorPeriodo_Load(object sender, EventArgs e)
        {
            CargarDatos();
            AjustarDgv();
            CargarPeriodo();
            CargarCuenta();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Asegúrate de que los SelectedValue no sean null antes de la conversión
            int idPeriodo = 0;
            int idCuenta = 0;
            decimal saldoInicial, saldoFinal;

            // Asegúrate de que los ComboBoxes tienen valores seleccionados
            if (comboBoxPeriodo.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un periodo válido.");
                return;
            }
            else
            {
                idPeriodo = Convert.ToInt32(comboBoxPeriodo.SelectedValue);
            }

            try
            {
                idCuenta = Convert.ToInt32(comboBoxCuenta.SelectedValue);
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor seleccionado no es un número válido.");
                return;
            }



            // Comprueba si los campos de saldo inicial y final son números válidos y no están vacíos
            bool esSaldoInicialValido = decimal.TryParse(textBoxSaldoInicial.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out saldoInicial);
            if (!esSaldoInicialValido)
            {
                MessageBox.Show("Por favor, ingrese un saldo inicial válido.");
                return;
            }

            bool esSaldoFinalValido = decimal.TryParse(textBoxSaldoFinal.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out saldoFinal);
            if (!esSaldoFinalValido)
            {
                MessageBox.Show("Por favor, ingrese un saldo final válido.");
                return;
            }


            // Utiliza tu clase ConexionSql para obtener la conexión
            ConexionSql conexionSql = new();

            // Define la consulta SQL para insertar los datos
            string query = "INSERT INTO HistoricoSaldosPorPeriodo (IdPeriodo, IdCuenta, SaldoInicial, SaldoFinal) VALUES (@IdPeriodo, @IdCuenta, @SaldoInicial, @SaldoFinal)";

            using (SqlConnection conexion = conexionSql.AbrirConexion())
            using (SqlCommand command = new(query, conexion))
            {
                // Especifica el tipo de los parámetros
                command.Parameters.Add("@IdPeriodo", SqlDbType.Int).Value = idPeriodo;
                command.Parameters.Add("@IdCuenta", SqlDbType.Int).Value = idCuenta;
                command.Parameters.Add("@SaldoInicial", SqlDbType.Decimal);
                command.Parameters["@SaldoInicial"].Precision = 18; // Suponiendo que tienes una precisión de 18
                command.Parameters["@SaldoInicial"].Scale = 2; // Suponiendo que quieres 2 decimales
                command.Parameters["@SaldoInicial"].Value = saldoInicial;

                command.Parameters.Add("@SaldoFinal", SqlDbType.Decimal);
                command.Parameters["@SaldoFinal"].Precision = 18; // Suponiendo que tienes una precisión de 18
                command.Parameters["@SaldoFinal"].Scale = 2; // Suponiendo que quieres 2 decimales
                command.Parameters["@SaldoFinal"].Value = saldoFinal;


                try
                {
                    // Ejecuta el comando y verifica el resultado
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Registro guardado con éxito.");
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
                    MessageBox.Show("Error al realizar la operación en la base de datos: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // La conexión se cerrará automáticamente al salir del bloque using
            }


        }
        private void ModificarRegistro()
        {
            // Verifica si hay un registro seleccionado en el DataGridView
            if (dtgHistoricoSPP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un registro para modificar.");
                return;
            }

            // Obtiene el ID del registro seleccionado en el DataGridView
            int idHistorico = Convert.ToInt32(dtgHistoricoSPP.SelectedRows[0].Cells["IdHistorico"].Value);

            // Aquí deberías obtener los valores de los controles de tu formulario
            int idPeriodo = ObtenerIdPeriodoSeleccionado();
            int idCuenta = ObtenerIdCuentaSeleccionada();
            decimal saldoInicial = ObtenerSaldoInicial();
            decimal saldoFinal = ObtenerSaldoFinal();

            // Prepara la consulta SQL para la actualización
            string updateQuery = @"
        UPDATE HistoricoSaldosPorPeriodo
        SET IdPeriodo = @IdPeriodo, IdCuenta = @IdCuenta, SaldoInicial = @SaldoInicial, SaldoFinal = @SaldoFinal
        WHERE IdHistorico = @IdHistorico";


            ConexionSql conexionSql = new();
            using (SqlConnection conexion = conexionSql.AbrirConexion())
            using (SqlCommand command = new SqlCommand(updateQuery, conexion))
            {
                command.Parameters.AddWithValue("@IdPeriodo", idPeriodo);
                command.Parameters.AddWithValue("@IdCuenta", idCuenta);
                command.Parameters.AddWithValue("@SaldoInicial", saldoInicial);
                command.Parameters.AddWithValue("@SaldoFinal", saldoFinal);
                command.Parameters.AddWithValue("@IdHistorico", idHistorico);

                try
                {
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Registro modificado con éxito.");
                        CargarDatos(); // Actualiza el DataGridView para reflejar los cambios.
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro o no se necesitó actualizar.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                }
            }
        }

        // Método para obtener el IdPeriodo seleccionado
        private int ObtenerIdPeriodoSeleccionado()
        {
            // Implementa la lógica para obtener el IdPeriodo del registro seleccionado o de los controles de entrada.
            // Esto podría ser algo así como comboBoxPeriodo.SelectedValue si comboBoxPeriodo está correctamente configurado con DisplayMember y ValueMember.
            return Convert.ToInt32(comboBoxPeriodo.SelectedValue);
        }

        // Método para obtener el IdCuenta seleccionado
        private int ObtenerIdCuentaSeleccionada()
        {
            // Implementa la lógica para obtener el IdCuenta del registro seleccionado o de los controles de entrada.
            // Esto podría ser algo así como comboBoxCuenta.SelectedValue si comboBoxCuenta está correctamente configurado con DisplayMember y ValueMember.
            return Convert.ToInt32(comboBoxCuenta.SelectedValue);
        }

        // Método para obtener el saldo inicial del registro seleccionado
        private decimal ObtenerSaldoInicial()
        {
            // Implementa la lógica para obtener el saldo inicial del registro seleccionado o de los controles de entrada.
            // Esto podría ser validar y convertir el contenido de un TextBox por ejemplo.
            if (decimal.TryParse(textBoxSaldoInicial.Text, out decimal saldoInicial))
            {
                return saldoInicial;
            }
            else
            {
                throw new InvalidOperationException("El saldo inicial no es un número válido.");
            }
        }

        // Método para obtener el saldo final del registro seleccionado
        private decimal ObtenerSaldoFinal()
        {
            // Utiliza la cultura de Estados Unidos para interpretar correctamente los números con comas y puntos.
            var cultureInfo = new CultureInfo("en-US");

            if (decimal.TryParse(textBoxSaldoFinal.Text, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint, cultureInfo, out decimal saldoFinal))
            {
                return saldoFinal;
            }
            else
            {
                throw new InvalidOperationException("El saldo final no es un número válido.");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Eliminar un registro
            if (dtgHistoricoSPP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un registro para eliminar.");
                return;
            }
            else
            {
                int idHistorico = Convert.ToInt32(dtgHistoricoSPP.SelectedRows[0].Cells["IdHistorico"].Value);

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?",
                                                     "Confirmar eliminación",
                                                     MessageBoxButtons.YesNo);
                ConexionSql conexionSql = new();
                if (confirmResult == DialogResult.Yes)
                {
                  
                    string deleteQuery = "DELETE FROM HistoricoSaldosPorPeriodo WHERE IdHistorico = @IdHistorico";
                    using (SqlCommand command = new(deleteQuery, conexionSql.AbrirConexion()))
                    {
                        command.Parameters.AddWithValue("@IdHistorico", idHistorico);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Registro eliminado con éxito.");
                            CargarDatos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el registro.");
                        }
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarRegistro();

        
        }

        private void dtgHistoricoSPP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGrid
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = this.dtgHistoricoSPP.Rows[e.RowIndex];

                // Mostrar los valores de las columnas seleccionadas en los campos correspondientes
                textBoxId.Text = row.Cells["IdHistorico"].Value.ToString();
                comboBoxCuenta.Text = row.Cells["NombreCuenta"].Value.ToString();
                DateTime fechaInicio;
                DateTime fechaFin;
                bool fechaInicioValida = DateTime.TryParse(row.Cells["FechaInicio"].Value.ToString(), out fechaInicio);
                bool fechaFinValida = DateTime.TryParse(row.Cells["FechaFin"].Value.ToString(), out fechaFin);

                if (fechaInicioValida && fechaFinValida)
                {
                    comboBoxPeriodo.Text = fechaInicio.ToString("dd/MM/yyyy") + " a " + fechaFin.ToString("dd/MM/yyyy");
                }
                else
                {
                    // Manejar el caso en que las fechas no sean válidas
                    MessageBox.Show("Una o ambas fechas no están en un formato válido.");
                }
                textBoxSaldoInicial.Text = row.Cells["SaldoInicial"].Value.ToString();
                textBoxSaldoFinal.Text = row.Cells["SaldoFinal"].Value.ToString();
            }
        }
    }
}
