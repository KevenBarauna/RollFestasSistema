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
    public partial class FaturamentoDia : Form
    {
        public FaturamentoDia()
        {
            InitializeComponent();

            Controller tempo = new Controller();
            TxtData.Text = Date.PegarDiaMesAnoAtual();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            CaixaController caixa = new CaixaController();
            LblTotal.Text = "R$ " +  caixa.MostrarTotalVendaDia(TxtData.Text);

            
        }

        private void FaturamentoDia_Load(object sender, EventArgs e)
        {

        }
    }
}
