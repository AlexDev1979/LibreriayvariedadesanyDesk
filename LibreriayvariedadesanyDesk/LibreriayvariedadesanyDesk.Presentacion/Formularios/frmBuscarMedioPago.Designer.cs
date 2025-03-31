namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    partial class frmBuscarMedioPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarMedioPago));
            GridDatosMPago = new DataGridView();
            btBuscarMP = new Button();
            tbBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)GridDatosMPago).BeginInit();
            SuspendLayout();
            // 
            // GridDatosMPago
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GridDatosMPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GridDatosMPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridDatosMPago.Location = new Point(21, 82);
            GridDatosMPago.Name = "GridDatosMPago";
            GridDatosMPago.Size = new Size(719, 247);
            GridDatosMPago.TabIndex = 12;
            GridDatosMPago.CellClick += GridDatosMPago_CellClick;
            // 
            // btBuscarMP
            // 
            btBuscarMP.BackColor = Color.White;
            btBuscarMP.Cursor = Cursors.Hand;
            btBuscarMP.FlatAppearance.BorderColor = Color.Black;
            btBuscarMP.FlatStyle = FlatStyle.Flat;
            btBuscarMP.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btBuscarMP.ForeColor = Color.Black;
            btBuscarMP.Image = (Image)resources.GetObject("btBuscarMP.Image");
            btBuscarMP.Location = new Point(649, 30);
            btBuscarMP.Name = "btBuscarMP";
            btBuscarMP.Size = new Size(91, 32);
            btBuscarMP.TabIndex = 11;
            btBuscarMP.Text = "Buscar";
            btBuscarMP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btBuscarMP.UseVisualStyleBackColor = false;
            btBuscarMP.Click += btBuscarMP_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(415, 41);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(228, 23);
            tbBuscar.TabIndex = 10;
            // 
            // frmBuscarMedioPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 360);
            Controls.Add(GridDatosMPago);
            Controls.Add(btBuscarMP);
            Controls.Add(tbBuscar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBuscarMedioPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBuscarMedioPago";
            Load += frmBuscarMedioPago_Load;
            ((System.ComponentModel.ISupportInitialize)GridDatosMPago).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridDatosMPago;
        private Button btBuscarMP;
        private TextBox tbBuscar;
    }
}