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

namespace RollFestas.View.Ponto
{
    public partial class BaterPonto : Form
    {
        public BaterPonto()
        {
            InitializeComponent();

            TxtNome.Text = Program._Usuario.Nome;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var Tela = new Home();
            Tela.Show();
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var pontoC = new PontoController();
            bool Sucesso = pontoC.BaterPonto(TxtNome.Text);
            if (Sucesso == true)
            {
                var Tela = new Home();
                Tela.Show();
                this.Close();
            }
        }
    }
}
