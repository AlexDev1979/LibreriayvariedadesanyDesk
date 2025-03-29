namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    partial class frmUsuario
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
            tabNuevo = new TabPage();
            tbNombreUsuario = new TextBox();
            label8 = new Label();
            tbEmail = new TextBox();
            label7 = new Label();
            btRegresarN = new Button();
            btGuardarN = new Button();
            cbNuevoRol = new ComboBox();
            label3 = new Label();
            tbNuevoNombre = new TextBox();
            label2 = new Label();
            tbUsuarioEdit = new TextBox();
            label4 = new Label();
            tbEmailEdit = new TextBox();
            label5 = new Label();
            cbRolEditar = new ComboBox();
            label9 = new Label();
            GridDatosUsuario = new DataGridView();
            btBuscarU = new Button();
            tbBuscar = new TextBox();
            btnuevoU = new Button();
            tabControlMain = new TabControl();
            tabLista = new TabPage();
            tabEditar = new TabPage();
            tbNombreEdit = new TextBox();
            label10 = new Label();
            cbHabilitadoE = new ComboBox();
            label6 = new Label();
            btREgresarE = new Button();
            btEditar = new Button();
            label1 = new Label();
            tabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridDatosUsuario).BeginInit();
            tabControlMain.SuspendLayout();
            tabLista.SuspendLayout();
            tabEditar.SuspendLayout();
            SuspendLayout();
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(tbNombreUsuario);
            tabNuevo.Controls.Add(label8);
            tabNuevo.Controls.Add(tbEmail);
            tabNuevo.Controls.Add(label7);
            tabNuevo.Controls.Add(btRegresarN);
            tabNuevo.Controls.Add(btGuardarN);
            tabNuevo.Controls.Add(cbNuevoRol);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Controls.Add(tbNuevoNombre);
            tabNuevo.Controls.Add(label2);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(768, 316);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
            // 
            // tbNombreUsuario
            // 
            tbNombreUsuario.Location = new Point(74, 230);
            tbNombreUsuario.Name = "tbNombreUsuario";
            tbNombreUsuario.Size = new Size(256, 25);
            tbNombreUsuario.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(80, 211);
            label8.Name = "label8";
            label8.Size = new Size(109, 22);
            label8.TabIndex = 8;
            label8.Text = "Nombre usuario:";
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
            // cbNuevoRol
            // 
            cbNuevoRol.Cursor = Cursors.Hand;
            cbNuevoRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNuevoRol.FormattingEnabled = true;
            cbNuevoRol.Location = new Point(74, 53);
            cbNuevoRol.Name = "cbNuevoRol";
            cbNuevoRol.Size = new Size(256, 30);
            cbNuevoRol.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 34);
            label3.Name = "label3";
            label3.Size = new Size(31, 22);
            label3.TabIndex = 2;
            label3.Text = "Rol:";
            // 
            // tbNuevoNombre
            // 
            tbNuevoNombre.Location = new Point(74, 112);
            tbNuevoNombre.Name = "tbNuevoNombre";
            tbNuevoNombre.Size = new Size(256, 25);
            tbNuevoNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 93);
            label2.Name = "label2";
            label2.Size = new Size(121, 22);
            label2.TabIndex = 0;
            label2.Text = "Nombre completo:";
            // 
            // tbUsuarioEdit
            // 
            tbUsuarioEdit.Location = new Point(75, 198);
            tbUsuarioEdit.Name = "tbUsuarioEdit";
            tbUsuarioEdit.Size = new Size(256, 25);
            tbUsuarioEdit.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 176);
            label4.Name = "label4";
            label4.Size = new Size(109, 22);
            label4.TabIndex = 20;
            label4.Text = "Nombre usuario:";
            // 
            // tbEmailEdit
            // 
            tbEmailEdit.Location = new Point(75, 145);
            tbEmailEdit.Name = "tbEmailEdit";
            tbEmailEdit.Size = new Size(256, 25);
            tbEmailEdit.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 123);
            label5.Name = "label5";
            label5.Size = new Size(45, 22);
            label5.TabIndex = 18;
            label5.Text = "Email:";
            // 
            // cbRolEditar
            // 
            cbRolEditar.Cursor = Cursors.Hand;
            cbRolEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRolEditar.FormattingEnabled = true;
            cbRolEditar.Location = new Point(75, 33);
            cbRolEditar.Name = "cbRolEditar";
            cbRolEditar.Size = new Size(256, 30);
            cbRolEditar.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(78, 11);
            label9.Name = "label9";
            label9.Size = new Size(31, 22);
            label9.TabIndex = 16;
            label9.Text = "Rol:";
            // 
            // GridDatosUsuario
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GridDatosUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GridDatosUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridDatosUsuario.Location = new Point(6, 65);
            GridDatosUsuario.Name = "GridDatosUsuario";
            GridDatosUsuario.Size = new Size(756, 245);
            GridDatosUsuario.TabIndex = 3;
            GridDatosUsuario.CellContentClick += GridDatosUsuario_CellContentClick;
            // 
            // btBuscarU
            // 
            btBuscarU.BackColor = Color.FromArgb(29, 114, 198);
            btBuscarU.Cursor = Cursors.Hand;
            btBuscarU.FlatAppearance.BorderColor = Color.Black;
            btBuscarU.FlatStyle = FlatStyle.Flat;
            btBuscarU.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btBuscarU.ForeColor = Color.White;
            btBuscarU.Location = new Point(652, 16);
            btBuscarU.Name = "btBuscarU";
            btBuscarU.Size = new Size(110, 30);
            btBuscarU.TabIndex = 2;
            btBuscarU.Text = "Buscar";
            btBuscarU.UseVisualStyleBackColor = false;
            btBuscarU.Click += btBuscarU_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(399, 21);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(247, 25);
            tbBuscar.TabIndex = 1;
            // 
            // btnuevoU
            // 
            btnuevoU.BackColor = Color.FromArgb(38, 152, 134);
            btnuevoU.Cursor = Cursors.Hand;
            btnuevoU.FlatAppearance.BorderColor = Color.Black;
            btnuevoU.FlatStyle = FlatStyle.Flat;
            btnuevoU.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnuevoU.ForeColor = Color.White;
            btnuevoU.Location = new Point(6, 15);
            btnuevoU.Name = "btnuevoU";
            btnuevoU.Size = new Size(110, 30);
            btnuevoU.TabIndex = 0;
            btnuevoU.Text = "Nuevo";
            btnuevoU.UseVisualStyleBackColor = false;
            btnuevoU.Click += btnuevoU_Click;
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
            tabLista.Controls.Add(GridDatosUsuario);
            tabLista.Controls.Add(btBuscarU);
            tabLista.Controls.Add(tbBuscar);
            tabLista.Controls.Add(btnuevoU);
            tabLista.Font = new Font("Poppins SemiBold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabLista.Location = new Point(4, 24);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(768, 316);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(tbUsuarioEdit);
            tabEditar.Controls.Add(label4);
            tabEditar.Controls.Add(tbEmailEdit);
            tabEditar.Controls.Add(label5);
            tabEditar.Controls.Add(cbRolEditar);
            tabEditar.Controls.Add(label9);
            tabEditar.Controls.Add(tbNombreEdit);
            tabEditar.Controls.Add(label10);
            tabEditar.Controls.Add(cbHabilitadoE);
            tabEditar.Controls.Add(label6);
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
            // tbNombreEdit
            // 
            tbNombreEdit.Location = new Point(75, 91);
            tbNombreEdit.Name = "tbNombreEdit";
            tbNombreEdit.Size = new Size(256, 25);
            tbNombreEdit.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(78, 69);
            label10.Name = "label10";
            label10.Size = new Size(121, 22);
            label10.TabIndex = 14;
            label10.Text = "Nombre completo:";
            // 
            // cbHabilitadoE
            // 
            cbHabilitadoE.Cursor = Cursors.Hand;
            cbHabilitadoE.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHabilitadoE.FormattingEnabled = true;
            cbHabilitadoE.Location = new Point(75, 251);
            cbHabilitadoE.Name = "cbHabilitadoE";
            cbHabilitadoE.Size = new Size(256, 30);
            cbHabilitadoE.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 229);
            label6.Name = "label6";
            label6.Size = new Size(78, 22);
            label6.TabIndex = 12;
            label6.Text = "Habilidado:";
            // 
            // btREgresarE
            // 
            btREgresarE.BackColor = Color.FromArgb(219, 94, 81);
            btREgresarE.Cursor = Cursors.Hand;
            btREgresarE.FlatAppearance.BorderColor = Color.Black;
            btREgresarE.FlatStyle = FlatStyle.Flat;
            btREgresarE.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btREgresarE.ForeColor = Color.White;
            btREgresarE.Location = new Point(510, 136);
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
            btEditar.Location = new Point(384, 136);
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
            label1.Size = new Size(79, 28);
            label1.TabIndex = 5;
            label1.Text = "Usuario";
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlMain);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuario";
            Load += Usuario_Load;
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridDatosUsuario).EndInit();
            tabControlMain.ResumeLayout(false);
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabPage tabNuevo;
        private TextBox tbNombreUsuario;
        private Label label8;
        private TextBox tbEmail;
        private Label label7;
        private Button btRegresarN;
        private Button btGuardarN;
        private ComboBox cbNuevoRol;
        private Label label3;
        private TextBox tbNuevoNombre;
        private Label label2;
        private TextBox tbUsuarioEdit;
        private Label label4;
        private TextBox tbEmailEdit;
        private Label label5;
        private ComboBox cbRolEditar;
        private Label label9;
        private DataGridView GridDatosUsuario;
        private Button btBuscarU;
        private TextBox tbBuscar;
        private Button btnuevoU;
        private TabControl tabControlMain;
        private TabPage tabLista;
        private TabPage tabEditar;
        private TextBox tbNombreEdit;
        private Label label10;
        private ComboBox cbHabilitadoE;
        private Label label6;
        private Button btREgresarE;
        private Button btEditar;
        private Label label1;
    }
}