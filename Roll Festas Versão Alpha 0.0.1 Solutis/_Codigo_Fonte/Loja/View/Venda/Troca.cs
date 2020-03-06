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
using Loja.Model;
using Loja.View.Duvida;

namespace Loja.View.Venda
{
    public partial class Troca : Form
    {
        Decimal VTAntigo = 0;
        Decimal VTNovo= 0;
        List<ProdutoModel> _ListaProdutos = new List<ProdutoModel>();//LISTA DE PRODUTOS
        public Troca()
        {
            InitializeComponent();
            // USUARIO
            DAOUsuario usuario = new DAOUsuario();
            UsuarioModel usuarioLogado = new UsuarioModel();

            usuarioLogado = usuario.PegarUsuarioLogado();
            LblUsuario.Text = usuarioLogado.Nome;

            //DATA
            LblData.Text = Date.PegarDiaMesAnoAtual();

            //INICAR TABELA CAIXA
            String data = Date.PegarDiaMesAnoAtual();

            DAOCaixa daocaixa = new DAOCaixa();
            daocaixa.IniciarCaixa(Convert.ToString(data));
        }

        private void BtnAdicionarDevolvido_Click(object sender, EventArgs e)//ANTIGO
        {
            var ProdutoModel = new ProdutoModel();
            var ProdutoController = new ProdutoController();

            ProdutoModel = ProdutoController.ExibirProduto(TxtIdDevolvido.Text);

            if (ProdutoModel.Id != 0)
            {
                //ADICIONAR NA LISTA
                ListViewItem list = new ListViewItem(ProdutoModel.Nome);
                list.SubItems.Add(TxtNumQuantDevolvido.Value.ToString());
                ListItensAntigos.Items.Add(list);

                //CALCUAR POR QUANTIDADE
                VendaController VendaController = new VendaController();
                VTAntigo += VendaController.CalcularPorQuantidade(ProdutoModel.Nome, TxtNumQuantDevolvido.Value);
                TxtValorDevolvidos.Text = Convert.ToString(VTAntigo);

                //LIMPANDO DADOS
                TxtNumQuantDevolvido.Value = 1;
                TxtIdDevolvido.Text = "";
                TxtIdDevolvido.Focus();

                //SALVA => QUANTIDADE - VALOR

                _ListaProdutos.Add(ProdutoModel);

            }
        }

        private void BtnAdicionarNovo_Click(object sender, EventArgs e)//NOVO
        {
            //OK ADICIONANDO NA LISTA
            ProdutoController produto = new ProdutoController();
            ProdutoModel produtoM = new ProdutoModel();

            produtoM = produto.ExibirProduto(TxtIdnovo.Text);
            if (produtoM.Nome == null)
            {
                MessageBox.Show("Produto não encontrado");
            }
            else
            {
                LBITEMNovo.Items.Add(produtoM.Nome);

                //CALCUAR POR QUANTIDADE
                VendaController v = new VendaController();
                VTNovo += v.CalcularPorQuantidade(produtoM.Nome, TxtNumQuantNovo.Value);
                TxtValorDevolvidos.Text = Convert.ToString(VTNovo);

                //CALCULAR CRÉDITO
                TxtCredito.Text = Convert.ToString( VTAntigo - VTNovo);

                TxtIdnovo.Text = "";
                TxtIdnovo.Focus();

                //MANDA PRO BANCO TEMP
                produto.PreparaBancoItemNovo(produtoM.Nome, TxtNumQuantNovo.Value);

            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            LVPesquisa.Items.Clear();
            List<ProdutoModel> PM = new List<ProdutoModel>();
            ProdutoController p = new ProdutoController();

            PM = p.ExibirProdutoPorNome(TxtPesquisa.Text);

            foreach (var us in PM)
            {
                ListViewItem list = new ListViewItem(Convert.ToString(us.Id));
                list.SubItems.Add(us.Nome);
                list.SubItems.Add(us.Preco);
                LVPesquisa.Items.Add(list);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtPesquisa.Text = "";
            LVPesquisa.Items.Clear();
            TxtCredito.Text = "";
            TxtValorDevolvidos.Text = "";
            TxtValorNovos.Text = "";

            VTAntigo = 0;
            ListItensAntigos.Items.Clear();
            TxtIdDevolvido.Text = "";
            TxtNumQuantDevolvido.Value = 1;

            VTNovo = 0;
            LBITEMNovo.Items.Clear();
            TxtIdnovo.Text = "";
            TxtNumQuantNovo.Value = 1;
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {

            String data = Date.PegarDiaMesAnoAtual();


            ////DECREMENTAR PRODUTOS
            //var produtoDAO = new DAOProduto();
            //foreach (var produto in _ListaProdutos)
            //{
            //    produtoDAO.DecrementaQuantidade(produto.Nome, produto.Quantidade);
            //}

            //ACRESCENTA PRODUTOS //ITENS ANTIGOS
            DAOVENDATEMP daotemp = new DAOVENDATEMP();
                List<ProdutoModel> lpm = new List<ProdutoModel>();
                lpm = daotemp.PegadoBancoItemAntigo();
                daotemp.AcrescentaBanco(lpm);

                //DECREMENTAR PRODUTOS //ITENS NOVOS
                DAOVENDATEMP daotempd = new DAOVENDATEMP();
                List<ProdutoModel> lpmd = new List<ProdutoModel>();
                lpmd = daotempd.PegadoBancoItemNovo();
                daotempd.DecrementaBanco(lpmd);



                //LIMPA TUDO
                TxtPesquisa.Text = "";
                LVPesquisa.Items.Clear();
                TxtCredito.Text = "";
                TxtValorDevolvidos.Text = "";
                TxtValorNovos.Text = "";

                VTAntigo = 0;
            ListItensAntigos.Items.Clear();
                TxtIdDevolvido.Text = "";
                TxtNumQuantDevolvido.Value = 1;

                VTNovo = 0;
                LBITEMNovo.Items.Clear();
                TxtIdnovo.Text = "";
                TxtNumQuantNovo.Value = 1;
            
        }

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            Duvida_Troca tela = new Duvida_Troca();
            tela.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home tela = new Home();
            tela.Show();
            this.Hide();
        }
    }
}
