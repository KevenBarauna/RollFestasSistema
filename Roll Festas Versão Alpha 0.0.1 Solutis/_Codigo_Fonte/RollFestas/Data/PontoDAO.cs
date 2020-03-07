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
    class PontoDAO
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public bool SalvarHoraNoBancoH1(string Nome, string Hora, string Data)
        {
            try
            {
                cmd.CommandText = "INSERT INTO TB_PONTO (nome,chegada,data) VALUES (@nome,@chegada,@data)";

                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@chegada", Hora);
                cmd.Parameters.AddWithValue("@data", Data);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                var Tela = new ErroConexao("DB1PT", e.Message);
                Tela.Show();
                return false;
            }
            return true;
        }

        public bool SalvarHoraNoBancoH2(string Nome, string Hora, string Data)
        {
            try
            {
                cmd.CommandText = "UPDATE TB_PONTO SET saida_almoco = @chegada WHERE nome = @nome  and data = @data";

                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@chegada", Hora);
                cmd.Parameters.AddWithValue("@data", Data);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
            }
            catch (SqlException e)
            {
                var Tela = new ErroConexao("DB2PT", e.Message);
                Tela.Show();
                return false;
            }

            return true;

        }

        public bool SalvarHoraNoBancoH3(string Nome, string Hora, string Data)
        {

            try
            {
                cmd.CommandText = "UPDATE TB_PONTO SET chegada_almoco = @hora WHERE nome = @nome and data = @data";

                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@hora", Hora);
                cmd.Parameters.AddWithValue("@data", Data);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();

            }
            catch (SqlException e)
            {
                var Tela = new ErroConexao("DB3PT", e.Message);
                Tela.Show();
                return false;
            }

            return true;
        }

        public bool SalvarHoraNoBancoH4(string Nome, string Hora, string Data)
        {
            try
            {
                cmd.CommandText = "UPDATE TB_PONTO SET saida = @hora WHERE nome = @nome  and data = @data";

                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@hora", Hora);
                cmd.Parameters.AddWithValue("@data", Data);


                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();

            }
            catch (SqlException e)
            {
                var Tela = new ErroConexao("DB3PT", e.Message);
                Tela.Show();
                return false;

            }
            return true;

        }


        public List<PontoModel> ListarPordata(string Data)
        {
            SqlDataReader dr;
            List<PontoModel> ListadePonto = new List<PontoModel>();
            try
            {
                cmd.CommandText = "SELECT * FROM TB_PONTO where data = @data";
                cmd.Parameters.AddWithValue("@data", Data);

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        PontoModel PontoL = new PontoModel();
                        PontoL.Data = Convert.ToString(dr["data"]);
                        PontoL.Nome = Convert.ToString(dr["nome"]);
                        PontoL.Hora1 = Convert.ToString(dr["chegada"]);
                        PontoL.Hora2 = Convert.ToString(dr["saida_almoco"]);
                        PontoL.Hora3 = Convert.ToString(dr["chegada_almoco"]);
                        PontoL.Hora4 = Convert.ToString(dr["saida"]);

                        ListadePonto.Add(PontoL);
                    }


                }

            }
            catch (SqlException e)
            {
                var Tela = new ErroConexao("DB4PT", e.Message);
                Tela.Show();
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadePonto;
        }//RETORNA TODOS OS USUARIOS

        public List<PontoModel> ListarPorMes(string MesAno)
        {
            SqlDataReader dr;
            List<PontoModel> ListadePonto = new List<PontoModel>();
            try
            {

                cmd.CommandText = "SELECT * FROM TB_PONTO where data LIKE '%/" + MesAno + "%'";

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        PontoModel PontoL = new PontoModel();
                        PontoL.Data = Convert.ToString(dr["data"]);
                        PontoL.Nome = Convert.ToString(dr["nome"]);
                        PontoL.Hora1 = Convert.ToString(dr["chegada"]);
                        PontoL.Hora2 = Convert.ToString(dr["saida_almoco"]);
                        PontoL.Hora3 = Convert.ToString(dr["chegada_almoco"]);
                        PontoL.Hora4 = Convert.ToString(dr["saida"]);

                        ListadePonto.Add(PontoL);
                    }


                }

            }
            catch (SqlException e)
            {
                var Tela = new ErroConexao("DB5PT", e.Message);
                Tela.Show();
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadePonto;
        }//RETORNA TODOS OS USUARIOS

        public List<PontoModel> ListarPorMes(string MesAno, string Usuario)
        {
            SqlDataReader dr;
            List<PontoModel> ListadePonto = new List<PontoModel>();

            try
            {

                cmd.CommandText = "SELECT * FROM TB_PONTO where nome = @usuario AND data LIKE '%/" + MesAno + "%'";
                cmd.Parameters.AddWithValue("@usuario", Usuario);

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        PontoModel PontoL = new PontoModel();
                        PontoL.Data = Convert.ToString(dr["data"]);
                        PontoL.Nome = Convert.ToString(dr["nome"]);
                        PontoL.Hora1 = Convert.ToString(dr["chegada"]);
                        PontoL.Hora2 = Convert.ToString(dr["saida_almoco"]);
                        PontoL.Hora3 = Convert.ToString(dr["chegada_almoco"]);
                        PontoL.Hora4 = Convert.ToString(dr["saida"]);

                        ListadePonto.Add(PontoL);
                    }


                }

            }
            catch (SqlException e)
            {
                var Tela = new ErroConexao("DB6PT", e.Message);
                Tela.Show();
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadePonto;
        }//RETORNA TODOS OS USUARIOS



    }
}
