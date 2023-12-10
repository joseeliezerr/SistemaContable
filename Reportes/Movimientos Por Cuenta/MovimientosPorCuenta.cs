using Microsoft.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaContable.Historicos.HistoricoSaldosPorPeriodo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaContable.Reportes.Movimientos_Por_Cuenta
{
    public partial class MovimientosPorCuenta : Form
    {
        public MovimientosPorCuenta()
        {
            InitializeComponent();
        }
        private void CargarCuentas()
        {
            List<Cuenta> CuentasContables = new();
            string query = "SELECT IdCuenta, NombreCuenta FROM CatalogoContable";

            ConexionSql conexionSql = new();
            using (SqlConnection conexion = conexionSql.AbrirConexion())
            {
                using SqlCommand command = new(query, conexion);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idCuenta = reader.GetInt32(reader.GetOrdinal("IdCuenta"));
                    string nombreCuenta = reader.GetString(reader.GetOrdinal("NombreCuenta"));
                    CuentasContables.Add(new Cuenta(idCuenta, nombreCuenta));
                }
            }
            comboBox1.DataSource = CuentasContables;
            comboBox1.DisplayMember = "NombreCuenta";
            comboBox1.ValueMember = "IdCuenta";
        }
        private void MovimientosPorCuenta_Load(object sender, EventArgs e)
        {

            CargarCuentas();



        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
            int idCuenta = Convert.ToInt32(comboBox1.SelectedValue);

         
            DataTable dataTableCatalogoContable = new ();

            using (SqlConnection connection = new ConexionSql().AbrirConexion())
            {
     
                string queryCatalogoContable = @"
        SELECT 
            IdCuenta,
            NombreCuenta,
            TipoCuenta,
            Descripcion
        FROM 
            CatalogoContable
        WHERE 
            IdCuenta = @IdCuenta";
                SqlCommand commandCatalogoContable = new (queryCatalogoContable, connection);
                commandCatalogoContable.Parameters.AddWithValue("@IdCuenta", idCuenta);
                SqlDataAdapter adapterCatalogoContable = new (commandCatalogoContable);
                adapterCatalogoContable.Fill(dataTableCatalogoContable);
            }

         
            reportViewer1.LocalReport.ReportPath = @"E:\Programacion\c#\SistemaContable\Reportes\Movimientos Por Cuenta\MovimientosPorCuenta.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();

          
            ReportDataSource dataSourceCatalogoContable = new("DataSet1", dataTableCatalogoContable);
            reportViewer1.LocalReport.DataSources.Add(dataSourceCatalogoContable);

            reportViewer1.RefreshReport();




        }
    }
}
