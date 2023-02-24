using System;
using System.Windows.Forms;

namespace WinFormsValidacoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotaoEnviar_Click(object sender, EventArgs e)
        {
            if (ValidarCampoDeTexto() && ValidarComboBox())
            {
                labelDeErro.Text = string.Empty;

                labelDeSucesso.Text = "Tudo certo meu nobre!";
            }
        }

        private bool ValidarCampoDeTexto()
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                labelDeSucesso.Visible = false;

                labelDeErro.Text = "Digite algo para enviar!";
                labelDeErro.Visible = true;

                return false;
            }
            else if (textBox1.Text.Contains("BANANA"))
            {
                labelDeSucesso.Visible = false;

                labelDeErro.Text = "Não pode digitar nada contendo BANANA!";
                labelDeErro.Visible = true;

                return false;
            }
            else
            {
                labelDeErro.Visible = false;

                labelDeSucesso.Visible = true;

                return true;
            }
        }

        private bool ValidarComboBox()
        {
            if (comboBox1.SelectedIndex == -1)
            {
                return false;
            }
            else if (comboBox1.SelectedItem.ToString() == "Opção 1")
            {
                MessageBox.Show("Opção 1 não pode, por que sim!");
                return false;
            }
            return true;
        }

        public bool ValidarCampoData()
        {
            if (dateTimePicker1.Value == DateTime.Now)
            {
                MessageBox.Show("Data não pode ser hoje!");
                return false;
            }
            else if (dateTimePicker1.Value == DateTime.Now.AddDays(-1))
            {
                MessageBox.Show("Data não pode ser ontem!");
                return false;
            }
            return true;
        }

        public bool ValidarCampoNumericUpDown()
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Valor nao pode ser zero!");
                return false;
            }
            else if (numericUpDown1.Value > 180)
            {
                MessageBox.Show("Valor muito alto!");
                return false;
            }
            return true;
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Nada foi digitado!");
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Int32.Parse(textBox1.Text);
            }
            catch
            {
                labelDeSucesso.Visible = false;

                MessageBox.Show("Digite apenas números!");
            }
        }
    }
}
