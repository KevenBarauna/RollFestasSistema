using System.Windows.Forms;
using RollFestas.Controllers;
using RollFestas.Models;
using RollFestas.View;

namespace RollFestas
{
    public partial class Login : Form
    {
        UsuarioController usuarioC = new UsuarioController();
        public Login()
        {
            InitializeComponent();

            //DEFINIR USUARIO LOGADO
            Program._Usuario = null;

            //TENTA CONCTAR COM BANCO DE DADOS
            var usuarioC = new UsuarioController();
            usuarioC.IniciaLogin();

            //SALVAR CAMINHOS
            Program._CaminhoReciboVenda = @"C:\Users\keven.barauna\Desktop";
            Program._CaminhoPlanilhaPonto = @"C:\Users\keven.barauna\Desktop";
        }

        private void BtnEntrar_Click(object sender, System.EventArgs e)
        {
            
            UsuarioModel usuarioM = usuarioC.Login(TxtUsuario.Text, TxtSenha.Text);
            
            if (usuarioM.Id != 0)
            {
                Program._Usuario = usuarioM;

                var Tela = new Home();
                Tela.Show();
                this.Hide();
            }
        }

        private void BtnSair_Click(object sender, System.EventArgs e)
        {
            Program._Usuario = null;
            Application.Exit();
        }
    }
}
