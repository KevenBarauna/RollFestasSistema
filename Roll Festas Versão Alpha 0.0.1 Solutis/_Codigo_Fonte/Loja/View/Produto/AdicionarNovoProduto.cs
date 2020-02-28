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
using Loja.Controler.Utils;
using Loja.View.Duvida;

namespace Loja.View.Produto
{
    public partial class AdicionarNovoProduto : Form
    {
        public AdicionarNovoProduto()
        {
            InitializeComponent();
            TxtData.Text = Data.PegarDiaMesAnoAtual();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            bool TudoCerto = false;
            bool ProdutoExiste = false;

            ProdutoController produto = new ProdutoController();

            ProdutoExiste = produto.VerificaSeNoveJaExiste(TxtNome.Text);

            if (ProdutoExiste == true)
            {
                MessageBox.Show("Já existe um produto cadastrado com esse nome");
            }
            else
            {
            TudoCerto = produto.Cadastrar(TxtNome.Text, TxtTema.Text ,Txtpreco.Text, TxtQuantidade.Text, TxtFornecedor.Text, TxtData.Text, txtDescricao.Text);

            if (TudoCerto == true)
            {
                TxtNome.Text = "";
                txtDescricao.Text = "";
                TxtFornecedor.Text = "";
                TxtQuantidade.Text = "0";
                Txtpreco.Text = "";
                TxtTema.Text = "";

                Controller tempo = new Controller();
                TxtData.Text = Data.PegarDiaMesAnoAtual();
            }

            }

        }

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            Duvida_NovoProduto tela = new Duvida_NovoProduto();
            tela.Show();
        }
    }
}
