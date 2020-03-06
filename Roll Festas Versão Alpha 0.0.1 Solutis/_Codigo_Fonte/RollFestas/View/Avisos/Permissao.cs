using System;
using System.Windows.Forms;
using RollFestas.Controllers;
using RollFestas.View.Usuario;
using RollFestas.View.Venda.PagamentoPendente;

namespace RollFestas.View.Avisos
{
    public partial class Permissao : Form
    {
        int TipoTelaEncaminhas;
        public Permissao(int InformacaoTela)
        {
            InitializeComponent();
            TipoTelaEncaminhas = InformacaoTela;
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            var usuarioC = new UsuarioController();
            bool AcessoLiberado = usuarioC.VerificaAdmin(TxtUsuario.Text, TxtSenha.Text);

            if (AcessoLiberado == true)
            {
                this.Hide();

                if (TipoTelaEncaminhas == 1)
                {
                    NovoUsuario Tela = new NovoUsuario();
                    Tela.Show();
                }
                else if (TipoTelaEncaminhas == 2)
                {
                    EditarUsuario Tela = new EditarUsuario();
                    Tela.Show();
                }
                else if (TipoTelaEncaminhas == 3)
                {
                    ApagarUsuario Tela = new ApagarUsuario();
                    Tela.Show();
                }
                else if (TipoTelaEncaminhas == 4)
                {
                    TodosUsuarios Tela = new TodosUsuarios();
                    Tela.Show();
                }
                else if (TipoTelaEncaminhas == 5)
                {
                    CancelarVendaPendente Tela = new CancelarVendaPendente(Program._Usuario.Nome);
                    Tela.Show();
                }

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
