namespace ControleEstoque.Masks
{
    public class CurrencyTextBox : TextBox
    {
        private bool _isUpdating = false;

        public CurrencyTextBox()
        {
            this.TextAlign = HorizontalAlignment.Right;
            this.TextChanged += CurrencyTextBox_TextChanged;
            this.KeyPress += CurrencyTextBox_KeyPress;
            this.Enter += CurrencyTextBox_Enter;
            this.Text = "0,00";
        }

        private void CurrencyTextBox_Enter(object sender, EventArgs e)
        {
            // Seleciona tudo quando entrar no campo
            this.SelectAll();
        }

        private void CurrencyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CurrencyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            _isUpdating = true;

            // Remove tudo que não é número
            string texto = new string(this.Text.Where(char.IsDigit).ToArray());

            if (string.IsNullOrEmpty(texto))
            {
                this.Text = "0,00";
                this.SelectionStart = this.Text.Length;
            }
            else
            {
                // Remove zeros à esquerda
                texto = texto.TrimStart('0');
                if (string.IsNullOrEmpty(texto))
                    texto = "0";

                // Converte para decimal (divide por 100 para ter 2 casas decimais)
                decimal valor = decimal.Parse(texto) / 100m;

                // Formata com 2 casas decimais e separador de milhares
                this.Text = valor.ToString("N2");

                // Mantém o cursor no final
                this.SelectionStart = this.Text.Length;
            }

            _isUpdating = false;
        }

        /// <summary>
        /// Obtém o valor decimal do TextBox
        /// </summary>
        public decimal GetValue()
        {
            string texto = this.Text.Replace(".", "").Replace(",", ".");
            if (decimal.TryParse(texto, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal valor))
                return valor;
            return 0;
        }

        /// <summary>
        /// Define o valor decimal no TextBox
        /// </summary>
        public void SetValue(decimal valor)
        {
            _isUpdating = true;
            this.Text = valor.ToString("N2");
            _isUpdating = false;
        }
    }
}
