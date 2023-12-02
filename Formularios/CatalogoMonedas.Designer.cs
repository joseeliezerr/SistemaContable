namespace SistemaContable.Formularios
{
    partial class CatalogoMonedas
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
            dtgCatalogoMoneda = new DataGridView();
            textBoxId = new TextBox();
            textBoxNombreMoneda = new TextBox();
            textBoxCodigoMoneda = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgCatalogoMoneda).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1284, 154);
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
            button2.Location = new Point(1179, 154);
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
            button1.Location = new Point(1079, 154);
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
            buttonNuevo.Location = new Point(979, 154);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(94, 45);
            buttonNuevo.TabIndex = 10;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += ButtonNuevo_Click;
            // 
            // dtgCatalogoMoneda
            // 
            dtgCatalogoMoneda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgCatalogoMoneda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgCatalogoMoneda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgCatalogoMoneda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCatalogoMoneda.Location = new Point(12, 231);
            dtgCatalogoMoneda.Name = "dtgCatalogoMoneda";
            dtgCatalogoMoneda.ReadOnly = true;
            dtgCatalogoMoneda.RowHeadersWidth = 51;
            dtgCatalogoMoneda.RowTemplate.Height = 29;
            dtgCatalogoMoneda.Size = new Size(1394, 539);
            dtgCatalogoMoneda.TabIndex = 14;
            dtgCatalogoMoneda.CellClick += DtgCatalogoMoneda_CellClick;
            dtgCatalogoMoneda.CellContentClick += DtgCatalogoContable_CellContentClick;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(30, 35);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(72, 27);
            textBoxId.TabIndex = 15;
            textBoxId.Visible = false;
            // 
            // textBoxNombreMoneda
            // 
            textBoxNombreMoneda.Location = new Point(139, 35);
            textBoxNombreMoneda.Name = "textBoxNombreMoneda";
            textBoxNombreMoneda.PlaceholderText = "Ejem: Lempiras";
            textBoxNombreMoneda.Size = new Size(219, 27);
            textBoxNombreMoneda.TabIndex = 16;
            // 
            // textBoxCodigoMoneda
            // 
            textBoxCodigoMoneda.Location = new Point(390, 35);
            textBoxCodigoMoneda.Name = "textBoxCodigoMoneda";
            textBoxCodigoMoneda.PlaceholderText = "Lps";
            textBoxCodigoMoneda.Size = new Size(219, 27);
            textBoxCodigoMoneda.TabIndex = 17;
            // 
            // CatalogoMonedas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 782);
            Controls.Add(textBoxCodigoMoneda);
            Controls.Add(textBoxNombreMoneda);
            Controls.Add(textBoxId);
            Controls.Add(dtgCatalogoMoneda);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonNuevo);
            Name = "CatalogoMonedas";
            Text = "CatalogoMonedas";
            Load += CatalogoMonedas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCatalogoMoneda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonNuevo;
        private DataGridView dtgCatalogoMoneda;
        private TextBox textBoxId;
        private TextBox textBoxNombreMoneda;
        private TextBox textBoxCodigoMoneda;
    }
}