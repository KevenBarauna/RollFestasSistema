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
    public partial class ApagarProduto : Form
    {
        public ApagarProduto()
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
            txtDescricao.Text = produtoeditavel.Descricao;

        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            ProdutoController produto = new ProdutoController();
            produto.ApagarProduto(Convert.ToInt32( TxtCodigo.Text));

            TxtCodigo.Text = "";
            TxtNome.Text = "";
            txtDescricao.Text = "";
            txtPesquisaCodigo.Text = "";
            txtPesquisaCodigo.Focus();


        }
    }
}
