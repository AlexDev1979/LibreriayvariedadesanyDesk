namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            tbMedioPago = new TextBox();
            btBuscarMP = new Button();
            label10 = new Label();
            GridDventas = new DataGridView();
            lbtotal = new Label();
            label9 = new Label();
            label8 = new Label();
            btRegistrarNV = new Button();
            btBuscar = new Button();
            tbCambio = new TextBox();
            label7 = new Label();
            tbPagocon = new TextBox();
            label6 = new Label();
            tbCliente = new TextBox();
            label5 = new Label();
            tbNit = new TextBox();
            label4 = new Label();
            tbCodigoProducto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)GridDventas).BeginInit();
            SuspendLayout();
            // 
            // tbMedioPago
            // 
            tbMedioPago.Location = new Point(125, 406);
            tbMedioPago.Name = "tbMedioPago";
            tbMedioPago.Size = new Size(154, 23);
            tbMedioPago.TabIndex = 70;
            // 
            // btBuscarMP
            // 
            btBuscarMP.BackColor = Color.FromArgb(29, 114, 198);
            btBuscarMP.FlatStyle = FlatStyle.Flat;
            btBuscarMP.Image = (Image)resources.GetObject("btBuscarMP.Image");
            btBuscarMP.Location = new Point(285, 406);
            btBuscarMP.Name = "btBuscarMP";
            btBuscarMP.Size = new Size(38, 23);
            btBuscarMP.TabIndex = 69;
            btBuscarMP.UseVisualStyleBackColor = false;
            btBuscarMP.Click += btBuscarMP_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(28, 412);
            label10.Name = "label10";
            label10.Size = new Size(90, 15);
            label10.TabIndex = 68;
            label10.Text = "Medio de pago:";
            // 
            // GridDventas
            // 
            GridDventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridDventas.Location = new Point(28, 235);
            GridDventas.Name = "GridDventas";
            GridDventas.Size = new Size(740, 158);
            GridDventas.TabIndex = 67;
            GridDventas.CellContentClick += GridDventas_CellContentClick;
            // 
            // lbtotal
            // 
            lbtotal.BackColor = Color.FromArgb(58, 49, 69);
            lbtotal.Font = new Font("Poppins", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbtotal.ForeColor = Color.White;
            lbtotal.Location = new Point(448, 134);
            lbtotal.Name = "lbtotal";
            lbtotal.Size = new Size(207, 71);
            lbtotal.TabIndex = 66;
            lbtotal.Text = "Q. 0.00";
            lbtotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(58, 49, 69);
            label9.Font = new Font("Poppins", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(481, 77);
            label9.Name = "label9";
            label9.Size = new Size(145, 71);
            label9.TabIndex = 65;
            label9.Text = "Total:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(58, 49, 69);
            label8.Location = new Point(448, 73);
            label8.Name = "label8";
            label8.Size = new Size(207, 153);
            label8.TabIndex = 64;
            // 
            // btRegistrarNV
            // 
            btRegistrarNV.BackColor = Color.FromArgb(38, 152, 134);
            btRegistrarNV.Cursor = Cursors.Hand;
            btRegistrarNV.FlatAppearance.BorderColor = Color.Black;
            btRegistrarNV.FlatStyle = FlatStyle.Flat;
            btRegistrarNV.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btRegistrarNV.ForeColor = Color.White;
            btRegistrarNV.Location = new Point(649, 400);
            btRegistrarNV.Name = "btRegistrarNV";
            btRegistrarNV.Size = new Size(119, 28);
            btRegistrarNV.TabIndex = 63;
            btRegistrarNV.Text = "Registrar";
            btRegistrarNV.TextAlign = ContentAlignment.TopCenter;
            btRegistrarNV.UseVisualStyleBackColor = false;
            btRegistrarNV.Click += btRegistrarNV_Click;
            // 
            // btBuscar
            // 
            btBuscar.BackColor = Color.FromArgb(29, 114, 198);
            btBuscar.Cursor = Cursors.Hand;
            btBuscar.FlatAppearance.BorderColor = Color.Black;
            btBuscar.FlatStyle = FlatStyle.Flat;
            btBuscar.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btBuscar.ForeColor = Color.White;
            btBuscar.Image = (Image)resources.GetObject("btBuscar.Image");
            btBuscar.Location = new Point(290, 96);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(100, 30);
            btBuscar.TabIndex = 62;
            btBuscar.Text = "Buscar";
            btBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btBuscar.UseVisualStyleBackColor = false;
            btBuscar.Click += btBuscar_Click;
            // 
            // tbCambio
            // 
            tbCambio.Location = new Point(551, 404);
            tbCambio.Name = "tbCambio";
            tbCambio.ReadOnly = true;
            tbCambio.Size = new Size(92, 23);
            tbCambio.TabIndex = 61;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(493, 413);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 60;
            label7.Text = "Cambio:";
            // 
            // tbPagocon
            // 
            tbPagocon.Location = new Point(395, 404);
            tbPagocon.Name = "tbPagocon";
            tbPagocon.Size = new Size(92, 23);
            tbPagocon.TabIndex = 59;
            tbPagocon.KeyDown += tbPagocon_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(329, 410);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 58;
            label6.Text = "Pago con:";
            // 
            // tbCliente
            // 
            tbCliente.Location = new Point(28, 203);
            tbCliente.Name = "tbCliente";
            tbCliente.Size = new Size(256, 23);
            tbCliente.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(28, 185);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 56;
            label5.Text = "Nombre cliente:";
            // 
            // tbNit
            // 
            tbNit.Location = new Point(28, 152);
            tbNit.Name = "tbNit";
            tbNit.Size = new Size(256, 23);
            tbNit.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(28, 134);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 54;
            label4.Text = "Nit:";
            // 
            // tbCodigoProducto
            // 
            tbCodigoProducto.Location = new Point(28, 103);
            tbCodigoProducto.Name = "tbCodigoProducto";
            tbCodigoProducto.Size = new Size(256, 23);
            tbCodigoProducto.TabIndex = 53;
            tbCodigoProducto.KeyDown += tbCodigoProducto_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(28, 78);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 52;
            label3.Text = "Código Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 51;
            label2.Text = "Modulo de caja";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(776, 378);
            label1.TabIndex = 50;
            // 
            // frmVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbMedioPago);
            Controls.Add(btBuscarMP);
            Controls.Add(label10);
            Controls.Add(GridDventas);
            Controls.Add(lbtotal);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btRegistrarNV);
            Controls.Add(btBuscar);
            Controls.Add(tbCambio);
            Controls.Add(label7);
            Controls.Add(tbPagocon);
            Controls.Add(label6);
            Controls.Add(tbCliente);
            Controls.Add(label5);
            Controls.Add(tbNit);
            Controls.Add(label4);
            Controls.Add(tbCodigoProducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVenta";
            Load += frmVenta_Load;
            ((System.ComponentModel.ISupportInitialize)GridDventas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMedioPago;
        private Button btBuscarMP;
        private Label label10;
        private DataGridView GridDventas;
        private Label lbtotal;
        private Label label9;
        private Label label8;
        private Button btRegistrarNV;
        private Button btBuscar;
        private TextBox tbCambio;
        private Label label7;
        private TextBox tbPagocon;
        private Label label6;
        private TextBox tbCliente;
        private Label label5;
        private TextBox tbNit;
        private Label label4;
        private TextBox tbCodigoProducto;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}