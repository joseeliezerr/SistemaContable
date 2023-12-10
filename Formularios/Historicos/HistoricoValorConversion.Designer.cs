namespace SistemaContable.Formularios.Historicos
{
    partial class HistoricoValorConversion
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
            dtgHistoricoVC = new DataGridView();
            label1 = new Label();
            comboBoxMoneda = new ComboBox();
            label2 = new Label();
            dateTimePickerFecha = new DateTimePicker();
            textBoxTasaCambio = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgHistoricoVC).BeginInit();
            SuspendLayout();
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(1310, 12);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(72, 27);
            textBoxId.TabIndex = 31;
            textBoxId.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1296, 63);
            button3.Name = "button3";
            button3.Size = new Size(94, 45);
            button3.TabIndex = 30;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1191, 63);
            button2.Name = "button2";
            button2.Size = new Size(94, 45);
            button2.TabIndex = 29;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1091, 63);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 28;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.BackColor = SystemColors.MenuHighlight;
            buttonNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNuevo.ForeColor = Color.White;
            buttonNuevo.Location = new Point(991, 63);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(94, 45);
            buttonNuevo.TabIndex = 27;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            // 
            // dtgHistoricoVC
            // 
            dtgHistoricoVC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgHistoricoVC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgHistoricoVC.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgHistoricoVC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHistoricoVC.Location = new Point(5, 161);
            dtgHistoricoVC.Name = "dtgHistoricoVC";
            dtgHistoricoVC.ReadOnly = true;
            dtgHistoricoVC.RowHeadersWidth = 51;
            dtgHistoricoVC.RowTemplate.Height = 29;
            dtgHistoricoVC.Size = new Size(1385, 615);
            dtgHistoricoVC.TabIndex = 26;
            dtgHistoricoVC.CellClick += DtgHistoricoVC_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 33;
            label1.Text = "Moneda";
            // 
            // comboBoxMoneda
            // 
            comboBoxMoneda.FormattingEnabled = true;
            comboBoxMoneda.Location = new Point(12, 43);
            comboBoxMoneda.Name = "comboBoxMoneda";
            comboBoxMoneda.Size = new Size(263, 28);
            comboBoxMoneda.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(307, 16);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 35;
            label2.Text = "Fecha";
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Location = new Point(307, 44);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(250, 27);
            dateTimePickerFecha.TabIndex = 34;
            // 
            // textBoxTasaCambio
            // 
            textBoxTasaCambio.Location = new Point(15, 112);
            textBoxTasaCambio.Name = "textBoxTasaCambio";
            textBoxTasaCambio.Size = new Size(260, 27);
            textBoxTasaCambio.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 85);
            label3.Name = "label3";
            label3.Size = new Size(136, 23);
            label3.TabIndex = 37;
            label3.Text = "Tasa de Cambio";
            // 
            // HistoricoValorConversion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 788);
            Controls.Add(label3);
            Controls.Add(textBoxTasaCambio);
            Controls.Add(label2);
            Controls.Add(dateTimePickerFecha);
            Controls.Add(label1);
            Controls.Add(comboBoxMoneda);
            Controls.Add(textBoxId);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonNuevo);
            Controls.Add(dtgHistoricoVC);
            Name = "HistoricoValorConversion";
            Text = "HistoricoValorConversion";
            Load += HistoricoValorConversion_Load;
            ((System.ComponentModel.ISupportInitialize)dtgHistoricoVC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxId;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonNuevo;
        private DataGridView dtgHistoricoVC;
        private Label label1;
        private ComboBox comboBoxMoneda;
        private Label label2;
        private DateTimePicker dateTimePickerFecha;
        private TextBox textBoxTasaCambio;
        private Label label3;
    }
}