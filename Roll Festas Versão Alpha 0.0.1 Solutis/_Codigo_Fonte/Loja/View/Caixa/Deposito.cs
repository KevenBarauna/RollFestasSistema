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
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }

        private void Deposito_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Controller tempo = new Controller();
            String data = tempo.PegarDiaMesAnoAtual();

            CaixaController caixa = new CaixaController();
            caixa.Deposito(data, TxtValor.Text);

            this.Hide();
        }
    }
}
