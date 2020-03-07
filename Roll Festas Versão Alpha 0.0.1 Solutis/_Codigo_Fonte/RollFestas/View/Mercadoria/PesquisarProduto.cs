using System;
using RollFestas.Controllers;
using System.Windows.Forms;
using RollFestas.Models;
using System.Collections.Generic;

namespace RollFestas.View.Mercadoria
{
    public partial class PesquisarProduto : Form
    {
        public PesquisarProduto()
        {
            InitializeComponent();

            //CARREGAR LISTA
            ListViewProduto.Items.Clear();

            var produtoC = new ProdutoController();
            List<ProdutoModel> ListaProduto = produtoC.ListarTodosOsProdutos();


            if (ListaProduto.Count > 0)
            {
                foreach (var produto in ListaProduto)
                {

                    ListViewItem Lista = new ListViewItem(Convert.ToString(produto.Id));
                    Lista.SubItems.Add(produto.Nome);
                    Lista.SubItems.Add(produto.Preco);
                    Lista.SubItems.Add(produto.Tema);
                    Lista.SubItems.Add(produto.Fornecedor);
                    Lista.SubItems.Add(produto.Data);
                    Lista.SubItems.Add(produto.QuantidadeEstoque);
                    Lista.SubItems.Add(produto.Descricao);

                    ListViewProduto.Items.Add(Lista);

                }
            }
            
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            var Tela = new Home();
            Tela.Show();
            this.Close();
        }

        private void BtnPesquisarCod_Click(object sender, EventArgs e)
        {

            ListViewProduto.Items.Clear();

            var produtoC = new ProdutoController();
            ProdutoModel produtoM = produtoC.ExibirProduto(txtPesquisaCodigo.Text);


            if (produtoM.Id != 0)
            {


                ListViewItem Lista = new ListViewItem(Convert.ToString(produtoM.Id));
                Lista.SubItems.Add(produtoM.Nome);
                Lista.SubItems.Add(produtoM.Preco);
                Lista.SubItems.Add(produtoM.Tema);
                Lista.SubItems.Add(produtoM.Fornecedor);
                Lista.SubItems.Add(produtoM.Data);
                Lista.SubItems.Add(produtoM.QuantidadeEstoque);
                Lista.SubItems.Add(produtoM.Descricao);

                ListViewProduto.Items.Add(Lista);
            }
                       

        }

        private void BtnPesquisarNome_Click(object sender, EventArgs e)
        {

            ListViewProduto.Items.Clear();

            var produtoC = new ProdutoController();
            List<ProdutoModel> ListaProduto = produtoC.ExibirProdutoPorNome(TxtPesquisaNome.Text);

            if (ListaProduto.Count > 0)
            {
                foreach (var produto in ListaProduto)
                {

                    ListViewItem Lista = new ListViewItem(Convert.ToString(produto.Id));
                    Lista.SubItems.Add(produto.Nome);
                    Lista.SubItems.Add(produto.Preco);
                    Lista.SubItems.Add(produto.Tema);
                    Lista.SubItems.Add(produto.Fornecedor);
                    Lista.SubItems.Add(produto.Data);
                    Lista.SubItems.Add(produto.QuantidadeEstoque);
                    Lista.SubItems.Add(produto.Descricao);

                    ListViewProduto.Items.Add(Lista);

                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewProduto.Items.Clear();

            var produtoC = new ProdutoController();
            List<ProdutoModel> ListaProduto = produtoC.ExibirProdutoPorTema(TxtPesquisaTema.Text);

            if (ListaProduto.Count > 0)
            {
                foreach (var produto in ListaProduto)
                {

                    ListViewItem Lista = new ListViewItem(Convert.ToString(produto.Id));
                    Lista.SubItems.Add(produto.Nome);
                    Lista.SubItems.Add(produto.Tema);
                    Lista.SubItems.Add(produto.Fornecedor);
                    Lista.SubItems.Add(produto.Data);
                    Lista.SubItems.Add(produto.QuantidadeEstoque);
                    Lista.SubItems.Add(produto.Descricao);

                    ListViewProduto.Items.Add(Lista);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Tela = new Home();
            Tela.Show();
            this.Close();
        }
    }
}
