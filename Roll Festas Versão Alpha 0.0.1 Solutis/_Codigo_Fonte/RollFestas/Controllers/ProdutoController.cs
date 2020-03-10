using System;
using System.Collections.Generic;
using RollFestas.Data;
using RollFestas.Models;
using RollFestas.Utils;
using RollFestas.View.MensagemErro;

namespace RollFestas.Controllers
{
    class ProdutoController
    {
        ProdutoDAO DAO = new ProdutoDAO();

        public bool Cadastrar(string Nome, string Tema, string Preco, string Quantidade, int SalvarQuantidade, string Fornecedor, string Data, string Descricao)
        {

            bool ProdutoExiste = VerificaSeNoveJaExiste(Nome);
            if (ProdutoExiste == true)
            {
                var Tela = new Erro("Já existe um produto cadastrado com esse nome");
                Tela.Show();
                return false;
            }

            if (Preco.Contains("."))
            {
                var Tela = new Erro("O preço da mercadoria deve conter somente números e virgula");
                Tela.Show();
                return false;
            }

            try
            {
                decimal ValorTeste = Convert.ToDecimal(Preco);
            }
            catch (Exception)
            {
                var Tela = new Erro("O preço da mercadoria não é válido");
                Tela.Show();
                return false;
            }

            if (string.IsNullOrEmpty(Data) || Data == "  /  /")
            {
                Data = GetDate.PegarDiaMesAnoAtual();
            }

            if (string.IsNullOrEmpty(Nome))
            {
                var Tela = new Erro("Informe o nome do produto");
                Tela.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(Preco))
            {
                var Tela = new Erro("Informe o preço do produto");
                Tela.Show();
                return false;
            }
            else if (SalvarQuantidade == 1 && string.IsNullOrEmpty(Quantidade))
            {
                var Tela = new Erro("Informe a quantidade do produto");
                Tela.Show();
                return false;
            }
            if (SalvarQuantidade == 2)
            {
                Quantidade = "0";
            }


            bool Sucesso = DAO.InserirProduto(Nome, Tema, Preco, Quantidade, SalvarQuantidade, Fornecedor, Data, Descricao);

            if (Sucesso == true)
            {
                var Tela = new Sucesso("Produto cadastrado com sucesso");
                Tela.Show();
            }
            return Sucesso;

        }//CADASTRAR NOVO PRODUTO

        public bool VerificaSeNoveJaExiste(string Nome)
        {

            return DAO.VerificaSeNomeExiste(Nome);

        }

        public ProdutoModel ExibirProduto(string Id)
        {
            ProdutoModel produto = DAO.ExibirDetalhesdoProduto(Id);

            if (produto.Nome == null)
            {
                Erro TelaDeErro = new Erro("Produto não encontrado");
                TelaDeErro.Show();
            }

            return produto;

        }

        public bool EditarProduto(string Nome, string Tema, string Preco, string Quantidade, int InformarQuantidade, string Fornecedor, string Data, string Descricao, string Id)
        {
            if (Preco.Contains("."))
            {
                var Tela = new Erro("O preço da mercadoria deve conter somente números e virgula");
                Tela.Show();
                return false;
            }

            if (InformarQuantidade == 2)
            {
                Quantidade = "0";
            }

            try
            {
                decimal ValorTeste = Convert.ToDecimal(Preco);
            }
            catch (Exception)
            {
                var Tela = new Erro("O preço da mercadoria não é válido");
                Tela.Show();
                return false;
            }

            if (string.IsNullOrEmpty(Data) || Data == "  /  /")
            {
                Data = GetDate.PegarDiaMesAnoAtual();
            }

            if (string.IsNullOrEmpty(Nome))
            {
                var Tela = new Erro("Informe o nome do produto");
                Tela.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(Preco))
            {
                var Tela = new Erro("Informe o preço do produto");
                Tela.Show();
                return false;
            }
            else if (string.IsNullOrEmpty(Quantidade))
            {
                var Tela = new Erro("Informe a quantidade do produto");
                Tela.Show();
                return false;
            }
            else if (Preco.Contains(".") || Preco.Contains("$"))
            {
                Erro TelaDeErro = new Erro("O campo 'Preço' deve conter somente númeos e virgula");
                TelaDeErro.Show();
                return false;
            }

            bool Sucesso = DAO.Editar(Nome, Tema, Preco, Quantidade, InformarQuantidade, Fornecedor, Data, Descricao, Id);

            if (Sucesso == true)
            {
                var Tela = new Sucesso("Produto editado com sucesso");
                Tela.Show();
            }
            return Sucesso;

        }

        public bool ApagarProduto(string Id)
        {

            ProdutoModel produto = DAO.ExibirDetalhesdoProduto(Id);

            if (produto.Id == 0)
            {
                var TelaErro = new Erro("Produto não encontrado");
                TelaErro.Show();
                return false;
            }
            bool Sucesso = DAO.Apagar(Id);

            if (Sucesso == true)
            {
                var Tela = new Sucesso("Produto apagado com sucesso");
                Tela.Show();
            }
            return Sucesso;


        }

        public List<ProdutoModel> ListarTodosOsProdutos()
        {
            List<ProdutoModel> ListaProdutos = DAO.ListarTodosOsProdutos();

            return ListaProdutos;
        }

        public List<ProdutoModel> ListarTodosOsProdutosPorQuantidade()
        {
            List<ProdutoModel> Listaprodutos = DAO.ListarTodosOsProdutosPorQuantidade();

            return Listaprodutos;
        }

        public List<ProdutoModel> ListarTodosOsProdutosPorNome()
        {
            List<ProdutoModel> ListaProdutos = DAO.ListarTodosOsProdutosPorNome();

            return ListaProdutos;
        }

        public List<ProdutoModel> ListarTodosOsProdutosPorData()
        {
            List<ProdutoModel> ListaProdutos = DAO.ListarTodosOsProdutosPorData();

            return ListaProdutos;
        }

        public List<ProdutoModel> ListarTodosOsProdutosPorTema()
        {
            List<ProdutoModel> ListaProduto = DAO.ListarTodosOsProdutosPorTema();

            return ListaProduto;
        }

        public List<ProdutoModel> ExibirProdutoPorNome(string Nome)
        {
            List<ProdutoModel> ListaProduto = DAO.ExibirDetalhesdoProdutoPorNome(Nome);
            return ListaProduto;
        }

        public List<ProdutoModel> ExibirProdutoPorTema(string Tema)
        {
            List<ProdutoModel> ListaProduto = DAO.ExibirDetalhesdoProdutoPorTema(Tema);
            return ListaProduto;

        }

        public bool DecrementarProdutos(List<ProdutoModel> ListaVendida)
        {
            try
            {
                var produtoC = new ProdutoController();
                var produtoM = new ProdutoModel();

                foreach (var produto in ListaVendida)
                {
                    if (produto.InformarQuantidade == "1")
                    {
                        decimal QuantidadeEstoque = Convert.ToDecimal(produto.QuantidadeEstoque);
                        decimal QuantidadeVenda = Convert.ToDecimal(produto.QuantidadeVenda);

                        decimal NovaQuantidade = QuantidadeEstoque - QuantidadeVenda;

                        DAO.Editar(produto.Nome, produto.Tema, produto.Preco, NovaQuantidade.ToString(), 1, produto.Fornecedor, produto.Data, produto.Descricao, produto.Id.ToString());
                    }
                    
                }
                return true;
            }
            catch (Exception)
            {
                var TelaErro = new Erro("Erro ao atualizar quantidade dos produtos no estoque");
                TelaErro.Show();
                return false;
            }

        }


    }
}
