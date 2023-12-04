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
    public partial class Catalogo_Contable : Form
    {
        public Catalogo_Contable()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarDatos()
        {
            string query = "SELECT IdCuenta, NombreCuenta, TipoCuenta, Descripcion FROM CatalogoContable";
            ConexionSql conexionSql = new();

            try
            {
                using SqlCommand command = new(query, conexionSql.AbrirConexion());
                using SqlDataAdapter adapter = new(command);
                DataTable table = new();
                adapter.Fill(table);
                dtgCatalogoContable.DataSource = table;
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

        private void LimpiarCampos()
        {
            textBoxId.Clear();
            textBoxCuenta.Clear();
            textBoxDescripcion.Clear();
            comboBoxtipoCuenta.SelectedItem = null;
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Obtén los valores de los controles TextBox de tu formulario
            string nombreCuenta = textBoxCuenta.Text.Trim();
            string tipoCuenta = comboBoxtipoCuenta.Text.Trim();
            string descripcion = textBoxDescripcion.Text.Trim();

            // Verifica que los campos necesarios estén llenos
            if (string.IsNullOrEmpty(nombreCuenta) || string.IsNullOrEmpty(tipoCuenta))
            {
                MessageBox.Show("Por favor, complete todos los campos necesarios.");
                return;
            }

            // Utiliza tu clase ConexionSql para obtener la conexión
            ConexionSql conexionSql = new();

            // Define la consulta SQL para insertar los datos
            string query = "INSERT INTO CatalogoContable (NombreCuenta, TipoCuenta, Descripcion) VALUES (@NombreCuenta, @TipoCuenta, @Descripcion)";

            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
            // Agrega los parámetros al comando para evitar la inyección SQL
            command.Parameters.AddWithValue("@NombreCuenta", nombreCuenta);
            command.Parameters.AddWithValue("@TipoCuenta", tipoCuenta);
            command.Parameters.AddWithValue("@Descripcion", descripcion);

            try
            {
                // Ejecuta el comando y verifica el resultado
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Cuenta contable guardada con éxito.");
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
        private void AjustarDtagridview()
        {
           
            dtgCatalogoContable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCatalogoContable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgCatalogoContable.AllowUserToAddRows = false;
            dtgCatalogoContable.AllowUserToDeleteRows = false;
            dtgCatalogoContable.AllowUserToResizeColumns = false;
            dtgCatalogoContable.AllowUserToResizeRows = false;
            dtgCatalogoContable.MultiSelect = false;
            dtgCatalogoContable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void Catalogo_Contable_Load(object sender, EventArgs e)

        {
            AjustarDtagridview();
            CargarDatos();

        }


        private void DtgCatalogoContable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGrid
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = this.dtgCatalogoContable.Rows[e.RowIndex];

                // Mostrar los valores de las columnas seleccionadas en los campos correspondientes
                textBoxId.Text = row.Cells["IdCuenta"].Value.ToString();
                textBoxCuenta.Text = row.Cells["NombreCuenta"].Value.ToString();
                comboBoxtipoCuenta.Text = row.Cells["TipoCuenta"].Value.ToString();
                textBoxDescripcion.Text = row.Cells["Descripcion"].Value.ToString();

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

            if (!int.TryParse(textBoxId.Text, out int idCuenta))
            {
                MessageBox.Show("El ID de cuenta proporcionado no es válido.");
                return;
            }

            string nombreCuenta = textBoxCuenta.Text;
            string tipoCuenta = comboBoxtipoCuenta.Text;
            string descripcion = textBoxDescripcion.Text;

            string query = "UPDATE CatalogoContable SET NombreCuenta = @NombreCuenta, TipoCuenta = @TipoCuenta, Descripcion = @Descripcion WHERE IdCuenta = @IdCuenta";

            ConexionSql conexionSql = new();
            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
            command.Parameters.AddWithValue("@IdCuenta", idCuenta);
            command.Parameters.AddWithValue("@NombreCuenta", nombreCuenta);
            command.Parameters.AddWithValue("@TipoCuenta", tipoCuenta);
            command.Parameters.AddWithValue("@Descripcion", descripcion);

            try
            {
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Cuenta contable actualizada con éxito.");
                    CargarDatos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró la cuenta contable o no se necesitó actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la cuenta contable: " + ex.Message);
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

            if (!int.TryParse(textBoxId.Text, out int idCuenta))
            {
                MessageBox.Show("El ID de cuenta proporcionado no es válido.");
                return;
            }

            // Pedir confirmación antes de eliminar
            if (MessageBox.Show("¿Está seguro de que desea eliminar esta cuenta contable?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE FROM CatalogoContable WHERE IdCuenta = @IdCuenta";

                ConexionSql conexionSql = new();
                using SqlConnection conexion = conexionSql.AbrirConexion();
                using SqlCommand command = new(query, conexion);
                command.Parameters.AddWithValue("@IdCuenta", idCuenta);

                try
                {
                    int result = command.ExecuteNonQuery();
                    if (result > 0)

                    {
                        CargarDatos();
                        LimpiarCampos();
                        MessageBox.Show("Cuenta contable eliminada con éxito.");
                       
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la cuenta contable.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la cuenta contable: " + ex.Message);
                }
            }
        }
    }
}
