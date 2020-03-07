using System;
using System.Windows.Forms;
using RollFestas.Controllers;
using RollFestas.Models;

namespace RollFestas.View.Mercadoria
{
    public partial class EditarMercadoria : Form
    {
        public EditarMercadoria()
        {
            InitializeComponent();

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            var produtoC = new ProdutoController();
            var produtoM = new ProdutoModel();

            produtoM = produtoC.ExibirProduto(txtPesquisaCodigo.Text);

            LblId.Text = produtoM.Id.ToString();
            TxtNome.Text = produtoM.Nome;
            Txtpreco.Text = produtoM.Preco;
            TxtTema.Text = produtoM.Tema;
            TxtFornecedor.Text = produtoM.Fornecedor;
            TxtData.Text = produtoM.Data;
            txtDescricao.Text = produtoM.Descricao;

            if (produtoM.QuantidadeEstoque == null || produtoM.QuantidadeEstoque == "" || produtoM.QuantidadeEstoque.Contains("-"))
            {
                TxtQuantidade.Value = 0;
            }
            else
            {
                TxtQuantidade.Value = Convert.ToDecimal(produtoM.QuantidadeEstoque);
            }
                
            
            
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            var Tela = new Home();
            Tela.Show();
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var produtoC = new ProdutoController();
            bool Sucesso = produtoC.EditarProduto(TxtNome.Text, TxtTema.Text, Txtpreco.Text, TxtQuantidade.Value.ToString(), TxtFornecedor.Text, TxtData.Text, txtDescricao.Text, LblId.Text);

            if (Sucesso ==  true)
            {
                txtPesquisaCodigo.Text = "";
                LblId.Text = "";
                TxtNome.Text = "";
                TxtQuantidade.Value = 0;
                Txtpreco.Text = "";
                TxtTema.Text = "";
                TxtFornecedor.Text = "";
                TxtData.Text = "";
                txtDescricao.Text = "";
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var Tela = new Home();
            Tela.Show();
            this.Close();
        }
    }
}
