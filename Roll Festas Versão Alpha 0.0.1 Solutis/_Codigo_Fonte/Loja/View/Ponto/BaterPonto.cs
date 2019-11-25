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
using Loja.View.Duvida;

namespace Loja.View.Ponto
{
    public partial class BaterPonto : Form
    {
        public BaterPonto()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            bool UsuarioExiste = false;

            PontoController ponto = new PontoController();
            UsuarioExiste = ponto.VerificaSeUsuarioExiste(TxtNome.Text);

            if (UsuarioExiste == true)
            {

                ponto.BaterPonto(TxtNome.Text);

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }

        }

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            Duvida_BaterPonto tela = new Duvida_BaterPonto();
            tela.Show();
        }
    }
}
