using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.View
{
    public partial class Erro : Form
    {
        public Erro(String NumeroErro, String MensagemErro, String Solucao, String s2, String s3, String s4, String s5)
        {
            InitializeComponent();
            LblNumeroErro.Text = LblNumeroErro.Text + NumeroErro;
            TxtErro.Text = TxtErro.Text + MensagemErro;
            LblSolucao01.Text = LblSolucao01.Text + Solucao;

            LblSolucao02.Text = s2;
            LblSolucao03.Text = s3;
            LblSolucao04.Text = s4;
            LblSolucao05.Text = s5;

        }
    }
}
