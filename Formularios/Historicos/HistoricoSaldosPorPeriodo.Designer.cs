namespace SistemaContable.Historicos
{
    partial class HistoricoSaldosPorPeriodo
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
            textBoxId = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonNuevo = new Button();
            dtgHistoricoSPP = new DataGridView();
            comboBoxPeriodo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxCuenta = new ComboBox();
            label3 = new Label();
            textBoxSaldoInicial = new TextBox();
            label4 = new Label();
            textBoxSaldoFinal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgHistoricoSPP).BeginInit();
            SuspendLayout();
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(1298, 11);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(72, 27);
            textBoxId.TabIndex = 25;
            textBoxId.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1298, 123);
            button3.Name = "button3";
            button3.Size = new Size(94, 45);
            button3.TabIndex = 24;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1193, 123);
            button2.Name = "button2";
            button2.Size = new Size(94, 45);
            button2.TabIndex = 23;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1093, 123);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 22;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.BackColor = SystemColors.MenuHighlight;
            buttonNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNuevo.ForeColor = Color.White;
            buttonNuevo.Location = new Point(993, 123);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(94, 45);
            buttonNuevo.TabIndex = 21;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += ButtonNuevo_Click;
            // 
            // dtgHistoricoSPP
            // 
            dtgHistoricoSPP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgHistoricoSPP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgHistoricoSPP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgHistoricoSPP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHistoricoSPP.Location = new Point(12, 197);
            dtgHistoricoSPP.Name = "dtgHistoricoSPP";
            dtgHistoricoSPP.ReadOnly = true;
            dtgHistoricoSPP.RowHeadersWidth = 51;
            dtgHistoricoSPP.RowTemplate.Height = 29;
            dtgHistoricoSPP.Size = new Size(1466, 700);
            dtgHistoricoSPP.TabIndex = 20;
            dtgHistoricoSPP.CellClick += DtgHistoricoSPP_CellClick;
            // 
            // comboBoxPeriodo
            // 
            comboBoxPeriodo.FormattingEnabled = true;
            comboBoxPeriodo.Location = new Point(12, 44);
            comboBoxPeriodo.Name = "comboBoxPeriodo";
            comboBoxPeriodo.Size = new Size(263, 28);
            comboBoxPeriodo.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 27;
            label1.Text = "Periodo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 29;
            label2.Text = "Cuenta";
            // 
            // comboBoxCuenta
            // 
            comboBoxCuenta.FormattingEnabled = true;
            comboBoxCuenta.Location = new Point(12, 123);
            comboBoxCuenta.Name = "comboBoxCuenta";
            comboBoxCuenta.Size = new Size(263, 28);
            comboBoxCuenta.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(351, 9);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 31;
            label3.Text = "Saldo Inicial";
            // 
            // textBoxSaldoInicial
            // 
            textBoxSaldoInicial.Location = new Point(351, 45);
            textBoxSaldoInicial.Name = "textBoxSaldoInicial";
            textBoxSaldoInicial.PlaceholderText = "200.00 lps";
            textBoxSaldoInicial.Size = new Size(251, 27);
            textBoxSaldoInicial.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(351, 88);
            label4.Name = "label4";
            label4.Size = new Size(98, 23);
            label4.TabIndex = 33;
            label4.Text = "Saldo Final";
            // 
            // textBoxSaldoFinal
            // 
            textBoxSaldoFinal.Location = new Point(351, 123);
            textBoxSaldoFinal.Name = "textBoxSaldoFinal";
            textBoxSaldoFinal.PlaceholderText = "200.00 lps";
            textBoxSaldoFinal.Size = new Size(251, 27);
            textBoxSaldoFinal.TabIndex = 32;
            // 
            // HistoricoSaldosPorPeriodo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 909);
            Controls.Add(label4);
            Controls.Add(textBoxSaldoFinal);
            Controls.Add(label3);
            Controls.Add(textBoxSaldoInicial);
            Controls.Add(label2);
            Controls.Add(comboBoxCuenta);
            Controls.Add(label1);
            Controls.Add(comboBoxPeriodo);
            Controls.Add(textBoxId);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonNuevo);
            Controls.Add(dtgHistoricoSPP);
            Name = "HistoricoSaldosPorPeriodo";
            Text = "Historico Saldos Por Periodo";
            Load += HistoricoSaldosPorPeriodo_Load;
            ((System.ComponentModel.ISupportInitialize)dtgHistoricoSPP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxId;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonNuevo;
        private DataGridView dtgHistoricoSPP;
        private ComboBox comboBoxPeriodo;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxCuenta;
        private Label label3;
        private TextBox textBoxSaldoInicial;
        private Label label4;
        private TextBox textBoxSaldoFinal;
    }
}