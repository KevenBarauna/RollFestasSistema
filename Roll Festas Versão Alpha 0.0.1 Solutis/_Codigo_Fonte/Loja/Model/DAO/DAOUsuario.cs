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

                    var iddoBanco = dr["id"];
                    var nomedoBanco = dr["nome"];
                    var senhadoBanco = dr["senha"];
                    var emaildoBanco = dr["email"];
                    var data_admissaodoBanco = dr["data_admissao"];

                    usuario.Id = Convert.ToInt32(iddoBanco);
                    usuario.Nome = Convert.ToString(nomedoBanco);
                    usuario.Senha = Convert.ToString(senhadoBanco);
                    usuario.Email = Convert.ToString(emaildoBanco);
                    usuario.Data_admissao = Convert.ToString(data_admissaodoBanco);

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

        public void InserirUsuario(String nome, String senha, string email, string data_admissao)
        {

            cmd.CommandText = "INSERT INTO TB_USUARIO (nome,senha,email,data_admissao) VALUES (@nomeInserir,@senhaInserir, @emailInserir, @data_admissaoInserir)";

            cmd.Parameters.AddWithValue("@nomeInserir", nome);
            cmd.Parameters.AddWithValue("@senhaInserir", senha);
            cmd.Parameters.AddWithValue("@emailInserir", email);
            cmd.Parameters.AddWithValue("@data_admissaoInserir", data_admissao);

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

        public bool ValidaNomeUsuario(string nome)
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

        public UsuarioModel ExibirDetalhesdoUsuario(string nome)
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
                    var emaildoBanco = dr["email"];
                    var data_admissaodoBanco = dr["data_admissao"];


                    usuario.Nome = Convert.ToString(nomedoBanco) ;
                    usuario.Senha = Convert.ToString(senhadoBanco);
                    usuario.Email = Convert.ToString(emaildoBanco);
                    usuario.Data_admissao = Convert.ToString(data_admissaodoBanco);

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

        public void EditarUsuario(string nome, string senha, string email, string data_admissao, string nomeoriginal)
        {

            cmd.CommandText = "UPDATE TB_USUARIO SET nome = @nomeEditar, senha = @senhaEditar, email = @emailEditar, data_admissao = @data_admissaoEditar WHERE nome = @nomeoriginal";

            cmd.Parameters.AddWithValue("@nomeEditar", nome);
            cmd.Parameters.AddWithValue("@senhaEditar", senha);
            cmd.Parameters.AddWithValue("@emailEditar", email);
            cmd.Parameters.AddWithValue("@data_admissaoEditar", data_admissao);
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
                        usuarioL.Email = Convert.ToString(dr["email"]);
                        usuarioL.Data_admissao = Convert.ToString(dr["data_admissao"]);

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

        public UsuarioModel VerificaAdmin(string nome, string senha)
        {
            SqlDataReader dr;
            UsuarioModel usuario = new UsuarioModel();

            cmd.CommandText = "SELECT * FROM TB_USUARIO WHERE nome = @nome AND senha = @senha";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var iddoBanco = dr["id"];
                    var nomedoBanco = dr["nome"];
                    var senhadoBanco = dr["senha"];
                    var emaildoBanco = dr["email"];
                    var data_admissaodoBanco = dr["data_admissao"];

                    usuario.Id = Convert.ToInt32( iddoBanco );
                    usuario.Nome = Convert.ToString(nomedoBanco);
                    usuario.Senha = Convert.ToString(senhadoBanco);
                    usuario.Email = Convert.ToString(emaildoBanco);
                    usuario.Data_admissao = Convert.ToString(data_admissaodoBanco);

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

        public string VerificaFerias(int id)
        {
            SqlDataReader dr;
            string Data_admissao = null;


            cmd.CommandText = "SELECT * FROM TB_USUARIO WHERE id = @id";

            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var data_admissaodoBanco = dr["data_admissao"];

                    Data_admissao = Convert.ToString(data_admissaodoBanco);

                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro:  " + e);
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return Data_admissao;
        }//EXIBIR FERIas


    }
}
