using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RollFestas.Controllers;
using RollFestas.Models;
using RollFestas.Utils;

namespace RollFestas.View.Caixa
{
    public partial class FechametoCaixa : Form
    {
        public FechametoCaixa()
        {
            InitializeComponent();

            lblData.Text = GetDate.PegarDiaMesAnoAtual();

            var caixaC = new CaixaController();

            CaixaModel caixaM = caixaC.TotalVendasNoDia(lblData.Text);

            LblTotal.Text = LblTotal.Text + caixaM.ValorTotal;
            LblDinheiro.Text = LblDinheiro.Text + caixaM.Dinheiro;
            LblCartao.Text = LblCartao.Text + caixaM.Cartao;
            LblOutros.Text = LblOutros.Text + caixaM.Outros;
            LblRetirada.Text = LblRetirada.Text + caixaM.Retirada;
            LblDeposito.Text = LblDeposito.Text + caixaM.Deposito;


        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var Tela = new Home();
            Tela.Show();
            this.Hide();
        }
    }
}
