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
using Loja.View.Caixa;
using Loja.View.Calcular;
using Loja.View.Duvida;
using Loja.View.Encomenda;
using Loja.View.Ponto;
using Loja.View.Produto;
using Loja.View.Recibo;
using Loja.View.Usuario;
using Loja.View.Venda;

namespace Loja.View
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            DAOUsuario usuario = new DAOUsuario();
            UsuarioModel us = new UsuarioModel();
            us = usuario.PegarUsuarioLogado();
            LblUsuario.Text = "Olá " + us.Nome;

            //LISTAR ENCOMENDAS

            try
            {

                EncomendaController encomenda = new EncomendaController();
                List<EncomendaModel> encomendas = new List<EncomendaModel>();

                encomendas = encomenda.ListraEncomendasPordata();


                foreach (var p in encomendas)
                {

                    ListViewItem listE = new ListViewItem(Convert.ToString(p.Id));
                    listE.SubItems.Add(p.TipoServico);
                   // listE.SubItems.Add(p.Data_Entrada);
                    listE.SubItems.Add(p.DataEntrega);
                    listE.SubItems.Add(p.Tema);
                  //  listE.SubItems.Add(p.valor);
                    listE.SubItems.Add(p.Descricao);

                    LVEntregas.Items.Add(listE);

                }

            }
            catch (Exception e)
            {
                Erro TelaDeErro = new Erro("000", "Sem acesso ao bando de dados" + e, "Reinicie o programa", "Reinicie o computador", "Reinicie o banco de dados.", "", "");
                TelaDeErro.Show();
            }




        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaVenda tela = new NovaVenda();
            tela.Show();
            this.Hide();
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarNovoUsuario tela = new AdicionarNovoUsuario();
            tela.Show();
        }

        private void editarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarUsuario tela = new EditarUsuario();
            tela.Show();
        }

        private void apagarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApagarUsuario tela = new ApagarUsuario();
            tela.Show();
        }

        private void verTodosOsUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PERMISSÂO ADM
              TodosOsUsuarios tela = new TodosOsUsuarios();
              tela.Show();
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarNovoProduto tela = new AdicionarNovoProduto();
            tela.Show();
        }

        private void apagarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PERMISSÂO ADM
            ApagarProduto tela = new ApagarProduto();
            tela.Show();
        }

        private void detalhesDoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetalhesProduto tela = new DetalhesProduto();
            tela.Show();
        }

        private void verTodosOsProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirProdutos tela = new ExibirProdutos();
            tela.Show();
        }

        private void editarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarProduto tela = new EditarProduto();
            tela.Show();
        }

        private void baterPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaterPonto tela = new BaterPonto();
            tela.Show();
        }

        private void verPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerPonto tela = new VerPonto();
            tela.Show();
        }

        private void gerarPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Controller tempo = new Controller();
            String mes = tempo.PegarMes();

            PontoController ponto = new PontoController();
            ponto.GerarPDFPonto(mes);
            MessageBox.Show("Planilha gerada e salva");
        }

        private void novaEncomendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaEncomenda tela = new NovaEncomenda();
            tela.Show();
        }

        private void verEmcomendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerEncomenda tela = new VerEncomenda();
            tela.Show();
        }

        private void editarEncomendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarEncomenda tela = new EditarEncomenda();
            tela.Show();
        }

        private void cancelarEncomendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApagarEncomenda tela = new ApagarEncomenda();
            tela.Show();
        }

        private void verTodasAsVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerVendas tela = new VerVendas();
            tela.Show();
            this.Hide();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void bannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcularBanner tela = new CalcularBanner();
            tela.Show();
        }

        private void mDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcularMDF tela = new CalcularMDF();
            tela.Show();
        }

        private void fechamentoDoCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FechamentoCaixa tela = new FechamentoCaixa();
            tela.Show();
        }

        private void verTodosOsPagamentosPendetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerpagamentosPendentes tela = new VerpagamentosPendentes();
            tela.Show();
        }

        private void pagarPagamentoPendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagarVendaPendente tela = new PagarVendaPendente();
            tela.Show();
        }

        private void cancelarPagamentoPendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelarVendaPendente tela = new CancelarVendaPendente();
            tela.Show();
        }

        private void cancelarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devolucao tela = new Devolucao();
            tela.Show();
            this.Hide();
        }

        private void trocaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Troca tela = new Troca();
            tela.Show();
            this.Hide();
        }

        private void registrarRetiradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Retirada tela = new Retirada();
            tela.Show();
        }

        private void registrarDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposito tela = new Deposito();
            tela.Show();
        }

        private void verVendaDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturamentoDia tela = new FaturamentoDia();
            tela.Show();
        }

        private void verVendaDoMêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturamentoMes tela = new FaturamentoMes();
            tela.Show();
        }

        private void verVendaDoAnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturamentoAno tela = new FaturamentoAno();
            tela.Show();
        }

        private void gerarReciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReciboController recibo = new ReciboController();
            recibo.GerarReciboDeVenda();
        }

        private void gerarTodosOsRecibosDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReciboPorId tela = new ReciboPorId();
            tela.Show();
    }

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            Duvida_Home tela = new Duvida_Home();
            tela.Show();
        }

        private void pesquisarPorTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarPorTema tela = new PesquisarPorTema();
            tela.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CacheController cache = new CacheController();
            cache.SalvarPontoTxt();
            Application.Exit();
        }

        private void BtnVenda_Click(object sender, EventArgs e)
        {
            NovaVenda tela = new NovaVenda();
            tela.Show();
            this.Hide();
        }
    }
}
