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

namespace Loja.View.Usuario
{
    public partial class ApagarUsuario : Form
    {
        public ApagarUsuario()
        {
            InitializeComponent();
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            bool sucesso = false;

            UsuarioController usuario = new UsuarioController();
            sucesso = usuario.ApagarUsuario(TxtPesquisa.Text);

            if (sucesso == true)
            {
                this.Hide();
            }
        }
    }
}
