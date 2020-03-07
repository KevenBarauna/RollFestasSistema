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
    class VendaDAO
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        //NOVA VENDA
        public bool NovaVenda(string Data, string Usuario, string ValorTotal, string ValorPago, string Troco, string TipoPagamento, int StatusPagamento, string ValorPendente, string Nome)
        {
            try
            {
                cmd.CommandText = "INSERT INTO TB_VENDA (data,usuario,valortotal,valorpago,troco,tipopagamento,status_pagamento,valor_pendente,nome) VALUES (@data,@usuario,@valortotal,@valorpago,@troco,@tipopagamento,@status_pagamento,@valor_pendente,@nome)";

                cmd.Parameters.AddWithValue("@data", Data);
                cmd.Parameters.AddWithValue("@usuario", Usuario);
                cmd.Parameters.AddWithValue("@valortotal", ValorTotal);
                cmd.Parameters.AddWithValue("@valorpago", ValorPago);
                cmd.Parameters.AddWithValue("@troco", Troco);
                cmd.Parameters.AddWithValue("@tipopagamento", TipoPagamento);
                cmd.Parameters.AddWithValue("@status_pagamento", StatusPagamento);
                cmd.Parameters.AddWithValue("@valor_pendente", ValorPendente);
                cmd.Parameters.AddWithValue("@nome", Nome);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB01V", e.Message);
                TelaErro.Show();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return false;
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();
            return true;

        }

        //EXIBIR VENDA PELO ID
        public VendaModel ExibirDetalhesdaVenda(string Id)
        {
            SqlDataReader dr;
            VendaModel venda = new VendaModel();

            try
            {
                cmd.CommandText = "SELECT * FROM TB_VENDA WHERE id = @id";

                cmd.Parameters.AddWithValue("@id", Id);

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var ID = dr["id"];
                    var DATA = dr["data"];
                    var USUARIO = dr["usuario"];
                    var VALORTOTAL = dr["valortotal"];
                    var VALORPAGO = dr["valorpago"];
                    var TROCO = dr["troco"];
                    var TIPOPAGAMENTO = dr["tipopagamento"];
                    var NOME = dr["nome"];


                    venda.Id = Convert.ToInt32(ID);
                    venda.Data = Convert.ToString(DATA);
                    venda.Usuario = Convert.ToString(USUARIO);
                    venda.ValorTotal = Convert.ToString(VALORTOTAL);
                    venda.ValorPago = Convert.ToString(VALORPAGO);
                    venda.Troco = Convert.ToString(TROCO);
                    venda.TipoPagamento = Convert.ToString(TIPOPAGAMENTO);
                    venda.NomeCliente = Convert.ToString(NOME);

                }

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB02V", e.Message);
                TelaErro.Show();
                cmd.Parameters.Clear();
                conexao.Desconectar();

            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return venda;
        }

        //EXIBIR TODAS AS VENDAS DO DIA
        public List<VendaModel> ListarVendas(string Data)
        {
            SqlDataReader dr;
            List<VendaModel> venda = new List<VendaModel>();

            try
            {

                cmd.CommandText = "SELECT * FROM TB_VENDA WHERE data = @data";

                cmd.Parameters.AddWithValue("@data", Data);

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        var vendaM = new VendaModel();

                        var ID = dr["id"];
                        var DATA = dr["data"];
                        var USUARIO = dr["usuario"];
                        var VALORTOTAL = dr["valortotal"];
                        var VALORPAGO = dr["valorpago"];
                        var TROCO = dr["troco"];
                        var TIPOPAGAMENTO = dr["tipopagamento"];
                        var STATUS = dr["status_pagamento"];
                        var VALORPENDENTE = dr["valor_pendente"];
                        var NOME = dr["nome"];
 

                        if (TROCO == null)
                        {
                            TROCO = "0";
                        }
                        if (VALORPAGO == null)
                        {
                            VALORPAGO = "0";
                        }

                        vendaM.Id = Convert.ToInt32(ID);
                        vendaM.Data = Convert.ToString(DATA);
                        vendaM.Usuario = Convert.ToString(USUARIO);
                        vendaM.ValorTotal = Convert.ToString(VALORTOTAL);
                        vendaM.ValorPago = Convert.ToString(VALORPAGO);
                        vendaM.Troco = Convert.ToString(TROCO);
                        vendaM.TipoPagamento = Convert.ToString(TIPOPAGAMENTO);
                        vendaM.StatusPagamento = Convert.ToString(STATUS);
                        vendaM.ValorPendente = Convert.ToString(VALORPENDENTE);
                        vendaM.NomeCliente = Convert.ToString(NOME);


                        venda.Add(vendaM);
                    }


                }

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB03V", e.Message);
                TelaErro.Show();
                cmd.Parameters.Clear();
                conexao.Desconectar();

            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return venda;

        }

        //EXIBIR VENDAS DO ANO POR VENDEDOR
        public List<VendaModel> ListarVendasPorVendedor(string Vendedor, string Ano)
        {
            SqlDataReader dr;
            List<VendaModel> venda = new List<VendaModel>();

            try
            {

                cmd.CommandText = @"SELECT * FROM TB_VENDA WHERE usuario = @usuario AND data LIKE '%/" + Ano + "%'";

                cmd.Parameters.AddWithValue("@usuario", Vendedor);

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        var vendaM = new VendaModel();

                        var VALOR = Convert.ToString(dr["valortotal"]);

                        vendaM.ValorTotal = Convert.ToString(VALOR);

                        venda.Add(vendaM);
                    }


                }

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB03V", e.Message);
                TelaErro.Show();
                cmd.Parameters.Clear();
                conexao.Desconectar();

            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return venda;

        }

        //LISTA TODAS AS VENDAS PAGAS
        public List<VendaModel> ListarVendasPagas(string Data)
        {
            SqlDataReader dr;
            List<VendaModel> venda = new List<VendaModel>();

            try
            {

                cmd.CommandText = "SELECT * FROM TB_VENDA WHERE data = @data and status_pagamento = 1";

                cmd.Parameters.AddWithValue("@data", Data);

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        var vendaM = new VendaModel();

                        var ID = dr["id"];
                        var DATA = dr["data"];
                        var USUARIO = dr["usuario"];
                        var VALORTOTAL = dr["valortotal"];
                        var VALORPAGO = dr["valorpago"];
                        var TROCO = dr["troco"];
                        var TIPOPAGAMENTO = dr["tipopagamento"];
                        var NOME = dr["nome"];

                        if (TROCO == null)
                        {
                            TROCO = "0";

                            if (VALORPAGO == null)
                            {
                                VALORPAGO = "0";
                            }

                            vendaM.Id = Convert.ToInt32(ID);
                            vendaM.Data = Convert.ToString(DATA);
                            vendaM.Usuario = Convert.ToString(USUARIO);
                            vendaM.ValorTotal = Convert.ToString(VALORTOTAL);
                            vendaM.ValorPago = Convert.ToString(VALORPAGO);
                            vendaM.Troco = Convert.ToString(TROCO);
                            vendaM.TipoPagamento = Convert.ToString(TIPOPAGAMENTO);
                            vendaM.NomeCliente = Convert.ToString(NOME);

                            venda.Add(vendaM);
                        }

                    }

                }
            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB05V", e.Message);
                TelaErro.Show();
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return venda;

        }

        //LISTAR TODAS AS VENDAS PAGAS
        public List<VendaModel> ListarVendasPendentes()
        {
            SqlDataReader dr;
            List<VendaModel> venda = new List<VendaModel>();

            try
            {

                cmd.CommandText = "SELECT * FROM TB_VENDA WHERE status_pagamento = 2";

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        var vendaM = new VendaModel();

                        var ID = dr["id"];
                        var DATA = dr["data"];
                        var USUARIO = dr["usuario"];
                        var VALORTOTAL = dr["valortotal"];
                        var VALORPAGO = dr["valorpago"];
                        var TROCO = dr["troco"];
                        var VALORPENDENTE = dr["valor_pendente"];
                        var TIPOPAGAMENTO = dr["tipopagamento"];
                        var NOME = dr["nome"];


                        if (TROCO == null)
                        {
                            TROCO = "0";
                        }
                        if (VALORPAGO == null)
                        {
                            VALORPAGO = "0";
                        }

                        vendaM.Id = Convert.ToInt32(ID);
                        vendaM.Data = Convert.ToString(DATA);
                        vendaM.Usuario = Convert.ToString(USUARIO);
                        vendaM.ValorTotal = Convert.ToString(VALORTOTAL);
                        vendaM.ValorPago = Convert.ToString(VALORPAGO);
                        vendaM.Troco = Convert.ToString(TROCO);
                        vendaM.ValorPendente = Convert.ToString(VALORPENDENTE);
                        vendaM.TipoPagamento = Convert.ToString(TIPOPAGAMENTO);
                        vendaM.NomeCliente = Convert.ToString(NOME);

                        venda.Add(vendaM);
                    }


                }

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB06V", e.Message);
                TelaErro.Show();

            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return venda;

        }

        //EXIBIR VENDA PENDENTE POR ID
        public VendaModel ExibirVendaPendentes(string Id)
        {
            SqlDataReader dr;
            var vendaM = new VendaModel();

            try
            {
                cmd.CommandText = "SELECT * FROM TB_VENDA WHERE status_pagamento = 2 and id = @id";
                cmd.Parameters.AddWithValue("@id", Id);

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var ID = dr["id"];
                    var DATA = dr["data"];
                    var USUARIO = dr["usuario"];
                    var VALORTOTAL = dr["valortotal"];
                    var VALORPAGO = dr["valorpago"];
                    var TROCO = dr["troco"];
                    var VALORPENDENTE = dr["valor_pendente"];
                    var TIPOPAGAMENTO = dr["tipopagamento"];
                    var NOME = dr["nome"];

                    if (TROCO == null)
                    {
                        TROCO = "0";
                    }
                    if (VALORPAGO == null)
                    {
                        VALORPAGO = "0";
                    }

                    vendaM.Id = Convert.ToInt32(ID);
                    vendaM.Data = Convert.ToString(DATA);
                    vendaM.Usuario = Convert.ToString(USUARIO);
                    vendaM.ValorTotal = Convert.ToString(VALORTOTAL);
                    vendaM.ValorPago = Convert.ToString(VALORPAGO);
                    vendaM.Troco = Convert.ToString(TROCO);
                    vendaM.ValorPendente = Convert.ToString(VALORPENDENTE);
                    vendaM.TipoPagamento = Convert.ToString(TIPOPAGAMENTO);
                    vendaM.NomeCliente = Convert.ToString(NOME);


                }



            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB07V", e.Message);
                TelaErro.Show();

            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return vendaM;

        }

        //RETIRAR STATUS DE PENDENCIA
        public bool RetirarPendencia(string Id)
        {
            try
            {
                cmd.CommandText = "UPDATE TB_VENDA SET status_pagamento = 1, valor_pendente = 0 WHERE id = @id";

                cmd.Parameters.AddWithValue("@id", Id);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB08V", e.Message);
                TelaErro.Show();
                return false;
            }

           
            cmd.Parameters.Clear();
            conexao.Desconectar();
            return true;

        }

        //APAGAR VENDA
        public bool ApagarVenda(string Id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM TB_VENDA where id = @id";

                cmd.Parameters.AddWithValue("@id", Id);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB09V", e.Message);
                TelaErro.Show();
                return false;

            }

            cmd.Parameters.Clear();
            conexao.Desconectar();
            return true;
        }

        //RETORNA ULTIMA VENDA
        public VendaModel UltimaVenda()
        {
            SqlDataReader dr;
            var vendaM = new VendaModel();

            try
            {

                cmd.CommandText = "SELECT * FROM TB_VENDA ORDER BY id DESC";

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var ID = dr["id"];
                    var DATA = dr["data"];
                    var USUARIO = dr["usuario"];
                    var VALORTOTAL = dr["valortotal"];
                    var VALORPAGO = dr["valorpago"];
                    var TROCO = dr["troco"];
                    var TIPOPAGAMENTO = dr["tipopagamento"];
                    var NOME = dr["nome"];


                    vendaM.Id = Convert.ToInt32(ID);
                    vendaM.Data = Convert.ToString(DATA);
                    vendaM.Usuario = Convert.ToString(USUARIO);
                    vendaM.ValorTotal = Convert.ToString(VALORTOTAL);
                    vendaM.ValorPago = Convert.ToString(VALORPAGO);
                    vendaM.Troco = Convert.ToString(TROCO);
                    vendaM.TipoPagamento = Convert.ToString(TIPOPAGAMENTO);
                    vendaM.NomeCliente = Convert.ToString(NOME);

                }

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB010V", e.Message);
                TelaErro.Show();

            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return vendaM;
        }

    }
}
