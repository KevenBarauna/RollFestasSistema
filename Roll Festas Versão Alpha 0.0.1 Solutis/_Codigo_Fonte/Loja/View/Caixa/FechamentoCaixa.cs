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
    public partial class FechamentoCaixa : Form
    {
        public FechamentoCaixa()
        {
            InitializeComponent();

            String data;
            data = Data.PegarDiaMesAnoAtual();
            lblData.Text = Data.PegarDiaMesAnoAtual();

            //SOMAR TOTAL:
            CaixaController caixaC = new CaixaController();
            caixaC.TotalVendasNoDia(data);

            CaixaController caixa = new CaixaController();
            LblTotal.Text = LblTotal.Text +caixa.FechamentoDoDiaTotal(data);
            LblDinheiro.Text = LblDinheiro.Text + caixa.FechamentoDoDiaTotalDinheiro(data);
            LblCartao.Text = LblCartao.Text + caixa.FechamentoDoDiaTotalCartao(data);
            LblOutros.Text = LblOutros.Text + caixa.FechamentoDoDiaTotalOutros(data);
            TxtRetirada.Text = TxtRetirada.Text + caixa.FechamentoDoDiaTotalRetirada(data);
            TxtDeposito.Text = TxtDeposito.Text + caixa.FechamentoDoDiaTotalDeposito(data);


        }
    }
}
