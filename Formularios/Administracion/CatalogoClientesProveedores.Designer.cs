namespace SistemaContable.Formularios.Administracion
{
    partial class CatalogoClientesProveedores
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
            dtgCatalogoUsuarios = new DataGridView();
            label1 = new Label();
            textBoxUsuario = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            textBoxDireccion = new TextBox();
            label2 = new Label();
            textBoxTelefono = new TextBox();
            label4 = new Label();
            textBoxEmail = new TextBox();
            comboBoxTipo = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgCatalogoUsuarios).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1246, 117);
            button3.Name = "button3";
            button3.Size = new Size(94, 45);
            button3.TabIndex = 20;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1141, 117);
            button2.Name = "button2";
            button2.Size = new Size(94, 45);
            button2.TabIndex = 19;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1041, 117);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 18;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.BackColor = SystemColors.MenuHighlight;
            buttonNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNuevo.ForeColor = Color.White;
            buttonNuevo.Location = new Point(941, 117);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(94, 45);
            buttonNuevo.TabIndex = 17;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // dtgCatalogoUsuarios
            // 
            dtgCatalogoUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgCatalogoUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgCatalogoUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgCatalogoUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCatalogoUsuarios.Location = new Point(-1, 199);
            dtgCatalogoUsuarios.Name = "dtgCatalogoUsuarios";
            dtgCatalogoUsuarios.ReadOnly = true;
            dtgCatalogoUsuarios.RowHeadersWidth = 51;
            dtgCatalogoUsuarios.RowTemplate.Height = 29;
            dtgCatalogoUsuarios.Size = new Size(1432, 804);
            dtgCatalogoUsuarios.TabIndex = 16;
            dtgCatalogoUsuarios.CellClick += dtgCatalogoUsuarios_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 23;
            label1.Text = "Nombre";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(12, 40);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Nombre de Usuario";
            textBoxUsuario.Size = new Size(220, 27);
            textBoxUsuario.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1356, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(72, 27);
            textBox1.TabIndex = 21;
            textBox1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 25;
            label3.Text = "Direccíon";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(12, 117);
            textBoxDireccion.Multiline = true;
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.PlaceholderText = "Direccíon";
            textBoxDireccion.Size = new Size(462, 76);
            textBoxDireccion.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(254, 7);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 27;
            label2.Text = "Telefono";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(254, 40);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.PlaceholderText = "Telefono";
            textBoxTelefono.Size = new Size(220, 27);
            textBoxTelefono.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(532, 7);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 29;
            label4.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(532, 40);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email";
            textBoxEmail.Size = new Size(220, 27);
            textBoxEmail.TabIndex = 28;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "C", "P" });
            comboBoxTipo.Location = new Point(532, 117);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(220, 28);
            comboBoxTipo.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(532, 88);
            label5.Name = "label5";
            label5.Size = new Size(46, 23);
            label5.TabIndex = 31;
            label5.Text = "Tipo";
            // 
            // CatalogoClientesProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 1015);
            Controls.Add(label5);
            Controls.Add(comboBoxTipo);
            Controls.Add(label4);
            Controls.Add(textBoxEmail);
            Controls.Add(label2);
            Controls.Add(textBoxTelefono);
            Controls.Add(label3);
            Controls.Add(textBoxDireccion);
            Controls.Add(label1);
            Controls.Add(textBoxUsuario);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonNuevo);
            Controls.Add(dtgCatalogoUsuarios);
            Name = "CatalogoClientesProveedores";
            Text = "CatalogoClientesProveedores";
            Load += CatalogoClientesProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCatalogoUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonNuevo;
        private DataGridView dtgCatalogoUsuarios;
        private Label label1;
        private TextBox textBoxUsuario;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBoxDireccion;
        private Label label2;
        private TextBox textBoxTelefono;
        private Label label4;
        private TextBox textBoxEmail;
        private ComboBox comboBoxTipo;
        private Label label5;
    }
}