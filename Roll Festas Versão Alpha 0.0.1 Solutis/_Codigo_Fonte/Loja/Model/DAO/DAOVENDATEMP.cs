using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Loja.Model
{
    class DAOVENDATEMP
    {
        _Conexao conexao = new _Conexao();
        SqlCommand cmd = new SqlCommand();

        public void ZerarTabela()
        {
            cmd.CommandText = "DELETE FROM TB_VENDA_TEMP";

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao zerar tabela de vendas, reinicie o programa.");
            }
            conexao.Desconectar();

        }//ZERAR TABELA TEMPORAIA DE VENDAS
        public void PreparaBanco(String nome, String quantidade)
        {

            cmd.CommandText = "INSERT INTO TB_VENDA_TEMP (nome,quantidade) VALUES (@nome,@quantidade)";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro na tabela TEMP Erro:  " + e);
            }

        }//INSERIR NOME DO PRODUTO E QUANTIDADE - E DEIXA GUARDADO
        public void PreparaBancoItemNovos(String nome, String quantidade)
        {
            cmd.CommandText = "INSERT INTO TB_VENDA_TEMP (decrementa_nome,decrementa_quantidade) VALUES (@nome,@quantidade)";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro na tabela TEMP Erro:  " + e);
            }

        }//INSERIR NOME DO PRODUTO E QUANTIDADE - E DEIXA GUARDADO PARA RETIRAR DO ESTOQUE
        public void PreparaBancoItemAntigos(String nome, String quantidade)
        {

            cmd.CommandText = "INSERT INTO TB_VENDA_TEMP (acrescenta_nome,acrescenta_quantidade) VALUES (@nome,@quantidade)";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro na tabela TEMP Erro:  " + e);
            }

        }//INSERIR NOME DO PRODUTO E QUANTIDADE - E DEIXA GUARDADO PARA ADICIONAR NO ESTOQUE
        public List<ProdutoModel> PegadoBanco()
        {
            SqlDataReader dr;
            List<ProdutoModel> list = new List<ProdutoModel>();

            cmd.CommandText = "SELECT nome, quantidade FROM TB_VENDA_TEMP";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.HasRows)
                {
                    try
                    {
                        ProdutoModel produto = new ProdutoModel();
                        dr.Read();

                        var nomedoBanco = dr["nome"];
                        var quantidadedoBanco = dr["quantidade"];


                        produto.Nome = Convert.ToString(nomedoBanco);
                        produto.Quantidade = Convert.ToString(quantidadedoBanco);

                        list.Add(produto);
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

            return list;
        }//PEGA NOME QUANTIDADE
        public void DecrementaBanco(List<ProdutoModel> list)
        {
            DAOProduto daop = new DAOProduto();
            ProdutoModel pm = new ProdutoModel();

            foreach (var p in list)
            {

                pm = daop.PegaQuantidadePeloNome(p.Nome);

                int novaquatidade = 0;
                novaquatidade = Convert.ToInt32(pm.Quantidade) - Convert.ToInt32(p.Quantidade);

                daop.DecrementaQuantidade(p.Nome, Convert.ToString(novaquatidade));

            }
        }//RETIRA PRODUTOS DO BANCO
        public void AcrescentaBanco(List<ProdutoModel> list)
        {
            DAOProduto daop = new DAOProduto();
            ProdutoModel pm = new ProdutoModel();

            foreach (var p in list)
            {

                pm = daop.PegaQuantidadePeloNome(p.Nome);


                int novaquatidade = 0;
                novaquatidade = Convert.ToInt32(pm.Quantidade) + Convert.ToInt32(p.Quantidade);

                daop.DecrementaQuantidade(p.Nome, Convert.ToString(novaquatidade));

            }
        }//ACRESCENTA PRODUTOS DO BANCO
        public List<ProdutoModel> PegadoBancoItemNovo()
        {
            SqlDataReader dr;

            List<ProdutoModel> list = new List<ProdutoModel>();

            cmd.CommandText = "SELECT decrementa_nome, decrementa_quantidade FROM TB_VENDA_TEMP";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.HasRows)
                {
                    try
                    {
                        ProdutoModel produto = new ProdutoModel();
                        dr.Read();

                        String nomedoBanco = Convert.ToString( dr["decrementa_nome"]);
                        String quantidadedoBanco = Convert.ToString( dr["decrementa_quantidade"]);


                        if (!String.IsNullOrEmpty(nomedoBanco) && !String.IsNullOrEmpty(quantidadedoBanco))
                        {
                            produto.Nome = Convert.ToString(nomedoBanco);
                            produto.Quantidade = Convert.ToString(quantidadedoBanco);

                            list.Add(produto);
                        }
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

            return list;
        }//PEGA NOME QUANTIDADE DO BANCO QUE DEVEM SER RETIRADO
        public List<ProdutoModel> PegadoBancoItemAntigo()
        {
            SqlDataReader dr;

            List<ProdutoModel> list = new List<ProdutoModel>();

            cmd.CommandText = "SELECT acrescenta_nome, acrescenta_quantidade FROM TB_VENDA_TEMP";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.HasRows)
                {
                    try
                    {
                        ProdutoModel produto = new ProdutoModel();
                        dr.Read();

                        String nomedoBanco = Convert.ToString( dr["acrescenta_nome"]);
                        String quantidadedoBanco = Convert.ToString(dr["acrescenta_quantidade"]);

                        if (!String.IsNullOrEmpty(nomedoBanco) && !String.IsNullOrEmpty(quantidadedoBanco))
                        {
                            produto.Nome = Convert.ToString(nomedoBanco);
                            produto.Quantidade = Convert.ToString(quantidadedoBanco);

                            list.Add(produto);
                        }

                       
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

            return list;
        }//PEGA NOME QUANTIDADE DO BANCO QUE DEVEM SER ADICIONADO

    }
}
