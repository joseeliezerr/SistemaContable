namespace SistemaContable.Formularios.Configuraciones
{
    partial class PeriodosContables
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
            dtgPeriodosContables = new DataGridView();
            label1 = new Label();
            dateTimePickerFin = new DateTimePicker();
            label2 = new Label();
            dateTimePickerInicio = new DateTimePicker();
            textBoxId = new TextBox();
            comboBoxEstado = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgPeriodosContables).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1182, 134);
            button3.Name = "button3";
            button3.Size = new Size(94, 45);
            button3.TabIndex = 51;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1077, 134);
            button2.Name = "button2";
            button2.Size = new Size(94, 45);
            button2.TabIndex = 50;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(977, 134);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 49;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.BackColor = SystemColors.MenuHighlight;
            buttonNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNuevo.ForeColor = Color.White;
            buttonNuevo.Location = new Point(877, 134);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(94, 45);
            buttonNuevo.TabIndex = 48;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += ButtonNuevo_Click;
            // 
            // dtgPeriodosContables
            // 
            dtgPeriodosContables.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgPeriodosContables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgPeriodosContables.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgPeriodosContables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPeriodosContables.Location = new Point(-1, 204);
            dtgPeriodosContables.Name = "dtgPeriodosContables";
            dtgPeriodosContables.ReadOnly = true;
            dtgPeriodosContables.RowHeadersWidth = 51;
            dtgPeriodosContables.RowTemplate.Height = 29;
            dtgPeriodosContables.Size = new Size(1383, 638);
            dtgPeriodosContables.TabIndex = 47;
            dtgPeriodosContables.CellClick += DtgPeriodosContables_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(336, 5);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 46;
            label1.Text = "Fecha de Fin";
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Location = new Point(337, 31);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(250, 27);
            dateTimePickerFin.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 5);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 44;
            label2.Text = "Fecha de Inicio";
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(23, 31);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(250, 27);
            dateTimePickerInicio.TabIndex = 43;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(1296, 31);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(72, 27);
            textBoxId.TabIndex = 42;
            textBoxId.Visible = false;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "ACTIVO", "INACTIVO", "CERRADO" });
            comboBoxEstado.Location = new Point(27, 105);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(246, 28);
            comboBoxEstado.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 79);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 53;
            label3.Text = "Estado";
            // 
            // PeriodosContables
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 846);
            Controls.Add(label3);
            Controls.Add(comboBoxEstado);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonNuevo);
            Controls.Add(dtgPeriodosContables);
            Controls.Add(label1);
            Controls.Add(dateTimePickerFin);
            Controls.Add(label2);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(textBoxId);
            Name = "PeriodosContables";
            Text = "PeriodosContables";
            Load += PeriodosContables_Load;
            ((System.ComponentModel.ISupportInitialize)dtgPeriodosContables).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonNuevo;
        private DataGridView dtgPeriodosContables;
        private Label label1;
        private DateTimePicker dateTimePickerFin;
        private Label label2;
        private DateTimePicker dateTimePickerInicio;
        private TextBox textBoxId;
        private ComboBox comboBoxEstado;
        private Label label3;
    }
}