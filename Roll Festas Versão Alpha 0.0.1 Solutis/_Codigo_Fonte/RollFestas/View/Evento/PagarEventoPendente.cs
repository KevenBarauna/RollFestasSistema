using System;
using System.Windows.Forms;
using RollFestas.Controllers;

namespace RollFestas.View.Evento
{
    public partial class PagarEventoPendente : Form
    {
        string ValorTipoPagamento;
        string ValorCep;
        string ValorLocal;
        string ValorTel1;
        string ValorTel2;
        string ValorEmail;
        string ValorTipoEvento;
        string ValorData;
        string ValorHora;
        string ValorParteCartao;
        string ValorDescricao;
        public PagarEventoPendente(string TipoPagamento, string ValorPago, string ValorTotal, string NomeCliente, string Cep, string Local, string Tel1, string Tel2, string Email, string TipoEvento, string Data, string Hora, string ParteCartao, string Descricao)
        {
            InitializeComponent();
            ValorTipoPagamento = TipoPagamento;
            TxtValorTotal.Text = ValorTotal;
            TxtValorPago.Text = ValorPago;
            TxtNome.Text = NomeCliente;

            ValorTipoPagamento = TipoPagamento;
            ValorCep = Cep;
            ValorLocal = Local;
            ValorTel1 = Tel1;
            ValorTel2 = Tel2;
            ValorEmail = Email;
            ValorTipoEvento = TipoEvento;
            ValorData = Data;
            ValorHora = Hora;
            ValorParteCartao = ParteCartao;
            ValorDescricao = Descricao;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var Tela = new Home(false);
            Tela.Show();
            this.Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            TxtValorRestante.Text = (Convert.ToDecimal(TxtValorTotal.Text) - Convert.ToDecimal(TxtValorPago.Text)).ToString();
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            var eventoC = new EventoController();
            bool Sucesso = eventoC.NovoEvento(ValorCep, ValorLocal, ValorDescricao, TxtNome.Text, ValorTel1, ValorTel2, ValorEmail, ValorTipoEvento, ValorData, ValorHora, TxtValorTotal.Text, TxtValorPago.Text, 2, ValorTipoPagamento, ValorParteCartao, 1, "0");

            if (Sucesso == true)
            {
                var Tela = new Home(false);
                Tela.Show();
                Tela.Close();

            }
        }

        private void RBDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            RBDinheiro.Checked = true;
            ValorTipoPagamento = "Dinheiro";
            TxtDinCart.Visible = false;
        }

        private void RBCartao_CheckedChanged(object sender, EventArgs e)
        {
            RBCartao.Checked = true;
            ValorTipoPagamento = "Cartão";
            TxtDinCart.Visible = false;
        }

        private void RBOutros_CheckedChanged(object sender, EventArgs e)
        {
            RBOutros.Checked = true;
            ValorTipoPagamento = "Outros";
            TxtDinCart.Visible = false;
        }

        private void RbDinCart_CheckedChanged(object sender, EventArgs e)
        {
            RbDinCart.Checked = true;
            ValorTipoPagamento = "Dinheiro e Cartão";
            TxtDinCart.Visible = true;
        }
    }
}
