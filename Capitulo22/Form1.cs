using System;
using System.Windows.Forms;

namespace Capitulo22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoAbrirForm2_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            //form2.ShowDialog();
            form2.Show();
        }
    }
}
