using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.Controler.Utils;
using Loja.Model;
using Loja.View;


namespace Loja.Controler
{
    class UsuarioController
    {

        public void IniciaLogin()
        {
            try
            {
                DAOUsuario dao = new DAOUsuario();
                dao.IniciaLogin();
            }
            catch (Exception e)
            {
                Erro TelaDeErro = new Erro("000", "Sem acesso ao bando de dados" + e, "Reinicie o programa", "Reinicie o computador", "Reinicie o banco de dados.", "", "");
                TelaDeErro.Show();
            }

        }//TODOS OS USUARIOS DESLOGADOS

        public bool Login(String nome, String senha)
        {
            bool UsuarioExiste = false;

            DAOUsuario dao = new DAOUsuario();
            UsuarioExiste = dao.VerificaUsuario(nome, senha);

            if (UsuarioExiste == false)
            {
                Erro TelaDeErro = new Erro("001","Usuário não encontrado no Banco de Dados", "Verifique se você digitou usuário e senha corretamente.", "Verifique se o caps lock está ativado.", "Tente acessar outra conta.", "Reinicie o banco de dados","");
                TelaDeErro.Show();
                return false;
            }
            else
            {
                dao.UsuarioLogado(nome);

                Home tela = new Home();
                tela.Show();
                return true;
            }
        }//NA TELA DE LOGIN - QUANDO O USUÁRO CLICA EM LOGIN

        public bool Cadastrar(string nome, string senha, string email, string data_admissao, string confSenha)
        {

            if (senha != confSenha) 
            {
                Erro TelaDeErro = new Erro("002", "As senhas são diferentes", "Digite as senhas iguais.", "", "", "", "");
                TelaDeErro.Show();
                return false;//NAÕ CADASTROU
            }
                else { 
            
                bool UsuarioExiste = false;

                DAOUsuario dao = new DAOUsuario();
                UsuarioExiste = dao.ValidaNomeUsuario(nome);

                if (UsuarioExiste == true)
                {
                    Erro TelaDeErro = new Erro("003", "Já existe um usuário cadastrado com esse nome, não é possível cadastrar com o mesmo nome", "Tente novamente com outro usuário.", "", "", "", "");
                    TelaDeErro.Show();
                    return false;//NAÕ CADASTROU
                }
                else
                {
                    dao.InserirUsuario(nome,senha,email,data_admissao);
                    return true;//CADASTROU
                }
            }
        }//VERIFICA SE SENHAS SÃO IGUAIS

        public UsuarioModel ExibirUsuario(String nome)//RETORNA NOME E SENHA DO USUARIO
        {
            UsuarioModel usuario = new UsuarioModel();
            DAOUsuario dao = new DAOUsuario();

            usuario = dao.ExibirDetalhesdoUsuario(nome);

            if (String.IsNullOrEmpty(usuario.Nome))
            {
                Erro TelaDeErro = new Erro("001", "Usuário não encontrado no Banco de Dados", "Verifique se você digitou usuário e senha corretamente.", "Verifique se o caps lock está ativado.", "Reinicie o programa", "Reinicie o banco de dados", "");
                TelaDeErro.Show();
            }

            return usuario;
        }

        public bool EditarUsuario(string nome, string senha, string email, string data_admissao ,string nomeoriginal)
        {
            DAOUsuario dao = new DAOUsuario();

            try
            {
            dao.EditarUsuario(nome,senha,email, data_admissao,nomeoriginal);
                return true;

            }catch (Exception e)
            {
                Erro TelaDeErro = new Erro("004", "Parâmetro invalido. " + e, "Verifique se você digitou os dados corretamente", "Não é aconselhável o uso de caracteres especiais", "", "", "");
                TelaDeErro.Show();
                return false;
            }

        }//UPDATE NO BANCO

        public bool ApagarUsuario(String nome)
        {
            bool UsuarioExiste = false;
            DAOUsuario dao = new DAOUsuario();

            UsuarioExiste = dao.ValidaNomeUsuario(nome);

            if (UsuarioExiste == true)
            {
                dao.ApagarUsuario(nome);
                return true;
            }
            else
            {
                Erro TelaDeErro = new Erro("001", "Usuário não encontrado no Banco de Dados", "Verifique se você digitou usuário e senha corretamente.", "Verifique se o caps lock está ativado.", "Reinicie o banco de dados", "", "");
                TelaDeErro.Show();
                return false;
            }
           

        }//APAGAR USUARIO

        public List<UsuarioModel> ListarTodosOsUsuario()//LISTAR TODOS OS USARIOS
        {
            List<UsuarioModel> todososusuarios = new List<UsuarioModel>();
            UsuarioModel usuario = new UsuarioModel();
            DAOUsuario dao = new DAOUsuario();
            try
            {
               todososusuarios = dao.ListarTodosOsusuarios();
            }
            catch (Exception e)
            {
                Erro TelaDeErro = new Erro("000", "Sem acesso ao bando de dados " + e, "Reinicie o programa", "Reinicie o computador", "Reinicie o banco de dados.", "", "");
                TelaDeErro.Show();
            }
            

            return todososusuarios;
        }

        public bool VerificaAdmin(string nome, string senha)
        {
            var dao = new DAOUsuario();
            var usuario = new UsuarioModel();

            usuario = dao.VerificaAdmin(nome, senha);

            if (usuario.Id == 1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }//VERIFiCAR ADM

        public string VerificaFerias(int id)
        {
            try
            {

            var DAO = new DAOUsuario();

            var Data_admissao = DAO.VerificaFerias(id);
            var Data_atual = Data.PegarDiaMesAnoAtual();

            Data_admissao = Data_admissao.Replace('/', '.');
            Data_atual = Data_atual.Replace('/', '.');

            double Admissao = Convert.ToDouble(Data_admissao);
            double Atual = Convert.ToDouble(Data_atual);

            var Ferias = Admissao - Atual;


            return Convert.ToString( Ferias );

            }
            catch (Exception)
            {

                return "ERRO";
            }

        }


    }

}

