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
using RollFestas.View.MensagemErro;

namespace RollFestas.View.Venda
{
    public partial class VendaSemPagamento : Form
    {

        List<ProdutoModel> _ListaProdutos;
        string TipoPagamento;
        public VendaSemPagamento(string ValorTotal, string ValorPago, string TipoPagamento, string ParteCartao)
        {
            InitializeComponent();

            //CARREGAR USUÁRIO
            LblUsuario.Text = Program._Usuario.Nome;

            //CARREGAR DATA
            LblData.Text = GetDate.PegarDiaMesAnoAtual();

            //CARREGAR LISTA DE PRODUTOS
            _ListaProdutos = Program._Produtos;

            TxtValorTotal.Text = ValorTotal;
            TxtValorPago.Text = ValorPago;

            if (TipoPagamento == "Dinheiro")
            {
                RBDinheiro.Checked = true;
                TipoPagamento = "Dinheiro";
            }
            if (TipoPagamento == "Cartão")
            {
                RBCartao.Checked = true;
                TipoPagamento = "Cartão";
            }
            if (TipoPagamento == "Outros")
            {
                RBOutros.Checked = true;
                TipoPagamento = "Outros";
            }
            if (TipoPagamento == "Dinheiro e Cartão")
            {
                RbDinCart.Checked = true;
                TipoPagamento = "Dinheiro e Cartão";
                TxtDinCart.Visible = true;
                TxtDinCart.Text = ParteCartao;
            }

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            decimal ValorTotal;
            decimal ValorPago;
            try
            {
                ValorTotal = Convert.ToDecimal(TxtValorTotal.Text);
                ValorPago = Convert.ToDecimal(TxtValorPago.Text);
            }
            catch (Exception)
            {
                var TelaErro = new Erro("Valores incorretos 'Valor recebido' altere esse valor e tente novamente");
                TelaErro.Show();
                ValorTotal = Convert.ToDecimal(TxtValorTotal.Text);
                ValorPago = 0;
            }

            TxtValorRestante.Text = (ValorTotal - ValorPago).ToString();

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var Tela = new Home(false);
            Tela.Show();
            this.Close();
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            var vendaC = new VendaController();
            bool SucessoVenda = vendaC.FinalizarVenda(LblData.Text, LblUsuario.Text, TxtValorTotal.Text, TxtValorPago.Text, TipoPagamento, "", 2, TxtValorRestante.Text, TxtNome.Text, _ListaProdutos,false);

            if (SucessoVenda == true)
            {
                var Tela = new Home(false);
                Tela.Show();
                this.Close();
            }
        }

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Program._CaminhoArquivoDuvida + @"\Duvida_Venda.pdf");
        }

        private void RBDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            RBDinheiro.Checked = true;
            TipoPagamento = "Dinheiro";
            TxtDinCart.Visible = false;
        }

        private void RBCartao_CheckedChanged(object sender, EventArgs e)
        {
            RBCartao.Checked = true;
            TipoPagamento = "Cartão";
            TxtDinCart.Visible = false;
        }

        private void RBOutros_CheckedChanged(object sender, EventArgs e)
        {

            RBOutros.Checked = true;
            TipoPagamento = "Outros";
            TxtDinCart.Visible = false;
        }

        private void RbDinCart_CheckedChanged(object sender, EventArgs e)
        {
            RbDinCart.Checked = true;
            TipoPagamento = "Dinheiro e Cartão";
            TxtDinCart.Visible = true;
        }
    }
}
