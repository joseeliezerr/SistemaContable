namespace SistemaContable.Formularios.Operaciones
{
    partial class CuentasPorCobrarPagar
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
            dtgCuentasCobrarPagar = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonNuevo = new Button();
            textBoxId = new TextBox();
            label4 = new Label();
            comboBoxClientesProveedores = new ComboBox();
            label3 = new Label();
            textBoxMonto = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            comboBoxCuenta = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgCuentasCobrarPagar).BeginInit();
            SuspendLayout();
            // 
            // dtgCuentasCobrarPagar
            // 
            dtgCuentasCobrarPagar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgCuentasCobrarPagar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgCuentasCobrarPagar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgCuentasCobrarPagar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCuentasCobrarPagar.Location = new Point(3, 179);
            dtgCuentasCobrarPagar.Name = "dtgCuentasCobrarPagar";
            dtgCuentasCobrarPagar.ReadOnly = true;
            dtgCuentasCobrarPagar.RowHeadersWidth = 51;
            dtgCuentasCobrarPagar.RowTemplate.Height = 29;
            dtgCuentasCobrarPagar.Size = new Size(1504, 719);
            dtgCuentasCobrarPagar.TabIndex = 11;
            dtgCuentasCobrarPagar.CellClick += DtgCuentasCobrarPagar_CellClick;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1338, 105);
            button3.Name = "button3";
            button3.Size = new Size(94, 45);
            button3.TabIndex = 18;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1233, 105);
            button2.Name = "button2";
            button2.Size = new Size(94, 45);
            button2.TabIndex = 17;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1133, 105);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 16;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.BackColor = SystemColors.MenuHighlight;
            buttonNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNuevo.ForeColor = Color.White;
            buttonNuevo.Location = new Point(1033, 105);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(94, 45);
            buttonNuevo.TabIndex = 15;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += ButtonNuevo_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(1360, 12);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(72, 27);
            textBoxId.TabIndex = 19;
            textBoxId.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 13);
            label4.Name = "label4";
            label4.Size = new Size(173, 23);
            label4.TabIndex = 25;
            label4.Text = " Cliente o Proveedor";
            // 
            // comboBoxClientesProveedores
            // 
            comboBoxClientesProveedores.FormattingEnabled = true;
            comboBoxClientesProveedores.Location = new Point(12, 39);
            comboBoxClientesProveedores.Name = "comboBoxClientesProveedores";
            comboBoxClientesProveedores.Size = new Size(251, 28);
            comboBoxClientesProveedores.TabIndex = 24;
         //   comboBoxClientesProveedores.TextChanged += ComboBoxClientesProveedores_TextChanged;
          //  comboBoxClientesProveedores.KeyUp += comboBoxClientesProveedores_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 27;
            label3.Text = "Saldo";
            // 
            // textBoxMonto
            // 
            textBoxMonto.Location = new Point(12, 114);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.PlaceholderText = "200.00 lps";
            textBoxMonto.Size = new Size(251, 27);
            textBoxMonto.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(360, 14);
            label2.Name = "label2";
            label2.Size = new Size(184, 23);
            label2.TabIndex = 29;
            label2.Text = "Fecha de Vencimiento";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(361, 40);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(360, 88);
            label1.Name = "label1";
            label1.Size = new Size(66, 23);
            label1.TabIndex = 31;
            label1.Text = "Cuenta";
            // 
            // comboBoxCuenta
            // 
            comboBoxCuenta.FormattingEnabled = true;
            comboBoxCuenta.Items.AddRange(new object[] { "COBRAR", "PAGAR" });
            comboBoxCuenta.Location = new Point(360, 114);
            comboBoxCuenta.Name = "comboBoxCuenta";
            comboBoxCuenta.Size = new Size(251, 28);
            comboBoxCuenta.TabIndex = 30;
            // 
            // CuentasPorCobrarPagar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1508, 900);
            Controls.Add(label1);
            Controls.Add(comboBoxCuenta);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBoxMonto);
            Controls.Add(label4);
            Controls.Add(comboBoxClientesProveedores);
            Controls.Add(textBoxId);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonNuevo);
            Controls.Add(dtgCuentasCobrarPagar);
            Name = "CuentasPorCobrarPagar";
            Text = "CuentasPorCobrarPagar";
            Load += CuentasPorCobrarPagar_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCuentasCobrarPagar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgCuentasCobrarPagar;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonNuevo;
        private TextBox textBoxId;
        private Label label4;
        private ComboBox comboBoxClientesProveedores;
        private Label label3;
        private TextBox textBoxMonto;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ComboBox comboBoxCuenta;
    }
}