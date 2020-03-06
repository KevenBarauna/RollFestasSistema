using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using RollFestas.Models;
using RollFestas.Services;
using RollFestas.View.MensagemErro;

namespace RollFestas.Date
{
    class UsuarioDAO
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        #region LOGIN
       
        //TESTA A CONEXÃO COM O BANCO
        public bool TesteConexao()
        {
            try
            {
                cmd.CommandText = "SELECT * FROM TB_USUARIO where id = 1";

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return true;
            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB01 - Erro ao conectar com o banco de dados", e.Message);
                TelaErro.Show();
                return false;
            }


        }


        //VERIFICA SE USUÁIO E SENHA ESTÃO CORRETOS
        public UsuarioModel VerificaUsuarioSenha(string Nome, string Senha)
        {
            SqlDataReader dr;
            var usuarioModel = new UsuarioModel();

            try
            {
                cmd.CommandText = "SELECT * FROM TB_USUARIO WHERE nome = @nome AND senha = @senha";

                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@senha", Senha);


                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var ID = dr["id"];
                    var NOME = dr["nome"];
                    var SENHA = dr["senha"];
                    var EMAIL = dr["email"];
                    var DATA_ADMISSAO = dr["data_admissao"];

                    usuarioModel.Id = Convert.ToInt32(ID);
                    usuarioModel.Nome = Convert.ToString(NOME);
                    usuarioModel.Senha = Convert.ToString(SENHA);
                    usuarioModel.Email = Convert.ToString(EMAIL);
                    usuarioModel.Data_Admissao = Convert.ToString(DATA_ADMISSAO);
                }

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB04", e.Message);
                TelaErro.Show();
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return usuarioModel;
        }

        #endregion

        #region CRUD
        //CADASTRA NOVO USUARIO
        public bool SetUsuario(string Nome, string Senha, string Email, string Data_admissao)
        {
            try
            {
                cmd.CommandText = "INSERT INTO TB_USUARIO (nome,senha,email,data_admissao) VALUES (@nome,@senha, @email, @data_admissao)";

                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@senha", Senha);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@data_admissao", Data_admissao);


                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();

                return true;
            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB06", e.Message);
                TelaErro.Show();

                return false;
            }

        }

        //EDITA USUARIO
        public bool Editar(string Nome, string Senha, string Email, string Data_admissao, string NomeOriginal)
        {
            try
            {
                cmd.CommandText = "UPDATE TB_USUARIO SET nome = @nome, senha = @senha, email = @email, data_admissao = @data_admissao WHERE nome = @nomeoriginal";

                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@senha", Senha);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@data_admissao", Data_admissao);
                cmd.Parameters.AddWithValue("@nomeoriginal", NomeOriginal);



                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return true;
            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB09", e.Message);
                TelaErro.Show();
                return false;
            }



        }


        //APAGA USUARIO
        public bool Deletar(string Nome)
        {
            try
            {
                cmd.CommandText = "DELETE FROM TB_USUARIO WHERE nome = @nome";
                cmd.Parameters.AddWithValue("@nome", Nome);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexao.Desconectar();
                return true;
            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB10", e.Message);
                TelaErro.Show();
                return false;
            }



        }


        //LISTA TODOS OS USUÁRIOS
        public List<UsuarioModel> GetTodosOsusuarios()
        {
            SqlDataReader dr;
            List<UsuarioModel> ListadeUsuario = new List<UsuarioModel>();
            try
            {

                cmd.CommandText = "SELECT * FROM TB_USUARIO";

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    foreach (var linhadobanco in dr)
                    {
                        UsuarioModel usuarioL = new UsuarioModel();
                        usuarioL.Id = Convert.ToInt32(dr["id"]);
                        usuarioL.Nome = Convert.ToString(dr["nome"]);
                        usuarioL.Senha = Convert.ToString(dr["senha"]);
                        usuarioL.Email = Convert.ToString(dr["email"]);
                        usuarioL.Data_Admissao = Convert.ToString(dr["data_admissao"]);

                        ListadeUsuario.Add(usuarioL);
                    }


                }

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB11", e.Message);
                TelaErro.Show();
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return ListadeUsuario;
        }


        //RETORNA DETALHES USUARIO
        public UsuarioModel GetUsuario(string Nome)
        {
            SqlDataReader dr;
            var UsuarioModel = new UsuarioModel();
            try
            {
                cmd.CommandText = "SELECT * FROM TB_USUARIO WHERE nome = @nome";

                cmd.Parameters.AddWithValue("@nome", Nome);

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var ID = dr["id"];
                    var NOME = dr["nome"];
                    var SENHA = dr["senha"];
                    var EMAIL = dr["email"];
                    var DATA_ADMISSAO = dr["data_admissao"];

                    UsuarioModel.Id = Convert.ToInt32(ID);
                    UsuarioModel.Nome = Convert.ToString(NOME);
                    UsuarioModel.Senha = Convert.ToString(SENHA);
                    UsuarioModel.Email = Convert.ToString(EMAIL);
                    UsuarioModel.Data_Admissao = Convert.ToString(DATA_ADMISSAO);

                }

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB08", e.Message);
                TelaErro.Show();
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return UsuarioModel;
        }


        //RETORNA DADOS DO USUARIO PELO NOME E SENHA
        public UsuarioModel GetUsuario(string Nome, string Senha)
        {
            SqlDataReader dr;
            UsuarioModel usuario = new UsuarioModel();

            try
            {
                cmd.CommandText = "SELECT * FROM TB_USUARIO WHERE nome = @nome AND senha = @senha";

                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@senha", Senha);


                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    var ID = dr["id"];
                    var NOME = dr["nome"];
                    var SENHA = dr["senha"];
                    var EMAIL = dr["email"];
                    var DATA_ADMISSAO = dr["data_admissao"];

                    usuario.Id = Convert.ToInt32(ID);
                    usuario.Nome = Convert.ToString(NOME);
                    usuario.Senha = Convert.ToString(SENHA);
                    usuario.Email = Convert.ToString(EMAIL);
                    usuario.Data_Admissao = Convert.ToString(DATA_ADMISSAO);

                }

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB12", e.Message);
                TelaErro.Show();
            }
            cmd.Parameters.Clear();
            conexao.Desconectar();

            return usuario;
        }


        #endregion


        //VERIFICA SE TEM USUÁRIO COM NOME PASSADO
        public bool ValidaNomeUsuario(string Nome)
        {
            SqlDataReader dr;
            bool UsuarioExiste = false;
            try
            {
                cmd.CommandText = "SELECT * FROM TB_USUARIO WHERE nome = @nome";

                cmd.Parameters.AddWithValue("@nome", Nome);

                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    UsuarioExiste = true;
                }

            }
            catch (SqlException e)
            {
                var TelaErro = new ErroConexao("CDB07", e.Message);
                TelaErro.Show();
            }

            cmd.Parameters.Clear();
            conexao.Desconectar();

            return UsuarioExiste;
        }


    }
}
