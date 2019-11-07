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
    public partial class DetalhesProduto : Form
    {
        public DetalhesProduto()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            ProdutoController produto = new ProdutoController();
            ProdutoModel produtoeditavel = new ProdutoModel();

            produtoeditavel = produto.ExibirProduto(txtPesquisaCodigo.Text);

            TxtCodigo.Text = Convert.ToString( produtoeditavel.Id );
            TxtNome.Text = produtoeditavel.Nome;
            TxtTema.Text = produtoeditavel.Tema;
            TxtData.Text = produtoeditavel.Data;
            txtDescricao.Text = produtoeditavel.Descricao;
            TxtFornecedor.Text = produtoeditavel.Fornecedor;
            TxtPreco.Text = produtoeditavel.Preco;
            TxtQuantidade.Text = produtoeditavel.Quantidade;
        }
    }
}
