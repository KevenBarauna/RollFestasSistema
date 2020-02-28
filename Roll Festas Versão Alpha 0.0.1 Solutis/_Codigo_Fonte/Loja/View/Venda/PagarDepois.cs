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
using Loja.Controler.Utils;
using Loja.Model;
using Loja.Model.DAO;

namespace Loja.View.Venda
{
    public partial class PagarDepois : Form
    {
        List<ProdutoModel> _ListaProdutos;
        public PagarDepois(String usuario, String valortotal, String valorpago, String TipoPagamento, String troco, List<ProdutoModel> ListaProdutos)
        {
            InitializeComponent();

            String data = Data.PegarDiaMesAnoAtual();

            LblUsuario.Text =  usuario;
            LblData.Text = data;

            LblValorTotal.Text =  valortotal;
            LblValorPago.Text =  valorpago;
            LblTipoDePagamento.Text = TipoPagamento;

            TxtValorRestante.Text = troco;


            if (String.IsNullOrEmpty(valorpago))
            {
                LblValorPago.Text = "0";
            }
            if (String.IsNullOrEmpty(valortotal))
            {
                LblValorTotal.Text = "0";
            }
            if (String.IsNullOrEmpty(valortotal) || troco.Contains("-"))
            {
                TxtValorRestante.Text = "0";
            }

            _ListaProdutos = ListaProdutos;

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal ValorTotal = Convert.ToDecimal(LblValorTotal.Text);
                Decimal ValorPago = Convert.ToDecimal(LblValorPago.Text);
                Decimal ValorRestante = ValorTotal - ValorPago;
                TxtValorRestante.Text = Convert.ToString(ValorRestante);
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao converter");
            }

        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            if (_ListaProdutos.Count == 0)
            {
                Erro tela = new Erro("NPL", "Nenhum produto adicionado na lista", "Adicione pelo menos um produto para realizar a venda", "", "", "", "");
                tela.Show();
                //throw new Exception("Nenhum produto adicionado na lista");
            }
            else
            {
                //INFO => 1 = PAGO | 2 = PAGAR DEPOIS

                string data = Data.PegarDiaMesAnoAtual();

                //FINALIZAR VENDA
                var vendaController = new VendaController();
                vendaController.FinalizarVenda(data, LblUsuario.Text, LblValorTotal.Text, LblValorPago.Text, "", LblTipoDePagamento.Text, 2, TxtValorRestante.Text, TxtNome.Text);

                //DECREMENTAR PRODUTOS
                var produtoDAO = new DAOProduto();
                foreach (var produto in _ListaProdutos)
                {
                    produtoDAO.DecrementaQuantidade(produto.Nome, produto.Quantidade);
                }

                //MANDAR VALOR PAGO PARA O CAIXA
                var caixaController = new CaixaController();
                caixaController.SalvarNoCaixa(data, LblValorPago.Text, LblTipoDePagamento.Text, "");


                //GERAR RECIBO
                var vendaModel = new VendaModel();
                var reciboController = new ReciboController();
                var SaveData = Data.DataPararCriarPasta();

                vendaModel = vendaController.PegarIdDaUltimaVenda();

                var local = Caminhos.CaminhoComprovante();


                var NomeArquivo = $@"{local}\Recibo_{SaveData}_{vendaModel.Id}.pdf";
                reciboController.GerarReciboDeVendaPeloId(Convert.ToString(vendaModel.Id), NomeArquivo);

                this.Hide();
            }
        }//FINALIZAR PAGAR DEPOIS
    }
}
