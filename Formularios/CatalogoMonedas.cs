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
    public partial class CatalogoMonedas : Form
    {
        public CatalogoMonedas()
        {
            InitializeComponent();
        }

        private void DtgCatalogoContable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            textBoxCodigoMoneda.Clear();
            textBoxId.Clear();
            textBoxNombreMoneda.Clear();
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void CargarDatos()
        {
            string query = "SELECT IdMoneda, NombreMoneda, CodigoMoneda FROM CatalogoMonedas";
            ConexionSql conexionSql = new();

            try
            {
                using SqlCommand command = new(query, conexionSql.AbrirConexion());
                using SqlDataAdapter adapter = new(command);
                DataTable table = new();
                adapter.Fill(table);
                dtgCatalogoMoneda.DataSource = table;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            String NombreMoneda = textBoxNombreMoneda.Text.Trim();
            String CodigoMoneda = textBoxCodigoMoneda.Text.Trim().ToUpper();


            //verificar que los campos no esten vacios 
            if (String.IsNullOrEmpty(NombreMoneda) || String.IsNullOrEmpty(CodigoMoneda))
            {
                MessageBox.Show("Por favor, complete todos los campos necesarios.");
                return;
            }


            ConexionSql conexionSql = new();

            String query = "INSERT INTO CatalogoMonedas(NombreMoneda,CodigoMoneda) VALUES (@NombreMoneda,@CodigoMoneda)";


            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);

            // Agrega los parámetros al comando para evitar la inyección SQL
            command.Parameters.AddWithValue("@NombreMoneda", NombreMoneda);
            command.Parameters.AddWithValue("@CodigoMoneda", CodigoMoneda);

            try
            {
                // Ejecuta el comando y verifica el resultado
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Catalogo Moneda guardada con éxito.");
                    CargarDatos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se insertaron registros.");
                }

            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción durante el proceso de inserción
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }
        private void AjustarDtagridview()
        {
            dtgCatalogoMoneda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCatalogoMoneda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgCatalogoMoneda.AllowUserToAddRows = false;
            dtgCatalogoMoneda.AllowUserToDeleteRows = false;
            dtgCatalogoMoneda.AllowUserToResizeColumns = false;
            dtgCatalogoMoneda.AllowUserToResizeRows = false;
            dtgCatalogoMoneda.MultiSelect = false;
            dtgCatalogoMoneda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DtgCatalogoMoneda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGrid
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = this.dtgCatalogoMoneda.Rows[e.RowIndex];

                // Mostrar los valores de las columnas seleccionadas en los campos correspondientes
                textBoxId.Text = row.Cells["IdMoneda"].Value.ToString();
                textBoxNombreMoneda.Text = row.Cells["NombreMoneda"].Value.ToString();
                textBoxCodigoMoneda.Text = row.Cells["CodigoMoneda"].Value.ToString();

            }
        }

        private void CatalogoMonedas_Load(object sender, EventArgs e)
        {
            CargarDatos();
            AjustarDtagridview();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un registro 
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show("Por favor, seleccione un registro para actualizar.");
                return;
            }

            if (!int.TryParse(textBoxId.Text, out int idMoneda))
            {
                MessageBox.Show("El ID de cuenta proporcionado no es válido.");
                return;
            }

            string nombreMoneda = textBoxNombreMoneda.Text;
            string codigoMoneda = textBoxCodigoMoneda.Text;


            string query = "UPDATE CatalogoMonedas SET nombreMoneda = @nombreMoneda, codigoMoneda = @codigoMoneda  WHERE IdMoneda = @IdMoneda";

            ConexionSql conexionSql = new();
            using SqlConnection conexion = conexionSql.AbrirConexion();
            using SqlCommand command = new(query, conexion);
            command.Parameters.AddWithValue("@IdMoneda", idMoneda);
            command.Parameters.AddWithValue("@nombreMoneda", nombreMoneda);
            command.Parameters.AddWithValue("@codigoMoneda", codigoMoneda);


            try
            {
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Catalogo Moneda actualizada con éxito.");
                    CargarDatos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró la moneda o no se necesitó actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la Moneda Contable: " + ex.Message);
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

            if (!int.TryParse(textBoxId.Text, out int idMoneda))
            {
                MessageBox.Show("El ID del catologo de monedas proporcionado no es válido.");
                return;
            }

            // Pedir confirmación antes de eliminar
            if (MessageBox.Show("¿Está seguro de que desea eliminar esta Moneda Contable?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE FROM CatalogoMonedas WHERE idMoneda = @idMoneda";

                ConexionSql conexionSql = new();
                using SqlConnection conexion = conexionSql.AbrirConexion();
                using SqlCommand command = new(query, conexion);
                command.Parameters.AddWithValue("@idMoneda", idMoneda);

                try
                {
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Moneda Contable eliminada con éxito.");
                        CargarDatos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la Moneda Contable.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la Moneda Contable: " + ex.Message);
                }
            }
        }
    }
}
