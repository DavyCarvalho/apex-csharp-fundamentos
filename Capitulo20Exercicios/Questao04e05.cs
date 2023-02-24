using System;
using System.Windows.Forms;

namespace Capitulo20Exercicios
{
    public partial class Questao04e05 : Form
    {
        public bool MaiorDeDezoito { get; set; }

        public Questao04e05()
        {
            InitializeComponent();
        }

        private void Nome_TextChanged(object sender, EventArgs e)
        {
            if (Nome.Text.Length >= 4)
            {
                DataDeNascimento.Enabled = true;
            }
            else
            {
                DataDeNascimento.Enabled = false;
            }
        }

        private void DataDeNascimento_ValueChanged(object sender, EventArgs e)
        {
            var dezoitoAnosAtras = DateTime.Today.AddYears(-18);
            var nascimento = DataDeNascimento.Value;

            if (nascimento < dezoitoAnosAtras)
            {
                MaiorDeDezoito = true;

                ContaPoupanca.Visible = true;
                ContaUniversitaria.Visible = true;
                ContaPJ.Visible = true;
                ContaCorrente.Visible = true;
            }
            else
            {
                MaiorDeDezoito = false;

                ContaPoupanca.Visible = true;
                Emancipado.Visible = true;
            }
        }

        private void Emancipado_CheckedChanged(object sender, EventArgs e)
        {
            if (Emancipado.Checked && MaiorDeDezoito)
            {
                ContaCorrente.Visible = true;
            }
            else
            {
                ContaCorrente.Visible = false;
            }
        }

        private void PessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (PessoaFisica.Checked)
            {
                PessoaJuridica.Enabled = false;
                TextoDigiteCNPJ.Visible = false;
                CNPJ.Visible = false;

                Universitario.Enabled = false;
                TextoDigiteCodDaMatricula.Visible = false;
                Matricula.Visible = false;
                SemCodigoDeMatricula.Visible = false;
                TextoPassarCodDoGerente.Visible = false;
                CodigoGerente.Visible = false;

                ContaPJ.Visible = false;
                ContaUniversitaria.Visible = false;
            }
            else
            {
                PessoaJuridica.Enabled = true;
                TextoDigiteCNPJ.Visible = true;
                CNPJ.Visible = true;

                Universitario.Enabled = true;
                TextoDigiteCodDaMatricula.Visible = true;
                Matricula.Visible = true;
                SemCodigoDeMatricula.Visible = true;
                TextoPassarCodDoGerente.Visible = true;
                CodigoGerente.Visible = true;

                ContaPJ.Visible = true;
                ContaUniversitaria.Visible = true;
            }
        }

        private void PessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (PessoaJuridica.Checked)
            {
                TextoDigiteNome.Text = "Digite o nome da sua Empresa:";
                TextoDigiteDataDeNascimento.Visible = false;
                DataDeNascimento.Visible = false;
                Emancipado.Visible = false;
                TextoDigiteSeuCpf.Visible = false;
                Cpf.Visible = false;

                Universitario.Enabled = false;
                TextoDigiteCodDaMatricula.Visible = false;
                Matricula.Visible = false;
                SemCodigoDeMatricula.Visible = false;
                TextoPassarCodDoGerente.Visible = false;
                CodigoGerente.Visible = false;

                ContaUniversitaria.Visible = false;
                ContaCorrente.Visible = false;
                ContaPoupanca.Visible = false;
            }
            else
            {
                TextoDigiteNome.Text = "Digite seu nome:";
                TextoDigiteDataDeNascimento.Visible = true;
                DataDeNascimento.Visible = true;
                Emancipado.Visible = true;
                TextoDigiteSeuCpf.Visible = true;
                Cpf.Visible = true;

                Universitario.Enabled = true;
                TextoDigiteCodDaMatricula.Visible = true;
                Matricula.Visible = true;
                SemCodigoDeMatricula.Visible = true;
                TextoPassarCodDoGerente.Visible = true;
                CodigoGerente.Visible = true;

                ContaUniversitaria.Visible = true;
                ContaCorrente.Visible = true;
                ContaPoupanca.Visible = true;
            }
        }

        private void Universitario_CheckedChanged(object sender, EventArgs e)
        {
            if (Universitario.Checked)
            {
                Emancipado.Visible = false;

                PessoaJuridica.Enabled = false;
                TextoDigiteCNPJ.Visible = false;
                CNPJ.Visible = false;

                ContaPJ.Visible = false;
                ContaCorrente.Visible = false;
                ContaPoupanca.Visible = false;
            }
            else
            {
                PessoaJuridica.Enabled = true;
                TextoDigiteCNPJ.Visible = true;
                CNPJ.Visible = true;

                ContaPJ.Visible = true;
                ContaCorrente.Visible = true;
                ContaPoupanca.Visible = true;
            }
        }

        private void SemCodigoDeMatricula_CheckedChanged(object sender, EventArgs e)
        {

            CodigoGerente.Visible = true;
        }
    }
}
