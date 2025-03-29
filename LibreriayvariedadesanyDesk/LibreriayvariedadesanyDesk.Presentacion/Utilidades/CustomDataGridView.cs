namespace SVPresentation.Utilidades
{
    public static class CustomDataGridView
    {
        public static void ImplementarConfiguracion(this DataGridView GridDatos, string textoBoton = "")
        {
            GridDatos.AllowUserToAddRows = false;
            GridDatos.AllowUserToDeleteRows = false;
            GridDatos.AllowUserToResizeColumns = true;
            GridDatos.AllowUserToResizeRows = false;
            GridDatos.AllowUserToOrderColumns = false;
            GridDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            GridDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridDatos.MultiSelect = false;
            GridDatos.RowHeadersVisible = false;
            GridDatos.ReadOnly = true;
            GridDatos.BackgroundColor = Color.White;
            GridDatos.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(31, 80, 154),
                SelectionBackColor = Color.FromArgb(31, 80, 154),
                ForeColor = Color.FromArgb(255, 255, 255)
            };
            GridDatos.DefaultCellStyle = new DataGridViewCellStyle
            {
                SelectionBackColor = Color.FromArgb(212, 235, 248),
                SelectionForeColor = Color.FromArgb(0, 0, 0)
            };
            GridDatos.ColumnHeadersHeight = 30;
            GridDatos.EnableHeadersVisualStyles = false;
            GridDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            var btEditarColumna = new DataGridViewButtonColumn();
            btEditarColumna.Text = textoBoton;
            btEditarColumna.Name = "ColumnaAccion";
            btEditarColumna.HeaderText = "";
            btEditarColumna.UseColumnTextForButtonValue = true;
            btEditarColumna.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            GridDatos.Columns.Add(btEditarColumna);
        }
    }
}