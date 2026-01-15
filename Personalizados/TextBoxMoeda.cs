using System.ComponentModel;

namespace ControleEstoque.Personalizados
{
    public class TextBoxMoeda : TextBox
    {
        private decimal _valor = 0;
        private bool _processando = false;

        private bool EmDesign => LicenseManager.UsageMode == LicenseUsageMode.Designtime;

        public TextBoxMoeda()
        {
            if (EmDesign) return;

            TextAlign = HorizontalAlignment.Right;
            Text = "0,00";

            KeyPress += TextBoxMoeda_KeyPress;
            TextChanged += TextBoxMoeda_TextChanged;
            Enter += TextBoxMoeda_Enter;
            Leave += TextBoxMoeda_Leave;
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
                    Text = _valor.ToString("N2");
            }
        }

        private void TextBoxMoeda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void TextBoxMoeda_TextChanged(object sender, EventArgs e)
        {
            if (EmDesign || _processando) return;

            _processando = true;

            var texto = Text.Replace(",", "").Replace(".", "").Trim();

            if (decimal.TryParse(texto, out var valor))
            {
                _valor = valor / 100;
                Text = _valor.ToString("N2");
                SelectionStart = Text.Length;
            }

            _processando = false;
        }

        private void TextBoxMoeda_Enter(object sender, EventArgs e)
        {
            SelectionStart = 0;
            SelectionLength = Text.Length;
        }

        private void TextBoxMoeda_Leave(object sender, EventArgs e)
        {
            Text = _valor.ToString("N2");
        }
    }
}
