using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.Model
{
    public class DAOUsuario
    {

        _Conexao conexao = new _Conexao();
        SqlCommand cmd = new SqlCommand();

        public void IniciaLogin()
        {
            cmd.CommandText = "UPDATE TB_USUARIO SET logado = 0";

            cmd.Connection = conexao.Conectar();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexao.Desconectar();

        }//QUANDO INICIAR O LOGIN TODOS OS USURIOS RECEBEM 0

        public void UsuarioLogado(String usuario)
        {
            cmd.CommandText = "UPDATE TB_USUARIO SET logado = 1 WHERE nome = @usuario";

            cmd.Parameters.AddWithValue("@usuario", usuario);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexao.Desconectar();

        }//USUARIO LOGADO RECEBE 1

        public UsuarioModel PegarUsuarioLogado()
        {
            SqlDataReader dr;
            UsuarioModel usuario = new UsuarioModel();

            cmd.CommandText = "SELECT * FROM TB_USUARIO WHERE logado = 1";


            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var nomedoBanco = dr["nome"];
                    var senhadoBanco = dr["senha"];

                    usuario.Nome = Convert.ToString(nomedoBanco);
                    usuario.Senha = Convert.ToString(senhadoBanco);

                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return usuario;
        }//RETONAR QUAL SUARIO ESTÁ LOGADO

        public bool VerificaUsuario(String nome, String senha)
        {
            SqlDataReader dr;
            bool UsuarioExiste = false;

            cmd.CommandText = "SELECT * FROM TB_USUARIO WHERE nome = @nomeverifica AND senha = @senhaverifica";

            cmd.Parameters.AddWithValue("@nomeverifica", nome);
            cmd.Parameters.AddWithValue("@senhaverifica", senha);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    UsuarioExiste = true;
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return UsuarioExiste;
        }//VERIFICA SE USUARIO E SENHAS ESTÃO CORRETOS

        public void InserirUsuario(String nome, String senha)
        {

            cmd.CommandText = "INSERT INTO TB_USUARIO (nome,senha) VALUES (@nomeInserir,@senhaInserir)";

            cmd.Parameters.AddWithValue("@nomeInserir", nome);
            cmd.Parameters.AddWithValue("@senhaInserir", senha);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("Usuario cadastrado com sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }

        }//INSERIR NOVO USUARIO

        public bool ValidaNomeUsuario(String nome)
        {
            SqlDataReader dr;
            bool UsuarioExiste = false;

            cmd.CommandText = "SELECT * FROM TB_USUARIO WHERE nome = @nome";

            cmd.Parameters.AddWithValue("@nome", nome);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    UsuarioExiste = true;
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return UsuarioExiste;
        }//VERIFICA SE EXISTE USUARIO COM ESSE NOME

        public UsuarioModel ExibirDetalhesdoUsuario(String nome)
        {
            SqlDataReader dr;
            UsuarioModel usuario = new UsuarioModel();

            cmd.CommandText = "SELECT * FROM TB_USUARIO WHERE nome = @nomeexibir";

            cmd.Parameters.AddWithValue("@nomeexibir", nome);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var nomedoBanco = dr["nome"];
                    var senhadoBanco = dr["senha"];

                    usuario.Nome = Convert.ToString(nomedoBanco) ;
                    usuario.Senha = Convert.ToString(senhadoBanco);
                   
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return usuario;
        }//EXIBIR DETALHES DE UM USUARIO

        public void EditarUsuario(String nome, String senha, String nomeoriginal)
        {

            cmd.CommandText = "UPDATE TB_USUARIO SET nome = @nomeEditar, senha = @senhaEditar WHERE nome = @nomeoriginal";

            cmd.Parameters.AddWithValue("@nomeEditar", nome);
            cmd.Parameters.AddWithValue("@senhaEditar", senha);
            cmd.Parameters.AddWithValue("@nomeoriginal", nomeoriginal);


            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("Usuário editado com sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }



        }//EDITA USUARIO

        public void ApagarUsuario(String nome)
        {

            cmd.CommandText = "DELETE FROM TB_USUARIO WHERE nome = @nomeApagar";
            cmd.Parameters.AddWithValue("@nomeApagar", nome);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                MessageBox.Show("Usuário apagado com sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }



        }//APAGAR USUARIO

        public List<UsuarioModel> ListarTodosOsusuarios()
        {
            SqlDataReader dr;
            List<UsuarioModel> ListadeUsuario = new List<UsuarioModel>();

            cmd.CommandText = "SELECT * FROM TB_USUARIO";

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        UsuarioModel usuarioL = new UsuarioModel();
                        usuarioL.Nome = Convert.ToString( dr["nome"]);
                        usuarioL.Senha = Convert.ToString(dr["senha"]);

                        ListadeUsuario.Add(usuarioL);
                    }
                    

                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeUsuario;
        }//RETORNA TODOS OS USUARIOS

    }
}
