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
using Loja.Model;

namespace Loja.View.Venda
{
    public partial class PagarDepois : Form
    {
        public PagarDepois(String usuario, String valortotal, String valorpago, String TipoPagamento, String troco)
        {
            InitializeComponent();

            Controller tempo = new Controller();
            String data = tempo.PegarDiaMesAnoAtual();

            LblData.Text = LblData.Text + data;
            LblUsuario.Text =  usuario;

            LblValorTotal.Text =  valortotal;
            LblValorPago.Text =  valorpago;
            LblTipoDePagamento.Text = TipoPagamento;

            TxtValorRestante.Text = troco;


            if (String.IsNullOrEmpty(valorpago))
            {
                LblValorPago.Text = "0";
            }
            if (String.IsNullOrEmpty(valortotal))
            {
                LblValorTotal.Text = "0";
            }
            if (String.IsNullOrEmpty(valortotal) || troco.Contains("-"))
            {
                TxtValorRestante.Text = "0";
            }

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal ValorTotal = Convert.ToDecimal(LblValorTotal.Text);
                Decimal ValorPago = Convert.ToDecimal(LblValorPago.Text);
                Decimal ValorRestante = ValorTotal - ValorPago;
                TxtValorRestante.Text = Convert.ToString(ValorRestante);
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao converter");
            }

        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            //FINALIZAR

            Controller tempo = new Controller();
            String data = tempo.PegarDiaMesAnoAtual();

            //1 = PAGO
            //2 = PAGAR DEPOIS

            //FINALIZAR VENDA
            VendaController v = new VendaController();
            v.FinalizarVenda(data, LblUsuario.Text, LblValorTotal.Text, LblValorPago.Text, "0", LblTipoDePagamento.Text, 2, TxtValorRestante.Text);

            //DECREMENTA PRODUTO
             DAOVENDATEMP daotemp = new DAOVENDATEMP();
             List<ProdutoModel> lpm = new List<ProdutoModel>();
             lpm = daotemp.PegadoBanco();
             daotemp.DecrementaBanco(lpm);

            //MANDAR VALOR PAGO PARA O CAIXA
            Controler.CaixaController caixa = new Controler.CaixaController();
            caixa.SalvarNoCaixa(data, LblValorPago.Text, LblTipoDePagamento.Text, "");


            //GERAR RECIBO
            VendaModel VendaM = new VendaModel();

            VendaController venda = new VendaController();
            VendaM = venda.PegarIdDaUltimaVenda();

            String SaveData = tempo.DataparaSalvar();

            ReciboController recibo = new ReciboController();
            recibo.GerarReciboDeVendaPeloId(Convert.ToString(VendaM.Id), @"C:\Users\keven.barauna\Desktop\Roll Festas Versão Alpha Solutis\Comprovantes\Recibo_" + SaveData + "_" + VendaM.Id + ".pdf");

            this.Hide();

        }
    }
}
