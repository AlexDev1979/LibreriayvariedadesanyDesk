namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    partial class frmReporteVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteVenta));
            gridDatosReporte = new DataGridView();
            dtFechaFinal = new DateTimePicker();
            dtFechaInicio = new DateTimePicker();
            btBuscarV = new Button();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)gridDatosReporte).BeginInit();
            SuspendLayout();
            // 
            // gridDatosReporte
            // 
            gridDatosReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDatosReporte.Location = new Point(22, 148);
            gridDatosReporte.Name = "gridDatosReporte";
            gridDatosReporte.Size = new Size(755, 279);
            gridDatosReporte.TabIndex = 72;
            // 
            // dtFechaFinal
            // 
            dtFechaFinal.Format = DateTimePickerFormat.Short;
            dtFechaFinal.Location = new Point(226, 103);
            dtFechaFinal.Name = "dtFechaFinal";
            dtFechaFinal.Size = new Size(179, 23);
            dtFechaFinal.TabIndex = 70;
            // 
            // dtFechaInicio
            // 
            dtFechaInicio.Format = DateTimePickerFormat.Short;
            dtFechaInicio.Location = new Point(22, 103);
            dtFechaInicio.Name = "dtFechaInicio";
            dtFechaInicio.Size = new Size(179, 23);
            dtFechaInicio.TabIndex = 69;
            // 
            // btBuscarV
            // 
            btBuscarV.BackColor = Color.White;
            btBuscarV.Cursor = Cursors.Hand;
            btBuscarV.FlatAppearance.BorderColor = Color.Black;
            btBuscarV.FlatStyle = FlatStyle.Flat;
            btBuscarV.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btBuscarV.ForeColor = Color.Black;
            btBuscarV.Image = (Image)resources.GetObject("btBuscarV.Image");
            btBuscarV.Location = new Point(411, 96);
            btBuscarV.Name = "btBuscarV";
            btBuscarV.Size = new Size(110, 30);
            btBuscarV.TabIndex = 68;
            btBuscarV.Text = "Buscar";
            btBuscarV.TextImageRelation = TextImageRelation.ImageBeforeText;
            btBuscarV.UseVisualStyleBackColor = false;
            btBuscarV.Click += btBuscarV_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(226, 85);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 66;
            label8.Text = "Fecha Final:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(22, 85);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 65;
            label3.Text = "Fehca Inicial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 21);
            label2.Name = "label2";
            label2.Size = new Size(156, 28);
            label2.TabIndex = 64;
            label2.Text = "Reporte / Venta";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(13, 70);
            label1.Name = "label1";
            label1.Size = new Size(776, 368);
            label1.TabIndex = 63;
            // 
            // btExcel
            // 
            btExcel.BackColor = Color.FromArgb(59, 157, 97);
            btExcel.Cursor = Cursors.Hand;
            btExcel.FlatAppearance.BorderColor = Color.Black;
            btExcel.FlatStyle = FlatStyle.Flat;
            btExcel.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btExcel.ForeColor = Color.White;
            btExcel.Image = (Image)resources.GetObject("btExcel.Image");
            btExcel.Location = new Point(667, 96);
            btExcel.Name = "btExcel";
            btExcel.Size = new Size(110, 30);
            btExcel.TabIndex = 73;
            btExcel.Text = "Excel";
            btExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btExcel.UseVisualStyleBackColor = false;
            btExcel.Click += btExcel_Click;
            // 
            // frmReporteVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btExcel);
            Controls.Add(gridDatosReporte);
            Controls.Add(dtFechaFinal);
            Controls.Add(dtFechaInicio);
            Controls.Add(btBuscarV);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReporteVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmReporteVenta";
            Load += frmReporteVenta_Load;
            ((System.ComponentModel.ISupportInitialize)gridDatosReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridDatosReporte;
        private DateTimePicker dtFechaFinal;
        private DateTimePicker dtFechaInicio;
        private Button btBuscarV;
        private Label label8;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btExcel;
    }
}