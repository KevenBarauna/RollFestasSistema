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

namespace RollFestas.View.Mercadoria
{
    public partial class ApagarProduto : Form
    {
        public ApagarProduto()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            var produtoC = new ProdutoController();
            var produtoM = new ProdutoModel();
            produtoM = produtoC.ExibirProduto(txtPesquisaCodigo.Text);

            TxtCodigo.Text = produtoM.Id.ToString();
            TxtNome.Text = produtoM.Nome;
            txtDescricao.Text = produtoM.Descricao;

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            var Tela = new Home();
            Tela.Show();
            this.Close();
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            var produtoC = new ProdutoController();
            bool Sucesso = produtoC.ApagarProduto(TxtCodigo.Text);

            if (Sucesso == true)
            {
                txtPesquisaCodigo.Text = "";
                TxtCodigo.Text = "";
                txtDescricao.Text = "";
                TxtNome.Text = "";
            }
        }
    }
}
