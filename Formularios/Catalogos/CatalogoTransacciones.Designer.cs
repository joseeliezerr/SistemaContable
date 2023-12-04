namespace SistemaContable.Formularios
{
    partial class CatalogoTransacciones
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
            dtgCatalogoTransacciones = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonNuevo = new Button();
            textBoxId = new TextBox();
            dateTimePickerFecha = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            textBoxDescripcion = new TextBox();
            comboBoxtipoTransaccion = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgCatalogoTransacciones).BeginInit();
            SuspendLayout();
            // 
            // dtgCatalogoTransacciones
            // 
            dtgCatalogoTransacciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgCatalogoTransacciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgCatalogoTransacciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgCatalogoTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCatalogoTransacciones.Location = new Point(-2, 162);
            dtgCatalogoTransacciones.Name = "dtgCatalogoTransacciones";
            dtgCatalogoTransacciones.ReadOnly = true;
            dtgCatalogoTransacciones.RowHeadersWidth = 51;
            dtgCatalogoTransacciones.RowTemplate.Height = 29;
            dtgCatalogoTransacciones.Size = new Size(1429, 631);
            dtgCatalogoTransacciones.TabIndex = 2;
            dtgCatalogoTransacciones.CellClick += DtgCatalogoContable_CellClick;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1189, 96);
            button3.Name = "button3";
            button3.Size = new Size(94, 45);
            button3.TabIndex = 13;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1084, 96);
            button2.Name = "button2";
            button2.Size = new Size(94, 45);
            button2.TabIndex = 12;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(984, 96);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 11;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.BackColor = SystemColors.MenuHighlight;
            buttonNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNuevo.ForeColor = Color.White;
            buttonNuevo.Location = new Point(884, 96);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(94, 45);
            buttonNuevo.TabIndex = 10;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += ButtonNuevo_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(1335, 18);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(72, 27);
            textBoxId.TabIndex = 14;
            textBoxId.Visible = false;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Location = new Point(12, 39);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(250, 27);
            dateTimePickerFecha.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(337, 2);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 19;
            label3.Text = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 18;
            label2.Text = "Tipo";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(337, 28);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.PlaceholderText = "Descripcion";
            textBoxDescripcion.Size = new Size(462, 76);
            textBoxDescripcion.TabIndex = 17;
            // 
            // comboBoxtipoTransaccion
            // 
            comboBoxtipoTransaccion.FormattingEnabled = true;
            comboBoxtipoTransaccion.Items.AddRange(new object[] { "INGRESOS", "GASTOS", "INVERSIONES", "FINANCIAMIENTO", "TRANSACCION DE AJUSTE", "TRANSACCIONES NO MONETARIAS", "OPERACIONES DEL DIA A DIA" });
            comboBoxtipoTransaccion.Location = new Point(12, 113);
            comboBoxtipoTransaccion.Name = "comboBoxtipoTransaccion";
            comboBoxtipoTransaccion.Size = new Size(250, 28);
            comboBoxtipoTransaccion.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 20;
            label1.Text = "Fecha";
            // 
            // CatalogoTransacciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 793);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxDescripcion);
            Controls.Add(comboBoxtipoTransaccion);
            Controls.Add(dateTimePickerFecha);
            Controls.Add(textBoxId);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonNuevo);
            Controls.Add(dtgCatalogoTransacciones);
            Name = "CatalogoTransacciones";
            Text = "CatalogoTransacciones";
            Load += CatalogoTransacciones_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCatalogoTransacciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgCatalogoTransacciones;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonNuevo;
        private TextBox textBoxId;
        private DateTimePicker dateTimePickerFecha;
        private Label label3;
        private Label label2;
        private TextBox textBoxDescripcion;
        private ComboBox comboBoxtipoTransaccion;
        private Label label1;
    }
}