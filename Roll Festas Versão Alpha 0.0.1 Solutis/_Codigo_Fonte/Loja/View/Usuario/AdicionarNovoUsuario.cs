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

namespace Loja.View
{
    public partial class AdicionarNovoUsuario : Form
    {
        public AdicionarNovoUsuario()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            bool sucesso = false;

            UsuarioController usuario = new UsuarioController();
            sucesso = usuario.Cadastrar(TxtNome.Text,TxtSenha.Text,TxtConfSenha.Text);

            if (sucesso == true)
            {
                this.Hide();
            }
            
        }
        
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AdicionarNovoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
