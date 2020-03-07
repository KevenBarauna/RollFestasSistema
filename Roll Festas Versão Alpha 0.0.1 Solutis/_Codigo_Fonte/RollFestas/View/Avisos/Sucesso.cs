using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollFestas.View.MensagemErro
{
    public partial class Sucesso : Form
    {
        public Sucesso(string Mensagem)
        {
            InitializeComponent();
            LblSucesso.Text = Mensagem;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
