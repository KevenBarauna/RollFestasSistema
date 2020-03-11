using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using RollFestas.Models;
using RollFestas.Services;
using RollFestas.Utils;
using RollFestas.View.MensagemErro;

namespace RollFestas.Data
{
    class EventoDAO
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        //CADASTRAR
        public bool NovoEvento(string Cep, string Local, string Descricao, string NomeCliente, string Telefone1, string Telefone2, string Email, string Tipo, string Data, string Hora, string ValorTotal, string ValorPago, int Entregue)
        {
            try
            {
                cmd.CommandText = "INSERT INTO TB_EVENTO (cep,local,descricao,nome_cliente,telefone_1,telefone_2,email,tipo,data,hora,valor_total,valor_pago,entregue) VALUES (@cep,@local,@descricao,@nome_cliente,@telefone_1,@telefone_2,@email,@tipo,@data,@hora,@valor_total,@valor_pago,@entregue)";

                cmd.Parameters.AddWithValue("@cep", Cep);
                cmd.Parameters.AddWithValue("@local", Local);
                cmd.Parameters.AddWithValue("@descricao", Descricao);
                cmd.Parameters.AddWithValue("@nome_cliente", NomeCliente);
                cmd.Parameters.AddWithValue("@telefone_1", Telefone1);
                cmd.Parameters.AddWithValue("@telefone_2", Telefone2);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@tipo", Tipo);
                cmd.Parameters.AddWithValue("@data", Data);
                cmd.Parameters.AddWithValue("@hora", Hora);
                cmd.Parameters.AddWithValue("@valor_total", ValorTotal);
                cmd.Parameters.AddWithValue("@valor_pago", ValorPago);
                cmd.Parameters.AddWithValue("@entregue", Entregue);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB01EV", e.Message);
                TelaErro.Show();
                return false;
            }
            return true;
        }

        //EXIBIR
        public EventoModel ExibirDetalhesdoDoEvento(string Id)
        {
            var eventoM = new EventoModel();

            try
            {
                SqlDataReader dr;

                cmd.CommandText = "SELECT * FROM TB_EVENTO WHERE id = @id";

                cmd.Parameters.AddWithValue("@id", Id);

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    eventoM.Id = Convert.ToInt32(dr["id"]);
                    eventoM.Cep = Convert.ToString(dr["cep"]);
                    eventoM.Local = Convert.ToString(dr["local"]);
                    eventoM.Descricao = Convert.ToString(dr["descricao"]);
                    eventoM.NomeCliente = Convert.ToString(dr["nome_cliente"]);
                    eventoM.Telefone1 = Convert.ToString(dr["telefone_1"]);
                    eventoM.Telefone2 = Convert.ToString(dr["telefone_2"]);
                    eventoM.Email = Convert.ToString(dr["email"]);
                    eventoM.Tipo = Convert.ToString(dr["tipo"]);
                    eventoM.Data = Convert.ToString(dr["data"]);
                    eventoM.Hora = Convert.ToString(dr["hora"]);
                    eventoM.ValorTotal = Convert.ToString(dr["valor_total"]);
                    eventoM.ValorPago = Convert.ToString(dr["valor_pago"]);
                    eventoM.Entregue = Convert.ToInt32(dr["entregue"]);

                }

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB02EV", e.Message);
                TelaErro.Show();
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return eventoM;
        }

        //EDITAR
        public bool EditarEvento(string Cep, string Local, string Descricao, string NomeCliente, string Telefone1, string Telefone2, string Email, string Tipo, string Data, string Hora, string ValorTotal, string ValorPago, int Entregue, string Id)
        {
            try
            {

                cmd.CommandText = "UPDATE TB_EVENTO SET cep = @cep, local = @local, nome_cliente = @nome_cliente, telefone_1 = @telefone_1, telefone_2 = @telefone_2, email = @email, tipo = @tipo, data = @data, hora = @hora, valor_total = @valor_total ,valor_pago = @valor_pago ,entregue = @entregue  WHERE id = @id";

                cmd.Parameters.AddWithValue("@cep", Cep);
                cmd.Parameters.AddWithValue("@local", Local);
                cmd.Parameters.AddWithValue("@descricao", Descricao);
                cmd.Parameters.AddWithValue("@nome_cliente", NomeCliente);
                cmd.Parameters.AddWithValue("@telefone_1", Telefone1);
                cmd.Parameters.AddWithValue("@telefone_2", Telefone2);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@tipo", Tipo);
                cmd.Parameters.AddWithValue("@data", Data);
                cmd.Parameters.AddWithValue("@hora", Hora);
                cmd.Parameters.AddWithValue("@valor_total", ValorTotal);
                cmd.Parameters.AddWithValue("@valor_pago", ValorPago);
                cmd.Parameters.AddWithValue("@entregue", Entregue);
                cmd.Parameters.AddWithValue("@id", Id);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB03VE", e.Message);
                TelaErro.Show();
                return false;
            }

            return true;
        }


        //RETORNA TODOS OS PRODUTOS
        public List<EventoModel> ListarTodosOsEventos()
        {
            SqlDataReader dr;
            List<EventoModel> ListadeEvento = new List<EventoModel>();

            try
            {
                cmd.CommandText = "SELECT * FROM TB_EVENTO";

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        var eventoM = new EventoModel();

                        eventoM.Id = Convert.ToInt32(dr["id"]);
                        eventoM.Cep = Convert.ToString(dr["cep"]);
                        eventoM.Local = Convert.ToString(dr["local"]);
                        eventoM.Descricao = Convert.ToString(dr["descricao"]);
                        eventoM.NomeCliente = Convert.ToString(dr["nome_cliente"]);
                        eventoM.Telefone1 = Convert.ToString(dr["telefone_1"]);
                        eventoM.Telefone2 = Convert.ToString(dr["telefone_2"]);
                        eventoM.Email = Convert.ToString(dr["email"]);
                        eventoM.Tipo = Convert.ToString(dr["tipo"]);
                        eventoM.Data = Convert.ToString(dr["data"]);
                        eventoM.Hora = Convert.ToString(dr["hora"]);
                        eventoM.ValorTotal = Convert.ToString(dr["valor_total"]);
                        eventoM.ValorPago = Convert.ToString(dr["valor_pago"]);
                        eventoM.Entregue = Convert.ToInt32(dr["entregue"]);

                        ListadeEvento.Add(eventoM);
                    }


                }

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB0EE", e.Message);
                TelaErro.Show();
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeEvento;
        }


        //RETORNA TODOS OS EVENOS POR ORDEM DE DATA
        public List<EventoModel> ListarTodasOsEventosPorData()
        {
            SqlDataReader dr;
            List<EventoModel> ListadeEvento = new List<EventoModel>();

            try
            {
                cmd.CommandText = "SELECT * FROM TB_EVENTO  where entregue = 1 ORDER BY data";

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        EventoModel eventoM = new EventoModel();

                        eventoM.Id = Convert.ToInt32(dr["id"]);
                        eventoM.Cep = Convert.ToString(dr["cep"]);
                        eventoM.Local = Convert.ToString(dr["local"]);
                        eventoM.Descricao = Convert.ToString(dr["descricao"]);
                        eventoM.NomeCliente = Convert.ToString(dr["nome_cliente"]);
                        eventoM.Telefone1 = Convert.ToString(dr["telefone_1"]);
                        eventoM.Telefone2 = Convert.ToString(dr["telefone_2"]);
                        eventoM.Email = Convert.ToString(dr["email"]);
                        eventoM.Tipo = Convert.ToString(dr["tipo"]);
                        eventoM.Data = Convert.ToString(dr["data"]);
                        eventoM.Hora = Convert.ToString(dr["hora"]);
                        eventoM.ValorTotal = Convert.ToString(dr["valor_total"]);
                        eventoM.ValorPago = Convert.ToString(dr["valor_pago"]);
                        eventoM.Entregue = Convert.ToInt32(dr["entregue"]);


                        ListadeEvento.Add(eventoM);
                    }


                }

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB06E", e.Message);
                TelaErro.Show();
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeEvento;
        }

        //ENCOMENDA PAGA
        public bool DefinirEventoFinalizado(int Id)
        {
            try
            {

                cmd.CommandText = "UPDATE TB_EVENTO SET entregue = 2 WHERE id = @id";

                cmd.Parameters.AddWithValue("@id", Id);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB03V", e.Message);
                TelaErro.Show();
                return false;
            }

            return true;
        }

    }
}
