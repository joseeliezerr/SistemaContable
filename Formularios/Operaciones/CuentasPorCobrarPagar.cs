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

namespace SistemaContable.Formularios.Operaciones
{
    public partial class CuentasPorCobrarPagar : Form
    {
        private List<string> nombresClientesProveedores = new List<string>();
        public CuentasPorCobrarPagar()
        {
            InitializeComponent();
            comboBoxClientesProveedores.TextChanged += comboBoxClientesProveedores_TextChanged;

            // Cargar la lista de nombres al iniciar
            CargarClienteoProveedor();
        }
        private void CargarClienteoProveedor()
        {
            // Asegúrate de que la lista esté vacía antes de llenarla
            nombresClientesProveedores.Clear();

            string query = "SELECT DISTINCT Nombre FROM ClientesProveedores";

            ConexionSql conexionSql = new ConexionSql();
            using (SqlConnection conexion = conexionSql.AbrirConexion())
            {
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nombresClientesProveedores.Add(reader["Nombre"].ToString());
                        }
                    }
                }
            }

            // Limpia los ítems del ComboBox antes de añadir nuevos para evitar duplicados
            comboBoxClientesProveedores.Items.Clear();
            comboBoxClientesProveedores.Items.AddRange(nombresClientesProveedores.ToArray());
        }

        private void AjustarDgv()
        {

            dtgCuentasCobrarPagar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCuentasCobrarPagar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgCuentasCobrarPagar.AllowUserToAddRows = false;
            dtgCuentasCobrarPagar.AllowUserToDeleteRows = false;
            dtgCuentasCobrarPagar.AllowUserToResizeColumns = false;
            dtgCuentasCobrarPagar.AllowUserToResizeRows = false;
            dtgCuentasCobrarPagar.MultiSelect = false;
            dtgCuentasCobrarPagar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CuentasPorCobrarPagar_Load(object sender, EventArgs e)
        {
            CargarClienteoProveedor();
            AjustarDgv();
            CargarDatosDtg();


        }
        private void LimpiarCampos()
        {
            textBoxId.Clear();
            comboBoxClientesProveedores.SelectedItem = null;
            dateTimePicker1.Value = DateTime.Now;
            textBoxMonto.Clear();
            comboBoxCuenta.SelectedItem = null;
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }
        private void CargarDatosDtg()
        {
            string query = @"
        SELECT 
            c.IdCuenta, 
            cp.Nombre AS 'NombreClienteProveedor', 
            cp.Tipo AS 'TipoClienteProveedor', 
            c.Saldo, 
            c.FechaVencimiento, 
            c.TipoCuenta 
        FROM 
            CuentasPorCobrarPagar c
            INNER JOIN ClientesProveedores cp ON c.IdClienteProveedor = cp.IdClienteProveedor";

            ConexionSql conexionSql = new ConexionSql();
            using (SqlConnection conexion = conexionSql.AbrirConexion())
            {
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Asigna el DataTable como DataSource para el DataGridView
                dtgCuentasCobrarPagar.DataSource = table;

                // Configurar el DataGridView para ocultar la columna IdClienteProveedor si está presente
                if (dtgCuentasCobrarPagar.Columns["IdClienteProveedor"] != null)
                {
                    dtgCuentasCobrarPagar.Columns["IdClienteProveedor"].Visible = false;
                }

                // Opcionalmente, puedes configurar los nombres de las columnas para que sean más amigables para el usuario
                dtgCuentasCobrarPagar.Columns["NombreClienteProveedor"].HeaderText = "Cliente/Proveedor";
                dtgCuentasCobrarPagar.Columns["TipoClienteProveedor"].HeaderText = "Tipo";
                dtgCuentasCobrarPagar.Columns["Saldo"].HeaderText = "Saldo";
                dtgCuentasCobrarPagar.Columns["FechaVencimiento"].HeaderText = "Fecha de Vencimiento";
                dtgCuentasCobrarPagar.Columns["TipoCuenta"].HeaderText = "Tipo de Cuenta";
            }
        }


        private void Button1_Click(object sender, EventArgs e)
        {

            int idClienteProveedor = Convert.ToInt32(comboBoxClientesProveedores.SelectedValue);
            float saldo;
            bool isSaldoValid = float.TryParse(textBoxMonto.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out saldo);
            if (comboBoxClientesProveedores.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente o proveedor.");
                return;
            }

            // Validar Saldo
            if (string.IsNullOrWhiteSpace(textBoxMonto.Text))
            {
                MessageBox.Show("Por favor, ingrese el saldo.");
                return;
            }
            _ = float.TryParse(textBoxMonto.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out saldo);
            if (!isSaldoValid)
            {
                MessageBox.Show("Por favor, ingrese un saldo válido.");
                return;
            }


            if (comboBoxCuenta.SelectedItem == null || string.IsNullOrWhiteSpace(comboBoxCuenta.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor, seleccione el tipo de cuenta.");
                return;
            }
            DateTime fechaVencimiento = dateTimePicker1.Value;

            // Utiliza tu clase ConexionSql para obtener la conexión
            ConexionSql conexionSql = new ConexionSql();

            // Define la consulta SQL para insertar los datos
            string query = "INSERT INTO CuentasPorCobrarPagar (IdClienteProveedor, Saldo, FechaVencimiento, TipoCuenta) VALUES (@IdClienteProveedor, @Saldo, @FechaVencimiento, @TipoCuenta)";

            using (SqlConnection conexion = conexionSql.AbrirConexion())
            {
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    // Agrega los parámetros al comando para evitar la inyección SQL
                    command.Parameters.AddWithValue("@IdClienteProveedor", idClienteProveedor);
                    command.Parameters.AddWithValue("@Saldo", saldo);
                    command.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);
                    string tipoCuenta = comboBoxCuenta.SelectedItem.ToString();
                    command.Parameters.AddWithValue("@TipoCuenta", tipoCuenta);

                    try
                    {
                        // Ejecuta el comando y verifica el resultado
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            CargarDatosDtg();
                            LimpiarCampos();

                            MessageBox.Show("Registro guardado con éxito.");

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
            }

        }

        private void dtgCuentasCobrarPagar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGrid
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = this.dtgCuentasCobrarPagar.Rows[e.RowIndex];

                // Mostrar los valores de las columnas seleccionadas en los campos correspondientes
                textBoxId.Text = row.Cells["IdCuenta"].Value.ToString();
                comboBoxClientesProveedores.Text = row.Cells["NombreClienteProveedor"].Value.ToString();
                textBoxMonto.Text = row.Cells["Saldo"].Value.ToString();
                dateTimePicker1.Text = row.Cells["FechaVencimiento"].Value.ToString();
                comboBoxCuenta.Text = row.Cells["TipoCuenta"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Asegúrate de que haya una fila seleccionada
            if (dtgCuentasCobrarPagar.SelectedRows.Count != 1)
            {
                MessageBox.Show("Por favor, seleccione un registro para eliminar.");
                return;
            }

            // Pedir confirmación antes de proceder con la eliminación
            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?",
                                                 "Confirmar eliminación",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Obtén el IdCuenta del registro seleccionado
                int idCuenta = Convert.ToInt32(dtgCuentasCobrarPagar.SelectedRows[0].Cells["IdCuenta"].Value);

                // Utiliza tu clase ConexionSql para obtener la conexión
                ConexionSql conexionSql = new ConexionSql();

                // Define la consulta SQL para eliminar los datos
                string query = "DELETE FROM CuentasPorCobrarPagar WHERE IdCuenta = @IdCuenta";

                using (SqlConnection conexion = conexionSql.AbrirConexion())
                {
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        // Agrega el parámetro al comando para evitar la inyección SQL
                        command.Parameters.AddWithValue("@IdCuenta", idCuenta);

                        try
                        {
                            // Ejecuta el comando y verifica el resultado
                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                CargarDatosDtg();
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
                            MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show("Por favor, seleccione un registro para actualizar.");
                return;
            }

            int idCuenta = Convert.ToInt32(textBoxId.Text); // Asegúrate de que textBoxIdCuenta contiene el IdCuenta del registro a actualizar

            // A continuación se obtienen los valores de los controles del formulario para los otros campos
            int idClienteProveedor = Convert.ToInt32(comboBoxClientesProveedores.SelectedValue);
            float saldo;
            bool isSaldoValid = float.TryParse(textBoxMonto.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out saldo);
            if (!isSaldoValid)
            {
                MessageBox.Show("Por favor, ingrese un saldo válido.");
                return;
            }
            DateTime fechaVencimiento = dateTimePicker1.Value;
            string tipoCuenta = comboBoxCuenta.SelectedItem.ToString();

            ConexionSql conexionSql = new ConexionSql();
            string query = @"
    UPDATE CuentasPorCobrarPagar
    SET IdClienteProveedor = @IdClienteProveedor, Saldo = @Saldo, FechaVencimiento = @FechaVencimiento, TipoCuenta = @TipoCuenta
    WHERE IdCuenta = @IdCuenta";

            using (SqlConnection conexion = conexionSql.AbrirConexion())
            {
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    // Agrega los parámetros al comando para evitar la inyección SQL
                    command.Parameters.AddWithValue("@IdCuenta", idCuenta);
                    command.Parameters.AddWithValue("@IdClienteProveedor", idClienteProveedor);
                    command.Parameters.AddWithValue("@Saldo", saldo);
                    command.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);
                    command.Parameters.AddWithValue("@TipoCuenta", tipoCuenta);

                    try
                    {
                        // Ejecuta el comando y verifica el resultado
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            CargarDatosDtg();
                            LimpiarCampos();
                            MessageBox.Show("Registro actualizado con éxito.");

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
            }

        }


        private void comboBoxClientesProveedores_TextChanged(object sender, EventArgs e)
        {
            // Desconecta el evento para prevenir la recursión infinita y duplicación
            comboBoxClientesProveedores.TextChanged -= comboBoxClientesProveedores_TextChanged;

            string searchText = comboBoxClientesProveedores.Text;
            comboBoxClientesProveedores.Items.Clear(); // Asegúrate de limpiar los items antes de agregar los nuevos

            if (!string.IsNullOrEmpty(searchText))
            {
                // Filtra los nombres que coincidan con el texto introducido
                var filteredItems = nombresClientesProveedores.Where(nombre => nombre.ToLower().Contains(searchText.ToLower()));
                comboBoxClientesProveedores.Items.AddRange(filteredItems.ToArray());
            }
            else
            {
                // Si no hay texto de búsqueda, añade todos los nombres de nuevo
                comboBoxClientesProveedores.Items.AddRange(nombresClientesProveedores.ToArray());
            }

            // Restablece el texto y la posición del cursor
            comboBoxClientesProveedores.Text = searchText;
            comboBoxClientesProveedores.SelectionStart = searchText.Length;

            // Vuelve a conectar el evento
            comboBoxClientesProveedores.TextChanged += comboBoxClientesProveedores_TextChanged;

        }

    }
    }


