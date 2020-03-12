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
        string ValorTipoPagamento;
        public VendaDescontoTotal(string Usuario, string Data, string ValorTotal, string TipoPagamento, string ParteCartao)
        {
            InitializeComponent();

            LblUsuario.Text = Usuario;
            LblData.Text = Data;
            TxtValorTotalCheio.Text = ValorTotal;
            ValorTipoPagamento = TipoPagamento;

            if (TipoPagamento == "Dinheiro")
            {
                RBDinheiro.Checked = true;
                TipoPagamento = "Dinheiro";
            }
            if (TipoPagamento == "Cartão")
            {
                RBCartao.Checked = true;
                TipoPagamento = "Cartão";
            }
            if (TipoPagamento == "Outros")
            {
                RBOutros.Checked = true;
                TipoPagamento = "Outros";
            }
            if (TipoPagamento == "Dinheiro e Cartão")
            {
                RbDinCart.Checked = true;
                TipoPagamento = "Dinheiro e Cartão";
                TxtDinCart.Visible = true;
                TxtDinCart.Text = ParteCartao;
            }

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int Porcentagem = Convert.ToInt32(TxtPorcentagem.Text);
                double ValorTotal = Convert.ToDouble(TxtValorTotalCheio.Text);
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
            var Tela = new Home(false);
            Tela.Show();
            this.Close();
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            var vendaC = new VendaController();
            bool Sucesso = vendaC.FinalizarVenda(LblData.Text,LblUsuario.Text,LblValorTotalNovo.Text,TxtValorRecebido.Text,ValorTipoPagamento,"",1,"","",Program._Produtos,false);

            if (Sucesso == true)
            {
                Program._Produtos = null;
                var Tela = new Home(false);
                Tela.Show();
            }
        }

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Program._CaminhoArquivoDuvida + @"\Duvida_Venda.pdf");
        }

        private void RBDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            RBDinheiro.Checked = true;
            ValorTipoPagamento = "Dinheiro";
            TxtDinCart.Visible = false;
        }

        private void RBCartao_CheckedChanged(object sender, EventArgs e)
        {
            RBCartao.Checked = true;
            ValorTipoPagamento = "Cartão";
            TxtDinCart.Visible = false;
        }

        private void RBOutros_CheckedChanged(object sender, EventArgs e)
        {
            RBOutros.Checked = true;
            ValorTipoPagamento = "Outros";
            TxtDinCart.Visible = false;
        }

        private void RbDinCart_CheckedChanged(object sender, EventArgs e)
        {
            RbDinCart.Checked = true;
            ValorTipoPagamento = "Dinheiro e Cartão";
            TxtDinCart.Visible = true;
        }
    }
}
