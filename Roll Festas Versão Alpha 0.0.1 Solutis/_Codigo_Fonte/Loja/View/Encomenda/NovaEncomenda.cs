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
using Loja.View.Duvida;

namespace Loja.View.Encomenda
{
    public partial class NovaEncomenda : Form
    {
        public NovaEncomenda()
        {
            InitializeComponent();

            //DATA
            Controller tempo = new Controller();
            String hora = tempo.PegarDiaeHora();
            TxtDataEntrada.Text = Convert.ToString(hora);
            TxtDataEntrega.Text = Convert.ToString(hora);
            LblTestedata.Text = Convert.ToString(hora);

            //USUARIO
            DAOUsuario usuario = new DAOUsuario();
            UsuarioModel us = new UsuarioModel();
            us = usuario.PegarUsuarioLogado();
            LblUsuario.Text = us.Nome;


            //INICAR TABELA CAIXA
            String data = tempo.PegarDiaMesAnoAtual();

            DAOCaixa daocaixa = new DAOCaixa();
            daocaixa.IniciarCaixa(Convert.ToString(data));
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            bool tudocerto = true;

            if (TxtValor.Text.Contains("."))
            {
                MessageBox.Show("O campo preço não pode conter PONTO, substitua por virgula");
                tudocerto = false;
            }
            else if (tudocerto == true)
            {
                EncomendaController encomenda = new EncomendaController();
                encomenda.NovaEncomenda(TxtTipo.Text, TxtDataEntrada.Text, TxtDataEntrega.Text, TxtTema.Text, TxtQuantidade.Text, TxtValor.Text, txtDescricao.Text);

                //SALVAR VENDA

                //1 = PAGO
                //2 = PAGAR DEPOIS
                Controller tempo = new Controller();
                String data = tempo.PegarDiaMesAnoAtual();

                String TipoPagamento = "Não selecionado";
                bool TodasAsInformacoes = false;

                if (RBDinheiro.Checked)
                {
                    TipoPagamento = "Dinheiro";
                    TodasAsInformacoes = true;
                }
                else if (RBCartao.Checked)
                {
                    TipoPagamento = "Cartão";
                    TodasAsInformacoes = true;
                }
                else if (RbDinCart.Checked)
                {
                    TipoPagamento = "Dinheiro e Cartão";
                    TodasAsInformacoes = true;

                }
                else if (RBOutros.Checked)
                {
                    TipoPagamento = "Outros";
                    TodasAsInformacoes = true;
                }
                else if (!RBDinheiro.Checked && !RBCartao.Checked && !RbDinCart.Checked && !RBOutros.Checked)
                {
                    MessageBox.Show("Informe a forma de pagamento");
                }




                if (TodasAsInformacoes == true)
                {
                    //SALVAR VENDA
                    VendaController v = new VendaController();
                    v.FinalizarVenda(data , LblUsuario.Text , TxtValor.Text , TxtValorpago.Text , TxtTroco.Text , TipoPagamento , 1 , "","");
                    //SALVAR NO CAIXA
                    Controler.CaixaController caixa = new Controler.CaixaController();
                    caixa.SalvarNoCaixa(data, TxtValor.Text, TipoPagamento, TxtDinCart.Text);

                    //LIMPA TUDO
                    TxtTipo.Text = "";
                    TxtQuantidade.Text = "";
                    TxtValor.Text = "";
                    TxtTema.Text = "";
                    txtDescricao.Text = "";
                    TxtValorpago.Text = "";
                    TxtTroco.Text = "";


                    //GERAR RECIBO
                    VendaModel VendaM = new VendaModel();

                    VendaController venda = new VendaController();
                    VendaM = venda.PegarIdDaUltimaVenda();

                    String SaveData = tempo.DataparaSalvar();

                    ReciboController recibo = new ReciboController();
                    recibo.GerarReciboDeVendaPeloId(Convert.ToString(VendaM.Id), @"C:\Users\keven.barauna\Desktop\Roll Festas Versão Alpha Solutis\Comprovantes\Recibo_" + SaveData + "_" + VendaM.Id + ".pdf");
                }


            }

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtValor.Text.Contains("."))
            {
                MessageBox.Show("Para calcular substitua o ponto por virgula");
            }
            else if (TxtValor.Text.Contains("."))
            {
                MessageBox.Show("Para calcular substitua o ponto por virgula");
            }
            else
            {
                try
                {
                    Decimal total = Convert.ToDecimal(TxtValor.Text);
                    Decimal pagamento = Convert.ToDecimal(TxtValorpago.Text);
                    Decimal troco = total - pagamento;
                    TxtTroco.Text = Convert.ToString(troco * -1);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro, você digitou os valores corretamente?");
                }

                if (TxtTroco.Text.Contains("-"))
                {
                    TxtTroco.Text = TxtTroco.Text;
                    MessageBox.Show(" O Valor é Negativo");
                }
            }
        }

        private void BtnPagarDepos_Click(object sender, EventArgs e)
        {
            //FINALIZAR

            Controller tempo = new Controller();
            String data = tempo.PegarDiaMesAnoAtual();

            String TipoPagamento="";

            if (RBDinheiro.Checked)
            {
                TipoPagamento = "Dinheiro";
            }
            else if (RBCartao.Checked)
            {
                TipoPagamento = "Cartão";
            }
            else if (RbDinCart.Checked)
            {
                TipoPagamento = "Dinheiro e Cartão";
            }
            else if (RBOutros.Checked)
            {
                TipoPagamento = "Outros";
            }


            //1 = PAGO
            //2 = PAGAR DEPOIS

            //FINALIZAR VENDA
            VendaController v = new VendaController();
            v.FinalizarVenda(data, LblUsuario.Text, TxtValor.Text, TxtValorpago.Text, TxtTroco.Text, TipoPagamento, 2, TxtValorPendente.Text,"");

            //DECREMENTA PRODUTO
            DAOVENDATEMP daotemp = new DAOVENDATEMP();
            List<ProdutoModel> lpm = new List<ProdutoModel>();
            lpm = daotemp.PegadoBanco();
            daotemp.DecrementaBanco(lpm);

            //MANDAR VALOR PAGO PARA O CAIXA
            Controler.CaixaController caixa = new Controler.CaixaController();
            caixa.SalvarNoCaixa(data, TxtValorpago.Text, TipoPagamento, "");


            //GERAR RECIBO
            VendaModel VendaM = new VendaModel();

            VendaController venda = new VendaController();
            VendaM = venda.PegarIdDaUltimaVenda();

            String SaveData = tempo.DataparaSalvar();

            ReciboController recibo = new ReciboController();
            recibo.GerarReciboDeVendaPeloId(Convert.ToString(VendaM.Id), @"C:\Users\keven.barauna\Desktop\Roll Festas Versão Alpha Solutis\Comprovantes\Recibo_" + SaveData + "_" + VendaM.Id + ".pdf");

            this.Hide();

        }

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            Duvida_NovaEncomenda tela = new Duvida_NovaEncomenda();
            tela.Show();
        }

        private void RBDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtDinCart.Text = "";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblDinCart.Visible = false;
        }

        private void RBCartao_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtDinCart.Text = "";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblDinCart.Visible = false;
        }

        private void RBOutros_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtDinCart.Text = "";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblDinCart.Visible = false;
        }

        private void RbDinCart_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDinCart.Checked)
            {
                this.TxtDinCart.ReadOnly = false;
                this.TxtDinCart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                this.LblDinCart.Visible = true;
            }
        }
    }
}
