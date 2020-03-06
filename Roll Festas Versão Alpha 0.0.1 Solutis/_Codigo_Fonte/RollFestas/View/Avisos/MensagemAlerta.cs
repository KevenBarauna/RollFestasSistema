using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollFestas.View.Avisos
{
    public partial class MensagemAlerta : Form
    {
        public MensagemAlerta(string MensagemAlerta)
        {
            InitializeComponent();

            LblAlerta.Text = MensagemAlerta;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
