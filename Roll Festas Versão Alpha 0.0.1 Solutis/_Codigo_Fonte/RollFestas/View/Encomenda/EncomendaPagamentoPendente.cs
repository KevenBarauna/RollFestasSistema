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

namespace RollFestas.View.Encomenda
{
    public partial class EncomendaPagamentoPendente : Form
    {
        EncomendaModel Encomenda;
        public EncomendaPagamentoPendente(string ValorTotal, string ValorPago, string TipoPagamento, string Troco, string NomeCliente)
        {
            InitializeComponent();

            //CARREGAR USUÁRIO
            LblUsuario.Text = Program._Usuario.Nome;

            //CARREGAR DATA
            LblData.Text = GetDate.PegarDiaMesAnoAtual();

            //CARREGAR LISTA DE PRODUTOS
            Encomenda = Program._Encomenda;

            TxtNome.Text = NomeCliente;
            LblValorTotal.Text = ValorTotal;
            LblValorPago.Text = ValorPago;
            LblTipoDePagamento.Text = TipoPagamento;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            decimal ValorTotal;
            decimal ValorPago;
            try
            {
                ValorTotal = Convert.ToDecimal(LblValorTotal.Text);
                ValorPago = Convert.ToDecimal(LblValorPago.Text);
            }
            catch (Exception)
            {
                var TelaErro = new Erro("Valores incorretos 'Valor recebido' altere esse valor e tente novamente");
                TelaErro.Show();
                ValorTotal = Convert.ToDecimal(LblValorTotal.Text);
                ValorPago = 0;
            }

            TxtValorRestante.Text = (ValorTotal - ValorPago).ToString();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var Tela = new Home();
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
                vendaC.FinalizarVenda(LblData.Text, LblUsuario.Text, LblValorTotal.Text, LblValorPago.Text, "0", LblTipoDePagamento.Text, "", 2, TxtValorRestante.Text, TxtNome.Text, null, true);
 
            }

        }
    }
}
