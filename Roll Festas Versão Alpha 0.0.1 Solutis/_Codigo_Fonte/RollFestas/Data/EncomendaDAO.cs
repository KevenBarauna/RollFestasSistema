using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RollFestas.Models;
using RollFestas.Services;
using RollFestas.View.MensagemErro;

namespace RollFestas.Data
{
    class EncomendaDAO
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        //CADASTRAR NOVA ENCOMENDA
        public bool NovaEncomenda(string Tipo, string DataEncomenda, string DataEntrega, string Tema, int Entregue ,string Quantidade, string Valor, string Descricao, string NomeCliente)
        {
            try
            {
                cmd.CommandText = "INSERT INTO TB_ENCOMENDA (tipo_servico,data_entrada,data_entrega,entregue,tema,quantidade,valor,descricao,nomecliente) VALUES (@tipo,@data_entrada,@data_entrega,@entregue,@tema,@quantidade,@valor,@descricao,@nomecliente)";

                cmd.Parameters.AddWithValue("@tipo", Tipo);
                cmd.Parameters.AddWithValue("@data_entrada", DataEncomenda);
                cmd.Parameters.AddWithValue("@data_entrega", DataEntrega);
                cmd.Parameters.AddWithValue("@tema", Tema);
                cmd.Parameters.AddWithValue("@entregue", Entregue);
                cmd.Parameters.AddWithValue("@quantidade", Quantidade);
                cmd.Parameters.AddWithValue("@valor", Valor);
                cmd.Parameters.AddWithValue("@descricao", Descricao);
                cmd.Parameters.AddWithValue("@nomecliente", NomeCliente);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB01E", e.Message);
                TelaErro.Show();
                return false;
            }
            return true;
        }

        //EXIBIR PRODUTO
        public EncomendaModel ExibirDetalhesdoDaEncomenda(string Id)
        {
            var encomendaM = new EncomendaModel();

            try
            {
                SqlDataReader dr;

                cmd.CommandText = "SELECT * FROM TB_ENCOMENDA WHERE id = @id";

                cmd.Parameters.AddWithValue("@id", Id);

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var ID = dr["id"];
                    var TIPO = dr["tipo_servico"];
                    var ENTRADA = dr["data_entrada"];
                    var ENTREGA = dr["data_entrega"];
                    var ENTREGE = dr["entregue"];
                    var TEMA = dr["tema"];
                    var QUANTIDADE = dr["quantidade"];
                    var VALOR = dr["valor"];
                    var DESCRICAO = dr["descricao"];
                    var NOMECLIENTE = dr["nomecliente"];

                    encomendaM.Id = Convert.ToInt32(ID);
                    encomendaM.TipoServico = Convert.ToString(TIPO);
                    encomendaM.DataEntrada = Convert.ToString(ENTRADA);
                    encomendaM.DataEntrega = Convert.ToString(ENTREGA);
                    encomendaM.Entregue = Convert.ToInt32(ENTREGE);
                    encomendaM.Tema = Convert.ToString(TEMA);
                    encomendaM.Quantidade = Convert.ToString(QUANTIDADE);
                    encomendaM.Valor = Convert.ToString(VALOR);
                    encomendaM.Descricao = Convert.ToString(DESCRICAO);
                    encomendaM.NomeCliente = Convert.ToString(NOMECLIENTE);

                }

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB02E", e.Message);
                TelaErro.Show();
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return encomendaM;
        }

        //EDITAR ENCOMENDA
        public bool EditarEncomenda(string Tipo, string DataEntrada, string DataEntrega, string Tema, string Quantidade, string Valor, string Descricao,int Entregue, string Id)
        {
            try
            {

                cmd.CommandText = "UPDATE TB_ENCOMENDA SET tipo_servico = @tipo, data_entrada = @data_entrada, data_entrega = @data_entrega, tema = @tema, quantidade = @quantidade, valor = @valor, descricao = @descricao, entregue = @entregue  WHERE id = @id";

                cmd.Parameters.AddWithValue("@tipo", Tipo);
                cmd.Parameters.AddWithValue("@data_entrada", DataEntrada);
                cmd.Parameters.AddWithValue("@data_entrega", DataEntrega);
                cmd.Parameters.AddWithValue("@tema", Tema);
                cmd.Parameters.AddWithValue("@quantidade", Quantidade);
                cmd.Parameters.AddWithValue("@valor", Valor);
                cmd.Parameters.AddWithValue("@descricao", Descricao);
                cmd.Parameters.AddWithValue("@entregue", Entregue);
                cmd.Parameters.AddWithValue("@id", Id);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB03V", e.Message);
                TelaErro.Show();
                return false;
            }

            return true;
        }

        //APAGAR PRODUTO
        public bool ApagarEncomenda(string Id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM TB_ENCOMENDA WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", Id);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB04E", e.Message);
                TelaErro.Show();
                return false;
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();
            return true;
        }

        //RETORNA TODOS OS PRODUTOS
        public List<EncomendaModel> ListarTodasAsEncomendas()
        {
            SqlDataReader dr;
            List<EncomendaModel> ListadeEncomenda = new List<EncomendaModel>();

            cmd.CommandText = "SELECT * FROM TB_ENCOMENDA";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        var encomendaM = new EncomendaModel();

                        var ID = dr["id"];
                        var TIPO = dr["tipo_servico"];
                        var ENTRADA = dr["data_entrada"];
                        var ENTREGA = dr["data_entrega"];
                        var ENTREGE = dr["entregue"];
                        var TEMA = dr["tema"];
                        var QUANTIDADE = dr["quantidade"];
                        var VALOR = dr["valor"];
                        var DESCRICAO = dr["descricao"];
                        var NOMECLIENTE = dr["descricao"];

                        encomendaM.Id = Convert.ToInt32(ID);
                        encomendaM.TipoServico = Convert.ToString(TIPO);
                        encomendaM.DataEntrada = Convert.ToString(ENTRADA);
                        encomendaM.DataEntrega = Convert.ToString(ENTREGA);
                        encomendaM.Entregue = Convert.ToInt32(ENTREGE);
                        encomendaM.Tema = Convert.ToString(TEMA);
                        encomendaM.Quantidade = Convert.ToString(QUANTIDADE);
                        encomendaM.Valor = Convert.ToString(VALOR);
                        encomendaM.Descricao = Convert.ToString(DESCRICAO);
                        encomendaM.NomeCliente = Convert.ToString(NOMECLIENTE);

                        ListadeEncomenda.Add(encomendaM);
                    }


                }

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB0EE", e.Message);
                TelaErro.Show();
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeEncomenda;
        }

        //RETORNA TODOS OS PRODUTOS POR ORDEM DE DATA
        public List<EncomendaModel> ListarTodasAsEncomendasPorData()
        {
            SqlDataReader dr;
            List<EncomendaModel> ListadeEncomenda = new List<EncomendaModel>();

            cmd.CommandText = "SELECT * FROM TB_ENCOMENDA  where entregue = 1 ORDER BY data_entrega";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        EncomendaModel encomendaM = new EncomendaModel();

                        var ID = dr["id"];
                        var TIPO = dr["tipo_servico"];
                        var ENTRADA = dr["data_entrada"];
                        var ENTREGA = dr["data_entrega"];
                        var ENTREGE = dr["entregue"];
                        var TEMA = dr["tema"];
                        var QUANTIDADE = dr["quantidade"];
                        var VALOR = dr["valor"];
                        var DESCRICAO = dr["descricao"];
                        var NOMECLIENTE = dr["nomecliente"];

                        encomendaM.Id = Convert.ToInt32(ID);
                        encomendaM.TipoServico = Convert.ToString(TIPO);
                        encomendaM.DataEntrada = Convert.ToString(ENTRADA);
                        encomendaM.DataEntrega = Convert.ToString(ENTREGA);
                        encomendaM.Entregue = Convert.ToInt32(ENTREGE);
                        encomendaM.Tema = Convert.ToString(TEMA);
                        encomendaM.Quantidade = Convert.ToString(QUANTIDADE);
                        encomendaM.Valor = Convert.ToString(VALOR);
                        encomendaM.Descricao = Convert.ToString(DESCRICAO);
                        encomendaM.NomeCliente = Convert.ToString(NOMECLIENTE);


                        ListadeEncomenda.Add(encomendaM);
                    }


                }

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB06E", e.Message);
                TelaErro.Show();
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeEncomenda;
        }

        //ENCOMENDA PAGA
        public bool DefinirEncomendaPaga(int Id )
        {
            try
            {

                cmd.CommandText = "UPDATE TB_ENCOMENDA SET entregue = 1 WHERE id = @id";

                cmd.Parameters.AddWithValue("@id", Id);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB03V", e.Message);
                TelaErro.Show();
                return false;
            }

            return true;
        }

    }
}
