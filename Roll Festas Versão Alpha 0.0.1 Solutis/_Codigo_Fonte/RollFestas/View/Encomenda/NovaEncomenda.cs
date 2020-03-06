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
using RollFestas.View.Avisos;
using RollFestas.View.MensagemErro;
using RollFestas.View.Venda;

namespace RollFestas.View.Encomenda
{
    public partial class NovaEncomenda : Form
    {
        int LembrarEncomenda = 1;

        string TipoPagamento = "Dinheiro";
        public NovaEncomenda()
        {
            InitializeComponent();

            LblUsuario.Text = Program._Usuario.Nome;
            LblData.Text = GetDate.PegarDiaMesAnoAtual();


            TxtDataEntrega.Text = GetDate.PegarDiaMesAnoAtual();
            TxtDataPedido.Text = GetDate.PegarDiaMesAnoAtual();

            //PADÃO
            TxtTipo.Text = "A3";
            TxtQuantidade.Text = "1";
            TxtNomeCliente.Text = "Não informado";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var vendaC = new VendaController();
            string Troco = vendaC.CalcularTroco(TxtValor.Text, TxtValorRecebido.Text);

            if (Troco != "PENDENTE")
            {
                LblTroco.Text = Troco;
            }
            else
            {
                var Tela = new VendaSemPagamento(TxtValor.Text, TxtValorRecebido.Text, TipoPagamento, LblTroco.Text);
                Tela.Show();
                this.Hide();

            }
        }

        private void RBDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtDinCart.Text = "";
            this.TxtDinCart.ReadOnly = true;

            this.LblDinCart.Visible = false;
            this.ImgAtencao.Visible = false;
            this.TxtDinCart.Visible = false;

            TipoPagamento = "Dinheiro";
        }

        private void RBCartao_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtDinCart.Text = "";
            this.TxtDinCart.ReadOnly = true;

            this.LblDinCart.Visible = false;
            this.ImgAtencao.Visible = false;
            this.TxtDinCart.Visible = false;

            TipoPagamento = "Cartão";
        }

        private void RBOutros_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtDinCart.Text = "";
            this.TxtDinCart.ReadOnly = true;

            this.LblDinCart.Visible = false;
            this.ImgAtencao.Visible = false;
            this.TxtDinCart.Visible = false;

            TipoPagamento = "Outros";
        }

        private void RbDinCart_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDinCart.Checked)
            {
                this.TxtDinCart.ReadOnly = false;

                this.LblDinCart.Visible = true;
                this.ImgAtencao.Visible = true;
                this.TxtDinCart.Visible = true;

                TipoPagamento = "Dinheiro e Cartão";
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            var encomendaC = new EncomendaController();
            bool Sucesso = encomendaC.NovaEncomenda(TxtTipo.Text,TxtDataPedido.Text,TxtDataEntrega.Text,TxtTema.Text, LembrarEncomenda, TxtQuantidade.Text,TxtValor.Text,txtDescricao.Text,TxtNomeCliente.Text);

            if (Sucesso == true)
            {
                var vendaC = new VendaController();
                Sucesso = vendaC.FinalizarVenda(LblData.Text, LblUsuario.Text, TxtValor.Text, TxtValorRecebido.Text, LblTroco.Text, TipoPagamento, TxtDinCart.Text, 1, null, TxtNomeCliente.Text, null,true);

                if (Sucesso == true)
                {
                    TxtValor.Text = "";
                    TxtValorRecebido.Text = "";
                    LblTroco.Text = "";
                    TxtDinCart.Text = "";
                    TxtNomeCliente.Text = "";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Program._Encomenda = null;
               var encomendaM = new EncomendaModel();
                encomendaM.TipoServico = TxtTipo.Text;
                encomendaM.DataEntrada = TxtDataPedido.Text;
                encomendaM.DataEntrega = TxtDataEntrega.Text;
                encomendaM.Tema = TxtTema.Text;
                encomendaM.Quantidade = TxtQuantidade.Text;
                encomendaM.Valor = TxtValor.Text;
                encomendaM.Descricao = txtDescricao.Text;
                encomendaM.NomeCliente = TxtNomeCliente.Text;

                Program._Encomenda = encomendaM;
                var Tela = new VendaSemPagamento(TxtValor.Text, TxtValorRecebido.Text, TipoPagamento, LblTroco.Text);
                Tela.Show();
                this.Hide();

            }
            catch (Exception)
            {
                var TelaErro = new Erro("Algum campo digitado esta incorreto");
                TelaErro.Show();
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CbAviso.Checked)
            {
                LembrarEncomenda = 2;
                var Tela = new MensagemAlerta("Caso você marque essa caixa não vamos cadastrar essa encomenda como 'Encomenda pendente', você está assumindo que essa encomenda já foi entregue.");
                Tela.Show();
            }
            else
            {
                LembrarEncomenda = 1;
            }
            
        }
    }
}
