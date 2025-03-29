namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    partial class frmCliente
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
            tbTelefonoE = new TextBox();
            label5 = new Label();
            tbEmailE = new TextBox();
            label6 = new Label();
            label9 = new Label();
            tbNitE = new TextBox();
            label10 = new Label();
            btREgresarE = new Button();
            tabEditar = new TabPage();
            cbHabilitadoE = new ComboBox();
            label12 = new Label();
            tbDireccionE = new TextBox();
            label4 = new Label();
            tbNClienteE = new TextBox();
            btEditar = new Button();
            tabControlMain = new TabControl();
            tabLista = new TabPage();
            GridDatosCliente = new DataGridView();
            btBuscarC = new Button();
            tbBuscar = new TextBox();
            btnuevoC = new Button();
            tabNuevo = new TabPage();
            tbDireccion = new TextBox();
            label11 = new Label();
            tbNCliente = new TextBox();
            tbTelefono = new TextBox();
            label8 = new Label();
            tbEmail = new TextBox();
            label7 = new Label();
            btRegresarN = new Button();
            btGuardarN = new Button();
            label3 = new Label();
            tbNit = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabEditar.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridDatosCliente).BeginInit();
            tabNuevo.SuspendLayout();
            SuspendLayout();
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
            label5.Location = new Point(80, 206);
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
            label6.Location = new Point(80, 145);
            label6.Name = "label6";
            label6.Size = new Size(45, 22);
            label6.TabIndex = 16;
            label6.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(80, 29);
            label9.Name = "label9";
            label9.Size = new Size(105, 22);
            label9.TabIndex = 15;
            label9.Text = "Nombre Cliente:";
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
            label10.Location = new Point(80, 88);
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
            // tabEditar
            // 
            tabEditar.Controls.Add(cbHabilitadoE);
            tabEditar.Controls.Add(label12);
            tabEditar.Controls.Add(tbDireccionE);
            tabEditar.Controls.Add(label4);
            tabEditar.Controls.Add(tbNClienteE);
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
            label12.Location = new Point(342, 83);
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
            label4.Location = new Point(342, 29);
            label4.Name = "label4";
            label4.Size = new Size(68, 22);
            label4.TabIndex = 21;
            label4.Text = "Direccion:";
            // 
            // tbNClienteE
            // 
            tbNClienteE.Location = new Point(77, 51);
            tbNClienteE.Name = "tbNClienteE";
            tbNClienteE.Size = new Size(256, 25);
            tbNClienteE.TabIndex = 20;
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
            tabControlMain.TabIndex = 6;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(GridDatosCliente);
            tabLista.Controls.Add(btBuscarC);
            tabLista.Controls.Add(tbBuscar);
            tabLista.Controls.Add(btnuevoC);
            tabLista.Font = new Font("Poppins SemiBold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabLista.Location = new Point(4, 24);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(768, 316);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // GridDatosCliente
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GridDatosCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GridDatosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridDatosCliente.Location = new Point(6, 65);
            GridDatosCliente.Name = "GridDatosCliente";
            GridDatosCliente.Size = new Size(756, 245);
            GridDatosCliente.TabIndex = 3;
            GridDatosCliente.CellContentClick += GridDatosCliente_CellContentClick;
            // 
            // btBuscarC
            // 
            btBuscarC.BackColor = Color.FromArgb(29, 114, 198);
            btBuscarC.Cursor = Cursors.Hand;
            btBuscarC.FlatAppearance.BorderColor = Color.Black;
            btBuscarC.FlatStyle = FlatStyle.Flat;
            btBuscarC.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btBuscarC.ForeColor = Color.White;
            btBuscarC.Location = new Point(652, 16);
            btBuscarC.Name = "btBuscarC";
            btBuscarC.Size = new Size(110, 30);
            btBuscarC.TabIndex = 2;
            btBuscarC.Text = "Buscar";
            btBuscarC.UseVisualStyleBackColor = false;
            btBuscarC.Click += btBuscarC_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(399, 21);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(247, 25);
            tbBuscar.TabIndex = 1;
            // 
            // btnuevoC
            // 
            btnuevoC.BackColor = Color.FromArgb(38, 152, 134);
            btnuevoC.Cursor = Cursors.Hand;
            btnuevoC.FlatAppearance.BorderColor = Color.Black;
            btnuevoC.FlatStyle = FlatStyle.Flat;
            btnuevoC.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnuevoC.ForeColor = Color.White;
            btnuevoC.Location = new Point(6, 15);
            btnuevoC.Name = "btnuevoC";
            btnuevoC.Size = new Size(110, 30);
            btnuevoC.TabIndex = 0;
            btnuevoC.Text = "Nuevo";
            btnuevoC.UseVisualStyleBackColor = false;
            btnuevoC.Click += btnuevoC_Click;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(tbDireccion);
            tabNuevo.Controls.Add(label11);
            tabNuevo.Controls.Add(tbNCliente);
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
            label11.Location = new Point(339, 31);
            label11.Name = "label11";
            label11.Size = new Size(68, 22);
            label11.TabIndex = 11;
            label11.Text = "Direccion:";
            // 
            // tbNCliente
            // 
            tbNCliente.Location = new Point(74, 53);
            tbNCliente.Name = "tbNCliente";
            tbNCliente.Size = new Size(256, 25);
            tbNCliente.TabIndex = 10;
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
            label8.Location = new Point(77, 208);
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
            label7.Location = new Point(77, 147);
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
            label3.Location = new Point(77, 31);
            label3.Name = "label3";
            label3.Size = new Size(105, 22);
            label3.TabIndex = 2;
            label3.Text = "Nombre Cliente:";
            // 
            // tbNit
            // 
            tbNit.Location = new Point(74, 112);
            tbNit.Name = "tbNit";
            tbNit.Size = new Size(256, 25);
            tbNit.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 90);
            label2.Name = "label2";
            label2.Size = new Size(28, 22);
            label2.TabIndex = 0;
            label2.Text = "Nit:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 7;
            label1.Text = "Clientes";
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlMain);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCliente";
            Load += frmCliente_Load;
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            tabControlMain.ResumeLayout(false);
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridDatosCliente).EndInit();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTelefonoE;
        private Label label5;
        private TextBox tbEmailE;
        private Label label6;
        private Label label9;
        private TextBox tbNitE;
        private Label label10;
        private Button btREgresarE;
        private TabPage tabEditar;
        private ComboBox cbHabilitadoE;
        private Label label12;
        private TextBox tbDireccionE;
        private Label label4;
        private TextBox tbNClienteE;
        private Button btEditar;
        private TabControl tabControlMain;
        private TabPage tabLista;
        private DataGridView GridDatosCliente;
        private Button btBuscarC;
        private TextBox tbBuscar;
        private Button btnuevoC;
        private TabPage tabNuevo;
        private TextBox tbDireccion;
        private Label label11;
        private TextBox tbNCliente;
        private TextBox tbTelefono;
        private Label label8;
        private TextBox tbEmail;
        private Label label7;
        private Button btRegresarN;
        private Button btGuardarN;
        private Label label3;
        private TextBox tbNit;
        private Label label2;
        private Label label1;
    }
}