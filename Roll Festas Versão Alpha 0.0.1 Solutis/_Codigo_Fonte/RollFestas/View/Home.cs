using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RollFestas.Controllers;
using RollFestas.Models;
using RollFestas.Utils;
using RollFestas.View.Avisos;
using RollFestas.View.Caixa;
using RollFestas.View.Encomenda;
using RollFestas.View.Mercadoria;
using RollFestas.View.Usuario;
using RollFestas.View.Venda;
using RollFestas.View.Venda.PagamentoPendente;

namespace RollFestas.View
{
    public partial class Home : Form
    {
        public Home()
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

                    if (item.DataEntrega == Data)
                    {
                        var Tela = new MensagemAlerta("Hoje tem entrega da encomenda do tipo " + item.TipoServico +" do(a) cliente " + item.NomeCliente);
                        Tela.Show();
                        Tela.Focus();
                    }
                }
            }
           


        }
        private void BtnTrocarUsuario_Click(object sender, System.EventArgs e)
        {
            var Tela = new Login();
            Tela.Show();
            this.Hide();
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
            }
        }


        #endregion

        #region MERCADORIO
        private void novoProdutoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new NovaMercadoria();
            Tela.Show();
            this.Hide();
        }
        #endregion

        #region PRODUTO
        private void editarProdutoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new EditarMercadoria();
            Tela.Show();
            this.Hide();
        }

        private void apagarProdutoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new ApagarProduto();
            Tela.Show();
            this.Hide();
        }

        private void detalhesDoProdutoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new PesquisarProduto();
            Tela.Show();
            this.Hide();
        }

        #endregion

        #region CAIXA
        private void registrarRetiradaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new Retirada();
            Tela.Show();
            this.Hide();
        }

        private void registrarDeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new Deposito();
            Tela.Show();
            this.Hide();
        }

        private void verVendaDoDiaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new Faturamento();
            Tela.Show();
            this.Hide();
        }
        #endregion

        private void fechamentoDoCaixaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new FechametoCaixa();
            Tela.Show();
            this.Hide();
        }

        private void novaVendaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new Venda.VendaNova();
            Tela.Show();
            this.Hide();
        }

        private void trocaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new Troca(LblUsuario.Text);
            Tela.Show();
            this.Hide();
        }

        private void verTodosOsPagamentosPendetesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new VerTodos();
            Tela.Show();
            this.Hide();
        }

        private void pagarPagamentoPendenteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new Pagamento(LblUsuario.Text);
            Tela.Show();
            this.Hide();
        }

        private void cancelarPagamentoPendenteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {


            if (Program._Usuario.Id == 1)
            {
                var Tela = new CancelarVendaPendente(LblUsuario.Text);
                Tela.Show();
                this.Hide();
            }
            else
            {
                var tela = new Permissao(5);
                tela.Show();
            }

          
        }

        private void verTodasAsVendasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new PesquisarDia();
            Tela.Show();
            this.Hide();
        }

        private void novaEncomendaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var Tela = new NovaEncomenda();
            Tela.Show();
            this.Hide();
        }

        private void editarEncomendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Tela = new EditarEncomenda();
            Tela.Show();
            this.Hide();
        }
    }
}
