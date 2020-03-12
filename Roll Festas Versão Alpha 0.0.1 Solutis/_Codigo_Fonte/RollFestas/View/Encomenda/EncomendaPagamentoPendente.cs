using System;
using System.Windows.Forms;
using RollFestas.Controllers;
using RollFestas.Models;
using RollFestas.Utils;
using RollFestas.View.MensagemErro;

namespace RollFestas.View.Encomenda
{
    public partial class EncomendaPagamentoPendente : Form
    {
        EncomendaModel Encomenda;
        string TipoPagamento;
        public EncomendaPagamentoPendente(string ValorTotal, string ValorPago, string TipoPagamento, string NomeCliente, string ParteCartao)
        {
            InitializeComponent();

            //CARREGAR USUÁRIO
            LblUsuario.Text = Program._Usuario.Nome;

            //CARREGAR DATA
            LblData.Text = GetDate.PegarDiaMesAnoAtual();

            //CARREGAR LISTA DE PRODUTOS
            Encomenda = Program._Encomenda;

            TxtNome.Text = NomeCliente;
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

            var encomendaC = new EncomendaController();
            bool Sucesso = encomendaC.NovaEncomenda(Encomenda.TipoServico, Encomenda.DataEntrada, Encomenda.DataEntrega, Encomenda.Tema, Encomenda.Entregue, Encomenda.Quantidade, Encomenda.Valor, Encomenda.Descricao, Encomenda.NomeCliente);

            if (Sucesso == true)
            {
                var vendaC = new VendaController();
                vendaC.FinalizarVenda(LblData.Text, LblUsuario.Text, TxtValorTotal.Text, TxtValorPago.Text, TipoPagamento, "", 2, TxtValorRestante.Text, TxtNome.Text, null, true);

            }

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
