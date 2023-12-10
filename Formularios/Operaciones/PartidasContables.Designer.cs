namespace SistemaContable.Formularios
{
    partial class PartidasContables
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonNuevo = new Button();
            dtgPartidaContable = new DataGridView();
            comboBoxPartidas = new ComboBox();
            label1 = new Label();
            textBoxId = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            textBoxMonto = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBoxCuentas = new ComboBox();
            buttonReporte = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgPartidaContable).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1109, 177);
            button3.Name = "button3";
            button3.Size = new Size(94, 45);
            button3.TabIndex = 14;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1004, 177);
            button2.Name = "button2";
            button2.Size = new Size(94, 45);
            button2.TabIndex = 13;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(904, 177);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 12;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.BackColor = SystemColors.MenuHighlight;
            buttonNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNuevo.ForeColor = Color.White;
            buttonNuevo.Location = new Point(804, 177);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(94, 45);
            buttonNuevo.TabIndex = 11;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += ButtonNuevo_Click;
            // 
            // dtgPartidaContable
            // 
            dtgPartidaContable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgPartidaContable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgPartidaContable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgPartidaContable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPartidaContable.Location = new Point(12, 238);
            dtgPartidaContable.Name = "dtgPartidaContable";
            dtgPartidaContable.ReadOnly = true;
            dtgPartidaContable.RowHeadersWidth = 51;
            dtgPartidaContable.RowTemplate.Height = 29;
            dtgPartidaContable.Size = new Size(1447, 718);
            dtgPartidaContable.TabIndex = 10;
            dtgPartidaContable.CellClick += DtgPartidaContable_CellClick;
            // 
            // comboBoxPartidas
            // 
            comboBoxPartidas.FormattingEnabled = true;
            comboBoxPartidas.Location = new Point(12, 32);
            comboBoxPartidas.Name = "comboBoxPartidas";
            comboBoxPartidas.Size = new Size(251, 28);
            comboBoxPartidas.TabIndex = 15;
            comboBoxPartidas.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 16;
            label1.Text = "Partida";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(1387, 23);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(72, 27);
            textBoxId.TabIndex = 17;
            textBoxId.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 108);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 82);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 19;
            label2.Text = "Fecha";
            // 
            // textBoxMonto
            // 
            textBoxMonto.Location = new Point(367, 32);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.PlaceholderText = "200.00 lps";
            textBoxMonto.Size = new Size(200, 27);
            textBoxMonto.TabIndex = 20;
            textBoxMonto.KeyPress += TextBoxMonto_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(367, 6);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 21;
            label3.Text = "Monto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(367, 81);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 23;
            label4.Text = "Cuenta";
            // 
            // comboBoxCuentas
            // 
            comboBoxCuentas.FormattingEnabled = true;
            comboBoxCuentas.Location = new Point(367, 107);
            comboBoxCuentas.Name = "comboBoxCuentas";
            comboBoxCuentas.Size = new Size(251, 28);
            comboBoxCuentas.TabIndex = 22;
            // 
            // buttonReporte
            // 
            buttonReporte.BackColor = Color.OliveDrab;
            buttonReporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReporte.ForeColor = Color.White;
            buttonReporte.Location = new Point(1220, 177);
            buttonReporte.Name = "buttonReporte";
            buttonReporte.Size = new Size(121, 45);
            buttonReporte.TabIndex = 24;
            buttonReporte.Text = "Ver Reporte";
            buttonReporte.UseVisualStyleBackColor = false;
            buttonReporte.Click += Button4_Click;
            // 
            // PartidasContables
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 968);
            Controls.Add(buttonReporte);
            Controls.Add(label4);
            Controls.Add(comboBoxCuentas);
            Controls.Add(label3);
            Controls.Add(textBoxMonto);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            Controls.Add(comboBoxPartidas);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonNuevo);
            Controls.Add(dtgPartidaContable);
            Name = "PartidasContables";
            Text = "PartidasContables";
            Load += PartidasContables_Load;
            ((System.ComponentModel.ISupportInitialize)dtgPartidaContable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonNuevo;
        private DataGridView dtgPartidaContable;
        private ComboBox comboBoxPartidas;
        private Label label1;
        private TextBox textBoxId;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox textBoxMonto;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxCuentas;
        private Button buttonReporte;
    }
}