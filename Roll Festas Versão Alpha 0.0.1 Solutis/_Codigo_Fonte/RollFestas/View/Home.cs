using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RollFestas.Controllers;
using RollFestas.Models;
using RollFestas.Utils;
using RollFestas.View.Avisos;
using RollFestas.View.Caixa;
using RollFestas.View.Calculo;
using RollFestas.View.Encomenda;
using RollFestas.View.Evento;
using RollFestas.View.MensagemErro;
using RollFestas.View.Mercadoria;
using RollFestas.View.Ponto;
using RollFestas.View.Usuario;
using RollFestas.View.Venda;
using RollFestas.View.Venda.PagamentoPendente;

namespace RollFestas.View
{
    public partial class Home : Form
    {
        public Home(bool ExibirAvisos)
        {
            InitializeComponent();

            

            //NOME USUÁRIO
            LblUsuario.Text = Program._Usuario.Nome;
            string Data = GetDate.PegarDiaMesAnoAtual();

            //VENDA USUÁRIO
            var VendaC = new VendaController();
            LblVendas.Text = VendaC.VendaPorUsuario(LblUsuario.Text);

            //LISTA DE ENTREGAS
            ListEntregas.Items.Clear();

            var encomendaoC = new EncomendaController();
            List<EncomendaModel> ListaEncomenda = encomendaoC.ListraEncomendasPordata();

            if (ListaEncomenda.Count > 0)
            {
                foreach (var item in ListaEncomenda)
                {
                    
                    ListViewItem Lista = new ListViewItem(Convert.ToString(item.Id));
                    Lista.SubItems.Add(item.TipoServico);
                    Lista.SubItems.Add(item.DataEntrega);
                    Lista.SubItems.Add(item.Tema);
                    Lista.SubItems.Add(item.Descricao);

                    ListEntregas.Items.Add(Lista);

                    if (item.DataEntrega == Data && ExibirAvisos == true)
                    {
                        this.Hide();
                        var Tela = new MensagemAlerta("Hoje tem entrega da encomenda do tipo " + item.TipoServico +" do(a) cliente " + item.NomeCliente);
                        Tela.Show();
                        Tela.Focus();
                        this.Show();
                    }
                }
            }

        }

        private void BtnTrocarUsuario_Click(object sender, System.EventArgs e)
        {
            var Tela = new Login();
            Tela.Show();
            this.Close();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        #region USUARIO
        //NOVO
        private void novoUsuárioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (Program._Usuario.Id == 1)
            {
                var Tela = new NovoUsuario();
                Tela.Show();
            }
            else
            {
                var tela = new Permissao(1);
                tela.Show();
                this.Close();
            }
        }

        //EDITAR
        private void editarUsuárioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (Program._Usuario.Id == 1)
            {
                var Tela = new EditarUsuario();
                Tela.Show();
            }
            else
            {
                var tela = new Permissao(2);
                tela.Show();
                this.Close();
            }
        }

        //APAGAR
        private void apagarUsuárioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (Program._Usuario.Id == 1)
            {
                var Tela = new ApagarUsuario();
                Tela.Show();
            }
            else
            {
                var tela = new Permissao(3);
                tela.Show();
                this.Close();
            }
        }

        //VER TODOS
        private void verTodosOsUsuáriosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (Program._Usuario.Id == 1)
            {
                var Tela = new TodosUsuarios();
                Tela.Show();
            }
            else
            {
                var tela = new Permissao(4);
                tela.Show();
                this.Close();
            }
        }


        #endregion

        #region PRODUTO
        private void novoProdutoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new NovaMercadoria();
            Tela.Show();
            this.Close();
        }
       
        private void editarProdutoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new EditarMercadoria();
            Tela.Show();
            this.Close();
        }

        private void apagarProdutoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new ApagarProduto();
            Tela.Show();
            this.Close();
        }

        private void detalhesDoProdutoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new PesquisarProduto();
            Tela.Show();
            this.Close();
        }

        #endregion

        #region CAIXA
        private void registrarRetiradaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (Program._Usuario.Id == 1)
            {
                var Tela = new Retirada();
                Tela.Show();
                this.Close();
            }
            else
            {
                var tela = new Permissao(7);
                tela.Show();
                this.Close();
            }
        }

        private void registrarDeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (Program._Usuario.Id == 1)
            {
                var Tela = new Deposito();
                Tela.Show();
                this.Close();
            }
            else
            {
                var tela = new Permissao(6);
                tela.Show();
                this.Close();
            }
            
        }

        private void fechamentoDoCaixaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new FechametoCaixa();
            Tela.Show();
            this.Close();
        }

        #endregion

        #region VENDA
        private void verVendaDoDiaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new Faturamento();
            Tela.Show();
            this.Close();
        }

        private void novaVendaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new Venda.VendaNova();
            Tela.Show();
            this.Close();
        }

        private void trocaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new Troca(LblUsuario.Text);
            Tela.Show();
            this.Close();
        }

        private void verTodosOsPagamentosPendetesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new VerTodos();
            Tela.Show();
            this.Close();
        }

        private void pagarPagamentoPendenteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new Pagamento(LblUsuario.Text);
            Tela.Show();
            this.Close();
        }

        private void cancelarPagamentoPendenteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {


            if (Program._Usuario.Id == 1)
            {
                var Tela = new CancelarVendaPendente(LblUsuario.Text);
                Tela.Show();
                this.Close();
            }
            else
            {
                var tela = new Permissao(5);
                tela.Show();
                this.Close();
            }


        }

        private void verTodasAsVendasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new PesquisarDia();
            Tela.Show();
            this.Close();
        }

        #endregion

        #region ENCOMENDA
        private void novaEncomendaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new NovaEncomenda();
            Tela.Show();
            this.Close();
        }

        private void editarEncomendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Tela = new EditarEncomenda();
            Tela.Show();
            this.Close();
        }

        private void cancelarEncomendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Tela = new CancelarEncomenda();
            Tela.Show();
            this.Close();
        }

        private void verEmcomendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Tela = new VerEncomendas();
            Tela.Show();
            this.Close();
        }
        #endregion

        #region PONTO
        private void baterPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Tela = new BaterPonto();
            Tela.Show();
            this.Close();
        }

        private void verPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Tela = new PesquisarPonto();
            Tela.Show();
            this.Close();
        }

        private void gerarPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerarPlanilha.GerarPlanilhaPonto(GetDate.PegarMesAno());
        }
        #endregion

        #region CALCULO
        private void bannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Tela = new CalcularBanner();
            Tela.Show();
            this.Close();
        }

        #endregion

        private void mDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Tela = new Erro("Essa função não foi desenvolvida, para ser finalizada é preciso enviar uma planilha com os tamanhos e valores para o desenvolvedor do software");
            Tela.Show();
        }

        private void novoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Tela = new NovoEvento();
            Tela.Show();
            this.Close();
        }

        private void editarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Tela = new EditarEvento();
            Tela.Show();
            this.Close();
        }

        private void apagarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Tela = new TodosOsEventos();
            Tela.Show();
            this.Close();
        }

        private void BtnVenda_Click(object sender, EventArgs e)
        {
            var Tela = new Venda.VendaNova();
            Tela.Show();
            this.Close();
        }

        private void BtnEncomenda_Click(object sender, EventArgs e)
        {
            var Tela = new NovaEncomenda();
            Tela.Show();
            this.Close();
        }

        private void BtnPonto_Click(object sender, EventArgs e)
        {
            var Tela = new BaterPonto();
            Tela.Show();
            this.Close();
        }

        private void BtnPesquisaTema_Click(object sender, EventArgs e)
        {
            var Tela = new PesquisarProduto();
            Tela.Show();
            this.Close();
        }

        private void abrirTodasAsAjudasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Program._CaminhoArquivoDuvida + @"\Duvida_Perguntas.pdf");
        }

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Program._CaminhoArquivoDuvida + @"\Duvida_Home.pdf");
        }
    }
}
