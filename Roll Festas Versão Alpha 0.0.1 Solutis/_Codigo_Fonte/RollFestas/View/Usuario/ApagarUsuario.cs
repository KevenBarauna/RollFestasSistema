using System;
using System.Windows.Forms;
using RollFestas.Controllers;
using RollFestas.View.Avisos;
using RollFestas.View.MensagemErro;

namespace RollFestas.View.Usuario
{
    public partial class ApagarUsuario : Form
    {
        public ApagarUsuario()
        {
            InitializeComponent();
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza que deseja apagar esse usuário do banco de dados?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var usuarioC = new UsuarioController();
                bool Sucesso = usuarioC.ApagarUsuario(TxtPesquisa.Text);

                if (Sucesso == true)
                {
                    TxtPesquisa.Text = "";
                }
            }

        }
    }
}
