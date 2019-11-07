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
using Loja.Model;

namespace Loja.View.Produto
{
    public partial class EditarProduto : Form
    {
        public EditarProduto()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

            ProdutoController produto = new ProdutoController();
            ProdutoModel produtoeditavel = new ProdutoModel();

            produtoeditavel = produto.ExibirProduto(txtPesquisaCodigo.Text);

            TxtCodigo.Text = Convert.ToString(produtoeditavel.Id);
            TxtNome.Text = produtoeditavel.Nome;
            TxtTema.Text = produtoeditavel.Tema;
            TxtData.Text = produtoeditavel.Data;
            txtDescricao.Text = produtoeditavel.Descricao;
            TxtFornecedor.Text = produtoeditavel.Fornecedor;
            TxtPreco.Text = produtoeditavel.Preco;
            TxtQuantidade.Text = produtoeditavel.Quantidade;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            bool sucesso = false;
            ProdutoController produto = new ProdutoController();
            sucesso = produto.EditarProduto(TxtNome.Text, TxtTema.Text ,TxtPreco.Text, TxtQuantidade.Text, TxtFornecedor.Text, TxtData.Text, txtDescricao.Text, Convert.ToInt32(TxtCodigo.Text));

            if (sucesso == true)
            {
                txtPesquisaCodigo.Text = "";
                TxtCodigo.Text = "";
                TxtNome.Text = "";
                TxtTema.Text = "";
                TxtData.Text = "";
                txtDescricao.Text = "";
                TxtFornecedor.Text = "";
                TxtPreco.Text = "";
                TxtQuantidade.Text = "";

                txtPesquisaCodigo.Focus();
            }


        }
    }
}
