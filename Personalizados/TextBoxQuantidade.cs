using System.ComponentModel;

namespace ControleEstoque.Personalizados
{
    public class TextBoxQuantidade : TextBox
    {
        private decimal _valor = 0;
        private bool _processando = false;

        private bool EmDesign => LicenseManager.UsageMode == LicenseUsageMode.Designtime;

        public TextBoxQuantidade()
        {
            if (EmDesign) return;

            TextAlign = HorizontalAlignment.Right;
            Text = "0,000";

            KeyPress += TextBoxQuantidade_KeyPress;
            TextChanged += TextBoxQuantidade_TextChanged;
            Enter += TextBoxQuantidade_Enter;
            Leave += TextBoxQuantidade_Leave;
        }

        [Category("Behavior")]
        [Description("O valor numérico do controle")]
        [DefaultValue(0)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public decimal Valor
        {
            get => _valor;
            set
            {
                _valor = value;
                if (!EmDesign)
                    Text = _valor.ToString("N3");
            }
        }

        private void TextBoxQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void TextBoxQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (EmDesign || _processando) return;

            _processando = true;

            var texto = Text.Replace(".", "").Replace(",", "").Trim();

            if (decimal.TryParse(texto, out var valor))
            {
                _valor = valor / 1000;
                Text = _valor.ToString("N3");
                SelectionStart = Text.Length;
            }

            _processando = false;
        }

        private void TextBoxQuantidade_Enter(object sender, EventArgs e)
        {
            SelectionStart = 0;
            SelectionLength = Text.Length;
        }

        private void TextBoxQuantidade_Leave(object sender, EventArgs e)
        {
            Text = _valor.ToString("N3");
        }
    }
}
