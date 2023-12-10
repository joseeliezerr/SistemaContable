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

namespace SistemaContable.Reportes.Movimientos_Diarios
{
    public partial class MovimientosDiarios : Form
    {
        public MovimientosDiarios()
        {
            InitializeComponent();

        }


        private void MovimientosDiarios_Load(object sender, EventArgs e)
        {
            //   string fechaReporte = "2023-03-15"; // Asegúrate de obtener esta fecha de forma dinámica, por ejemplo, a través de un control DatePicker o un parámetro.

            string query = $@"
    SELECT 
        FORMAT(ct.Fecha, 'dd/MM/yyyy') as Fecha,
        ct.TipoTransaccion,
        ct.Descripcion 
    FROM 
        CatalogoTransacciones ct
    ORDER BY 
        ct.Fecha, ct.IdTransaccion";




            DataSet dataSet = new();

            ConexionSql conexionSql1 = new();
            ConexionSql conexionSql = conexionSql1;
            using (SqlConnection connection = conexionSql.AbrirConexion())
            {
                using (SqlCommand command = new(query, connection))
                {
                    using SqlDataAdapter adapter = new(command);
                    adapter.Fill(dataSet, "MovimientosDiarios");
                }
                conexionSql.CerrarConexion();
            }

            reportViewer1.LocalReport.ReportPath = "E:\\Programacion\\c#\\SistemaContable\\Reportes\\Movimientos Diarios\\ReporteMovimientosDiarios.rdlc"; // Ruta al archivo del reporte
            ReportDataSource dataSource = new("DataSet1", dataSet.Tables[0]);
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dataSource);
            reportViewer1.RefreshReport();


        }

        private void ReportViewer1_Resize(object sender, EventArgs e)
        {
            reportViewer1.Top = 0;
            reportViewer1.Left = 0;
            reportViewer1.Height = this.ClientSize.Height;
            reportViewer1.Width = this.ClientSize.Width;
        }
    }
}
