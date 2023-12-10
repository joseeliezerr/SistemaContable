using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
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


namespace SistemaContable.Formularios
{
    public partial class PartidasContables : Form
    {
        public PartidasContables()
        {
            InitializeComponent();
        }
        private void CargarCatalogoPartidas()
        {
            string query = "SELECT IdPartida, Descripcion FROM CatalogoPartidas";

            ConexionSql conexionSql = new();
            using SqlConnection conexion = conexionSql.AbrirConexion();
            SqlCommand command = new(query, conexion);
            try
            {
                SqlDataAdapter adapter = new(command);
                DataTable table = new();
                adapter.Fill(table);

                // Establecer la propiedad DataSource del ComboBox
                comboBoxPartidas.DataSource = table;
                // Establecer la propiedad DisplayMember del ComboBox para mostrar la Descripcion
                comboBoxPartidas.DisplayMember = "Descripcion";
                // Establecer la propiedad ValueMember del ComboBox para almacenar el IdPartida
                comboBoxPartidas.ValueMember = "IdPartida";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al cargar el catálogo de partidas: " + ex.Message);
            }
        }

        private void CuentasContables()
        {
            string query = "SELECT IdCuenta, NombreCuenta FROM CatalogoContable";

            ConexionSql conexionSql = new();
            using SqlConnection conexion = conexionSql.AbrirConexion();
            SqlCommand command = new(query, conexion);
            try
            {
                SqlDataAdapter adapter = new(command);
                DataTable table = new();
                adapter.Fill(table);

                // Establecer la propiedad DataSource del ComboBox
                comboBoxCuentas.DataSource = table;
                // Establecer la propiedad DisplayMember del ComboBox para mostrar la Descripcion
                comboBoxCuentas.DisplayMember = "NombreCuenta";
                // Establecer la propiedad ValueMember del ComboBox para almacenar el IdPartida
                comboBoxCuentas.ValueMember = "IdCuenta";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al cargar el catálogo de Cuentas: " + ex.Message);
            }

        }

        private void AjustarDgv()
        {

            dtgPartidaContable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgPartidaContable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgPartidaContable.AllowUserToAddRows = false;
            dtgPartidaContable.AllowUserToDeleteRows = false;
            dtgPartidaContable.AllowUserToResizeColumns = false;
            dtgPartidaContable.AllowUserToResizeRows = false;
            dtgPartidaContable.MultiSelect = false;
            dtgPartidaContable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void PartidasContables_Load(object sender, EventArgs e)
        {
            CargarCatalogoPartidas();
            CuentasContables();
            CargarDatos();
            AjustarDgv();
        }
        // Dentro de tu clase PartidasContables
        public void OcultarBoton()
        {
            buttonReporte.Visible = false;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LimpiarCampos()
        {
            textBoxId.Clear();
            comboBoxCuentas.SelectedItem = null;
            comboBoxPartidas.SelectedItem = null;
            dateTimePicker1.Value = DateTime.Now;
            textBoxMonto.Clear();
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void CargarDatos()
        {
            // Esta consulta realiza un JOIN con las tablas CatalogoPartidas y CatalogoContable para obtener los nombres en lugar de los IDs
            string query = @"
        SELECT 
            ip.IdRegistro, 
            cp.Descripcion AS Partida, 
            ip.Fecha, 
            ip.Monto, 
            cc.NombreCuenta AS Cuenta,
            cc.TipoCuenta AS Tipo
        FROM 
            IngresoPartidasContable ip
            INNER JOIN CatalogoPartidas cp ON ip.IdPartida = cp.IdPartida
            INNER JOIN CatalogoContable cc ON ip.IdCuenta = cc.IdCuenta";

            ConexionSql conexionSql = new();
            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
            SqlDataAdapter adapter = new(command);
            DataTable table = new();
            adapter.Fill(table);

            // Asigna el DataTable como DataSource para el DataGridView
            dtgPartidaContable.DataSource = table;

            // Ajusta el DataGridView para mostrar nombres descriptivos
            dtgPartidaContable.Columns["Partida"].HeaderText = "NombrePartida";
            dtgPartidaContable.Columns["Cuenta"].HeaderText = "NombreCuenta";
            // Otros ajustes de visualización, si son necesarios
            if (dtgPartidaContable.Columns.Contains("Monto"))
            {
                dtgPartidaContable.Columns["Monto"].DefaultCellStyle.Format = "N2"; // Formato numérico con dos decimales
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Obtén los valores de los controles del formulario
            int idPartida = Convert.ToInt32(comboBoxPartidas.SelectedValue); // Asumiendo que comboBoxPartidas es el ComboBox que tiene el IdPartida
            DateTime fecha = dateTimePicker1.Value; // Asumiendo que dateTimePickerFecha es el DateTimePicker para la fecha
            bool success = float.TryParse(textBoxMonto.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float monto);

            if (!success)
            {
                MessageBox.Show("Por favor, ingrese un monto válido.");
                return;
            }

            int idCuenta = Convert.ToInt32(comboBoxCuentas.SelectedValue); // Asumiendo que comboBoxCuentas es el ComboBox que tiene el IdCuenta

            // Verifica que los campos necesarios estén llenos
            if (string.IsNullOrEmpty(textBoxMonto.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos necesarios.");
                return;
            }

            // Utiliza tu clase ConexionSql para obtener la conexión
            ConexionSql conexionSql = new();

            // Define la consulta SQL para insertar los datos
            string query = "INSERT INTO IngresoPartidasContable (IdPartida, Fecha, Monto, IdCuenta) VALUES (@IdPartida, @Fecha, @Monto, @IdCuenta)";

            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
            // Agrega los parámetros al comando para evitar la inyección SQL
            command.Parameters.AddWithValue("@IdPartida", idPartida);
            command.Parameters.AddWithValue("@Fecha", fecha);
            command.Parameters.Add("@Monto", SqlDbType.Float).Value = monto;
            command.Parameters.AddWithValue("@IdCuenta", idCuenta);

            try
            {
                // Ejecuta el comando y verifica el resultado
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    CargarDatos();
                    LimpiarCampos();
                    AjustarDgv();
                    MessageBox.Show("Ingreso de partida contable guardado con éxito.");

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

        private void TextBoxMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Comprobar si la tecla presionada no es un dígito ni un control (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                if (e.KeyChar == '.' && !textBoxMonto.Text.Contains('.') && !textBoxMonto.Text.Contains('.'))
                {
                    // Si es el principio del texto, agregar un 0 antes de la coma
                    if (textBoxMonto.Text.Length == 0) textBoxMonto.Text = "0";
                    return; // Permitir la coma
                }
                // Permitir el punto decimal si aún no está presente en el texto
                else if (e.KeyChar == '.' && !textBoxMonto.Text.Contains('.') && !textBoxMonto.Text.Contains(','))
                {
                    // Si es el principio del texto, agregar un 0 antes del punto
                    if (textBoxMonto.Text.Length == 0) textBoxMonto.Text = "0";
                    return; // Permitir el punto
                }

                e.Handled = true; // Rechazar la entrada si no es un número o control o ya hay un punto/coma
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show("Por favor, seleccione un registro para actualizar.");
                return;
            }


            int idRegistro = Convert.ToInt32(textBoxId.Text);


            int idPartida = Convert.ToInt32(comboBoxPartidas.SelectedValue);
            DateTime fecha = dateTimePicker1.Value;
            bool success = float.TryParse(textBoxMonto.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float monto);
            if (!success)
            {
                MessageBox.Show("Por favor, ingrese un monto válido.");
                return;
            }
            int idCuenta = Convert.ToInt32(comboBoxCuentas.SelectedValue);

            // Define la consulta SQL para actualizar los datos
            string query = @"
    UPDATE IngresoPartidasContable
    SET IdPartida = @IdPartida, Fecha = @Fecha, Monto = @Monto, IdCuenta = @IdCuenta
    WHERE IdRegistro = @IdRegistro";

            ConexionSql conexionSql = new();
            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
            // Agrega los parámetros al comando para evitar la inyección SQL
            command.Parameters.AddWithValue("@IdRegistro", idRegistro);
            command.Parameters.AddWithValue("@IdPartida", idPartida);
            command.Parameters.AddWithValue("@Fecha", fecha);
            command.Parameters.Add("@Monto", SqlDbType.Float).Value = monto;
            command.Parameters.AddWithValue("@IdCuenta", idCuenta);

            try
            {
                // Ejecuta el comando y verifica el resultado
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    CargarDatos();
                    LimpiarCampos();
                    MessageBox.Show("Ingreso de partida contable actualizado con éxito.");

                }
                else
                {
                    MessageBox.Show("No se encontró el registro para actualizar.");
                }
            }
            catch (SqlException ex)
            {
                // Maneja cualquier excepción durante el proceso de actualización
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            // Asumimos que tienes un control, como un TextBox, para obtener el IdRegistro que se eliminará
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show("Por favor, seleccione un registro para eliminar.");
                return;
            }

            bool isValidId = int.TryParse(textBoxId.Text, out int idRegistro);
            if (!isValidId || idRegistro <= 0)
            {
                MessageBox.Show("El ID de registro proporcionado no es válido.");
                return;
            }

            // Pedir confirmación antes de proceder con la eliminación
            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?",
                                                 "Confirmar eliminación",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Utiliza tu clase ConexionSql para obtener la conexión
                ConexionSql conexionSql = new();

                // Define la consulta SQL para eliminar los datos
                string query = "DELETE FROM IngresoPartidasContable WHERE IdRegistro = @IdRegistro";

                using SqlConnection conexion = conexionSql.AbrirConexion();
                using SqlCommand command = new(query, conexion);
                // Agrega el parámetro al comando para evitar la inyección SQL
                command.Parameters.AddWithValue("@IdRegistro", idRegistro);

                try
                {
                    // Ejecuta el comando y verifica el resultado
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        CargarDatos();
                        LimpiarCampos();
                        MessageBox.Show("Registro eliminado con éxito.");

                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro para eliminar.");
                    }
                }
                catch (SqlException ex)
                {
                    // Maneja cualquier excepción durante el proceso de eliminación
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DtgPartidaContable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGrid
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = this.dtgPartidaContable.Rows[e.RowIndex];

                // Mostrar los valores de las columnas seleccionadas en los campos correspondientes
                textBoxId.Text = row.Cells["IdRegistro"].Value.ToString();
                comboBoxPartidas.Text = row.Cells["Partida"].Value.ToString();
                dateTimePicker1.Text = row.Cells["Fecha"].Value.ToString();
                textBoxMonto.Text = row.Cells["Monto"].Value.ToString();
                comboBoxCuentas.Text = row.Cells["Cuenta"].Value.ToString();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new()
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = "BalanceGeneral.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;

                using PdfWriter writer = new(filename);
                using PdfDocument pdf = new(writer);
                using Document document = new(pdf);
                Paragraph title = new Paragraph("Balance General")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(14);
                document.Add(title);

                Table table = new Table(UnitValue.CreatePercentArray(new float[] { 1, 2, 2, 2, 2, 2 }))
                    .UseAllAvailableWidth();
                table.AddHeaderCell("ID");
                table.AddHeaderCell("Nombre de Partida");
                table.AddHeaderCell("Fecha");
                table.AddHeaderCell("Nombre de Cuenta");
                table.AddHeaderCell("Monto");
                table.AddHeaderCell("Tipo");

                decimal totalActivos = 0;
                decimal totalPasivos = 0;
                decimal totalPatrimonio = 0;

                // Asumimos que 'dtgPartidaContable' es tu DataGridView
                foreach (DataGridViewRow row in dtgPartidaContable.Rows)
                {
                    if (!row.IsNewRow)
                    {

                        string idRegistro = row.Cells["IdRegistro"].Value?.ToString() ?? "";
                        string nombrePartida = row.Cells["Partida"].Value?.ToString() ?? ""; // Asegúrate de que esto coincida con el nombre de tu columna
                        DateTime fecha = Convert.ToDateTime(row.Cells["Fecha"].Value);
                        string nombreCuenta = row.Cells["Cuenta"].Value?.ToString() ?? ""; // Igual aquí
                        decimal monto = Convert.ToDecimal(row.Cells["Monto"].Value);
                        CultureInfo cultureInfo = new("es-HN");
                        string formattedMonto = monto.ToString("C", cultureInfo);
                        string tipo = row.Cells["Tipo"].Value?.ToString() ?? ""; // Y aquí


                        table.AddCell(new Cell().Add(new Paragraph(idRegistro)));
                        table.AddCell(new Cell().Add(new Paragraph(nombrePartida)));
                        table.AddCell(new Cell().Add(new Paragraph(fecha.ToString("dd/MM/yyyy"))));
                        table.AddCell(new Cell().Add(new Paragraph(nombreCuenta)));
                        table.AddCell(new Cell().Add(new Paragraph(formattedMonto)));
                        table.AddCell(new Cell().Add(new Paragraph(tipo)));

                        // Aquí se realiza la clasificación de los montos según el tipo de cuenta
                        switch (tipo.ToUpper())
                        {
                            case "ACTIVO":
                                totalActivos += monto;
                                break;
                            case "PASIVO":
                                totalPasivos += monto;
                                break;
                            case "PATRIMONIO":
                                totalPatrimonio += monto;
                                break;
                                
                        }
                    }
                }
                CultureInfo lempiraCulture = new("es-HN");
                document.Add(table);

                // Añadir los totales al documento con el formato de Lempira
                document.Add(new Paragraph($"Total Activos: {totalActivos.ToString("C", lempiraCulture)}"));
                document.Add(new Paragraph($"Total Pasivos: {totalPasivos.ToString("C", lempiraCulture)}"));
                document.Add(new Paragraph($"Total Patrimonio: {totalPatrimonio.ToString("C", lempiraCulture)}"));

                // La ecuación del balance general es Activo = Pasivo + Patrimonio
                decimal balanceGeneral = totalPasivos + totalPatrimonio;
                document.Add(new Paragraph($"Balance General (Pasivo + Patrimonio): {balanceGeneral.ToString("C", lempiraCulture)}"));
                // Verificamos la igualdad para la ecuación contable Activo = Pasivo + Patrimonio
                if (totalActivos != balanceGeneral)
                {
                    document.Add(new Paragraph("Advertencia: Los totales no están balanceados según la ecuación contable."));
                }

                try
                {
                    // Cerrar el documento
                    document.Close();

                    // Abrir el archivo PDF generado automáticamente
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filename) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo abrir el archivo PDF automáticamente. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("El reporte se ha generado correctamente.", "Reporte Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }
    }
}

