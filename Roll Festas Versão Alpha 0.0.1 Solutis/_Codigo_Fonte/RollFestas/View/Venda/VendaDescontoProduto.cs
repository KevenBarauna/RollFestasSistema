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

namespace RollFestas.View.Venda
{
    public partial class VendaDescontoProduto : Form
    {
        List<ProdutoModel> ListaProdutos;

        public VendaDescontoProduto(string Usuario, string Data, string ValorTotal, string TipoPagamento)
        {
            InitializeComponent();

            LblUsuario.Text = Usuario;
            LblData.Text = Data;
            LblTipoDePagamento.Text = TipoPagamento;
            LblValorTotalCheio.Text = ValorTotal;

            ListaProdutos = Program._Produtos;

            decimal ValorTotalProdutos = 0;

            //CARREGAR LISTA
            foreach (var item in ListaProdutos)
            {
                ListViewItem list = new ListViewItem(item.Nome);
                list.SubItems.Add(item.QuantidadeVenda);
                list.SubItems.Add(item.Preco);
                list.SubItems.Add(Convert.ToString(item.Id));
                ListItens.Items.Add(list);

                //ADICIONAR VALOR TOTAL
                decimal ValorProduto = Convert.ToDecimal(item.Preco) * Convert.ToDecimal(item.QuantidadeVenda);
                ValorTotalProdutos = ValorTotalProdutos + ValorProduto;
            }

            LblValorTotalCheio.Text = ValorTotalProdutos.ToString();
            LblValorTotalNovo.Text = ValorTotalProdutos.ToString();

            TxtId.Focus();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            var produtoM = new ProdutoModel();
            var produtoC = new ProdutoController();
            var vendaC = new VendaController();

            produtoM = produtoC.ExibirProduto(TxtId.Text);

            if (produtoM.Id != 0)
            {
                //VEFICA SE ESSE PRODUTO FOI ESCOLHIDO NA COMPRA
                bool ProdutoExiste = false;

                foreach (var item in ListaProdutos)
                {
                    if (item.Id == produtoM.Id)
                    {
                        ProdutoExiste = true;
                    }
                }
                if (ProdutoExiste == false)
                {
                    var Tela = new MensagemAlerta("O produto " + produtoM.Nome + " não está na lista de compras. Nada foi alterado.");
                    Tela.Show();
                }
                else
                {

                    //ADICIONAR NA LISTA 1
                    ListViewItem list = new ListViewItem(produtoM.Nome);
                    list.SubItems.Add(TxtNovoValor.Text.ToString());
                    ListaViewDesconto.Items.Add(list);

                    decimal ValorTotalNovo = 0;

                    //ALTERAR VALOR PRODUTO
                    foreach (var item in ListaProdutos)
                    {
                        if (item.Id == Convert.ToInt32(TxtId.Text))
                        {
                            item.Preco = TxtNovoValor.Text;

                        }

                        decimal ValorProduto = Convert.ToDecimal(item.Preco);
                        ValorProduto = ValorProduto * Convert.ToInt32(item.QuantidadeVenda);


                        ValorTotalNovo = ValorTotalNovo + ValorProduto;

                        LblValorTotalNovo.Text = ValorTotalNovo.ToString();

                    }


                    TxtId.Focus();

                }

                //LIMPANDO DADOS
                TxtNovoValor.Text = "";
                TxtId.Text = "";


            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            var Tela = new Home(false);
            Tela.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vendaC = new VendaController();
            TxtTroco.Text = CalculoValores.CalcularTroco(TxtValorRecebido.Text, TxtValorRecebido.Text);
        }
    }
}
