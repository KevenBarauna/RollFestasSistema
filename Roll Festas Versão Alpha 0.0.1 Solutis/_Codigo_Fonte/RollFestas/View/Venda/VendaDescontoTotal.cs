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
using RollFestas.View.MensagemErro;

namespace RollFestas.View.Venda
{
    public partial class VendaDescontoTotal : Form
    {
        public VendaDescontoTotal(string Usuario, string Data, string ValorTotal, string TipoPagamento)
        {
            InitializeComponent();

            LblUsuario.Text = Usuario;
            LblData.Text = Data;
            LblValorTotalCheio.Text = ValorTotal;
            LblTipoDePagamento.Text = TipoPagamento;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int Porcentagem = Convert.ToInt32(TxtPorcentagem.Text);
                double ValorTotal = Convert.ToDouble(LblValorTotalCheio.Text);
                double valorFinal;

                valorFinal = (Porcentagem * ValorTotal) / 100;
                valorFinal = ValorTotal - valorFinal;
                LblValorTotalNovo.Text = valorFinal.ToString();
            }
            catch (Exception)
            {
                var TelaDeErro = new ErroController("ECP","Erro ao calcular","Verifique se os númeors foram digitados corretamente","","");
                TelaDeErro.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtValorRecebido.Text.Contains("."))
            {
                var TelaDeErro = new ErroController("EPN", "´Valor não válido", "Verifique se os números foram digitados corretamente", "Use somente números e virgula", "");
                TelaDeErro.Show();
            }
            else
            {
                try
                {
                    Decimal total = Convert.ToDecimal(LblValorTotalNovo.Text);
                    Decimal pagamento = Convert.ToDecimal(TxtValorRecebido.Text);
                    Decimal troco = total - pagamento;
                    TxtTroco.Text = Convert.ToString(troco * -1);
                }
                catch (Exception)
                {
                    var TelaDeErro = new ErroController("EPN", "´Valor não válido", "Verifique se os números foram digitados corretamente", "Use somente números e virgula", "");
                    TelaDeErro.Show();
                }

                if (TxtTroco.Text.Contains("-"))
                {
                    TxtTroco.Text = TxtTroco.Text;
                    var TelaDeErro = new ErroController("EPN", "Valor negativo", "", "", "");
                    TelaDeErro.Show();
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            var Tela = new Home();
            Tela.Show();
            this.Close();
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            var vendaC = new VendaController();
            bool Sucesso = vendaC.FinalizarVenda(LblData.Text,LblUsuario.Text,LblValorTotalNovo.Text,TxtValorRecebido.Text,TxtTroco.Text,LblTipoDePagamento.Text,"",1,"","",Program._Produtos,false);

            if (Sucesso == true)
            {
                Program._Produtos = null;
                var Tela = new Home();
                Tela.Show();
            }
        }
    }
}
