using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.Controler;

namespace Loja.View.Caixa
{
    public partial class Retirada : Form
    {
        public Retirada()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            CaixaController caixa = new CaixaController();
            caixa.Retirada(TxtValor.Text);
            this.Hide();
        }
    }
}
