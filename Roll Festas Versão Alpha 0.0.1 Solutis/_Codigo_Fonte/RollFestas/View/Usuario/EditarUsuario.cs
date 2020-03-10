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
using RollFestas.Models;

namespace RollFestas.View.Usuario
{
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var usuarioC = new UsuarioController();
            bool Sucesso = usuarioC.EditarUsuario(TxtNome.Text, TxtSenha.Text, TxtSenhaConf.Text ,TxtEmail.Text, TxtDataAdmissao.Text, txtPesquisa.Text);

            if (Sucesso == true)
            {
                txtPesquisa.Text = "";
                TxtNome.Text = "";
                TxtSenha.Text = "";
                TxtEmail.Text = "";
                TxtDataAdmissao.Text = "";
                TxtSenhaConf.Text = "";

            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioC = new UsuarioController();
            UsuarioModel usuarioM = new UsuarioModel();

            usuarioM = usuarioC.ExibirUsuario(txtPesquisa.Text);

            TxtNome.Text = usuarioM.Nome;
            TxtSenha.Text = usuarioM.Senha;
            TxtSenhaConf.Text = usuarioM.Senha;
            TxtEmail.Text = usuarioM.Email;
            TxtDataAdmissao.Text = usuarioM.Data_Admissao;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var Tela = new Home(false);
            Tela.Show();
            this.Close();
        }
    }
}
