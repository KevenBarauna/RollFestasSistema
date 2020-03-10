using System;
using System.Windows.Forms;
using RollFestas.Controllers;
using RollFestas.Models;

namespace RollFestas.View.Mercadoria
{
    public partial class EditarMercadoria : Form
    {
        int SalvarQuantidade;
        public EditarMercadoria()
        {
            InitializeComponent();

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            var produtoC = new ProdutoController();
            var produtoM = new ProdutoModel();

            produtoM = produtoC.ExibirProduto(txtPesquisaCodigo.Text);
            if (produtoM.Id != 0)
            {
                LblId.Text = produtoM.Id.ToString();
                TxtNome.Text = produtoM.Nome;
                Txtpreco.Text = produtoM.Preco;
                TxtTema.Text = produtoM.Tema;
                TxtFornecedor.Text = produtoM.Fornecedor;
                TxtData.Text = produtoM.Data;
                txtDescricao.Text = produtoM.Descricao;

                TxtNome.ReadOnly = false;
                Txtpreco.ReadOnly = false;
                TxtTema.ReadOnly = false;
                TxtFornecedor.ReadOnly = false;
                TxtData.ReadOnly = false;
                txtDescricao.ReadOnly = false;

                if (produtoM.InformarQuantidade == "1")
                {
                    SalvarQuantidade = 1;
                    if (produtoM.QuantidadeEstoque == null || produtoM.QuantidadeEstoque == "" || produtoM.QuantidadeEstoque.Contains("-"))
                    {
                        TxtQuantidade.Value = 0;
                    }
                    else
                    {
                        TxtQuantidade.Value = Convert.ToDecimal(produtoM.QuantidadeEstoque);
                    }
                }
                else
                {
                    SalvarQuantidade = 2;
                    CbQuant.Checked = true;
                    TxtQuantidade.ReadOnly = true;
                }
            }
            
            
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            var Tela = new Home(false);
            Tela.Show();
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var produtoC = new ProdutoController();
            bool Sucesso = produtoC.EditarProduto(TxtNome.Text, TxtTema.Text, Txtpreco.Text, TxtQuantidade.Value.ToString(), SalvarQuantidade, TxtFornecedor.Text, TxtData.Text, txtDescricao.Text, LblId.Text);

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
            var Tela = new Home(false);
            Tela.Show();
            this.Close();
        }

        private void CbQuant_CheckedChanged(object sender, EventArgs e)
        {
            if (CbQuant.Checked)
            {
                TxtQuantidade.ReadOnly = true;
                SalvarQuantidade = 2;
            }
            else
            {
                TxtQuantidade.ReadOnly = false;
                SalvarQuantidade = 1;
            }
        }
    }
}
