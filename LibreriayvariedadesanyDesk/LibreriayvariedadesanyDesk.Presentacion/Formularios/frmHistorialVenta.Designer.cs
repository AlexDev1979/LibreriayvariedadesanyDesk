namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    partial class frmHistorialVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialVenta));
            btBuscarV = new Button();
            tbBuscarVenta = new TextBox();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtFechaInicio = new DateTimePicker();
            dtFechaFinal = new DateTimePicker();
            label4 = new Label();
            gridDatosVentas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridDatosVentas).BeginInit();
            SuspendLayout();
            // 
            // btBuscarV
            // 
            btBuscarV.BackColor = Color.FromArgb(29, 114, 198);
            btBuscarV.Cursor = Cursors.Hand;
            btBuscarV.FlatAppearance.BorderColor = Color.Black;
            btBuscarV.FlatStyle = FlatStyle.Flat;
            btBuscarV.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btBuscarV.ForeColor = Color.White;
            btBuscarV.Image = (Image)resources.GetObject("btBuscarV.Image");
            btBuscarV.Location = new Point(666, 81);
            btBuscarV.Name = "btBuscarV";
            btBuscarV.Size = new Size(110, 45);
            btBuscarV.TabIndex = 58;
            btBuscarV.Text = "Buscar";
            btBuscarV.TextImageRelation = TextImageRelation.ImageBeforeText;
            btBuscarV.UseVisualStyleBackColor = false;
            btBuscarV.Click += btBuscarV_Click;
            // 
            // tbBuscarVenta
            // 
            tbBuscarVenta.Location = new Point(434, 103);
            tbBuscarVenta.Name = "tbBuscarVenta";
            tbBuscarVenta.Size = new Size(207, 23);
            tbBuscarVenta.TabIndex = 57;
            tbBuscarVenta.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(225, 85);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 54;
            label8.Text = "Fecha Final:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(21, 85);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 44;
            label3.Text = "Fehca Inicial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(159, 28);
            label2.TabIndex = 43;
            label2.Text = "Historial / Venta";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(776, 368);
            label1.TabIndex = 42;
            // 
            // dtFechaInicio
            // 
            dtFechaInicio.Format = DateTimePickerFormat.Short;
            dtFechaInicio.Location = new Point(21, 103);
            dtFechaInicio.Name = "dtFechaInicio";
            dtFechaInicio.Size = new Size(179, 23);
            dtFechaInicio.TabIndex = 59;
            // 
            // dtFechaFinal
            // 
            dtFechaFinal.Format = DateTimePickerFormat.Short;
            dtFechaFinal.Location = new Point(225, 103);
            dtFechaFinal.Name = "dtFechaFinal";
            dtFechaFinal.Size = new Size(179, 23);
            dtFechaFinal.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(443, 85);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 61;
            label4.Text = "Buscar Venta:";
            // 
            // gridDatosVentas
            // 
            gridDatosVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDatosVentas.Location = new Point(21, 144);
            gridDatosVentas.Name = "gridDatosVentas";
            gridDatosVentas.Size = new Size(755, 279);
            gridDatosVentas.TabIndex = 62;
            gridDatosVentas.CellContentClick += gridDatosVentas_CellContentClick;
            // 
            // frmHistorialVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridDatosVentas);
            Controls.Add(label4);
            Controls.Add(dtFechaFinal);
            Controls.Add(dtFechaInicio);
            Controls.Add(btBuscarV);
            Controls.Add(tbBuscarVenta);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHistorialVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHistorialVenta";
            Load += frmHistorialVenta_Load;
            ((System.ComponentModel.ISupportInitialize)gridDatosVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBuscarV;
        private TextBox tbBuscarVenta;
        private Label label8;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtFechaInicio;
        private DateTimePicker dtFechaFinal;
        private Label label4;
        private DataGridView gridDatosVentas;
    }
}