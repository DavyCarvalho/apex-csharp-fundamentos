using System;
using System.Windows.Forms;

namespace Capitulo20Exercicios
{
    public partial class Questao02e03 : Form
    {
        public Questao02e03()
        {
            InitializeComponent();
        }

        private void BotaoConsultarSaldo_Click(object sender, EventArgs e)
        {
            var numeroDaConta = int.Parse(textBoxDoNumeroDaConta.Text);
            var saldo = 100;

            if (numeroDaConta > 0 && numeroDaConta <= 5)
            {
                saldo = -10;
            }

            textBoxDoSaldo.Text = string.Empty;
            textBoxDoSaldo.Text = saldo.ToString();
        }

        private void textBoxDoNumeroDaConta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxDoSaldo.Text = string.Empty;
                checkBoxChequeEspecial.Checked = false;

                var numeroDaConta = int.Parse(textBoxDoNumeroDaConta.Text);

                if (numeroDaConta > 0 && numeroDaConta <= 10)
                {
                    BotaoConsultarSaldo.Enabled = true;
                }
                else
                {
                    BotaoConsultarSaldo.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void textBoxDoSaldo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDoSaldo.Text.Length > 0)
            {
                var saldo = int.Parse(textBoxDoSaldo.Text);

                if (saldo > 0 || checkBoxChequeEspecial.Checked)
                {
                    BotaoSacar.Enabled = true;
                }
                else
                {
                    BotaoSacar.Enabled = false;
                }
            }
        }

        private void BotaoSacar_Click(object sender, EventArgs e)
        {
            textBoxDoSaldo.Text = string.Empty;
        }
    }
}
