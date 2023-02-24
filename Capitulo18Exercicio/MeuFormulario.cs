using System;
using System.Windows.Forms;

namespace Capitulo18Exercicio
{
    public partial class MeuFormulario : Form
    {
        public MeuFormulario()
        {
            InitializeComponent();
        }

        private void BotaoUm_Click(object sender, EventArgs e)
        {
            var mensagem = "Os nomes são:" +
                           $"{PainelUm.Name}, " +
                           $"{CaixaDeTextoUm.Name}, " +
                           $"{SelecionadorDeDataUm.Name}, " +
                           $"{ComboBoxUm.Name} ," +
                           $"{NumericUpDownUm.Name} ," +
                           $"{VisualizadorDeDadosUm.Name} ,";

            MessageBox.Show(mensagem);        
        }
    }
}
