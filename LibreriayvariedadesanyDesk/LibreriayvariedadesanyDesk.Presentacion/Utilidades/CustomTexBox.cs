namespace LibreriayvariedadesanyDeskPresentacion.Utilidades
{
    public static class CustomTexBox
    {
        public static void ValidarNumero(this TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    { 
                        e.Handled= true;
                    }
                } 

            };
        }
    }
}
