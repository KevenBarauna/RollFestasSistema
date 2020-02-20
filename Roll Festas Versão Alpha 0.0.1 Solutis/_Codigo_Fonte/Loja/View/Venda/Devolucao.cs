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
using Loja.View.Duvida;

namespace Loja.View.Venda
{
    public partial class Devolucao : Form
    {
        Decimal VT = 0;
        public Devolucao()
        {
            InitializeComponent();


            // USUARIO
            DAOUsuario usuario = new DAOUsuario();
            UsuarioModel usuarioLogado = new UsuarioModel();

            usuarioLogado = usuario.PegarUsuarioLogado();
            LblUsuario.Text = usuarioLogado.Nome;

            //DATA
            Controller tempo = new Controller();

            //INICAR TABELA CAIXA
            String data = tempo.PegarDiaMesAnoAtual();

            DAOCaixa daocaixa = new DAOCaixa();
            daocaixa.IniciarCaixa(Convert.ToString(data));

            //CARREGAR VALOR DATA
            TxtDataVenda.Text = data;
            TxtDatVenda.Text = data;

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
            VT = 0;
            LVPesquisa.Items.Clear();
            ListVenda.Items.Clear();
            LBITEM.Items.Clear();
            TxtTotal.Text = "";
            TxtPesquisa.Text = "";
            TxtId.Text = "";
            TxtNumQuant.Value = 1;
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            //OK ADICIONANDO NA LISTA
            ProdutoController produto = new ProdutoController();
            ProdutoModel produtoM = new ProdutoModel();

            produtoM = produto.ExibirProduto(TxtId.Text);
            if (produtoM.Nome == null)
            {
                MessageBox.Show("Produto não encontrado");
            }
            else
            {
                LBITEM.Items.Add(produtoM.Nome);

                //CALCUAR POR QUANTIDADE
                VendaController v = new VendaController();
                VT += v.CalcularPorQuantidade(produtoM.Nome, TxtNumQuant.Value);
                TxtTotal.Text = Convert.ToString(VT);

                TxtId.Text = "";
                TxtId.Focus();

                //MANDA PRO BANCO TEMP
                produto.PreparaBanco(produtoM.Nome, TxtNumQuant.Value);

            }

        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            //1 = PAGO
            //2 = PAGAR DEPOIS
            Controller tempo = new Controller();
            String data = tempo.PegarDiaMesAnoAtual();
            bool TodasAsInformacoes = true;

            if (TxtDatVenda.Text == "__/__/____")
            {
                MessageBox.Show("Informe a data da venda, que está presente no recibo");
                TodasAsInformacoes = false;
            }
            if (String.IsNullOrEmpty( TxtCodigoVenda.Text))
            {
                MessageBox.Show("Informe o código da venda, que está presente no recibo");
                TodasAsInformacoes = false;
            }

            if (TodasAsInformacoes == true)
            {
                //APAGAR VENDA
                VendaController v = new VendaController();
                v.CancelarVenda(TxtCodigoVenda.Text);

                //ACRESCENTA PRODUTOS
                DAOVENDATEMP daotemp = new DAOVENDATEMP();
                List<ProdutoModel> lpm = new List<ProdutoModel>();
                lpm = daotemp.PegadoBanco();
                daotemp.AcrescentaBanco(lpm);

                //SALVAR NO CAIXA
                CaixaController caixa = new CaixaController();
                caixa.RetirarDoCaixaPorCancelamento(TxtDatVenda.Text, TxtTotal.Text);

                //LIMPA TUDO
                VT = 0;
                LVPesquisa.Items.Clear();
                LBITEM.Items.Clear();
                TxtTotal.Text = "";
                TxtPesquisa.Text = "";
                TxtId.Text = "";
                TxtNumQuant.Value = 1;

                this.Hide();
            }

        }

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            Duvida_Devolucao tela = new Duvida_Devolucao();
            tela.Show();
        }

        private void BtnPesquisarVenda_Click(object sender, EventArgs e)
        {
            VendaController venda = new VendaController();
            var TodasAsVendas = venda.ListarVendas(TxtDataVenda.Text);

            ListVenda.Items.Clear();

            foreach (var us in TodasAsVendas)
            {
                ListViewItem list = new ListViewItem(Convert.ToString(us.Id));
                list.SubItems.Add(us.ValorTotal);
                ListVenda.Items.Add(list);
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            //LIMPA TUDO
            VT = 0;
            LVPesquisa.Items.Clear();
            LBITEM.Items.Clear();
            TxtTotal.Text = "";
            TxtPesquisa.Text = "";
            TxtId.Text = "";
            TxtNumQuant.Value = 1;

            Home tela = new Home();
            tela.Show();
            this.Hide();
        }
    }
}
