using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.Model;
using Loja.View;

namespace Loja.Controler
{
    class ProdutoController
    {

        public bool Cadastrar(String nome, String tema, String preco, String quantidade, String fornecedor, String data, String descricao)
        {
            
            if (string.IsNullOrEmpty(data) || data == "  /  /    ")
            {
                Controller tempo = new Controller();
                data = tempo.PegarDiaMesAnoAtual();
            }

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Preencha o nome do produto");
                return false;
            }
            else if(string.IsNullOrEmpty(preco))
            {
                MessageBox.Show("Preencha o preço do produto");
                return false;
            }
            else if (string.IsNullOrEmpty(quantidade))
            {
                MessageBox.Show("Preencha a quantidade do produto que está em estoque");
                return false;
            }
            else
            {
                if (preco.Contains("."))
                {
                    preco = preco.Replace(".",",");
                }
  

                DAOProduto dao = new DAOProduto();
                dao.InserirProduto(nome, tema, preco, quantidade, fornecedor, data, descricao);
                return true;
            }

        }//CADASTRAR NOVO PRODUTO

        public bool VerificaSeNoveJaExiste(String nome)//RETORNA DETALHES DO PRODUTO
        {
            bool ProdutoExiste = false;
            DAOProduto dao = new DAOProduto();

            ProdutoExiste = dao.VerificaSeNomeExiste(nome);

            if (ProdutoExiste == true)
            {
                return true;
            }
            else
            {
                return false;
            }
           

        }

        public ProdutoModel ExibirProduto(String id)//RETORNA DETALHES DO PRODUTO
        {
            ProdutoModel produto = new ProdutoModel();
            DAOProduto dao = new DAOProduto();

            produto = dao.ExibirDetalhesdoProduto(id);

            return produto;

        }

        public bool EditarProduto(String nome, String tema, String preco, String quantidade, String fornecedor, String data, String descricao, int id)
        {

            if (string.IsNullOrEmpty(nome))
            {
                Erro TelaDeErro = new Erro("CP01", "Parâmetro invalido", "Nome do produto obrigatório", "Verifique se você digitou os dados corretamente.", "", "", "");
                TelaDeErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(preco))
            {
                Erro TelaDeErro = new Erro("CP02", "Parâmetro invalido", "Preço do produto obrigatório", "Verifique se você digitou os dados corretamente.", "", "", "");
                TelaDeErro.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(quantidade))
            {
                Erro TelaDeErro = new Erro("CP03", "Parâmetro invalido", "Quantidade do produto obrigatório", "Verifique se você digitou os dados corretamente.", "", "", "");
                TelaDeErro.Show();
                return false;
            }
            else if ( preco.Contains(".") || preco.Contains("$"))
            {
                Erro TelaDeErro = new Erro("CP04", "Parâmetro invalido", "O campo Preço está incorreto", "Use virgulas no lugar de ponto", "Verifique se você digitou os dados corretamente.", "Digite somente números e virgula", "Não digite R$");
                TelaDeErro.Show();
                return false;
            }

           

            try
            {
                DAOProduto dao = new DAOProduto();
                dao.EditarProduto(nome, tema, preco, quantidade, fornecedor, data, descricao, id);
                return true;
            }
            catch (Exception e)
            {

                Erro TelaDeErro = new Erro("ERX", "Erro inesperado" + e, "Verifique se você digitou os campos corretamente.", "Reinicie o computador", "", "", "");
                TelaDeErro.Show();
                return false;

            }


        }//UPDATE NO BANCO

        public void ApagarProduto(int id)
        {
            DAOProduto dao = new DAOProduto();

                dao.ApagarProduto(id);

        }//APAGAR PRODUTO

        public List<ProdutoModel> ListarTodosOsProdutos()//LISTAR TODOS OS PRODUTOS
        {
            List<ProdutoModel> todososprodutos = new List<ProdutoModel>();
            ProdutoModel produto = new ProdutoModel();

            DAOProduto dao = new DAOProduto();
            todososprodutos = dao.ListarTodosOsProdutos();

            return todososprodutos;
        }

        public List<ProdutoModel> ListarTodosOsProdutosPorCodigo()//LISTAR TODOS OS PRODUTOS
        {
            List<ProdutoModel> todososprodutos = new List<ProdutoModel>();
            ProdutoModel produto = new ProdutoModel();

            DAOProduto dao = new DAOProduto();
            todososprodutos = dao.ListarTodosOsProdutosPorCodigo();

            return todososprodutos;
        }

        public List<ProdutoModel> ListarTodosOsProdutosPorQuantidade()//LISTAR TODOS OS PRODUTOS
        {
            List<ProdutoModel> todososprodutos = new List<ProdutoModel>();
            ProdutoModel produto = new ProdutoModel();

            DAOProduto dao = new DAOProduto();
            todososprodutos = dao.ListarTodosOsProdutosPorQuantidade();

            return todososprodutos;
        }

        public List<ProdutoModel> ListarTodosOsProdutosPorNome()//LISTAR TODOS OS PRODUTOS
        {
            List<ProdutoModel> todososprodutos = new List<ProdutoModel>();
            ProdutoModel produto = new ProdutoModel();

            DAOProduto dao = new DAOProduto();
            todososprodutos = dao.ListarTodosOsProdutosPorNome();

            return todososprodutos;
        }

        public List<ProdutoModel> ListarTodosOsProdutosPorData()//LISTAR TODOS OS PRODUTOS
        {
            List<ProdutoModel> todososprodutos = new List<ProdutoModel>();
            ProdutoModel produto = new ProdutoModel();

            DAOProduto dao = new DAOProduto();
            todososprodutos = dao.ListarTodosOsProdutosPorData();

            return todososprodutos;
        }

        public List<ProdutoModel> ListarTodosOsProdutosPorTema()//LISTAR TODOS OS PRODUTOS
        {
            List<ProdutoModel> todososprodutos = new List<ProdutoModel>();
            ProdutoModel produto = new ProdutoModel();

            DAOProduto dao = new DAOProduto();
            todososprodutos = dao.ListarTodosOsProdutosPorTema();

            return todososprodutos;
        }

        public List<ProdutoModel> ExibirProdutoPorNome(String nome)//RETORNA DETALHES DO PRODUTO
        {
            List<ProdutoModel> produto = new List<ProdutoModel>();
            DAOProduto dao = new DAOProduto();

            produto = dao.ExibirDetalhesdoProdutoPorNome(nome);

            return produto;

        }

        public List<ProdutoModel> ExibirProdutoPorTema(String tema)//RETORNA DETALHES DO PRODUTO
        {
            List<ProdutoModel> produto = new List<ProdutoModel>();
            DAOProduto dao = new DAOProduto();

            produto = dao.ExibirDetalhesdoProdutoPorTema(tema);

            return produto;

        }

        public void PreparaBanco(String nome, Decimal quantidadeDecimal)
        {

            DAOVENDATEMP daotemp = new DAOVENDATEMP();
            String quantidade = Convert.ToString(quantidadeDecimal);

            daotemp.PreparaBanco(nome, quantidade);
         
        }//SALVA NO BANCO TEMPORARIO

        public void PreparaBancoItemNovo(String nome, Decimal quantidadeDecimal)
        {

            DAOVENDATEMP daotemp = new DAOVENDATEMP();
            String quantidade = Convert.ToString(quantidadeDecimal);

            daotemp.PreparaBancoItemNovos(nome, quantidade);

        }//SALVA NO BANCO TEMPORARIO

        public void PreparaBancoItemAntigo(String nome, Decimal quantidadeDecimal)
        {

            DAOVENDATEMP daotemp = new DAOVENDATEMP();
            String quantidade = Convert.ToString(quantidadeDecimal);

            daotemp.PreparaBancoItemAntigos(nome, quantidade);

        }//SALVA NO BANCO TEMPORARIO



    }
}
