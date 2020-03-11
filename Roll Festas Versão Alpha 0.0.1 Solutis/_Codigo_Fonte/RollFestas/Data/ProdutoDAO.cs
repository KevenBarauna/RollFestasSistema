using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using RollFestas.Models;
using RollFestas.Services;
using RollFestas.Utils;
using RollFestas.View.MensagemErro;

namespace RollFestas.Data
{
    class ProdutoDAO
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        //NOVO PRODUTO
        public bool InserirProduto(string Nome, string Tema, string Preco, string Quantidade, int InfQuantidade, string Fornecedor, string Data, string Descricao)
        {
            try
            {
                cmd.CommandText = "INSERT INTO TB_PRODUTO (nome,tema,preco,quantidade,informar_quantidade,fornecedor,data,descricao) VALUES (@nome,@tema,@preco,@quantidade,@infQuantidade,@fornecedor,@data,@descricao)";

                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@tema", Tema);
                cmd.Parameters.AddWithValue("@preco", Preco);
                cmd.Parameters.AddWithValue("@quantidade", Quantidade);
                cmd.Parameters.AddWithValue("@infQuantidade", InfQuantidade);
                cmd.Parameters.AddWithValue("@fornecedor", Fornecedor);
                cmd.Parameters.AddWithValue("@data", Data);
                cmd.Parameters.AddWithValue("@descricao", Descricao);


                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB01P", e.Message);
                TelaErro.Show();
                return false;
            }

            return true;
        }

        //VERIFICA SE NOME EXISTE
        public bool VerificaSeNomeExiste(string Nome)
        {
            SqlDataReader dr;

            bool ProdutoExiste = false;

            cmd.CommandText = "SELECT * FROM TB_PRODUTO WHERE nome = @nome ";

            cmd.Parameters.AddWithValue("@nome", Nome);
            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    ProdutoExiste = true;
                }

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB02P", e.Message);
                TelaErro.Show();
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ProdutoExiste;
        }

        //EDITAR
        public bool Editar(string Nome, string Tema, string Preco, string Quantidade, int InformarQuantidade, string Fornecedor, string Data, string Descricao, string Id)
        {
            try
            {
                cmd.CommandText = "UPDATE TB_PRODUTO SET nome = @nome, tema = @tema, preco = @preco, quantidade = @quantidade, informar_quantidade = @InformarQuantidade ,fornecedor = @fornecedor, data = @data, descricao = @descricao  WHERE id = @id";

                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@tema", Tema);
                cmd.Parameters.AddWithValue("@preco", Preco);
                cmd.Parameters.AddWithValue("@quantidade", Quantidade);
                cmd.Parameters.AddWithValue("@InformarQuantidade", InformarQuantidade);
                cmd.Parameters.AddWithValue("@fornecedor", Fornecedor);
                cmd.Parameters.AddWithValue("@data", Data);
                cmd.Parameters.AddWithValue("@descricao", Descricao);
                cmd.Parameters.AddWithValue("@id", Id);


                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return true;
            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB03P", e.Message);
                TelaErro.Show();
                return false;
            }



        }

        //APAGAR
        public bool Apagar(string Id)
        {

            cmd.CommandText = "DELETE FROM TB_PRODUTO WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", Id);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();

                return true;
            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB04P", e.Message);
                TelaErro.Show();
                return false;
            }



        }

        //ALTERA QUANTIDADE DO PRODUTO
        public void AlteraQuantidade(string Nome, string Quantidade)
        {
            try
            {
                cmd.CommandText = "UPDATE TB_PRODUTO SET quantidade = @quantidade WHERE nome = @nome";

                cmd.Parameters.AddWithValue("@quantidade", Quantidade);
                cmd.Parameters.AddWithValue("@nome", Nome);


                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB05P", e.Message);
                TelaErro.Show();
            }

        }

        //EXIBIR DETALHES DO PRODUTO
        public List<ProdutoModel> ListarTodosOsProdutos()
        {
            SqlDataReader dr;
            List<ProdutoModel> ListadeProduto = new List<ProdutoModel>();
            try
            {

                cmd.CommandText = "SELECT * FROM TB_PRODUTO";

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        var produtoM = new ProdutoModel();

                        produtoM.Nome = Convert.ToString(dr["nome"]);
                        produtoM.Tema = Convert.ToString(dr["tema"]);
                        produtoM.Preco = Convert.ToString(dr["preco"]);
                        produtoM.QuantidadeEstoque = Convert.ToString(dr["quantidade"]);
                        produtoM.InformarQuantidade = Convert.ToString(dr["informar_quantidade"]);
                        produtoM.Fornecedor = Convert.ToString(dr["fornecedor"]);
                        produtoM.Data = Convert.ToString(dr["data"]);
                        produtoM.Descricao = Convert.ToString(dr["descricao"]);
                        produtoM.Id = Convert.ToInt32(dr["id"]);

                        ListadeProduto.Add(produtoM);
                    }


                }

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB06P", e.Message);
                TelaErro.Show();
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeProduto;
        }

        //EXIBIR DETALHES DO PRODUTO
        public ProdutoModel ExibirDetalhesdoProduto(string Id)
        {
            SqlDataReader dr;
            var produtoM = new ProdutoModel();

            try
            {
                cmd.CommandText = "SELECT * FROM TB_PRODUTO WHERE id = @id";

                cmd.Parameters.AddWithValue("@id", Id);

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var ID = dr["id"];
                    var NOME = dr["nome"];
                    var TEMA = dr["tema"];
                    var PRECO = dr["preco"];
                    var QUANTIDADE = dr["quantidade"];
                    var INFOQUANTIDADE = dr["informar_quantidade"];
                    var FORNECEDOR = dr["fornecedor"];
                    var DATA = dr["data"];
                    var DESCRICAO = dr["descricao"];

                    produtoM.Id = Convert.ToInt32(ID);
                    produtoM.Nome = Convert.ToString(NOME);
                    produtoM.Tema = Convert.ToString(TEMA);
                    produtoM.Preco = Convert.ToString(PRECO);
                    produtoM.QuantidadeEstoque = Convert.ToString(QUANTIDADE);
                    produtoM.InformarQuantidade = Convert.ToString(INFOQUANTIDADE);
                    produtoM.Fornecedor = Convert.ToString(FORNECEDOR);
                    produtoM.Data = Convert.ToString(DATA);
                    produtoM.Descricao = Convert.ToString(DESCRICAO);

                }

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB07P", e.Message);
                TelaErro.Show();
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return produtoM;
        }

        //EXIBIR DETALHES DO PRODUTO
        public ProdutoModel ExibirProdutoPorNome(string Nome)
        {
            SqlDataReader dr;

            var produtoM = new ProdutoModel();

            try
            {

                cmd.CommandText = "SELECT * FROM TB_PRODUTO WHERE nome = @nome ";
                cmd.Parameters.AddWithValue("@nome", Nome);

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    dr.Read();

                    var ID = dr["id"];
                    var NOME = dr["nome"];
                    var TEMA = dr["tema"];
                    var PRECO = dr["preco"];
                    var QUANTIDADE = dr["quantidade"];
                    var INFOQUANTIDADE = dr["informar_quantidade"];
                    var FORNECEDOR = dr["fornecedor"];
                    var DATA = dr["data"];
                    var DESCRICAO = dr["descricao"];

                    produtoM.Id = Convert.ToInt32(ID);
                    produtoM.Nome = Convert.ToString(NOME);
                    produtoM.Tema = Convert.ToString(TEMA);
                    produtoM.Preco = Convert.ToString(PRECO);
                    produtoM.QuantidadeEstoque = Convert.ToString(QUANTIDADE);
                    produtoM.InformarQuantidade = Convert.ToString(INFOQUANTIDADE);
                    produtoM.Fornecedor = Convert.ToString(FORNECEDOR);
                    produtoM.Data = Convert.ToString(DATA);
                    produtoM.Descricao = Convert.ToString(DESCRICAO);

                }

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB08P", e.Message);
                TelaErro.Show();
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return produtoM;
        }

        //EXIBIR DETALHES DO PRODUTO
        public List<ProdutoModel> ExibirDetalhesdoProdutoPorNome(string Nome)
        {
            SqlDataReader dr;

            var Listproduto = new List<ProdutoModel>();

            try
            {

                cmd.CommandText = "SELECT * FROM TB_PRODUTO WHERE nome LIKE '%" + Nome + "%' ";

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.HasRows)
                {
                    try
                    {
                        dr.Read();

                        var ID = dr["id"];
                        var NOME = dr["nome"];
                        var TEMA = dr["tema"];
                        var PRECO = dr["preco"];
                        var QUANTIDADE = dr["quantidade"];
                        var INFOQUANTIDADE = dr["informar_quantidade"];
                        var FORNECEDOR = dr["fornecedor"];
                        var DATA = dr["data"];
                        var DESCRICAO = dr["descricao"];

                        var produtoM = new ProdutoModel();

                        produtoM.Id = Convert.ToInt32(ID);
                        produtoM.Nome = Convert.ToString(NOME);
                        produtoM.Tema = Convert.ToString(TEMA);
                        produtoM.Preco = Convert.ToString(PRECO);
                        produtoM.QuantidadeEstoque = Convert.ToString(QUANTIDADE);
                        produtoM.InformarQuantidade = Convert.ToString(INFOQUANTIDADE);
                        produtoM.Fornecedor = Convert.ToString(FORNECEDOR);
                        produtoM.Data = Convert.ToString(DATA);
                        produtoM.Descricao = Convert.ToString(DESCRICAO);

                        Listproduto.Add(produtoM);
                    }
                    catch (Exception)
                    {
                        break;
                    }

                }

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB08P", e.Message);
                TelaErro.Show();
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return Listproduto;
        }

        //EXIBIR DETALHES DO PRODUTO
        public List<ProdutoModel> ExibirDetalhesdoProdutoPorTema(string Tema)
        {
            SqlDataReader dr;

            var Listproduto = new List<ProdutoModel>();

            cmd.CommandText = "SELECT * FROM TB_PRODUTO WHERE tema LIKE '%" + Tema + "%' ";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.HasRows)
                {
                    try
                    {
                        dr.Read();

                        var ID = dr["id"];
                        var NOME = dr["nome"];
                        var TEMA = dr["tema"];
                        var PRECO = dr["preco"];
                        var QUANTIDADE = dr["quantidade"];
                        var INFOQUANTIDADE = dr["informar_quantidade"];
                        var FORNECEDOR = dr["fornecedor"];
                        var DATA = dr["data"];
                        var DESCRICAO = dr["descricao"];

                        var produtoM = new ProdutoModel();

                        produtoM.Id = Convert.ToInt32(ID);
                        produtoM.Nome = Convert.ToString(NOME);
                        produtoM.Tema = Convert.ToString(TEMA);
                        produtoM.Preco = Convert.ToString(PRECO);
                        produtoM.QuantidadeEstoque = Convert.ToString(QUANTIDADE);
                        produtoM.InformarQuantidade = Convert.ToString(INFOQUANTIDADE);
                        produtoM.Fornecedor = Convert.ToString(FORNECEDOR);
                        produtoM.Data = Convert.ToString(DATA);
                        produtoM.Descricao = Convert.ToString(DESCRICAO);

                        Listproduto.Add(produtoM);
                    }
                    catch (Exception)
                    {
                        break;
                    }

                }

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB09P", e.Message);
                TelaErro.Show();
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return Listproduto;
        }

        //EXIBIR DETALHES DO PRODUTO POR QUANTIDADE
        public List<ProdutoModel> ListarTodosOsProdutosPorQuantidade()
        {
            SqlDataReader dr;
            var ListadeProduto = new List<ProdutoModel>();

            cmd.CommandText = "SELECT * FROM TB_PRODUTO ORDER BY quantidade";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        var produtoM = new ProdutoModel();

                        produtoM.Nome = Convert.ToString(dr["nome"]);
                        produtoM.Tema = Convert.ToString(dr["tema"]);
                        produtoM.Preco = Convert.ToString(dr["preco"]);
                        produtoM.QuantidadeEstoque = Convert.ToString(dr["quantidade"]);
                        produtoM.InformarQuantidade = Convert.ToString(dr["informar_quantidade"]);
                        produtoM.Fornecedor = Convert.ToString(dr["fornecedor"]);
                        produtoM.Data = Convert.ToString(dr["data"]);
                        produtoM.Descricao = Convert.ToString(dr["descricao"]);
                        produtoM.Id = Convert.ToInt32(dr["id"]);

                        ListadeProduto.Add(produtoM);
                    }


                }

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB10P", e.Message);
                TelaErro.Show();
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeProduto;
        }

        //EXIBIR DETALHES DO PRODUTO POR ID
        public List<ProdutoModel> ListarTodosOsProdutosPorCodigo()
        {
            SqlDataReader dr;
            List<ProdutoModel> ListadeProduto = new List<ProdutoModel>();
            try
            {
                cmd.CommandText = "SELECT * FROM TB_PRODUTO ORDER BY id";


                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        var produtoM = new ProdutoModel();

                        produtoM.Nome = Convert.ToString(dr["nome"]);
                        produtoM.Tema = Convert.ToString(dr["tema"]);
                        produtoM.Preco = Convert.ToString(dr["preco"]);
                        produtoM.QuantidadeEstoque = Convert.ToString(dr["quantidade"]);
                        produtoM.InformarQuantidade = Convert.ToString(dr["informar_quantidade"]);
                        produtoM.Fornecedor = Convert.ToString(dr["fornecedor"]);
                        produtoM.Data = Convert.ToString(dr["data"]);
                        produtoM.Descricao = Convert.ToString(dr["descricao"]);
                        produtoM.Id = Convert.ToInt32(dr["id"]);

                        ListadeProduto.Add(produtoM);
                    }


                }

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB11P", e.Message);
                TelaErro.Show();
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeProduto;
        }

        //EXIBIR DETALHES DO PRODUTO POR NOME
        public List<ProdutoModel> ListarTodosOsProdutosPorNome()
        {
            SqlDataReader dr;
            var ListadeProduto = new List<ProdutoModel>();

            try
            {
                cmd.CommandText = "SELECT * FROM TB_PRODUTO ORDER BY nome";


                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        var produtoM = new ProdutoModel();

                        produtoM.Nome = Convert.ToString(dr["nome"]);
                        produtoM.Tema = Convert.ToString(dr["tema"]);
                        produtoM.Preco = Convert.ToString(dr["preco"]);
                        produtoM.QuantidadeEstoque = Convert.ToString(dr["quantidade"]);
                        produtoM.InformarQuantidade = Convert.ToString(dr["informar_quantidade"]);
                        produtoM.Fornecedor = Convert.ToString(dr["fornecedor"]);
                        produtoM.Data = Convert.ToString(dr["data"]);
                        produtoM.Descricao = Convert.ToString(dr["descricao"]);
                        produtoM.Id = Convert.ToInt32(dr["id"]);

                        ListadeProduto.Add(produtoM);
                    }


                }

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB12P", e.Message);
                TelaErro.Show();
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeProduto;
        }

        //EXIBIR DETALHES DO PRODUTO POR DATA
        public List<ProdutoModel> ListarTodosOsProdutosPorData()
        {
            SqlDataReader dr;
            var ListadeProduto = new List<ProdutoModel>();

            try
            {
                cmd.CommandText = "SELECT * FROM TB_PRODUTO ORDER BY data";


                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        var produtoM = new ProdutoModel();

                        produtoM.Nome = Convert.ToString(dr["nome"]);
                        produtoM.Tema = Convert.ToString(dr["tema"]);
                        produtoM.Preco = Convert.ToString(dr["preco"]);
                        produtoM.QuantidadeEstoque = Convert.ToString(dr["quantidade"]);
                        produtoM.InformarQuantidade = Convert.ToString(dr["informar_quantidade"]);
                        produtoM.Fornecedor = Convert.ToString(dr["fornecedor"]);
                        produtoM.Data = Convert.ToString(dr["data"]);
                        produtoM.Descricao = Convert.ToString(dr["descricao"]);
                        produtoM.Id = Convert.ToInt32(dr["id"]);

                        ListadeProduto.Add(produtoM);
                    }


                }

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB13P", e.Message);
                TelaErro.Show();
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeProduto;
        }

        //EXIBIR DETALHES DO PRODUTO POR TEMA
        public List<ProdutoModel> ListarTodosOsProdutosPorTema()
        {
            SqlDataReader dr;
            var ListadeProduto = new List<ProdutoModel>();

            try
            {

                cmd.CommandText = "SELECT * FROM TB_PRODUTO ORDER BY tema";

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        var produtoM = new ProdutoModel();

                        produtoM.Nome = Convert.ToString(dr["nome"]);
                        produtoM.Tema = Convert.ToString(dr["tema"]);
                        produtoM.Preco = Convert.ToString(dr["preco"]);
                        produtoM.QuantidadeEstoque = Convert.ToString(dr["quantidade"]);
                        produtoM.InformarQuantidade = Convert.ToString(dr["informar_quantidade"]);
                        produtoM.Fornecedor = Convert.ToString(dr["fornecedor"]);
                        produtoM.Data = Convert.ToString(dr["data"]);
                        produtoM.Descricao = Convert.ToString(dr["descricao"]);
                        produtoM.Id = Convert.ToInt32(dr["id"]);

                        ListadeProduto.Add(produtoM);
                    }


                }

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB14P", e.Message);
                TelaErro.Show();
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeProduto;
        }


    }
}
