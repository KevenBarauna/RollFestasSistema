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

namespace RollFestas.View.Venda
{
    public partial class Troca : Form
    {
        decimal _ValorTotalDevolvido = 0;
        decimal _ValorTotalNovos = 0;
        List<ProdutoModel> _ListaProdutosDevolvio = new List<ProdutoModel>();
        List<ProdutoModel> _ListaProdutosNovos = new List<ProdutoModel>();
        public Troca(string Usuario)
        {
            InitializeComponent();

            LblUsuario.Text = Usuario;
            LblData.Text = GetDate.PegarDiaMesAnoAtual();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            LVPesquisa.Items.Clear();
            var ListaProduto = new List<ProdutoModel>();
            var produtoC = new ProdutoController();

            ListaProduto = produtoC.ExibirProdutoPorNome(TxtPesquisa.Text);

            foreach (var produto in ListaProduto)
            {
                ListViewItem list = new ListViewItem(Convert.ToString(produto.Id));
                list.SubItems.Add(produto.Nome);
                LVPesquisa.Items.Add(list);
            }
        }

        private void BtnAdicionarDevolvido_Click(object sender, EventArgs e)
        {
            var produtoM = new ProdutoModel();
            var produtoC = new ProdutoController();
            var vendaC = new VendaController();

            produtoM = produtoC.ExibirProduto(TxtIdDevolvido.Text);

            if (produtoM.Id != 0)
            {
                //ADICIONAR NA LISTA 1
                ListViewItem list = new ListViewItem(produtoM.Nome);
                list.SubItems.Add(TxtNumQuantDevolvido.Value.ToString());
                ListItensAntigos.Items.Add(list);

                //VALOR TOTAL
                decimal ValorProduto = Convert.ToDecimal(produtoM.Preco);
                ValorProduto = ValorProduto * TxtNumQuantDevolvido.Value;
                _ValorTotalDevolvido += ValorProduto;
                TxtValorDevolvidos.Text = _ValorTotalDevolvido.ToString();

                //SALVA => QUANTIDADE - VALOR
                produtoM.QuantidadeVenda = TxtNumQuantDevolvido.Value.ToString();
                _ListaProdutosDevolvio.Add(produtoM);

                //CALCLULAR DIFERENÇA
                if (TxtValorDevolvidos.Text != "" && TxtValorNovos.Text != "")
                {
                    TxtCredito.Text = Convert.ToString(_ValorTotalDevolvido - _ValorTotalNovos);
                }

                //LIMPANDO DADOS
                TxtNumQuantDevolvido.Value = 1;
                TxtIdDevolvido.Text = "";
                TxtIdDevolvido.Focus();


            }
        }

        private void BtnAdicionarNovo_Click(object sender, EventArgs e)
        {
            var produtoM = new ProdutoModel();
            var produtoC = new ProdutoController();
            var vendaC = new VendaController();

            produtoM = produtoC.ExibirProduto(TxtIdnovo.Text);

            if (produtoM.Id != 0)
            {
                //ADICIONAR NA LISTA 1
                ListViewItem list = new ListViewItem(produtoM.Nome);
                list.SubItems.Add(TxtNumQuantNovo.Value.ToString());
                ListItensNovos.Items.Add(list);

                //VALOR TOTAL
                decimal ValorProduto = Convert.ToDecimal(produtoM.Preco);
                ValorProduto = ValorProduto * TxtNumQuantNovo.Value;
                _ValorTotalNovos += ValorProduto;
                TxtValorNovos.Text = _ValorTotalNovos.ToString();

                //SALVA => QUANTIDADE - VALOR
                produtoM.QuantidadeVenda = TxtNumQuantNovo.Value.ToString();
                _ListaProdutosNovos.Add(produtoM);

                //LIMPANDO DADOS
                TxtNumQuantNovo.Value = 1;
                TxtIdnovo.Text = "";
                TxtIdnovo.Focus();

                //CALCLULAR DIFERENÇA
                if (TxtValorDevolvidos.Text != "" && TxtValorNovos.Text != "")
                {
                    TxtCredito.Text = Convert.ToString(_ValorTotalDevolvido - _ValorTotalNovos);
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Tela = new Home();
            Tela.Show();
            this.Hide();
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            decimal credito = Convert.ToDecimal(TxtCredito.Text);
            bool Sucesso = false;

            if (TxtCredito.Text.Contains("-"))
            {
                if (MessageBox.Show("Existe uma diferença de valor que o cliente deve pagar. Caso o cliente pague aperte 'SIM', caso o cliente não pague, aperte 'NÃO'. ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    TxtCredito.Text = TxtCredito.Text.Replace("-", "");
                    //RECEBER DINHEIRO
                    var caixaC = new CaixaController();
                    bool SucessoCaixa = caixaC.SalvarValor(LblData.Text, TxtCredito.Text, "Dinheiro", "");
                }
            }

            if (credito > 0)
            {
                if (MessageBox.Show("Ainda existe um valor de crédito do cliente. Caso o valor de diferença seja devolvido para o cliene aperte 'SIM', caso o valor de diferença fique no caixa aperte 'NÃO'. ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //DEVOLVER DINHEIRO
                    var caixaC = new CaixaController();
                    bool SucessoCaixa = caixaC.SalvarValor(LblData.Text, TxtCredito.Text, "Troca", "");
                }


            }

            //ESTOQUE DOS PRODUTOS
            var produtoC = new ProdutoController();

            foreach (var item in _ListaProdutosDevolvio)
            {
                decimal Quantidade = Convert.ToDecimal(item.QuantidadeVenda) + Convert.ToDecimal(item.QuantidadeEstoque);
                item.QuantidadeEstoque = Quantidade.ToString();

                produtoC.DecrementarProdutos(_ListaProdutosDevolvio);
            }
            foreach (var item in _ListaProdutosNovos)
            {
                decimal Quantidade = Convert.ToDecimal(item.QuantidadeVenda) - Convert.ToDecimal(item.QuantidadeEstoque);
                item.QuantidadeEstoque = Quantidade.ToString();
                Sucesso = produtoC.DecrementarProdutos(_ListaProdutosNovos);
            }

            if (Sucesso == true)
            {
                ListItensNovos.Items.Clear();
                ListItensAntigos.Items.Clear();

                TxtNumQuantNovo.Value = 1;
                TxtNumQuantDevolvido.Value = 1;

                TxtIdnovo.Text = "";
                TxtIdDevolvido.Text = "";

                TxtCredito.Text = "";
                TxtValorDevolvidos.Text = "";
                TxtValorNovos.Text = "";

                _ValorTotalDevolvido = 0;
                _ValorTotalNovos = 0;

            }

        }

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\keven.barauna\Desktop\Duvida_Troca.pdf");
        }
    }
}
