namespace SistemaContable.Formularios
{
    partial class Catalogo_Contable
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
            dtgCatalogoContable = new DataGridView();
            textBoxId = new TextBox();
            textBoxCuenta = new TextBox();
            comboBoxtipoCuenta = new ComboBox();
            textBoxDescripcion = new TextBox();
            buttonNuevo = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgCatalogoContable).BeginInit();
            SuspendLayout();
            // 
            // dtgCatalogoContable
            // 
            dtgCatalogoContable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgCatalogoContable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgCatalogoContable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgCatalogoContable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCatalogoContable.Location = new Point(0, 208);
            dtgCatalogoContable.Name = "dtgCatalogoContable";
            dtgCatalogoContable.ReadOnly = true;
            dtgCatalogoContable.RowHeadersWidth = 51;
            dtgCatalogoContable.RowTemplate.Height = 29;
            dtgCatalogoContable.Size = new Size(1440, 569);
            dtgCatalogoContable.TabIndex = 1;
            dtgCatalogoContable.CellClick += DtgCatalogoContable_CellClick;
            dtgCatalogoContable.CellContentClick += DataGridView1_CellContentClick;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(12, 51);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(72, 27);
            textBoxId.TabIndex = 2;
            textBoxId.Visible = false;
            // 
            // textBoxCuenta
            // 
            textBoxCuenta.Location = new Point(112, 38);
            textBoxCuenta.Name = "textBoxCuenta";
            textBoxCuenta.PlaceholderText = "Nombre de Cuenta";
            textBoxCuenta.Size = new Size(220, 27);
            textBoxCuenta.TabIndex = 3;
            // 
            // comboBoxtipoCuenta
            // 
            comboBoxtipoCuenta.FormattingEnabled = true;
            comboBoxtipoCuenta.Items.AddRange(new object[] { "ACTIVO", "PASIVO", "PATRIMONIO O CAPITAL", "GASTOS", "INGRESOS O VENTAS", "COSTOS " });
            comboBoxtipoCuenta.Location = new Point(357, 37);
            comboBoxtipoCuenta.Name = "comboBoxtipoCuenta";
            comboBoxtipoCuenta.Size = new Size(217, 28);
            comboBoxtipoCuenta.TabIndex = 4;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(112, 110);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.PlaceholderText = "Descripcion";
            textBoxDescripcion.Size = new Size(462, 76);
            textBoxDescripcion.TabIndex = 5;
            // 
            // buttonNuevo
            // 
            buttonNuevo.BackColor = SystemColors.MenuHighlight;
            buttonNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNuevo.ForeColor = Color.White;
            buttonNuevo.Location = new Point(687, 141);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(94, 45);
            buttonNuevo.TabIndex = 6;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += ButtonNuevo_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(787, 141);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 7;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(887, 141);
            button2.Name = "button2";
            button2.Size = new Size(94, 45);
            button2.TabIndex = 8;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(992, 141);
            button3.Name = "button3";
            button3.Size = new Size(94, 45);
            button3.TabIndex = 9;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(112, 5);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 10;
            label1.Text = " Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(357, 5);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 11;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(112, 84);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 12;
            label3.Text = "Descripción";
            // 
            // Catalogo_Contable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1452, 768);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonNuevo);
            Controls.Add(textBoxDescripcion);
            Controls.Add(comboBoxtipoCuenta);
            Controls.Add(textBoxCuenta);
            Controls.Add(textBoxId);
            Controls.Add(dtgCatalogoContable);
            Name = "Catalogo_Contable";
            Text = "Catalogo Contable";
            Load += Catalogo_Contable_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCatalogoContable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgCatalogoContable;
        private TextBox textBoxId;
        private TextBox textBoxCuenta;
        private ComboBox comboBoxtipoCuenta;
        private TextBox textBoxDescripcion;
        private Button buttonNuevo;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}