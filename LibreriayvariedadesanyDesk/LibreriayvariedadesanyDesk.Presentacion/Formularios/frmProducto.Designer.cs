namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    partial class frmProducto
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
            label10 = new Label();
            tbPrecioVN = new TextBox();
            label9 = new Label();
            tbPrecioCN = new TextBox();
            label8 = new Label();
            cbHabilitadoE = new ComboBox();
            label15 = new Label();
            NBCantidadE = new NumericUpDown();
            label4 = new Label();
            label7 = new Label();
            label2 = new Label();
            GridDatosProducto = new DataGridView();
            tbPrecioVE = new TextBox();
            label5 = new Label();
            tbCostoVE = new TextBox();
            label6 = new Label();
            tbDescripcionE = new TextBox();
            label11 = new Label();
            cbCategoriaE = new ComboBox();
            btBuscar = new Button();
            tbBuscar = new TextBox();
            btnuevo = new Button();
            tbDescripcion = new TextBox();
            tabControlMain = new TabControl();
            tabLista = new TabPage();
            tabNuevo = new TabPage();
            NBNuevaCantidad = new NumericUpDown();
            btRegresarN = new Button();
            btGuardarN = new Button();
            cbNuevoCategoria = new ComboBox();
            label3 = new Label();
            tbNuevoCodigo = new TextBox();
            tabEditar = new TabPage();
            label12 = new Label();
            cbCodigoE = new TextBox();
            label13 = new Label();
            btREgresarE = new Button();
            btEditar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)NBCantidadE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridDatosProducto).BeginInit();
            tabControlMain.SuspendLayout();
            tabLista.SuspendLayout();
            tabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NBNuevaCantidad).BeginInit();
            tabEditar.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(286, 37);
            label10.Name = "label10";
            label10.Size = new Size(69, 22);
            label10.TabIndex = 12;
            label10.Text = "Cantidad:";
            // 
            // tbPrecioVN
            // 
            tbPrecioVN.Location = new Point(21, 264);
            tbPrecioVN.Name = "tbPrecioVN";
            tbPrecioVN.Size = new Size(256, 25);
            tbPrecioVN.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 242);
            label9.Name = "label9";
            label9.Size = new Size(88, 22);
            label9.TabIndex = 10;
            label9.Text = "Precio Venta:";
            // 
            // tbPrecioCN
            // 
            tbPrecioCN.Location = new Point(21, 208);
            tbPrecioCN.Name = "tbPrecioCN";
            tbPrecioCN.Size = new Size(256, 25);
            tbPrecioCN.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 186);
            label8.Name = "label8";
            label8.Size = new Size(88, 22);
            label8.TabIndex = 8;
            label8.Text = "Precio Costo:";
            // 
            // cbHabilitadoE
            // 
            cbHabilitadoE.Cursor = Cursors.Hand;
            cbHabilitadoE.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHabilitadoE.FormattingEnabled = true;
            cbHabilitadoE.Location = new Point(282, 90);
            cbHabilitadoE.Name = "cbHabilitadoE";
            cbHabilitadoE.Size = new Size(256, 30);
            cbHabilitadoE.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(285, 68);
            label15.Name = "label15";
            label15.Size = new Size(75, 22);
            label15.TabIndex = 28;
            label15.Text = "Disponible:";
            // 
            // NBCantidadE
            // 
            NBCantidadE.Location = new Point(357, 38);
            NBCantidadE.Name = "NBCantidadE";
            NBCantidadE.Size = new Size(120, 25);
            NBCantidadE.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 40);
            label4.Name = "label4";
            label4.Size = new Size(69, 22);
            label4.TabIndex = 24;
            label4.Text = "Cantidad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 125);
            label7.Name = "label7";
            label7.Size = new Size(82, 22);
            label7.TabIndex = 6;
            label7.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 70);
            label2.Name = "label2";
            label2.Size = new Size(83, 22);
            label2.TabIndex = 0;
            label2.Text = "Codigo SKU:";
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
            GridDatosProducto.Location = new Point(6, 65);
            GridDatosProducto.Name = "GridDatosProducto";
            GridDatosProducto.Size = new Size(756, 245);
            GridDatosProducto.TabIndex = 3;
            GridDatosProducto.CellContentClick += GridDatosProducto_CellContentClick;
            // 
            // tbPrecioVE
            // 
            tbPrecioVE.Location = new Point(20, 267);
            tbPrecioVE.Name = "tbPrecioVE";
            tbPrecioVE.Size = new Size(256, 25);
            tbPrecioVE.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 245);
            label5.Name = "label5";
            label5.Size = new Size(88, 22);
            label5.TabIndex = 22;
            label5.Text = "Precio Venta:";
            // 
            // tbCostoVE
            // 
            tbCostoVE.Location = new Point(20, 211);
            tbCostoVE.Name = "tbCostoVE";
            tbCostoVE.Size = new Size(256, 25);
            tbCostoVE.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 189);
            label6.Name = "label6";
            label6.Size = new Size(88, 22);
            label6.TabIndex = 20;
            label6.Text = "Precio Costo:";
            // 
            // tbDescripcionE
            // 
            tbDescripcionE.Location = new Point(20, 150);
            tbDescripcionE.Name = "tbDescripcionE";
            tbDescripcionE.Size = new Size(256, 25);
            tbDescripcionE.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 128);
            label11.Name = "label11";
            label11.Size = new Size(82, 22);
            label11.TabIndex = 18;
            label11.Text = "Descripcion:";
            // 
            // cbCategoriaE
            // 
            cbCategoriaE.Cursor = Cursors.Hand;
            cbCategoriaE.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoriaE.FormattingEnabled = true;
            cbCategoriaE.Location = new Point(20, 37);
            cbCategoriaE.Name = "cbCategoriaE";
            cbCategoriaE.Size = new Size(256, 30);
            cbCategoriaE.TabIndex = 17;
            // 
            // btBuscar
            // 
            btBuscar.BackColor = Color.FromArgb(29, 114, 198);
            btBuscar.Cursor = Cursors.Hand;
            btBuscar.FlatAppearance.BorderColor = Color.Black;
            btBuscar.FlatStyle = FlatStyle.Flat;
            btBuscar.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btBuscar.Location = new Point(652, 16);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(110, 30);
            btBuscar.TabIndex = 2;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = false;
            btBuscar.Click += btBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(399, 17);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(247, 25);
            tbBuscar.TabIndex = 1;
            // 
            // btnuevo
            // 
            btnuevo.BackColor = Color.FromArgb(38, 152, 134);
            btnuevo.Cursor = Cursors.Hand;
            btnuevo.FlatAppearance.BorderColor = Color.Black;
            btnuevo.FlatStyle = FlatStyle.Flat;
            btnuevo.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnuevo.Location = new Point(6, 15);
            btnuevo.Name = "btnuevo";
            btnuevo.Size = new Size(110, 30);
            btnuevo.TabIndex = 0;
            btnuevo.Text = "Nuevo";
            btnuevo.UseVisualStyleBackColor = false;
            btnuevo.Click += btnuevo_Click;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(21, 147);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(256, 25);
            tbDescripcion.TabIndex = 7;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabLista);
            tabControlMain.Controls.Add(tabNuevo);
            tabControlMain.Controls.Add(tabEditar);
            tabControlMain.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tabControlMain.ItemSize = new Size(80, 20);
            tabControlMain.Location = new Point(12, 79);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(776, 344);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 4;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(GridDatosProducto);
            tabLista.Controls.Add(btBuscar);
            tabLista.Controls.Add(tbBuscar);
            tabLista.Controls.Add(btnuevo);
            tabLista.Font = new Font("Poppins SemiBold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabLista.Location = new Point(4, 24);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(768, 316);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(NBNuevaCantidad);
            tabNuevo.Controls.Add(label10);
            tabNuevo.Controls.Add(tbPrecioVN);
            tabNuevo.Controls.Add(label9);
            tabNuevo.Controls.Add(tbPrecioCN);
            tabNuevo.Controls.Add(label8);
            tabNuevo.Controls.Add(tbDescripcion);
            tabNuevo.Controls.Add(label7);
            tabNuevo.Controls.Add(btRegresarN);
            tabNuevo.Controls.Add(btGuardarN);
            tabNuevo.Controls.Add(cbNuevoCategoria);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Controls.Add(tbNuevoCodigo);
            tabNuevo.Controls.Add(label2);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(768, 316);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
            // 
            // NBNuevaCantidad
            // 
            NBNuevaCantidad.Location = new Point(358, 35);
            NBNuevaCantidad.Name = "NBNuevaCantidad";
            NBNuevaCantidad.Size = new Size(120, 25);
            NBNuevaCantidad.TabIndex = 13;
            // 
            // btRegresarN
            // 
            btRegresarN.BackColor = Color.FromArgb(219, 94, 81);
            btRegresarN.Cursor = Cursors.Hand;
            btRegresarN.FlatAppearance.BorderColor = Color.Black;
            btRegresarN.FlatStyle = FlatStyle.Flat;
            btRegresarN.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btRegresarN.ForeColor = Color.White;
            btRegresarN.Location = new Point(533, 149);
            btRegresarN.Name = "btRegresarN";
            btRegresarN.Size = new Size(120, 35);
            btRegresarN.TabIndex = 5;
            btRegresarN.Text = "Regresar";
            btRegresarN.UseVisualStyleBackColor = false;
            btRegresarN.Click += btRegresarN_Click;
            // 
            // btGuardarN
            // 
            btGuardarN.BackColor = Color.FromArgb(38, 152, 134);
            btGuardarN.Cursor = Cursors.Hand;
            btGuardarN.FlatAppearance.BorderColor = Color.Black;
            btGuardarN.FlatStyle = FlatStyle.Flat;
            btGuardarN.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btGuardarN.ForeColor = Color.White;
            btGuardarN.Location = new Point(407, 149);
            btGuardarN.Name = "btGuardarN";
            btGuardarN.Size = new Size(120, 35);
            btGuardarN.TabIndex = 4;
            btGuardarN.Text = "Guardar";
            btGuardarN.UseVisualStyleBackColor = false;
            btGuardarN.Click += btGuardarN_Click;
            // 
            // cbNuevoCategoria
            // 
            cbNuevoCategoria.Cursor = Cursors.Hand;
            cbNuevoCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNuevoCategoria.FormattingEnabled = true;
            cbNuevoCategoria.Location = new Point(21, 34);
            cbNuevoCategoria.Name = "cbNuevoCategoria";
            cbNuevoCategoria.Size = new Size(256, 30);
            cbNuevoCategoria.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 14);
            label3.Name = "label3";
            label3.Size = new Size(72, 22);
            label3.TabIndex = 2;
            label3.Text = "Categoria:";
            // 
            // tbNuevoCodigo
            // 
            tbNuevoCodigo.Location = new Point(21, 92);
            tbNuevoCodigo.Name = "tbNuevoCodigo";
            tbNuevoCodigo.Size = new Size(256, 25);
            tbNuevoCodigo.TabIndex = 1;
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(cbHabilitadoE);
            tabEditar.Controls.Add(label15);
            tabEditar.Controls.Add(NBCantidadE);
            tabEditar.Controls.Add(label4);
            tabEditar.Controls.Add(tbPrecioVE);
            tabEditar.Controls.Add(label5);
            tabEditar.Controls.Add(tbCostoVE);
            tabEditar.Controls.Add(label6);
            tabEditar.Controls.Add(tbDescripcionE);
            tabEditar.Controls.Add(label11);
            tabEditar.Controls.Add(cbCategoriaE);
            tabEditar.Controls.Add(label12);
            tabEditar.Controls.Add(cbCodigoE);
            tabEditar.Controls.Add(label13);
            tabEditar.Controls.Add(btREgresarE);
            tabEditar.Controls.Add(btEditar);
            tabEditar.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tabEditar.Location = new Point(4, 24);
            tabEditar.Name = "tabEditar";
            tabEditar.Padding = new Padding(3);
            tabEditar.Size = new Size(768, 316);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            tabEditar.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 17);
            label12.Name = "label12";
            label12.Size = new Size(72, 22);
            label12.TabIndex = 16;
            label12.Text = "Categoria:";
            // 
            // cbCodigoE
            // 
            cbCodigoE.Location = new Point(20, 95);
            cbCodigoE.Name = "cbCodigoE";
            cbCodigoE.Size = new Size(256, 25);
            cbCodigoE.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 73);
            label13.Name = "label13";
            label13.Size = new Size(57, 22);
            label13.TabIndex = 14;
            label13.Text = "Codigo:";
            // 
            // btREgresarE
            // 
            btREgresarE.BackColor = Color.FromArgb(219, 94, 81);
            btREgresarE.Cursor = Cursors.Hand;
            btREgresarE.FlatAppearance.BorderColor = Color.Black;
            btREgresarE.FlatStyle = FlatStyle.Flat;
            btREgresarE.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btREgresarE.ForeColor = Color.White;
            btREgresarE.Location = new Point(507, 201);
            btREgresarE.Name = "btREgresarE";
            btREgresarE.Size = new Size(120, 35);
            btREgresarE.TabIndex = 11;
            btREgresarE.Text = "Regresar";
            btREgresarE.UseVisualStyleBackColor = false;
            btREgresarE.Click += btREgresarE_Click;
            // 
            // btEditar
            // 
            btEditar.BackColor = Color.FromArgb(29, 114, 198);
            btEditar.Cursor = Cursors.Hand;
            btEditar.FlatAppearance.BorderColor = Color.Black;
            btEditar.FlatStyle = FlatStyle.Flat;
            btEditar.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btEditar.ForeColor = Color.White;
            btEditar.Location = new Point(381, 201);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(120, 35);
            btEditar.TabIndex = 10;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = false;
            btEditar.Click += btEditar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(203, 28);
            label1.TabIndex = 5;
            label1.Text = "Inventario / Producto";
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlMain);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProducto";
            Load += frmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)NBCantidadE).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridDatosProducto).EndInit();
            tabControlMain.ResumeLayout(false);
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NBNuevaCantidad).EndInit();
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private TextBox tbPrecioVN;
        private Label label9;
        private TextBox tbPrecioCN;
        private Label label8;
        private ComboBox cbHabilitadoE;
        private Label label15;
        private NumericUpDown NBCantidadE;
        private Label label4;
        private Label label7;
        private Label label2;
        private DataGridView GridDatosProducto;
        private TextBox tbPrecioVE;
        private Label label5;
        private TextBox tbCostoVE;
        private Label label6;
        private TextBox tbDescripcionE;
        private Label label11;
        private ComboBox cbCategoriaE;
        private Button btBuscar;
        private TextBox tbBuscar;
        private Button btnuevo;
        private TextBox tbDescripcion;
        private TabControl tabControlMain;
        private TabPage tabLista;
        private TabPage tabNuevo;
        private NumericUpDown NBNuevaCantidad;
        private Button btRegresarN;
        private Button btGuardarN;
        private ComboBox cbNuevoCategoria;
        private Label label3;
        private TextBox tbNuevoCodigo;
        private TabPage tabEditar;
        private Label label12;
        private TextBox cbCodigoE;
        private Label label13;
        private Button btREgresarE;
        private Button btEditar;
        private Label label1;
    }
}