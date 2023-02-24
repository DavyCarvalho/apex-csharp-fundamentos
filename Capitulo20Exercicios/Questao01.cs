using System;
using System.Windows.Forms;

namespace Capitulo20Exercicios
{
    public partial class Questao01 : Form
    {
        public Questao01()
        {
            InitializeComponent();
        }

        private void BotaoDeCalcularMedia_Click(object sender, EventArgs e)
        {
            var nota1 = double.Parse(textBoxNota1.Text);
            var nota2 = double.Parse(textBoxNota2.Text);
            var nota3 = double.Parse(textBoxNota3.Text);
            var nota4 = double.Parse(textBoxNota4.Text);

            var media = (nota1 + nota2 + nota3 + nota4) / 4;
            var mediaArredondada = Math.Round(media, 2);

            textBoxDoResultado.Text = mediaArredondada.ToString();
        }

        private void BotaoLimpar_Click(object sender, EventArgs e)
        {
            textBoxNota1.Text = string.Empty;
            textBoxNota2.Text = string.Empty;
            textBoxNota3.Text = string.Empty;
            textBoxNota4.Text = string.Empty;
            textBoxDoResultado.Text = string.Empty;
        }
    }
}
