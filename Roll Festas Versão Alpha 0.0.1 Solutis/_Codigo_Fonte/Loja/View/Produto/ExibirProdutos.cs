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
    public partial class ExibirProdutos : Form
    {
        public ExibirProdutos()
        {
            InitializeComponent();
            try
            {

                ProdutoController produto = new ProdutoController();
                List<ProdutoModel> produtos = new List<ProdutoModel>();
                produtos = produto.ListarTodosOsProdutos();


                foreach (var p in produtos)
                {

                    ListViewItem listP = new ListViewItem(Convert.ToString(p.Id));
                    listP.SubItems.Add(p.Nome);
                    listP.SubItems.Add(p.Tema);
                    listP.SubItems.Add(p.Preco);
                    listP.SubItems.Add(p.Quantidade_Estoque);
                    listP.SubItems.Add(p.Fornecedor);
                    listP.SubItems.Add(p.Descricao);
                    listP.SubItems.Add(p.Data);

                    listCodigo.Items.Add(listP);

                }

            }
            catch (Exception e)
            {
                Erro TelaDeErro = new Erro("000", "Sem acesso ao bando de dados" + e, "Reinicie o programa", "Reinicie o computador", "Reinicie o banco de dados.", "", "");
                TelaDeErro.Show();
            }
            

        }

        private void BtnCodigo_Click(object sender, EventArgs e)
        {

            listCodigo.Items.Clear();

          ProdutoController produto = new ProdutoController();
            List<ProdutoModel> produtos = new List<ProdutoModel>();
            produtos = produto.ListarTodosOsProdutosPorQuantidade();

            try 
            { 

                foreach (var p in produtos)
                {

                    ListViewItem listP = new ListViewItem(Convert.ToString(p.Id));
                    listP.SubItems.Add(p.Nome);
                    listP.SubItems.Add(p.Tema);
                    listP.SubItems.Add(p.Preco);
                    listP.SubItems.Add(p.Quantidade_Estoque);
                    listP.SubItems.Add(p.Fornecedor);
                    listP.SubItems.Add(p.Descricao);
                    listP.SubItems.Add(p.Data);

                    listCodigo.Items.Add(listP);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao pesquisar produtos");
            }

        }

        private void BtnAlfabetica_Click(object sender, EventArgs e)
        {

            listCodigo.Items.Clear();

            ProdutoController produto = new ProdutoController();
            List<ProdutoModel> produtos = new List<ProdutoModel>();
            produtos = produto.ListarTodosOsProdutosPorNome();

            try
            {

                foreach (var p in produtos)
                {

                    ListViewItem listP = new ListViewItem(Convert.ToString(p.Id));
                    listP.SubItems.Add(p.Nome);
                    listP.SubItems.Add(p.Tema);
                    listP.SubItems.Add(p.Preco);
                    listP.SubItems.Add(p.Quantidade_Estoque);
                    listP.SubItems.Add(p.Fornecedor);
                    listP.SubItems.Add(p.Descricao);
                    listP.SubItems.Add(p.Data);

                    listCodigo.Items.Add(listP);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao pesquisar produtos");
            }
        }

        private void BtnData_Click(object sender, EventArgs e)
        {

            listCodigo.Items.Clear();

            ProdutoController produto = new ProdutoController();
            List<ProdutoModel> produtos = new List<ProdutoModel>();
            produtos = produto.ListarTodosOsProdutosPorData();

            try
            {

                foreach (var p in produtos)
                {

                    ListViewItem listP = new ListViewItem(Convert.ToString(p.Id));
                    listP.SubItems.Add(p.Nome);
                    listP.SubItems.Add(p.Tema);
                    listP.SubItems.Add(p.Preco);
                    listP.SubItems.Add(p.Quantidade_Estoque);
                    listP.SubItems.Add(p.Fornecedor);
                    listP.SubItems.Add(p.Descricao);
                    listP.SubItems.Add(p.Data);

                    listCodigo.Items.Add(listP);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao pesquisar produtos");
            }
        }

        private void BtnTema_Click(object sender, EventArgs e)
        {

            listCodigo.Items.Clear();

            ProdutoController produto = new ProdutoController();
            List<ProdutoModel> produtos = new List<ProdutoModel>();
            produtos = produto.ListarTodosOsProdutosPorTema();

            try
            {

                foreach (var p in produtos)
                {

                    ListViewItem listP = new ListViewItem(Convert.ToString(p.Id));
                    listP.SubItems.Add(p.Nome);
                    listP.SubItems.Add(p.Tema);
                    listP.SubItems.Add(p.Preco);
                    listP.SubItems.Add(p.Quantidade_Estoque);
                    listP.SubItems.Add(p.Fornecedor);
                    listP.SubItems.Add(p.Descricao);
                    listP.SubItems.Add(p.Data);

                    listCodigo.Items.Add(listP);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao pesquisar produtos");
            }
        }
    }
}
