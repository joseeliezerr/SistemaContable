namespace SistemaContable.Formularios.Administracion
{
    partial class CatalogoUsuarios
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
            textBoxId = new TextBox();
            dtgCatalogoUsuarios = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            textBoxUsuario = new TextBox();
            label2 = new Label();
            textBoxPass = new TextBox();
            comboBoxRol = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgCatalogoUsuarios).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1004, 99);
            button3.Name = "button3";
            button3.Size = new Size(94, 45);
            button3.TabIndex = 15;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(899, 99);
            button2.Name = "button2";
            button2.Size = new Size(94, 45);
            button2.TabIndex = 14;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(799, 99);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 13;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.BackColor = SystemColors.MenuHighlight;
            buttonNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNuevo.ForeColor = Color.White;
            buttonNuevo.Location = new Point(699, 99);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(94, 45);
            buttonNuevo.TabIndex = 12;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(9, -50);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(72, 27);
            textBoxId.TabIndex = 11;
            textBoxId.Visible = false;
            // 
            // dtgCatalogoUsuarios
            // 
            dtgCatalogoUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgCatalogoUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgCatalogoUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgCatalogoUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCatalogoUsuarios.Location = new Point(2, 187);
            dtgCatalogoUsuarios.Name = "dtgCatalogoUsuarios";
            dtgCatalogoUsuarios.ReadOnly = true;
            dtgCatalogoUsuarios.RowHeadersWidth = 51;
            dtgCatalogoUsuarios.RowTemplate.Height = 29;
            dtgCatalogoUsuarios.Size = new Size(1426, 437);
            dtgCatalogoUsuarios.TabIndex = 10;
            dtgCatalogoUsuarios.CellClick += dtgCatalogoUsuarios_CellClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1356, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(72, 27);
            textBox1.TabIndex = 16;
            textBox1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 18;
            label1.Text = "Nombre";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(12, 40);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Nombre de Usuario";
            textBoxUsuario.Size = new Size(220, 27);
            textBoxUsuario.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(318, 7);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 20;
            label2.Text = "Contraseña";
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(318, 40);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '*';
            textBoxPass.PlaceholderText = "Contraseña";
            textBoxPass.Size = new Size(220, 27);
            textBoxPass.TabIndex = 19;
            // 
            // comboBoxRol
            // 
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Items.AddRange(new object[] { "ADMINISTRADOR", "USUARIO" });
            comboBoxRol.Location = new Point(12, 116);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(220, 28);
            comboBoxRol.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(36, 23);
            label3.TabIndex = 22;
            label3.Text = "Rol";
            // 
            // CatalogoUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 627);
            Controls.Add(label3);
            Controls.Add(comboBoxRol);
            Controls.Add(label2);
            Controls.Add(textBoxPass);
            Controls.Add(label1);
            Controls.Add(textBoxUsuario);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonNuevo);
            Controls.Add(textBoxId);
            Controls.Add(dtgCatalogoUsuarios);
            Name = "CatalogoUsuarios";
            Text = "CatalogoUsuarios";
            Load += CatalogoUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCatalogoUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonNuevo;
        private TextBox textBoxId;
        private DataGridView dtgCatalogoUsuarios;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBoxUsuario;
        private Label label2;
        private TextBox textBoxPass;
        private ComboBox comboBoxRol;
        private Label label3;
    }
}