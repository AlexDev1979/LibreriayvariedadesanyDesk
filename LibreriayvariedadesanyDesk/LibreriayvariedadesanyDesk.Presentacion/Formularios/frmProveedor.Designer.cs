namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    partial class frmProveedor
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
            label1 = new Label();
            tbDireccion = new TextBox();
            label11 = new Label();
            tbNProveedor = new TextBox();
            tbTelefono = new TextBox();
            label8 = new Label();
            tbEmail = new TextBox();
            label7 = new Label();
            btRegresarN = new Button();
            btGuardarN = new Button();
            label3 = new Label();
            tbNit = new TextBox();
            tabNuevo = new TabPage();
            label2 = new Label();
            tabLista = new TabPage();
            GridDatosProveedor = new DataGridView();
            btBuscarP = new Button();
            tbBuscar = new TextBox();
            btnuevoP = new Button();
            tbTelefonoE = new TextBox();
            label5 = new Label();
            tbEmailE = new TextBox();
            label6 = new Label();
            label9 = new Label();
            tbNitE = new TextBox();
            label10 = new Label();
            btREgresarE = new Button();
            tabControlMain = new TabControl();
            tabEditar = new TabPage();
            cbHabilitadoE = new ComboBox();
            label12 = new Label();
            tbDireccionE = new TextBox();
            label4 = new Label();
            tbProveedorE = new TextBox();
            btEditar = new Button();
            tabNuevo.SuspendLayout();
            tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridDatosProveedor).BeginInit();
            tabControlMain.SuspendLayout();
            tabEditar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 9;
            label1.Text = "Proveedor";
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(336, 53);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(256, 25);
            tbDireccion.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(342, 34);
            label11.Name = "label11";
            label11.Size = new Size(68, 22);
            label11.TabIndex = 11;
            label11.Text = "Direccion:";
            // 
            // tbNProveedor
            // 
            tbNProveedor.Location = new Point(74, 53);
            tbNProveedor.Name = "tbNProveedor";
            tbNProveedor.Size = new Size(256, 25);
            tbNProveedor.TabIndex = 10;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(74, 230);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(256, 25);
            tbTelefono.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(80, 211);
            label8.Name = "label8";
            label8.Size = new Size(64, 22);
            label8.TabIndex = 8;
            label8.Text = "Telefono:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(74, 169);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(256, 25);
            tbEmail.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 150);
            label7.Name = "label7";
            label7.Size = new Size(45, 22);
            label7.TabIndex = 6;
            label7.Text = "Email:";
            // 
            // btRegresarN
            // 
            btRegresarN.BackColor = Color.FromArgb(219, 94, 81);
            btRegresarN.Cursor = Cursors.Hand;
            btRegresarN.FlatAppearance.BorderColor = Color.Black;
            btRegresarN.FlatStyle = FlatStyle.Flat;
            btRegresarN.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btRegresarN.ForeColor = Color.White;
            btRegresarN.Location = new Point(462, 220);
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
            btGuardarN.Location = new Point(336, 220);
            btGuardarN.Name = "btGuardarN";
            btGuardarN.Size = new Size(120, 35);
            btGuardarN.TabIndex = 4;
            btGuardarN.Text = "Guardar";
            btGuardarN.UseVisualStyleBackColor = false;
            btGuardarN.Click += btGuardarN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 34);
            label3.Name = "label3";
            label3.Size = new Size(124, 22);
            label3.TabIndex = 2;
            label3.Text = "Nombre Proveedor:";
            // 
            // tbNit
            // 
            tbNit.Location = new Point(74, 112);
            tbNit.Name = "tbNit";
            tbNit.Size = new Size(256, 25);
            tbNit.TabIndex = 1;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(tbDireccion);
            tabNuevo.Controls.Add(label11);
            tabNuevo.Controls.Add(tbNProveedor);
            tabNuevo.Controls.Add(tbTelefono);
            tabNuevo.Controls.Add(label8);
            tabNuevo.Controls.Add(tbEmail);
            tabNuevo.Controls.Add(label7);
            tabNuevo.Controls.Add(btRegresarN);
            tabNuevo.Controls.Add(btGuardarN);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Controls.Add(tbNit);
            tabNuevo.Controls.Add(label2);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(768, 316);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 93);
            label2.Name = "label2";
            label2.Size = new Size(28, 22);
            label2.TabIndex = 0;
            label2.Text = "Nit:";
            // 
            // tabLista
            // 
            tabLista.Controls.Add(GridDatosProveedor);
            tabLista.Controls.Add(btBuscarP);
            tabLista.Controls.Add(tbBuscar);
            tabLista.Controls.Add(btnuevoP);
            tabLista.Font = new Font("Poppins SemiBold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabLista.Location = new Point(4, 24);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(768, 316);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // GridDatosProveedor
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GridDatosProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GridDatosProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridDatosProveedor.Location = new Point(6, 65);
            GridDatosProveedor.Name = "GridDatosProveedor";
            GridDatosProveedor.Size = new Size(756, 245);
            GridDatosProveedor.TabIndex = 3;
            GridDatosProveedor.CellContentClick += GridDatosProveedor_CellContentClick;
            // 
            // btBuscarP
            // 
            btBuscarP.BackColor = Color.FromArgb(29, 114, 198);
            btBuscarP.Cursor = Cursors.Hand;
            btBuscarP.FlatAppearance.BorderColor = Color.Black;
            btBuscarP.FlatStyle = FlatStyle.Flat;
            btBuscarP.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btBuscarP.ForeColor = Color.White;
            btBuscarP.Location = new Point(652, 16);
            btBuscarP.Name = "btBuscarP";
            btBuscarP.Size = new Size(110, 30);
            btBuscarP.TabIndex = 2;
            btBuscarP.Text = "Buscar";
            btBuscarP.UseVisualStyleBackColor = false;
            btBuscarP.Click += btBuscarP_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(399, 21);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(247, 25);
            tbBuscar.TabIndex = 1;
            // 
            // btnuevoP
            // 
            btnuevoP.BackColor = Color.FromArgb(38, 152, 134);
            btnuevoP.Cursor = Cursors.Hand;
            btnuevoP.FlatAppearance.BorderColor = Color.Black;
            btnuevoP.FlatStyle = FlatStyle.Flat;
            btnuevoP.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnuevoP.ForeColor = Color.White;
            btnuevoP.Location = new Point(6, 15);
            btnuevoP.Name = "btnuevoP";
            btnuevoP.Size = new Size(110, 30);
            btnuevoP.TabIndex = 0;
            btnuevoP.Text = "Nuevo";
            btnuevoP.UseVisualStyleBackColor = false;
            btnuevoP.Click += btnuevoP_Click;
            // 
            // tbTelefonoE
            // 
            tbTelefonoE.Location = new Point(77, 228);
            tbTelefonoE.Name = "tbTelefonoE";
            tbTelefonoE.Size = new Size(256, 25);
            tbTelefonoE.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 209);
            label5.Name = "label5";
            label5.Size = new Size(64, 22);
            label5.TabIndex = 18;
            label5.Text = "Telefono:";
            // 
            // tbEmailE
            // 
            tbEmailE.Location = new Point(77, 167);
            tbEmailE.Name = "tbEmailE";
            tbEmailE.Size = new Size(256, 25);
            tbEmailE.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 148);
            label6.Name = "label6";
            label6.Size = new Size(45, 22);
            label6.TabIndex = 16;
            label6.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(83, 32);
            label9.Name = "label9";
            label9.Size = new Size(124, 22);
            label9.TabIndex = 15;
            label9.Text = "Nombre Proveedor:";
            // 
            // tbNitE
            // 
            tbNitE.Location = new Point(77, 110);
            tbNitE.Name = "tbNitE";
            tbNitE.Size = new Size(256, 25);
            tbNitE.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(83, 91);
            label10.Name = "label10";
            label10.Size = new Size(28, 22);
            label10.TabIndex = 13;
            label10.Text = "Nit:";
            // 
            // btREgresarE
            // 
            btREgresarE.BackColor = Color.FromArgb(219, 94, 81);
            btREgresarE.Cursor = Cursors.Hand;
            btREgresarE.FlatAppearance.BorderColor = Color.Black;
            btREgresarE.FlatStyle = FlatStyle.Flat;
            btREgresarE.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btREgresarE.ForeColor = Color.White;
            btREgresarE.Location = new Point(475, 157);
            btREgresarE.Name = "btREgresarE";
            btREgresarE.Size = new Size(120, 35);
            btREgresarE.TabIndex = 11;
            btREgresarE.Text = "Regresar";
            btREgresarE.UseVisualStyleBackColor = false;
            btREgresarE.Click += btREgresarE_Click;
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
            tabControlMain.TabIndex = 8;
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(cbHabilitadoE);
            tabEditar.Controls.Add(label12);
            tabEditar.Controls.Add(tbDireccionE);
            tabEditar.Controls.Add(label4);
            tabEditar.Controls.Add(tbProveedorE);
            tabEditar.Controls.Add(tbTelefonoE);
            tabEditar.Controls.Add(label5);
            tabEditar.Controls.Add(tbEmailE);
            tabEditar.Controls.Add(label6);
            tabEditar.Controls.Add(label9);
            tabEditar.Controls.Add(tbNitE);
            tabEditar.Controls.Add(label10);
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
            // cbHabilitadoE
            // 
            cbHabilitadoE.Cursor = Cursors.Hand;
            cbHabilitadoE.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHabilitadoE.FormattingEnabled = true;
            cbHabilitadoE.Location = new Point(339, 105);
            cbHabilitadoE.Name = "cbHabilitadoE";
            cbHabilitadoE.Size = new Size(256, 30);
            cbHabilitadoE.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(345, 86);
            label12.Name = "label12";
            label12.Size = new Size(78, 22);
            label12.TabIndex = 23;
            label12.Text = "Habilidado:";
            // 
            // tbDireccionE
            // 
            tbDireccionE.Location = new Point(339, 51);
            tbDireccionE.Name = "tbDireccionE";
            tbDireccionE.Size = new Size(256, 25);
            tbDireccionE.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(345, 32);
            label4.Name = "label4";
            label4.Size = new Size(68, 22);
            label4.TabIndex = 21;
            label4.Text = "Direccion:";
            // 
            // tbProveedorE
            // 
            tbProveedorE.Location = new Point(77, 51);
            tbProveedorE.Name = "tbProveedorE";
            tbProveedorE.Size = new Size(256, 25);
            tbProveedorE.TabIndex = 20;
            // 
            // btEditar
            // 
            btEditar.BackColor = Color.FromArgb(29, 114, 198);
            btEditar.Cursor = Cursors.Hand;
            btEditar.FlatAppearance.BorderColor = Color.Black;
            btEditar.FlatStyle = FlatStyle.Flat;
            btEditar.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btEditar.ForeColor = Color.White;
            btEditar.Location = new Point(339, 157);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(120, 35);
            btEditar.TabIndex = 10;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = false;
            btEditar.Click += btEditar_Click;
            // 
            // frmProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProveedor";
            Load += frmProveedor_Load;
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridDatosProveedor).EndInit();
            tabControlMain.ResumeLayout(false);
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbDireccion;
        private Label label11;
        private TextBox tbNProveedor;
        private TextBox tbTelefono;
        private Label label8;
        private TextBox tbEmail;
        private Label label7;
        private Button btRegresarN;
        private Button btGuardarN;
        private Label label3;
        private TextBox tbNit;
        private TabPage tabNuevo;
        private Label label2;
        private TabPage tabLista;
        private DataGridView GridDatosProveedor;
        private Button btBuscarP;
        private TextBox tbBuscar;
        private Button btnuevoP;
        private TextBox tbTelefonoE;
        private Label label5;
        private TextBox tbEmailE;
        private Label label6;
        private Label label9;
        private TextBox tbNitE;
        private Label label10;
        private Button btREgresarE;
        private TabControl tabControlMain;
        private TabPage tabEditar;
        private ComboBox cbHabilitadoE;
        private Label label12;
        private TextBox tbDireccionE;
        private Label label4;
        private TextBox tbProveedorE;
        private Button btEditar;
    }
}