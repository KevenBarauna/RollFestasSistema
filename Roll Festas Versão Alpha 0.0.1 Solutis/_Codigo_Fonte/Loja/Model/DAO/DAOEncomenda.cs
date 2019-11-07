using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.Model
{
    class DAOEncomenda
    {

        _Conexao conexao = new _Conexao();
        SqlCommand cmd = new SqlCommand();


        public void NovaEncomenda(String tipo, String data_entrada, String data_enrega, String tema, String quantidade, String valor, String obs)
        {

            cmd.CommandText = "INSERT INTO TB_ENCOMENDA (tipo_servico,data_entrada,data_entrega,tema,quantidade,valor,obs) VALUES (@tipo,@data_entrada,@data_entrega,@tema,@quantidade,@valor,@obs)";

            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@data_entrada", data_entrada);
            cmd.Parameters.AddWithValue("@data_entrega", data_enrega);
            cmd.Parameters.AddWithValue("@tema", tema);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@obs", obs);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("Encomanda cadastrada com sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao cadastrar encomenda. Erro:  " + e);
            }

        }//INSERIR

        public EncomendaModel ExibirDetalhesdoDaEncomenda(String id)
        {
            SqlDataReader dr;
            EncomendaModel encomenda = new EncomendaModel();

            cmd.CommandText = "SELECT * FROM TB_ENCOMENDA WHERE id = @id";

            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var iddoBanco = dr["id"];
                    var tipodoBanco = dr["tipo_servico"];
                    var dataEntradadoBanco = dr["data_entrada"];
                    var dataEntregadoBanco = dr["data_entrega"];
                    var temadoBanco = dr["tema"];
                    var quantidadedoBanco = dr["quantidade"];
                    var valorBanco = dr["valor"];
                    var obgdoBanco = dr["obs"];

                    encomenda.Id = Convert.ToInt32(iddoBanco);
                    encomenda.TipoServico = Convert.ToString(tipodoBanco);
                    encomenda.DataEntrada = Convert.ToString(dataEntradadoBanco);
                    encomenda.DataEntrega = Convert.ToString(dataEntregadoBanco);
                    encomenda.Tema = Convert.ToString(temadoBanco);
                    encomenda.Quantidade = Convert.ToString(quantidadedoBanco);
                    encomenda.Valor = Convert.ToString(valorBanco);
                    encomenda.Descricao = Convert.ToString(obgdoBanco);

                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return encomenda;
        }//EXIBIR DETALHES

        public void EditarEncomenda(String tipo, String data_entrada, String data_entrega, String tema, String quantidade, String valor, String obs, String id)
        {

            cmd.CommandText = "UPDATE TB_ENCOMENDA SET tipo_servico = @tipo, data_entrada = @data_entrada, data_entrega = @data_entrega, tema = @tema, quantidade = @quantidade, valor = @valor, obs = @obs  WHERE id = @id";

            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@data_entrada", data_entrada);
            cmd.Parameters.AddWithValue("@data_entrega", data_entrega);
            cmd.Parameters.AddWithValue("@tema", tema);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@obs", obs);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("Encomenda editada com sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao editar encomenda. Erro:  " + e);
            }


            cmd.Parameters.Clear();
        }//UPDATE

        public void ApagarEncomenda(String id)
        {

            cmd.CommandText = "DELETE FROM TB_ENCOMENDA WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("Encomenda apagada com sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao apagar encomenda. Erro:  " + e);
            }


            cmd.Parameters.Clear();
        }//APAGAR PRODUTO

        public List<EncomendaModel> ListarTodasAsEncomendas()
        {
            SqlDataReader dr;
            List<EncomendaModel> ListadeEncomenda = new List<EncomendaModel>();

            cmd.CommandText = "SELECT * FROM TB_ENCOMENDAS";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        EncomendaModel encomandaL = new EncomendaModel();
                        var iddoBanco = dr["id"];
                        var tipodoBanco = dr["tipo_servico"];
                        var dataEntradadoBanco = dr["data_entrada"];
                        var dataEntregadoBanco = dr["data_entrega"];
                        var temadoBanco = dr["tema"];
                        var valorBanco = dr["valor"];
                        var obgdoBanco = dr["obs"];

                        ListadeEncomenda.Add(encomandaL);
                    }


                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeEncomenda;
        }//RETORNA TODOS OS PRODUTOS

        public List<EncomendaModel> ListarTodasAsEncomendasPorData()
        {
            SqlDataReader dr;
            List<EncomendaModel> ListadeEncomenda = new List<EncomendaModel>();

            cmd.CommandText = "SELECT * FROM TB_ENCOMENDA ORDER BY data_entrega";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        EncomendaModel encomandaL = new EncomendaModel();
                        var iddoBanco = dr["id"];
                        var tipodoBanco = dr["tipo_servico"];
                        var dataEntradadoBanco = dr["data_entrada"];
                        var dataEntregadoBanco = dr["data_entrega"];
                        var temadoBanco = dr["tema"];
                        var valorBanco = dr["valor"];
                        var obsdoBanco = dr["obs"];


                        encomandaL.Id = Convert.ToInt32(iddoBanco);
                        encomandaL.TipoServico = Convert.ToString(tipodoBanco);
                        encomandaL.DataEntrada = Convert.ToString(dataEntradadoBanco);
                        encomandaL.DataEntrega = Convert.ToString(dataEntregadoBanco);
                        encomandaL.Tema = Convert.ToString(temadoBanco);
                        encomandaL.Valor = Convert.ToString(valorBanco);
                        encomandaL.Descricao = Convert.ToString(obsdoBanco);


                        ListadeEncomenda.Add(encomandaL);
                    }


                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeEncomenda;
        }//RETORNA TODOS OS PRODUTOS
    }
}
