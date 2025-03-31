namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    partial class frmDetalleVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleVenta));
            GridDatosDetalleV = new DataGridView();
            btverPDF = new Button();
            label1 = new Label();
            lbNumeroVenta = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)GridDatosDetalleV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GridDatosDetalleV
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GridDatosDetalleV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GridDatosDetalleV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridDatosDetalleV.Location = new Point(12, 101);
            GridDatosDetalleV.Name = "GridDatosDetalleV";
            GridDatosDetalleV.Size = new Size(736, 247);
            GridDatosDetalleV.TabIndex = 10;
            // 
            // btverPDF
            // 
            btverPDF.BackColor = Color.FromArgb(29, 114, 198);
            btverPDF.Cursor = Cursors.Hand;
            btverPDF.FlatAppearance.BorderColor = Color.Black;
            btverPDF.FlatStyle = FlatStyle.Flat;
            btverPDF.Font = new Font("Poppins", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btverPDF.ForeColor = Color.White;
            btverPDF.Image = (Image)resources.GetObject("btverPDF.Image");
            btverPDF.Location = new Point(638, 46);
            btverPDF.Name = "btverPDF";
            btverPDF.Size = new Size(110, 43);
            btverPDF.TabIndex = 11;
            btverPDF.Text = "ver PDF";
            btverPDF.TextImageRelation = TextImageRelation.ImageBeforeText;
            btverPDF.UseVisualStyleBackColor = false;
            btverPDF.Click += btverPDF_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 12;
            label1.Text = "Numero de venta:";
            // 
            // lbNumeroVenta
            // 
            lbNumeroVenta.AutoSize = true;
            lbNumeroVenta.Location = new Point(120, 58);
            lbNumeroVenta.Name = "lbNumeroVenta";
            lbNumeroVenta.Size = new Size(13, 15);
            lbNumeroVenta.TabIndex = 13;
            lbNumeroVenta.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(726, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(760, 360);
            Controls.Add(pictureBox1);
            Controls.Add(lbNumeroVenta);
            Controls.Add(label1);
            Controls.Add(btverPDF);
            Controls.Add(GridDatosDetalleV);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(760, 360);
            MinimumSize = new Size(760, 360);
            Name = "frmDetalleVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmDetalleVenta_Load;
            ((System.ComponentModel.ISupportInitialize)GridDatosDetalleV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridDatosDetalleV;
        private Button btverPDF;
        private Label label1;
        private Label lbNumeroVenta;
        private PictureBox pictureBox1;
    }
}