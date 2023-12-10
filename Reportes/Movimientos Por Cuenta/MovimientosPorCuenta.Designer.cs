namespace SistemaContable.Reportes.Movimientos_Por_Cuenta
{
    partial class MovimientosPorCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            button1 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.Padding = new Padding(0, 50, 0, 0);
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1350, 700);
            reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(246, 12);
            button1.Name = "button1";
            button1.Size = new Size(110, 29);
            button1.TabIndex = 8;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(5, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(235, 28);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Cuenta";
            // 
            // MovimientosPorCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 718);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(reportViewer1);
            Name = "MovimientosPorCuenta";
            Text = "MovimientosPorCuenta";
            Load += MovimientosPorCuenta_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Button button1;
        private ComboBox comboBox1;
    }
}