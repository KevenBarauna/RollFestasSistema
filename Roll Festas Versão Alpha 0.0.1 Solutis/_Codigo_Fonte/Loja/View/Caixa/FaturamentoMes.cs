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

namespace Loja.View.Caixa
{
    public partial class FaturamentoMes : Form
    {
        public FaturamentoMes()
        {
            InitializeComponent();

            //DATA
            Controller tempo = new Controller();
            TxtData.Text = tempo.PegarMesAno();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            CaixaController caixa = new CaixaController();
            LblTotal.Text = "R$ " + caixa.MostrarTotalVendaMes(TxtData.Text);
        }
    }
}
