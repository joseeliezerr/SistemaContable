using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Globalization;

namespace SistemaContable.Formularios.Operaciones
{
    public partial class CuentasPorCobrarPagar : Form
    {
        private readonly List<string> nombresClientesProveedores = new();
        public CuentasPorCobrarPagar()
        {
            InitializeComponent();
        

          
           
        }
        private void CargarClienteoProveedor()
        {
            List<ClienteProveedorItem> nombresClientesProveedores = new();
            string query = "SELECT IdClienteProveedor, Nombre FROM ClientesProveedores";

            ConexionSql conexionSql = new ();
            using (SqlConnection conexion = conexionSql.AbrirConexion())
            {
                using SqlCommand command = new(query, conexion);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    nombresClientesProveedores.Add(new ClienteProveedorItem
                    {
                        Id = Convert.ToInt32(reader["IdClienteProveedor"]),
                        Nombre = reader["Nombre"].ToString()
                    });
                }
            }


            comboBoxClientesProveedores.DataSource = nombresClientesProveedores;
            comboBoxClientesProveedores.DisplayMember = "Nombre";
            comboBoxClientesProveedores.ValueMember = "Id";


            comboBoxClientesProveedores.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxClientesProveedores.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        public class ClienteProveedorItem
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            public override string ToString()
            {
                return Nombre; // Esto es lo que se mostrará en el combobox
            }
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

            ConexionSql conexionSql = new();
            using SqlConnection conexion = conexionSql.AbrirConexion();
            SqlCommand command = new(query, conexion);
            SqlDataAdapter adapter = new(command);
            DataTable table = new();
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


        private void Button1_Click(object sender, EventArgs e)
        {
          
            if (comboBoxClientesProveedores.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente o proveedor.");
                return;
            }

           
            Debug.WriteLine("SelectedValue: " + comboBoxClientesProveedores.SelectedValue);

            if (comboBoxClientesProveedores.SelectedValue != null &&
                int.TryParse(comboBoxClientesProveedores.SelectedValue.ToString(), out int idClienteProveedor))
            {

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente o proveedor válido.");
                return;
            }

            if (!float.TryParse(textBoxMonto.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float saldo))
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

            ConexionSql conexionSql = new();
            string queryInsercion = "INSERT INTO CuentasPorCobrarPagar (IdClienteProveedor, Saldo, FechaVencimiento, TipoCuenta) VALUES (@IdClienteProveedor, @Saldo, @FechaVencimiento, @TipoCuenta)";

            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand commandInsercion = new(queryInsercion, conexion);
            commandInsercion.Parameters.AddWithValue("@IdClienteProveedor", idClienteProveedor);
            commandInsercion.Parameters.AddWithValue("@Saldo", saldo);
            commandInsercion.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);
            commandInsercion.Parameters.AddWithValue("@TipoCuenta", comboBoxCuenta.SelectedItem.ToString());

            try
            {
                int result = commandInsercion.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Registro guardado con éxito.");
                    CargarDatosDtg();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se insertaron registros.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }




        private void DtgCuentasCobrarPagar_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void Button3_Click(object sender, EventArgs e)
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
                ConexionSql conexionSql = new();

                // Define la consulta SQL para eliminar los datos
                string query = "DELETE FROM CuentasPorCobrarPagar WHERE IdCuenta = @IdCuenta";

                using SqlConnection conexion = conexionSql.AbrirConexion();
                using SqlCommand command = new(query, conexion);
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

        private void Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show("Por favor, seleccione un registro para actualizar.");
                return;
            }

            int idCuenta = Convert.ToInt32(textBoxId.Text); // Asegúrate de que textBoxIdCuenta contiene el IdCuenta del registro a actualizar

            // A continuación se obtienen los valores de los controles del formulario para los otros campos
            int idClienteProveedor = Convert.ToInt32(comboBoxClientesProveedores.SelectedValue);
            bool isSaldoValid = float.TryParse(textBoxMonto.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float saldo);
            if (!isSaldoValid)
            {
                MessageBox.Show("Por favor, ingrese un saldo válido.");
                return;
            }
            DateTime fechaVencimiento = dateTimePicker1.Value;
            ConexionSql conexionSql = new();
            string query = @"
    UPDATE CuentasPorCobrarPagar
    SET IdClienteProveedor = @IdClienteProveedor, Saldo = @Saldo, FechaVencimiento = @FechaVencimiento, TipoCuenta = @TipoCuenta
    WHERE IdCuenta = @IdCuenta";

            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
            // Agrega los parámetros al comando para evitar la inyección SQL
            command.Parameters.AddWithValue("@IdCuenta", idCuenta);
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


