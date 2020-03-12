using System.Windows.Forms;
using RollFestas.Controllers;
using RollFestas.Models;
using RollFestas.Utils;
using RollFestas.View;
using RollFestas.View.MensagemErro;

namespace RollFestas
{
    public partial class Login : Form
    {
        UsuarioController usuarioC = new UsuarioController();
        public Login()
        {
            InitializeComponent();


            //SALVAR CAMINHOS
            Program._CaminhoReciboVenda = @"C:\SistemaRollFestas";
            Program._CaminhoPlanilhaPonto = @"C:\SistemaRollFestas";
            Program._CaminhoCacheErro = @"C:\SistemaRollFestas";
            Program._CaminhoArquivoDuvida = @"C:\Users\keven.barauna\Documents\_Projetos\_Pessoal\_SistemaRollFestas\Roll Festas Versão Alpha 0.0.1 Solutis\_Codigo_Fonte\RollFestas\Content\Arquivos";

            //DEFINIR USUARIO LOGADO
            Program._Usuario = null;

            //TENTA CONCTAR COM BANCO DE DADOS
            var usuarioC = new UsuarioController();
            usuarioC.IniciaLogin();

            //INICIA CAIXA
            var caixaC = new CaixaController();
            bool Sucesso = caixaC.IniciarCaixaDia(GetDate.PegarDiaMesAnoAtual());
            if (Sucesso == false)
            {
                Application.Exit();
            }



        }

        private void BtnEntrar_Click(object sender, System.EventArgs e)
        {
            
            UsuarioModel usuarioM = usuarioC.Login(TxtUsuario.Text, TxtSenha.Text);
            
            if (usuarioM.Id != 0)
            {
                Program._Usuario = usuarioM;

                var Tela = new Home(true);
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
