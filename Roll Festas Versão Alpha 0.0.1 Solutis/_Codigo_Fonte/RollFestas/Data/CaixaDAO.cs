using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using RollFestas.Models;
using RollFestas.Services;
using RollFestas.Utils;
using RollFestas.View.MensagemErro;

namespace RollFestas.Data
{
    class CaixaDAO
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        //JavaScriptSerializer javascriptSerializer = new JavaScriptSerializer();

        //INICIAR CAIXA
        public bool IniciarCaixa(string Data)
        {

            SqlDataReader dr;

            try
            {
                cmd.CommandText = "SELECT * FROM TB_CAIXA WHERE data = @data";

                cmd.Connection = conexao.Conectar();
                cmd.Parameters.AddWithValue("@data", Data);
                dr = cmd.ExecuteReader();

                if (!dr.HasRows)
                {
                    cmd.Parameters.Clear();
                    conexao.Desconectar();

                    cmd.CommandText = "INSERT INTO TB_CAIXA (data) VALUES (@data)";

                    cmd.Parameters.AddWithValue("@data", Data);

                    try
                    {
                        cmd.Connection = conexao.Conectar();
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        conexao.Desconectar();
                    }
                    catch (SqlException e)
                    {
                        var TelaErro = new ErroConexao("CDBFT", e.Message);
                        TelaErro.Show();

                        cmd.Parameters.Clear();
                        conexao.Desconectar();
                        return false;
                    }


                }
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return true;
            }
            catch (SqlException e)
            {
                
                GerarTxt.SalvarTxtErro(null, e.Message,e.Number.ToString(),e.Errors.ToString(),e.ErrorCode.ToString(),Program._CaminhoCacheErro);

                var TelaErro = new ErroConexao("E.I.C", e.Message);
                TelaErro.Show();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return false;
            }

        }

        //INSERIR DINHEIRO NO CAIXA
        public bool InserirDinheiro(string ValorTotal, string Data)
        {
            try
            {
                cmd.CommandText = "UPDATE TB_CAIXA SET dinheiro = @valorTotal WHERE data = @data";

                cmd.Parameters.AddWithValue("@valorTotal", ValorTotal);
                cmd.Parameters.AddWithValue("@data", Data);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB02C", e.Message);
                TelaErro.Show();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return false;
            }
            return true;
        }

        //INSERIR CARTÃO NO CAIXA
        public bool InserirCartao(string ValorTotal, string Data)
        {
            try
            {
                cmd.CommandText = "UPDATE TB_CAIXA SET cartao = @valorTotal WHERE data = @data";

                cmd.Parameters.AddWithValue("@valorTotal", ValorTotal);
                cmd.Parameters.AddWithValue("@data", Data);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB03C", e.Message);
                TelaErro.Show();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return false;
            }
            return true;
        }

        //INSERIR OUTROS NO CAIXA
        public bool InserirOutros(string ValorTotal, string Data)
        {
            try
            {
                cmd.CommandText = "UPDATE TB_CAIXA SET outros = @valor WHERE data = @data";

                cmd.Parameters.AddWithValue("@valor", ValorTotal);
                cmd.Parameters.AddWithValue("@data", Data);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB04C", e.Message);
                TelaErro.Show();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return false;
            }
            return true;
        }

        //INSERIR TROCA NO CAIXA
        public bool InserirTroca(string ValorTotal, string Data)
        {
            try
            {
                cmd.CommandText = "UPDATE TB_CAIXA SET troca = @valor WHERE data = @data";

                cmd.Parameters.AddWithValue("@valor", ValorTotal);
                cmd.Parameters.AddWithValue("@data", Data);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB04C", e.Message);
                TelaErro.Show();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return false;
            }
            return true;
        }

        //INSERIR VALOR TOTAL
        public bool InserirValorTotal(string ValorTotal, string Data)
        {
            try
            {
                cmd.CommandText = "UPDATE TB_CAIXA SET valor_total_dia = @valor WHERE data = @data";

                cmd.Parameters.AddWithValue("@valor", ValorTotal);
                cmd.Parameters.AddWithValue("@data", Data);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB04iC", e.Message);
                TelaErro.Show();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return false;
            }
            return true;
        }

        //LANÇAR RETIRADA
        public bool Retirada(string Valor, string Data)
        {
            try
            {
                cmd.CommandText = "UPDATE TB_CAIXA SET retirada = @retirada where data = @data";

                cmd.Parameters.AddWithValue("@data", Data);
                cmd.Parameters.AddWithValue("@retirada", Valor);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB05C", e.Message);
                TelaErro.Show();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return false;
            }
            return true;
        }

        //LARÇAR DEPOSITO
        public bool Deposito(string Valor, string Data)
        {
            try
            {
                cmd.CommandText = "UPDATE TB_CAIXA SET deposito = @deposito where data = @data";

                cmd.Parameters.AddWithValue("@data", Data);
                cmd.Parameters.AddWithValue("@deposito", Valor);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB06C", e.Message);
                TelaErro.Show();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return false;
            }
            return true;
        }

        //RETORNA DADOS PELA DATA
        public CaixaModel PegarValoresPorData(string Data)
        {
            SqlDataReader dr;
            var CaixaM = new CaixaModel();

            try
            {
                cmd.CommandText = "SELECT * FROM TB_CAIXA WHERE data = @data";

                cmd.Parameters.AddWithValue("@data", Data);

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var ID = Convert.ToString(dr["id"]);
                    var VALORTOTAL = Convert.ToString(dr["valor_total_dia"]);
                    var DATA = Convert.ToString(dr["data"]);
                    var RETIRADA = Convert.ToString(dr["retirada"]);
                    var DEPOSITO = Convert.ToString(dr["deposito"]);
                    var DINHEIRO = Convert.ToString(dr["dinheiro"]);
                    var CARTAO = Convert.ToString(dr["cartao"]);
                    var OUTROS = Convert.ToString(dr["outros"]);
                    var DEVOLUCAO = Convert.ToString(dr["devolucao"]);

                    CaixaM.Id = Convert.ToInt32(ID);
                    CaixaM.ValorTotal = VALORTOTAL.ToString();
                    CaixaM.Data = DATA.ToString();
                    CaixaM.Retirada = RETIRADA.ToString();
                    CaixaM.Deposito = DEPOSITO.ToString();
                    CaixaM.Dinheiro = DINHEIRO.ToString();
                    CaixaM.Cartao = CARTAO.ToString();
                    CaixaM.Outros = OUTROS.ToString();
                    CaixaM.Devolucao = DEVOLUCAO.ToString();


                }

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB07C", e.Message);
                TelaErro.Show();
                cmd.Parameters.Clear();
                conexao.Desconectar();

            }
            cmd.Parameters.Clear();
            conexao.Desconectar();
            return CaixaM;

        }

        //RETORNA DADOS POR MES
        public List<CaixaModel> PegarValoresPorMes(string MesAno)
        {
            SqlDataReader dr;
            var ListaCaixa = new List<CaixaModel>();

            try
            {
                cmd.CommandText = "SELECT * FROM TB_CAIXA WHERE data LIKE '%" + MesAno + "%'";

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        var CaixaM = new CaixaModel();

                        var ID = Convert.ToString(dr["id"]);
                        var VALORTOTAL = Convert.ToString(dr["valor_total_dia"]);
                        var DATA = Convert.ToString(dr["data"]);
                        var RETIRADA = Convert.ToString(dr["retirada"]);
                        var DEPOSITO = Convert.ToString(dr["deposito"]);
                        var DINHEIRO = Convert.ToString(dr["dinheiro"]);
                        var CARTAO = Convert.ToString(dr["cartao"]);
                        var OUTROS = Convert.ToString(dr["outros"]);
                        var DEVOLUCAO = Convert.ToString(dr["devolucao"]);

                        CaixaM.Id = Convert.ToInt32(ID);
                        CaixaM.ValorTotal = VALORTOTAL.ToString();
                        CaixaM.Data = DATA.ToString();
                        CaixaM.Retirada = RETIRADA.ToString();
                        CaixaM.Deposito = DEPOSITO.ToString();
                        CaixaM.Dinheiro = DINHEIRO.ToString();
                        CaixaM.Cartao = CARTAO.ToString();
                        CaixaM.Outros = OUTROS.ToString();
                        CaixaM.Devolucao = DEVOLUCAO.ToString();

                        ListaCaixa.Add(CaixaM);
                    }


                }

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB08C", e.Message);
                TelaErro.Show();
                cmd.Parameters.Clear();
                conexao.Desconectar();
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListaCaixa;

        }

        //RETORNA DADOS POR ANO
        public List<CaixaModel> PegarValoresPorAno(string Ano)
        {
            SqlDataReader dr;
            var ListaCaixa = new List<CaixaModel>();
            try
            {
                cmd.CommandText = "SELECT * FROM TB_CAIXA WHERE data LIKE '%/" + Ano + "%'";

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        var CaixaM = new CaixaModel();

                        var ID = Convert.ToString(dr["id"]);
                        var VALORTOTAL = Convert.ToString(dr["valor_total_dia"]);
                        var DATA = Convert.ToString(dr["data"]);
                        var RETIRADA = Convert.ToString(dr["retirada"]);
                        var DEPOSITO = Convert.ToString(dr["deposito"]);
                        var DINHEIRO = Convert.ToString(dr["dinheiro"]);
                        var CARTAO = Convert.ToString(dr["cartao"]);
                        var OUTROS = Convert.ToString(dr["outros"]);
                        var DEVOLUCAO = Convert.ToString(dr["devolucao"]);

                        CaixaM.Id = Convert.ToInt32(ID);
                        CaixaM.ValorTotal = VALORTOTAL.ToString();
                        CaixaM.Data = DATA.ToString();
                        CaixaM.Retirada = RETIRADA.ToString();
                        CaixaM.Deposito = DEPOSITO.ToString();
                        CaixaM.Dinheiro = DINHEIRO.ToString();
                        CaixaM.Cartao = CARTAO.ToString();
                        CaixaM.Outros = OUTROS.ToString();
                        CaixaM.Devolucao = DEVOLUCAO.ToString();

                        ListaCaixa.Add(CaixaM);

                    }


                }

            }
            catch (SqlException e)
            {
                GerarTxt.SalvarTxtErro(null, e.Message, e.Number.ToString(), e.Errors.ToString(), e.ErrorCode.ToString(), Program._CaminhoCacheErro);
                var TelaErro = new ErroConexao("CDB09C", e.Message);
                TelaErro.Show();
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListaCaixa;

        }


    }
}
