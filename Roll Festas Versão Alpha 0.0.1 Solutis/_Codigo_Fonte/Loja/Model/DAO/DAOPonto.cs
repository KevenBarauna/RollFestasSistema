using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.Model
{
    class DAOPonto
    {

        _Conexao conexao = new _Conexao();
        SqlCommand cmd = new SqlCommand();

        public void SalvarHoraNoBancoH1(String nome, String hora, String data)
        {
            cmd.CommandText = "INSERT INTO TB_PONTO (nome,chegada,data) VALUES (@nome,@chegada,@data)";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@chegada", hora);
            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("Sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }

        }

        public void SalvarHoraNoBancoH2(String nome, String hora, String data)
        {
            cmd.CommandText = "UPDATE TB_PONTO SET saida_almoco = @chegada WHERE nome = @nome  and data = @data";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@chegada", hora);
            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("Sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }


        }

        public void SalvarHoraNoBancoH3(String nome, String hora, String data)
        {
            cmd.CommandText = "UPDATE TB_PONTO SET chegada_almoco = @hora WHERE nome = @nome and data = @data";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@hora", hora);
            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("Sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }


        }

        public void SalvarHoraNoBancoH4(String nome, String hora, String data)
        {
            cmd.CommandText = "UPDATE TB_PONTO SET saida = @hora WHERE nome = @nome  and data = @data";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@hora", hora);
            cmd.Parameters.AddWithValue("@data", data);



            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("Sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }


        }



        public int VerificaH1(String nome, String data)
        {
            SqlDataReader dr;
            int H = 1;

            cmd.CommandText = "SELECT * FROM TB_PONTO WHERE nome = @nome and data = @data and chegada != 'null' ";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    H = 0;
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return H;
        }//VERIFICA SE HORA 1 JÁ ESTA COM VALOR

        public int VerificaH2(String nome, String data)
        {
            SqlDataReader dr;
            int H = 2;

            cmd.CommandText = "SELECT * FROM TB_PONTO WHERE nome = @nome and data = @data and saida_almoco != 'null' ";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    H = 0;
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return H;
        }//VERIFICA SE HORA 2 JÁ ESTA COM VALOR

        public int VerificaH3(String nome, String data)
        {
            SqlDataReader dr;
            int H = 3;

            cmd.CommandText = "SELECT * FROM TB_PONTO WHERE nome = @nome and data = @data  and chegada_almoco != 'null' ";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@data", data);


            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    H = 0;
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return H;
        }//VERIFICA SE HORA 2 JÁ ESTA COM VALOR

        public int VerificaH4(String nome, String data)
        {
            SqlDataReader dr;
            int H = 4;

            cmd.CommandText = "SELECT * FROM TB_PONTO WHERE nome = @nome and data = @data and saida != 'null' ";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    H = 0;
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return H;
        }//VERIFICA SE HORA 2 JÁ ESTA COM VALOR

        public List<PontoModel> ListarPordata(String data)
        {
            SqlDataReader dr;
            List<PontoModel> ListadePonto= new List<PontoModel>();

            cmd.CommandText = "SELECT * FROM TB_PONTO where data = @data";
            cmd.Parameters.AddWithValue("@data", data);
            try
            {
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
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadePonto;
        }//RETORNA TODOS OS USUARIOS

        public List<PontoModel> ListarPorMes(String mes)
        {
            SqlDataReader dr;
            List<PontoModel> ListadePonto = new List<PontoModel>();

            cmd.CommandText = "SELECT * FROM TB_PONTO where data LIKE '%/" + mes + "%'" ;

            try
            {
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
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadePonto;
        }//RETORNA TODOS OS USUARIOS

        public List<PontoModel> ListarPorAno(String mes)
        {
            SqlDataReader dr;
            List<PontoModel> ListadePonto = new List<PontoModel>();

            cmd.CommandText = "SELECT * FROM TB_PONTO where data LIKE '%/" + mes + "%'";

            try
            {
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
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadePonto;
        }//RETORNA TODOS OS USUARIOS


    }
}
