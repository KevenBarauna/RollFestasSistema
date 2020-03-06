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
using Loja.Controler.Utils;

namespace Loja.View.Caixa
{
    public partial class FaturamentoAno : Form
    {
        public FaturamentoAno()
        {
            InitializeComponent();

            TxtData.Text = Date.PegarAno();


        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            CaixaController caixa = new CaixaController();
            LblTotal.Text = "R$ " + caixa.MostrarTotalVendaAno(TxtData.Text);
        }

    }
}
