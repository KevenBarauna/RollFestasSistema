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
using Loja.View.Usuario;
using Loja.View.Venda;

namespace Loja.View
{
    public partial class PermissaoAdm : Form
    {
        int TipoTelaEncaminhas;
        public PermissaoAdm(int TipoTela)
        {
            TipoTelaEncaminhas = TipoTela;
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            bool AcessoLiberado = false;
            var usuario = new UsuarioController();
            AcessoLiberado = usuario.VerificaAdmin(TxtUsuario.Text, TxtSenha.Text);
            if (AcessoLiberado == true)
            {
                this.Hide();

                if (TipoTelaEncaminhas == 1)
                {
                    AdicionarNovoUsuario Tela = new AdicionarNovoUsuario();
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
                    TodosOsUsuarios Tela = new TodosOsUsuarios();
                    Tela.Show();
                }
                else if (TipoTelaEncaminhas == 5)
                {
                    CancelarVendaPendente Tela = new CancelarVendaPendente();
                    Tela.Show();
                }

            }
        }
    }
}
