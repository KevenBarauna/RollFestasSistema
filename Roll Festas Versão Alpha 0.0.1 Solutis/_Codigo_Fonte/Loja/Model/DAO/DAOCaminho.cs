using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.Model.DAO
{
    class DAOCaminho
    {
        _Conexao conexao = new _Conexao();
        SqlCommand cmd = new SqlCommand();

        public string CaminhoPonto()
        {
            SqlDataReader dr;
 
            cmd.CommandText = "SELECT * FROM TB_CAMINHOS WHERE nome = 'ponto' ";

            String caminho = @"C:\";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var caminhodoBanco = dr["caminho"];

                    caminho = Convert.ToString(caminhodoBanco);
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }

            

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return caminho;
        }//PEGA CAMINHO para SALVAR PONTO

        public string CaminhoCahce()
        {
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM TB_CAMINHOS WHERE nome = 'cache' ";

            String caminho = @"C:\";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var caminhodoBanco = dr["caminho"];

                    caminho = Convert.ToString(caminhodoBanco);
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }



            cmd.Parameters.Clear();
            conexao.Desconectar();

            return caminho;
        }//PEGA CAMINHO para SALVAR CAHCE

        public string CaminhoComprovante()
        {
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM TB_CAMINHOS WHERE nome = 'comprovantes' ";

            String caminho = @"C:\";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var caminhodoBanco = dr["caminho"];

                    caminho = Convert.ToString(caminhodoBanco);
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }



            cmd.Parameters.Clear();
            conexao.Desconectar();

            return caminho;
        }//PEGA CAMINHO para SALVAR CAHCE

    }
}
