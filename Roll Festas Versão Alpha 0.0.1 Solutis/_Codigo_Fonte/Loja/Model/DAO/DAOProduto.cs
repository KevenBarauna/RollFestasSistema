using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.Model
{
    public class DAOProduto
    {

        _Conexao conexao = new _Conexao();
        SqlCommand cmd = new SqlCommand();

        public void InserirProduto(String nome, String tema, String preco, String quantidade, String fornecedor, String data, String descricao)
        {

            cmd.CommandText = "INSERT INTO TB_PRODUTO (nome,tema,preco,quantidade,fornecedor,data,descricao) VALUES (@nome,@tema,@preco,@quantidade,@fornecedor,@data,@descricao)";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@tema", tema);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@fornecedor", fornecedor);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@descricao", descricao);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao cadastrar produto. Erro:  " + e);
            }

        }//INSERIR PROUTO

        public ProdutoModel ExibirDetalhesdoProduto(String id)
        {
            SqlDataReader dr;
            ProdutoModel produto = new ProdutoModel();

            cmd.CommandText = "SELECT * FROM TB_PRODUTO WHERE id = @id";

            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var iddoBanco = dr["id"];
                    var nomedoBanco = dr["nome"];
                    var temadoBanco = dr["tema"];
                    var precodoBanco = dr["preco"];
                    var quantidadedoBanco = dr["quantidade"];
                    var fornecedordoBanco = dr["fornecedor"];
                    var datadoBanco = dr["data"];
                    var descricaodoBanco = dr["descricao"];

                    produto.Id = Convert.ToInt32(iddoBanco);
                    produto.Nome = Convert.ToString(nomedoBanco);
                    produto.Tema = Convert.ToString(temadoBanco);
                    produto.Preco = Convert.ToString(precodoBanco);
                    produto.Quantidade = Convert.ToString(quantidadedoBanco);
                    produto.Fornecedor = Convert.ToString(fornecedordoBanco);
                    produto.Data = Convert.ToString(datadoBanco);
                    produto.Descricao = Convert.ToString(descricaodoBanco);

                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return produto;
        }//EXIBIR DETALHES DE UM PRODUTO

        public List<ProdutoModel> ExibirDetalhesdoProdutoPorNome(String nome)
        {
            SqlDataReader dr;
            
            List<ProdutoModel> Lproduto = new List<ProdutoModel>();

            cmd.CommandText = "select * from TB_PRODUTO where nome LIKE '%" + nome + "%' ";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                while(dr.HasRows)
                {
                    try
                    {
                        dr.Read();

                        var iddoBanco = dr["id"];
                        var nomedoBanco = dr["nome"];
                        var precodoBanco = dr["preco"];

                        ProdutoModel produto = new ProdutoModel();
                        produto.Id = Convert.ToInt32(iddoBanco);
                        produto.Nome = Convert.ToString(nomedoBanco);
                        produto.Preco = Convert.ToString(precodoBanco);

                        Lproduto.Add(produto);
                    }
                    catch (Exception)
                    {
                        break;
                    }
                   
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return Lproduto;
        }//EXIBIR DETALHES DE UM PRODUTO PELO NOME (%LIKE%)

        public List<ProdutoModel> ExibirDetalhesdoProdutoPorTema(String tema)
        {
            SqlDataReader dr;

            List<ProdutoModel> Lproduto = new List<ProdutoModel>();

            cmd.CommandText = "select * from TB_PRODUTO where tema LIKE '%" + tema + "%' ";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.HasRows)
                {
                    try
                    {
                        dr.Read();

                        var iddoBanco = dr["id"];
                        var nomedoBanco = dr["nome"];
                        var precodoBanco = dr["preco"];

                        ProdutoModel produto = new ProdutoModel();
                        produto.Id = Convert.ToInt32(iddoBanco);
                        produto.Nome = Convert.ToString(nomedoBanco);
                        produto.Preco = Convert.ToString(precodoBanco);

                        Lproduto.Add(produto);
                    }
                    catch (Exception)
                    {
                        break;
                    }

                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return Lproduto;
        }//EXIBIR DETALHES DE UM PRODUTO PELO NOME (%LIKE%)

        public bool VerificaSeNomeExiste(String nome)
        {
            SqlDataReader dr;

            bool ProdutoExiste = false;

            cmd.CommandText = "select * from TB_PRODUTO where nome = @nome ";

            cmd.Parameters.AddWithValue("@nome", nome);
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
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ProdutoExiste;
        }//VERIFICA SE EXISTE PRODUTO COM ESSE NOME

        public void EditarProduto(String nome, String tema, String preco, String quantidade, String fornecedor, String data, String descricao, int id)
        {

            cmd.CommandText = "UPDATE TB_PRODUTO SET nome = @nome, tema = @tema, preco = @preco, quantidade = @quantidade, fornecedor = @fornecedor, data = @data, descricao = @descricao  WHERE id = @id";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@tema", tema);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@fornecedor", fornecedor);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("Produto editado com sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao editar produto. Erro:  " + e);
            }



        }//UPDATE DE PROUTO

        public void ApagarProduto(int id)
        {

            cmd.CommandText = "DELETE FROM TB_PRODUTO WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("Produto apagado com sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao apagar produto. Erro:  " + e);
            }



        }//APAGAR PRODUTO

        public List<ProdutoModel> ListarTodosOsProdutos()
        {
            SqlDataReader dr;
            List<ProdutoModel> ListadeProduto = new List<ProdutoModel>();

            cmd.CommandText = "SELECT * FROM TB_PRODUTO";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        ProdutoModel produtoL = new ProdutoModel();
                        produtoL.Nome = Convert.ToString(dr["nome"]);
                        produtoL.Tema = Convert.ToString(dr["tema"]);
                        produtoL.Preco = Convert.ToString(dr["preco"]);
                        produtoL.Quantidade = Convert.ToString(dr["quantidade"]);
                        produtoL.Fornecedor = Convert.ToString(dr["fornecedor"]);
                        produtoL.Data = Convert.ToString(dr["data"]);
                        produtoL.Descricao = Convert.ToString(dr["descricao"]);
                        produtoL.Id = Convert.ToInt32( dr["id"]);

                        ListadeProduto.Add(produtoL);
                    }


                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeProduto;
        }//RETORNA TODOS OS PRODUTOS

        public ProdutoModel PegaQuantidadePeloNome(String nome)
        {
            SqlDataReader dr;
            ProdutoModel produto = new ProdutoModel();

            cmd.CommandText = "SELECT * FROM TB_PRODUTO WHERE nome = @nome";

            cmd.Parameters.AddWithValue("@nome", nome);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var quantidadedoBanco = dr["quantidade"];


                    produto.Quantidade = Convert.ToString(quantidadedoBanco);


                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro PegaIdPeloNome:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return produto;
        }//PEGA QUANTIDADE PELO NOME

        public void DecrementaQuantidade(String nome, String quantidade)
        {
            cmd.CommandText = "UPDATE TB_PRODUTO SET quantidade = @quantidade WHERE nome = @nome";

            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@nome", nome);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao decrementar produto. Erro:  " + e);
            }

        }//RETIRA VALOR VENDIDO DO PRODUTO


        public List<ProdutoModel> ListarTodosOsProdutosPorCodigo()
        {
            SqlDataReader dr;
            List<ProdutoModel> ListadeProduto = new List<ProdutoModel>();

            cmd.CommandText = "SELECT * FROM TB_PRODUTO ORDER BY id";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        ProdutoModel produtoL = new ProdutoModel();
                        produtoL.Nome = Convert.ToString(dr["nome"]);
                        produtoL.Tema = Convert.ToString(dr["tema"]);
                        produtoL.Preco = Convert.ToString(dr["preco"]);
                        produtoL.Quantidade = Convert.ToString(dr["quantidade"]);
                        produtoL.Fornecedor = Convert.ToString(dr["fornecedor"]);
                        produtoL.Data = Convert.ToString(dr["data"]);
                        produtoL.Descricao = Convert.ToString(dr["descricao"]);
                        produtoL.Id = Convert.ToInt32(dr["id"]);

                        ListadeProduto.Add(produtoL);
                    }


                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeProduto;
        }//RETORNA TODOS OS PRODUTOS POR ID

        public List<ProdutoModel> ListarTodosOsProdutosPorNome()
        {
            SqlDataReader dr;
            List<ProdutoModel> ListadeProduto = new List<ProdutoModel>();

            cmd.CommandText = "SELECT * FROM TB_PRODUTO ORDER BY nome";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        ProdutoModel produtoL = new ProdutoModel();
                        produtoL.Nome = Convert.ToString(dr["nome"]);
                        produtoL.Tema = Convert.ToString(dr["tema"]);
                        produtoL.Preco = Convert.ToString(dr["preco"]);
                        produtoL.Quantidade = Convert.ToString(dr["quantidade"]);
                        produtoL.Fornecedor = Convert.ToString(dr["fornecedor"]);
                        produtoL.Data = Convert.ToString(dr["data"]);
                        produtoL.Descricao = Convert.ToString(dr["descricao"]);
                        produtoL.Id = Convert.ToInt32(dr["id"]);

                        ListadeProduto.Add(produtoL);
                    }


                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeProduto;
        }//RETORNA TODOS OS PRODUTOS  POR NOME

        public List<ProdutoModel> ListarTodosOsProdutosPorData()
        {
            SqlDataReader dr;
            List<ProdutoModel> ListadeProduto = new List<ProdutoModel>();

            cmd.CommandText = "SELECT * FROM TB_PRODUTO ORDER BY data";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        ProdutoModel produtoL = new ProdutoModel();
                        produtoL.Nome = Convert.ToString(dr["nome"]);
                        produtoL.Tema = Convert.ToString(dr["tema"]);
                        produtoL.Preco = Convert.ToString(dr["preco"]);
                        produtoL.Quantidade = Convert.ToString(dr["quantidade"]);
                        produtoL.Fornecedor = Convert.ToString(dr["fornecedor"]);
                        produtoL.Data = Convert.ToString(dr["data"]);
                        produtoL.Descricao = Convert.ToString(dr["descricao"]);
                        produtoL.Id = Convert.ToInt32(dr["id"]);

                        ListadeProduto.Add(produtoL);
                    }


                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeProduto;
        }//RETORNA TODOS OS PRODUTOS  POR DATA

        public List<ProdutoModel> ListarTodosOsProdutosPorTema()
        {
            SqlDataReader dr;
            List<ProdutoModel> ListadeProduto = new List<ProdutoModel>();

            cmd.CommandText = "SELECT * FROM TB_PRODUTO ORDER BY tema";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        ProdutoModel produtoL = new ProdutoModel();
                        produtoL.Nome = Convert.ToString(dr["nome"]);
                        produtoL.Tema = Convert.ToString(dr["tema"]);
                        produtoL.Preco = Convert.ToString(dr["preco"]);
                        produtoL.Quantidade = Convert.ToString(dr["quantidade"]);
                        produtoL.Fornecedor = Convert.ToString(dr["fornecedor"]);
                        produtoL.Data = Convert.ToString(dr["data"]);
                        produtoL.Descricao = Convert.ToString(dr["descricao"]);
                        produtoL.Id = Convert.ToInt32(dr["id"]);

                        ListadeProduto.Add(produtoL);
                    }


                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeProduto;
        }//RETORNA TODOS OS PRODUTOS  POR TEMA

    }


}

