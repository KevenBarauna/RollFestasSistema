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
using Loja.Model;
using Loja.View.Duvida;
using Loja.View.Venda;

namespace Loja.View.Encomenda
{
    public partial class NovaEncomenda : Form
    {
        public NovaEncomenda()
        {
            InitializeComponent();

            //DATA
            Controller tempo = new Controller();
            String hora = Data.PegarDiaeHora();
            TxtDataEntrada.Text = Convert.ToString(hora);
            TxtDataEntrega.Text = Convert.ToString(hora);
            LblTestedata.Text = Convert.ToString(hora);

            //USUARIO
            DAOUsuario usuario = new DAOUsuario();
            UsuarioModel us = new UsuarioModel();
            us = usuario.PegarUsuarioLogado();
            LblUsuario.Text = us.Nome;


            //INICAR TABELA CAIXA
            String data = Data.PegarDiaMesAnoAtual();

            DAOCaixa daocaixa = new DAOCaixa();
            daocaixa.IniciarCaixa(Convert.ToString(data));
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            
            EncomendaController encomenda = new EncomendaController();
           if ( encomenda.ValidarEncomenda(TxtTipo.Text, TxtDataEntrada.Text, TxtDataEntrega.Text, TxtTema.Text, TxtQuantidade.Text, TxtValor.Text, txtDescricao.Text))
            {
                
                encomenda.NovaEncomenda(TxtTipo.Text, TxtDataEntrada.Text, TxtDataEntrega.Text, TxtTema.Text, TxtQuantidade.Text, TxtValor.Text, txtDescricao.Text);

                //SALVAR VENDA | 1 = PAGO | 2 = PAGAR DEPOIS
                String TipoPagamento = "Não selecionado";

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

                String data = Data.PegarDiaMesAnoAtual();

                //SALVAR VENDA
                VendaController v = new VendaController();
                v.FinalizarVenda(data, LblUsuario.Text, TxtValor.Text, TxtValorpago.Text, TxtTroco.Text, TipoPagamento, 1, "", TxtNome.Text);

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

                string caminho = Caminhos.CaminhoComprovante();

                VendaModel VendaM = new VendaModel();

                VendaController venda = new VendaController();
                VendaM = venda.PegarIdDaUltimaVenda();

                String SaveData = Data.DataPararCriarPasta();

                ReciboController recibo = new ReciboController();
                recibo.GerarReciboDeVendaPeloId(Convert.ToString(VendaM.Id), @"" + caminho + @"\" + SaveData + "_" + VendaM.Id + ".pdf");


            }

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtValor.Text.Contains("."))
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

            //VALIDAR ENCOEMNDA

            EncomendaController encomenda = new EncomendaController();
            if (encomenda.ValidarEncomenda(TxtTipo.Text, TxtDataEntrada.Text, TxtDataEntrega.Text, TxtTema.Text, TxtQuantidade.Text, TxtValor.Text, txtDescricao.Text))
            {
                //DATA DA ENCOMENDA
                String data = Data.PegarDiaMesAnoAtual();

                //TIPO DE PAGAMENTO
                String TipoPagamento = "";

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

                //SALVAR VENDA
                VendaController v = new VendaController();
                v.FinalizarVenda(data, LblUsuario.Text, TxtValor.Text, TxtValorpago.Text, TxtTroco.Text, TipoPagamento, 2, TxtValorPendente.Text, TxtNome.Text);

                //MANDAR VALOR PAGO PARA O CAIXA
                Controler.CaixaController caixa = new Controler.CaixaController();
                caixa.SalvarNoCaixa(data, TxtValorpago.Text, TipoPagamento, TxtDinCart.Text);

                //LIMPA TUDO
                TxtTipo.Text = "";
                TxtQuantidade.Text = "";
                TxtValor.Text = "";
                TxtTema.Text = "";
                txtDescricao.Text = "";
                TxtValorpago.Text = "";
                TxtTroco.Text = "";

                //GERAR RECIBO


                string caminho = Caminhos.CaminhoComprovante();

                VendaModel VendaM = new VendaModel();

                VendaController venda = new VendaController();
                VendaM = venda.PegarIdDaUltimaVenda();

                String SaveData = Data.DataPararCriarPasta();

                ReciboController recibo = new ReciboController();
                recibo.GerarReciboDeVendaPeloId(Convert.ToString(VendaM.Id), @"" + caminho + @"\" + SaveData + "_" + VendaM.Id + ".pdf");

                this.Hide();
            }

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
