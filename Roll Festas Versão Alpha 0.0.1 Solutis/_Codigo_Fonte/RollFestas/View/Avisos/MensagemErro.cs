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
    public partial class Erro : Form
    {
        public Erro(string MensagemErro)
        {
            InitializeComponent();

            LblErro.Text = MensagemErro;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
