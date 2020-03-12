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
        string ValorTipoPagamento;
        public VendaDescontoProduto(string Usuario, string Data, string ValorTotal, string TipoPagamento, string ParteCartao)
        {
            InitializeComponent();

            LblUsuario.Text = Usuario;
            LblData.Text = Data;
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

            if (TipoPagamento == "Dinheiro")
            {
                RBDinheiro.Checked = true;
                ValorTipoPagamento = "Dinheiro";
            }
            if (TipoPagamento == "Cartão")
            {
                RBCartao.Checked = true;
                ValorTipoPagamento = "Cartão";
            }
            if (TipoPagamento == "Outros")
            {
                RBOutros.Checked = true;
                ValorTipoPagamento = "Outros";
            }
            if (TipoPagamento == "Dinheiro e Cartão")
            {
                RbDinCart.Checked = true;
                ValorTipoPagamento = "Dinheiro e Cartão";
                TxtDinCart.Visible = true;
                TxtDinCart.Text = ParteCartao;
            }

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

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Program._CaminhoArquivoDuvida + @"\Duvida_Venda.pdf");
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

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            var vendaC = new VendaController();
            bool Sucesso = vendaC.FinalizarVenda(LblData.Text, LblUsuario.Text, LblValorTotalNovo.Text, TxtValorRecebido.Text, ValorTipoPagamento, "", 1, "", "", Program._Produtos, false);

            if (Sucesso == true)
            {
                Program._Produtos = null;
                var Tela = new Home(false);
                Tela.Show();
            }
        }
    }
}
