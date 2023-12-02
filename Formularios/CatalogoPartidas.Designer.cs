namespace SistemaContable.Formularios
{
    partial class CatalogoPartidas
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
            dtgCatalogoPartidas = new DataGridView();
            textBoxId = new TextBox();
            label2 = new Label();
            comboBoxtipoPartida = new ComboBox();
            label3 = new Label();
            textBoxDescripcion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgCatalogoPartidas).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(991, 136);
            button3.Name = "button3";
            button3.Size = new Size(94, 45);
            button3.TabIndex = 14;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(886, 136);
            button2.Name = "button2";
            button2.Size = new Size(94, 45);
            button2.TabIndex = 13;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(786, 136);
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
            buttonNuevo.Location = new Point(686, 136);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(94, 45);
            buttonNuevo.TabIndex = 11;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += ButtonNuevo_Click;
            // 
            // dtgCatalogoPartidas
            // 
            dtgCatalogoPartidas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgCatalogoPartidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgCatalogoPartidas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgCatalogoPartidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCatalogoPartidas.Location = new Point(6, 214);
            dtgCatalogoPartidas.Name = "dtgCatalogoPartidas";
            dtgCatalogoPartidas.ReadOnly = true;
            dtgCatalogoPartidas.RowHeadersWidth = 51;
            dtgCatalogoPartidas.RowTemplate.Height = 29;
            dtgCatalogoPartidas.Size = new Size(1464, 666);
            dtgCatalogoPartidas.TabIndex = 10;
            dtgCatalogoPartidas.CellClick += dtgCatalogoPartidas_CellClick;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(12, 34);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(72, 27);
            textBoxId.TabIndex = 15;
            textBoxId.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(110, 137);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 17;
            label2.Text = "Tipo";
            // 
            // comboBoxtipoPartida
            // 
            comboBoxtipoPartida.FormattingEnabled = true;
            comboBoxtipoPartida.Items.AddRange(new object[] { "DEBE", "HABER" });
            comboBoxtipoPartida.Location = new Point(110, 169);
            comboBoxtipoPartida.Name = "comboBoxtipoPartida";
            comboBoxtipoPartida.Size = new Size(217, 28);
            comboBoxtipoPartida.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(110, 26);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 19;
            label3.Text = "Descripción";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(110, 52);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.PlaceholderText = "Descripcion";
            textBoxDescripcion.Size = new Size(462, 76);
            textBoxDescripcion.TabIndex = 18;
            // 
            // CatalogoPartidas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1475, 881);
            Controls.Add(label3);
            Controls.Add(textBoxDescripcion);
            Controls.Add(label2);
            Controls.Add(comboBoxtipoPartida);
            Controls.Add(textBoxId);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonNuevo);
            Controls.Add(dtgCatalogoPartidas);
            Name = "CatalogoPartidas";
            Text = "CatalogoPartidas";
            Load += CatalogoPartidas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCatalogoPartidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonNuevo;
        private DataGridView dtgCatalogoPartidas;
        private TextBox textBoxId;
        private Label label2;
        private ComboBox comboBoxtipoPartida;
        private Label label3;
        private TextBox textBoxDescripcion;
    }
}