using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RollFestas.Controllers;

namespace RollFestas.View.Usuario
{
    public partial class NovoUsuario : Form
    {
        public NovoUsuario()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var usuarioC = new UsuarioController();
            bool Sucesso = usuarioC.Cadastrar(TxtNome.Text,TxtSenha.Text,TxtEmail.Text,TxtDataAdmissao.Text,TxtConfSenha.Text);

            if (Sucesso == true)
            {
                TxtNome.Text = "";
                TxtSenha.Text = "";
                TxtEmail.Text = "";
                TxtDataAdmissao.Text = "";
                TxtConfSenha.Text = "";

            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var Tela = new Home(false);
            Tela.Show();
            this.Close();
        }

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Program._CaminhoArquivoDuvida + @"\Duvida_Usuario.pdf");
        }
    }
}
