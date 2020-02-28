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

namespace Loja.View.Venda
{
    public partial class DescontoCompra : Form
    {
        List<ProdutoModel> _ListaProdutos;
        public DescontoCompra(string usuario, string Valor, string Tipopagamento, List<ProdutoModel> ListaProdutos)
        {
            InitializeComponent();

            LblData.Text = Data.PegarDiaMesAnoAtual();
            LblValorTotalCheio.Text = Valor;
            LblUsuario.Text = usuario;
            LblTipoDePagamento.Text = Tipopagamento;
            _ListaProdutos = ListaProdutos;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int Porcentagem = Convert.ToInt32(TxtPorcentagem.Text);
                double ValorTotal = Convert.ToDouble(LblValorTotalCheio.Text);
                double valorFinal;

                valorFinal = (Porcentagem * ValorTotal) / 100;
                valorFinal = ValorTotal - valorFinal;
                LblValorTotalNovo.Text = valorFinal.ToString();
            }
            catch (Exception)
            {
                Erro TelaDeErro = new Erro("CV", "Erro ao converter valor", "Verifique se os valores digitados em telas estão corretos.", "", "", "", "");
                TelaDeErro.Show();
            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            NovaVenda tela = new NovaVenda();
            tela.Show();
            this.Hide();
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {

            //INFO => 1 = PAGO | 2 = PAGAR DEPOIS

            String data = Data.PegarDiaMesAnoAtual();


                //SALVAR VENDA
                var vendaController = new VendaController();
                vendaController.FinalizarVenda(data, LblUsuario.Text, LblValorTotalNovo.Text, TxtValorRecebido.Text, TxtTroco.Text, LblTipoDePagamento.Text, 1, "", "");

                //DECREMENTAR PRODUTOS
                var produtoDAO = new DAOProduto();
                foreach (var produto in _ListaProdutos)
                {
                    produtoDAO.DecrementaQuantidade(produto.Nome, produto.Quantidade);
                }

                //SALVAR NO CAIXA
                CaixaController caixaController = new CaixaController();
                caixaController.SalvarNoCaixa(data, LblValorTotalNovo.Text, LblTipoDePagamento.Text, "");


                //GERAR RECIBO
                var vendaModel = new VendaModel();
                var reciboController = new ReciboController();
                var SaveData = Data.DataPararCriarPasta();

                vendaModel = vendaController.PegarIdDaUltimaVenda();

                var local = Caminhos.CaminhoComprovante();


                var NomeArquivo = $@"{local}\Recibo_{SaveData}_{vendaModel.Id}.pdf";
                reciboController.GerarReciboDeVendaPeloId(Convert.ToString(vendaModel.Id), NomeArquivo);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtValorRecebido.Text.Contains("."))
            {
                MessageBox.Show("Para calcular substitua o ponto po virgula");
            }
            else
            {
                try
                {
                    Decimal total = Convert.ToDecimal(LblValorTotalNovo.Text);
                    Decimal pagamento = Convert.ToDecimal(TxtValorRecebido.Text);
                    Decimal troco = total - pagamento;
                    TxtTroco.Text = Convert.ToString(troco * -1);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao calcular, digite os valores corretos");
                }

                if (TxtTroco.Text.Contains("-"))
                {
                    TxtTroco.Text = TxtTroco.Text;
                    MessageBox.Show(" O Valor é Negativo");
                }
            }
        }
    }
}
