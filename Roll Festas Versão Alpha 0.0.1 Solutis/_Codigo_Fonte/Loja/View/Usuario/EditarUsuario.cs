using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.Controler;
using Loja.Model;

namespace Loja.View.Usuario
{
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            UsuarioController usuario = new UsuarioController();
            UsuarioModel usuarioeditavel = new UsuarioModel();

            usuarioeditavel = usuario.ExibirUsuario(txtPesquisa.Text);

            TxtNome.Text = usuarioeditavel.Nome;
            TxtSenha.Text = usuarioeditavel.Senha;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            bool sucesso = false;

            UsuarioController usuario = new UsuarioController();
            sucesso = usuario.EditarUsuario(TxtNome.Text, TxtSenha.Text ,txtPesquisa.Text);

            if (sucesso == true)
            {
                this.Hide();
            }

        }
    }
}
