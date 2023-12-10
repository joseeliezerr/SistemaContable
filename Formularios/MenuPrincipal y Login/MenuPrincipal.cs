using SistemaContable.Formularios.Administracion;
using SistemaContable.Formularios.Configuraciones;
using SistemaContable.Formularios.Historicos;
using SistemaContable.Formularios.Operaciones;
using SistemaContable.Historicos;
using SistemaContable.Reportes.Movimientos_Diarios;
using SistemaContable.Reportes.Movimientos_Por_Cuenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;



namespace SistemaContable.Formularios
{
    public partial class MenuPrincipal : Form
    {


        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Catalogo_Contable catalogoContable = new()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            catalogoContable.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            CatalogoTransacciones catalogoTransacciones = new()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            catalogoTransacciones.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoPartidas catalogoPartidas = new()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            catalogoPartidas.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FechasModulares FechasModulares = new()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            FechasModulares.Show();
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeriodosContables PeriodosContables = new()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            PeriodosContables.Show();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoUsuarios CatalogoUsuarios = new()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            CatalogoUsuarios.Show();
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MD_Load(object sender, EventArgs e)
        {

        }

        private void StatusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FileMenu_Click(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoMonedas catalogoMonedas = new()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            catalogoMonedas.Show();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartidasContables PartidasContables = new()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };

            // Asumiendo que el botón que quieres ocultar se llama 'btnMiBoton' y es de acceso público
            PartidasContables.OcultarBoton();

            PartidasContables.Show();
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuentasPorCobrarPagar CuentasPorCobrarPagar = new()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            CuentasPorCobrarPagar.Show();
        }

        private void CatalogoDeClientesProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoClientesProveedores CatalogoClientesProveedores = new()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            CatalogoClientesProveedores.Show();

        }

        private void ContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoricoSaldosPorPeriodo HistoricoSaldosPorPeriodo = new()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            HistoricoSaldosPorPeriodo.Show();
        }

        private void HistoricoValorDeConversiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoricoValorConversion HistoricoValorConversion = new()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            HistoricoValorConversion.Show();
        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovimientosDiarios MovimientosDiarios = new()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            MovimientosDiarios.Show();
        }

        private void MovimientosPorCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovimientosPorCuenta MovimientosPorCuenta = new()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            MovimientosPorCuenta.Show();
        }


        private void BalanceGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartidasContables PartidasContables = new()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            PartidasContables.Show();

        }
    }

}





