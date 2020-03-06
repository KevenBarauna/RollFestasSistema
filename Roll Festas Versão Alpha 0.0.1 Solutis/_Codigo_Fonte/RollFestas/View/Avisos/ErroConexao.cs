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
    public partial class ErroConexao : Form
    {
        public ErroConexao(string NumeroErro, string DescricaoErro)
        {
            InitializeComponent();

            LblNumeroErro.Text = LblNumeroErro.Text + NumeroErro;
            LblErro.Text = DescricaoErro;

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
