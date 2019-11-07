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

                string h = DateTime.Now.Hour.ToString();
                string m = DateTime.Now.Minute.ToString();

                string hora = h + ":" + m;
                string dia = DateTime.Now.Day.ToString();
                string mes = DateTime.Now.Month.ToString();
                string ano = DateTime.Now.Year.ToString();



                ponto.BaterPonto(TxtNome.Text, hora);

                this.Hide();
            }
            else
            {
                MessageBox.Show("usuário não encontrado");
            }

        }

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            Duvida_BaterPonto tela = new Duvida_BaterPonto();
            tela.Show();
        }
    }
}
