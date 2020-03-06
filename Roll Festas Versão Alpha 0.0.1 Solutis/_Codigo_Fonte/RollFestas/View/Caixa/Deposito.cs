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

namespace RollFestas.View.Caixa
{
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            var Tela = new Home();
            Tela.Show();
            this.Hide();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var caixaC = new CaixaController();
            bool Sucesso = caixaC.Deposito(TxtValor.Text);

            if (Sucesso == true)
            {
               
                this.Hide();
                TxtValor.Text = "";
            }
        }
    }
}
