namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    partial class frmBuscarProducto
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            GridDatosProducto = new DataGridView();
            btBuscar = new Button();
            tbBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)GridDatosProducto).BeginInit();
            SuspendLayout();
            // 
            // GridDatosProducto
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GridDatosProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GridDatosProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridDatosProducto.Location = new Point(12, 77);
            GridDatosProducto.Name = "GridDatosProducto";
            GridDatosProducto.Size = new Size(719, 247);
            GridDatosProducto.TabIndex = 9;
            GridDatosProducto.CellClick += GridDatosProducto_CellClick;
            // 
            // btBuscar
            // 
            btBuscar.BackColor = Color.FromArgb(29, 114, 198);
            btBuscar.Cursor = Cursors.Hand;
            btBuscar.FlatAppearance.BorderColor = Color.Black;
            btBuscar.FlatStyle = FlatStyle.Flat;
            btBuscar.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btBuscar.Location = new Point(640, 27);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(91, 32);
            btBuscar.TabIndex = 8;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = false;
            btBuscar.Click += btBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(406, 36);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(228, 23);
            tbBuscar.TabIndex = 7;
            // 
            // frmBuscarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 360);
            Controls.Add(GridDatosProducto);
            Controls.Add(btBuscar);
            Controls.Add(tbBuscar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBuscarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBuscarProducto";
            Load += frmBuscarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)GridDatosProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridDatosProducto;
        private Button btBuscar;
        private TextBox tbBuscar;
    }
}