namespace SistemaContable.Formularios
{
    partial class MD
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MD));
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            fileMenu = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            editMenu = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            viewMenu = new ToolStripMenuItem();
            toolBarToolStripMenuItem = new ToolStripMenuItem();
            statusBarToolStripMenuItem = new ToolStripMenuItem();
            toolsMenu = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            movimientosPorCuentaToolStripMenuItem = new ToolStripMenuItem();
            balanceGeneralToolStripMenuItem = new ToolStripMenuItem();
            estadoDeResultadoToolStripMenuItem = new ToolStripMenuItem();
            windowsMenu = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            helpMenu = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            historicoValorDeConversiónToolStripMenuItem = new ToolStripMenuItem();
            menuStrip = new MenuStrip();
            statusStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 694);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 19, 0);
            statusStrip.Size = new Size(1435, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            statusStrip.ItemClicked += StatusStrip_ItemClicked;
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(54, 20);
            toolStripStatusLabel.Text = "Estado";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator3, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileMenu.Image = (Image)resources.GetObject("fileMenu.Image");
            fileMenu.ImageTransparentColor = SystemColors.ActiveBorder;
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(110, 24);
            fileMenu.Text = "Catalogos";
            fileMenu.Click += FileMenu_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = Color.Black;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.ShowShortcutKeys = false;
            newToolStripMenuItem.Size = new Size(259, 26);
            newToolStripMenuItem.Text = "&Catalogo Contable";
            newToolStripMenuItem.Click += ShowNewForm;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Black;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.ShowShortcutKeys = false;
            openToolStripMenuItem.Size = new Size(259, 26);
            openToolStripMenuItem.Text = "Cátalago de Transacciones";
            openToolStripMenuItem.Click += OpenFile;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(256, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Black;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.ShowShortcutKeys = false;
            saveToolStripMenuItem.Size = new Size(259, 26);
            saveToolStripMenuItem.Text = "Cátalago de Monedas";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Image = (Image)resources.GetObject("saveAsToolStripMenuItem.Image");
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShowShortcutKeys = false;
            saveAsToolStripMenuItem.Size = new Size(259, 26);
            saveAsToolStripMenuItem.Text = "Cátalago de Partidas";
            saveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // editMenu
            // 
            editMenu.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem });
            editMenu.Image = (Image)resources.GetObject("editMenu.Image");
            editMenu.Name = "editMenu";
            editMenu.Size = new Size(126, 24);
            editMenu.Text = "&Operaciones";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Image = (Image)resources.GetObject("undoToolStripMenuItem.Image");
            undoToolStripMenuItem.ImageTransparentColor = Color.Black;
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.ShowShortcutKeys = false;
            undoToolStripMenuItem.Size = new Size(252, 26);
            undoToolStripMenuItem.Text = "Partidas Contables";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Image = (Image)resources.GetObject("redoToolStripMenuItem.Image");
            redoToolStripMenuItem.ImageTransparentColor = Color.Black;
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.ShowShortcutKeys = false;
            redoToolStripMenuItem.Size = new Size(252, 26);
            redoToolStripMenuItem.Text = "Cuentas Por Cobrar/Pagar";
            // 
            // viewMenu
            // 
            viewMenu.DropDownItems.AddRange(new ToolStripItem[] { toolBarToolStripMenuItem, statusBarToolStripMenuItem });
            viewMenu.Image = (Image)resources.GetObject("viewMenu.Image");
            viewMenu.Name = "viewMenu";
            viewMenu.Size = new Size(150, 24);
            viewMenu.Text = "&Configuraciones";
            // 
            // toolBarToolStripMenuItem
            // 
            toolBarToolStripMenuItem.CheckOnClick = true;
            toolBarToolStripMenuItem.Image = (Image)resources.GetObject("toolBarToolStripMenuItem.Image");
            toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            toolBarToolStripMenuItem.Size = new Size(224, 26);
            toolBarToolStripMenuItem.Text = "Fechas Modulares";
            toolBarToolStripMenuItem.Click += ToolBarToolStripMenuItem_Click;
            // 
            // statusBarToolStripMenuItem
            // 
            statusBarToolStripMenuItem.CheckOnClick = true;
            statusBarToolStripMenuItem.Image = (Image)resources.GetObject("statusBarToolStripMenuItem.Image");
            statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            statusBarToolStripMenuItem.Size = new Size(224, 26);
            statusBarToolStripMenuItem.Text = "Periodos Contables";
            statusBarToolStripMenuItem.Click += StatusBarToolStripMenuItem_Click;
            // 
            // toolsMenu
            // 
            toolsMenu.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem, movimientosPorCuentaToolStripMenuItem, balanceGeneralToolStripMenuItem, estadoDeResultadoToolStripMenuItem });
            toolsMenu.Image = (Image)resources.GetObject("toolsMenu.Image");
            toolsMenu.Name = "toolsMenu";
            toolsMenu.Size = new Size(102, 24);
            toolsMenu.Text = "&Reportes";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Image = (Image)resources.GetObject("optionsToolStripMenuItem.Image");
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(253, 26);
            optionsToolStripMenuItem.Text = "Movimientos Diarios";
            // 
            // movimientosPorCuentaToolStripMenuItem
            // 
            movimientosPorCuentaToolStripMenuItem.Image = (Image)resources.GetObject("movimientosPorCuentaToolStripMenuItem.Image");
            movimientosPorCuentaToolStripMenuItem.Name = "movimientosPorCuentaToolStripMenuItem";
            movimientosPorCuentaToolStripMenuItem.Size = new Size(253, 26);
            movimientosPorCuentaToolStripMenuItem.Text = "Movimientos Por Cuenta";
            // 
            // balanceGeneralToolStripMenuItem
            // 
            balanceGeneralToolStripMenuItem.Image = (Image)resources.GetObject("balanceGeneralToolStripMenuItem.Image");
            balanceGeneralToolStripMenuItem.Name = "balanceGeneralToolStripMenuItem";
            balanceGeneralToolStripMenuItem.Size = new Size(253, 26);
            balanceGeneralToolStripMenuItem.Text = "Balance General";
            // 
            // estadoDeResultadoToolStripMenuItem
            // 
            estadoDeResultadoToolStripMenuItem.Image = (Image)resources.GetObject("estadoDeResultadoToolStripMenuItem.Image");
            estadoDeResultadoToolStripMenuItem.Name = "estadoDeResultadoToolStripMenuItem";
            estadoDeResultadoToolStripMenuItem.Size = new Size(253, 26);
            estadoDeResultadoToolStripMenuItem.Text = "Estado de Resultado";
            // 
            // windowsMenu
            // 
            windowsMenu.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem });
            windowsMenu.Image = (Image)resources.GetObject("windowsMenu.Image");
            windowsMenu.Name = "windowsMenu";
            windowsMenu.Size = new Size(143, 24);
            windowsMenu.Text = "&Administración";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Image = (Image)resources.GetObject("cascadeToolStripMenuItem.Image");
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(234, 26);
            cascadeToolStripMenuItem.Text = "&Catalogo de Usuarios";
            cascadeToolStripMenuItem.Click += CascadeToolStripMenuItem_Click;
            // 
            // helpMenu
            // 
            helpMenu.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, toolStripSeparator8, historicoValorDeConversiónToolStripMenuItem });
            helpMenu.Image = (Image)resources.GetObject("helpMenu.Image");
            helpMenu.Name = "helpMenu";
            helpMenu.Size = new Size(109, 24);
            helpMenu.Text = "Historicos";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Image = (Image)resources.GetObject("contentsToolStripMenuItem.Image");
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F1;
            contentsToolStripMenuItem.ShowShortcutKeys = false;
            contentsToolStripMenuItem.Size = new Size(288, 26);
            contentsToolStripMenuItem.Text = "Historico Saldos Por Periodo";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(285, 6);
            // 
            // historicoValorDeConversiónToolStripMenuItem
            // 
            historicoValorDeConversiónToolStripMenuItem.Image = (Image)resources.GetObject("historicoValorDeConversiónToolStripMenuItem.Image");
            historicoValorDeConversiónToolStripMenuItem.Name = "historicoValorDeConversiónToolStripMenuItem";
            historicoValorDeConversiónToolStripMenuItem.Size = new Size(288, 26);
            historicoValorDeConversiónToolStripMenuItem.Text = "Historico Valor de Conversión";
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, editMenu, viewMenu, toolsMenu, windowsMenu, helpMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.MdiWindowListItem = windowsMenu;
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(1435, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // MD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1435, 720);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MD";
            Load += MD_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolTip toolTip;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem editMenu;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem viewMenu;
        private ToolStripMenuItem toolBarToolStripMenuItem;
        private ToolStripMenuItem statusBarToolStripMenuItem;
        private ToolStripMenuItem toolsMenu;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem windowsMenu;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private MenuStrip menuStrip;
        private ToolStripMenuItem movimientosPorCuentaToolStripMenuItem;
        private ToolStripMenuItem balanceGeneralToolStripMenuItem;
        private ToolStripMenuItem estadoDeResultadoToolStripMenuItem;
        private ToolStripMenuItem historicoValorDeConversiónToolStripMenuItem;
    }
}



