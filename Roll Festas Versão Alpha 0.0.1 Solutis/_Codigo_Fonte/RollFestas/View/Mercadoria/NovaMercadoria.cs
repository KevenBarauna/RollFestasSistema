using System;
using System.Windows.Forms;
using RollFestas.Controllers;
using RollFestas.View.Avisos;
using RollFestas.View.MensagemErro;

namespace RollFestas.View.Mercadoria
{
    public partial class NovaMercadoria : Form
    {

        int SalvarQuantidade; //1 CASO QUEIRA SALVAR || 2 PARA NÃO SALVAR
        public NovaMercadoria()
        {
            InitializeComponent();
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
            bool SucessoCadastro = produtoC.Cadastrar(TxtNome.Text , TxtTema.Text , Txtpreco.Text , TxtQuantidade.Value.ToString(), SalvarQuantidade, TxtFornecedor.Text , TxtData.Text , txtDescricao.Text);

            if (SucessoCadastro == true)
            {
                TxtNome.Text = ""; 
                TxtTema.Text = "";
                Txtpreco.Text = "";
                TxtQuantidade.Value = 0;
                TxtFornecedor.Text = "";
                TxtData.Text = "";
                txtDescricao.Text = "";

            }
        }

        private void CbQuant_CheckedChanged(object sender, EventArgs e)
        {
            var Tela = new MensagemAlerta("Caso você marque essa caixa não será salvo a quantidade no banco de dados.");
            Tela.Show();
            if (CbQuant.Checked)
            {
                TxtQuantidade.Value = 0;
                TxtQuantidade.ReadOnly = true;
                SalvarQuantidade = 2;
            }
            else
            {
                TxtQuantidade.ReadOnly = false;
                SalvarQuantidade = 1;
            }

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var Tela = new Home(false);
            Tela.Show();
            this.Close();
        }
    }
}
