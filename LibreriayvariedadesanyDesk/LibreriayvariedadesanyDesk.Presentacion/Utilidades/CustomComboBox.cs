using LibreriayvariedadesanyDeskPresentacion.Utilidades.Objetos;

namespace SVPresentation.Utilidades
{
    public static class CustomComboBox
    {
        public static void InsertarItems(this ComboBox comboBox, OpcionCombo[] items)
        {
            comboBox.Items.AddRange(items);
            comboBox.DisplayMember = "Texto";
            comboBox.ValueMember = "1";
            comboBox.SelectedIndex = 0;
        }
        public static void EstablecerValor(this ComboBox combo, int valor)
        {
            foreach (OpcionCombo Opcion in combo.Items)
            {
                if (Opcion.Valor == valor)
                {
                    combo.SelectedItem = Opcion;
                    break;
                }
            }
        }
    }
}
