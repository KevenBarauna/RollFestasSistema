using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollFestas.View.MensagemErro
{
    public partial class ErroController : Form
    {
        public ErroController(string NumeroErro, string Erro, string Solucao1, string Solucao2, string Solucao3)
        {
            InitializeComponent();

            LblNumeroErro.Text = LblNumeroErro.Text + NumeroErro;
            LblErro.Text = Erro;
            LblSolucao1.Text = Solucao1;
            LblSolucao2.Text = Solucao2;
            LblSolucao3.Text = Solucao3;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
