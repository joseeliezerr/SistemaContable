namespace SistemaContable.Formularios.Configuraciones
{
    partial class FechasModulares
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
            label2 = new Label();
            dateTimePickerInicio = new DateTimePicker();
            textBoxId = new TextBox();
            label1 = new Label();
            dateTimePickerFin = new DateTimePicker();
            label3 = new Label();
            textBoxDescripcion = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonNuevo = new Button();
            dtgFechasModulares = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgFechasModulares).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 9);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 32;
            label2.Text = "Fecha de Inicio";
            label2.Click += Label2_Click;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(12, 35);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(250, 27);
            dateTimePickerInicio.TabIndex = 31;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(1308, 35);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(72, 27);
            textBoxId.TabIndex = 30;
            textBoxId.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(325, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 34;
            label1.Text = "Fecha de Fin";
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Location = new Point(326, 35);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(250, 27);
            dateTimePickerFin.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 83);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 36;
            label3.Text = "Descripción";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(11, 109);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.PlaceholderText = "Descripcion";
            textBoxDescripcion.Size = new Size(565, 76);
            textBoxDescripcion.TabIndex = 35;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1194, 138);
            button3.Name = "button3";
            button3.Size = new Size(94, 45);
            button3.TabIndex = 41;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1089, 138);
            button2.Name = "button2";
            button2.Size = new Size(94, 45);
            button2.TabIndex = 40;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(989, 138);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 39;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.BackColor = SystemColors.MenuHighlight;
            buttonNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNuevo.ForeColor = Color.White;
            buttonNuevo.Location = new Point(889, 138);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(94, 45);
            buttonNuevo.TabIndex = 38;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += ButtonNuevo_Click;
            // 
            // dtgFechasModulares
            // 
            dtgFechasModulares.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgFechasModulares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgFechasModulares.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgFechasModulares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgFechasModulares.Location = new Point(11, 208);
            dtgFechasModulares.Name = "dtgFechasModulares";
            dtgFechasModulares.ReadOnly = true;
            dtgFechasModulares.RowHeadersWidth = 51;
            dtgFechasModulares.RowTemplate.Height = 29;
            dtgFechasModulares.Size = new Size(1383, 638);
            dtgFechasModulares.TabIndex = 37;
            dtgFechasModulares.CellClick += DtgFechasModulares_CellClick;
            // 
            // FechasModulares
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 858);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonNuevo);
            Controls.Add(dtgFechasModulares);
            Controls.Add(label3);
            Controls.Add(textBoxDescripcion);
            Controls.Add(label1);
            Controls.Add(dateTimePickerFin);
            Controls.Add(label2);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(textBoxId);
            Name = "FechasModulares";
            Text = "FechasModulares";
            Load += FechasModulares_Load;
            ((System.ComponentModel.ISupportInitialize)dtgFechasModulares).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DateTimePicker dateTimePickerInicio;
        private TextBox textBoxId;
        private Label label1;
        private DateTimePicker dateTimePickerFin;
        private Label label3;
        private TextBox textBoxDescripcion;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonNuevo;
        private DataGridView dtgFechasModulares;
    }
}