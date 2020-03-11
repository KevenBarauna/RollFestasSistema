using System;
using System.Collections.Generic;
using RollFestas.Date;
using RollFestas.Models;
using RollFestas.View.MensagemErro;
using RollFestas.View;
using RollFestas.Utils;

namespace RollFestas.Controllers
{
    class UsuarioController
    {

        UsuarioDAO DAO = new UsuarioDAO();

        //QUANDO INICIA O PROGRAMA
        public bool IniciaLogin()
        {
            return DAO.TesteConexao();
        }


        //NA TELA DE LOGIN - QUANDO O USUÁRO CLICA EM LOGIN
        public UsuarioModel Login(string Nome, String Senha)
        {
            UsuarioModel usurioModel = DAO.VerificaUsuarioSenha(Nome, Senha);

            if (usurioModel.Id == 0)
            {
                var TelaDeErro = new Erro("Usuário não encontrado");
                TelaDeErro.Show();
                return usurioModel;
            }
            else
            {
                return usurioModel;
            }
        }


        //CADASTRAR NOVO USUARIO
        public bool Cadastrar(string Nome, string Senha, string Email, string Data_admissao, string ConfSenha)
        {

            bool UsuarioExiste = DAO.ValidaNomeUsuario(Nome);

            if (string.IsNullOrEmpty(Nome) || string.IsNullOrEmpty(Senha) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Data_admissao) || string.IsNullOrEmpty(ConfSenha))
            {
                Erro TelaDeErro = new Erro("Preencha todos os campos");
                TelaDeErro.Show();
                return false;
            }
            if (Senha != ConfSenha)
            {
                Erro TelaDeErro = new Erro("As senhas são diferentes");
                TelaDeErro.Show();
                return false;
            }
            if (UsuarioExiste == true)
            {
                Erro TelaDeErro = new Erro("Já existe um usuário cadastrado com esse nome, não é possível cadastrar com o mesmo nome, tente novamente com outro usuário.");
                TelaDeErro.Show();
                return false;
            }
            else
            {
                bool Sucesso;
                Sucesso = DAO.SetUsuario(Nome, Senha, Email, Data_admissao);
                if (Sucesso == true)
                {
                    var Tela = new Sucesso("Usuário cadastrado com sucesso");
                    Tela.Show();
                    return true;
                }
                return false;
            }

        }


        //EXIBE USUARIO PELO NOME
        public UsuarioModel ExibirUsuario(string Nome)
        {
            UsuarioModel usuarioModel = new UsuarioModel();

            usuarioModel = DAO.GetUsuario(Nome);

            if (String.IsNullOrEmpty(usuarioModel.Nome))
            {
                Erro TelaDeErro = new Erro("Verifique se o nome de usuário foi digitado corretamente.");
                TelaDeErro.Show();
            }

            return usuarioModel;
        }


        //EDITAR USUARIO
        public bool EditarUsuario(string Nome, string Senha, string ConfSenha ,string Email, string Data_admissao, string NomeOriginal)
        {

            bool UsuarioExiste = DAO.ValidaNomeUsuario(Nome);

            if (string.IsNullOrEmpty(Nome) || string.IsNullOrEmpty(Senha) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Data_admissao) || string.IsNullOrEmpty(ConfSenha))
            {
                Erro TelaDeErro = new Erro("Preencha todos os campos");
                TelaDeErro.Show();
                return false;
            }
            if (Senha != ConfSenha)
            {
                Erro TelaDeErro = new Erro("As senhas são diferentes");
                TelaDeErro.Show();
                return false;
            }
            if (UsuarioExiste == true)
            {
                Erro TelaDeErro = new Erro("Já existe um usuário cadastrado com esse nome, não é possível cadastrar com o mesmo nome, tente novamente com outro usuário.");
                TelaDeErro.Show();
                return false;
            }
            else
            {
                bool Sucesso = DAO.Editar(Nome, Senha, Email, Data_admissao, NomeOriginal);

                if (Sucesso == true)
                {
                    var Tela = new Sucesso("Usuário editado com sucesso");
                    Tela.Show();
                    return true;
                }
                else
                {
                    var TelaDeErro = new Erro("Erro ao editar usuário.");
                    TelaDeErro.Show();
                    return false;
                }
            }





        }//UPDATE NO BANCO


        //APAGAR USUARIO
        public bool ApagarUsuario(string Nome)
        {
            bool UsuarioExiste = DAO.ValidaNomeUsuario(Nome);
            bool Sucesso = false;

            if (string.IsNullOrEmpty(Nome))
            {
                var Tela = new Erro("Informe o nome de usuário");
                Tela.Show();
                return false;
            }

            else if (UsuarioExiste == false)
            {
                var Tela = new Erro("Usuário não encontrado");
                Tela.Show();
                return false;

            }
            else if (UsuarioExiste == true)
            {
                Sucesso = DAO.Deletar(Nome);
            }

            if (Sucesso == false)
            {
                var Tela = new Erro("Erro ao apagar usuário");
                Tela.Show();
                return false;
            }
            if (Sucesso == true)
            {
                var Tela = new Sucesso("Usuário apagado com sucesso");
                Tela.Show();
                return true;
            }


            return false;

        }


        //LISTAR TODOS OS USUÁRIOS
        public List<UsuarioModel> ListarTodosOsUsuario()
        {
            List<UsuarioModel> ListaUsuarios = new List<UsuarioModel>();
            UsuarioModel usuarioModel = new UsuarioModel();

            ListaUsuarios = DAO.GetTodosOsusuarios();

            return ListaUsuarios;
        }


        //VERIFICA SE USUÁIO TEM PERMISSÃO
        public bool VerificaAdmin(string Nome, string Senha)
        {
            var usuarioModel = new UsuarioModel();

            usuarioModel = DAO.GetUsuario(Nome, Senha);

            if (usuarioModel.Id == 1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }//VERIFiCAR ADM


       
    }
}
