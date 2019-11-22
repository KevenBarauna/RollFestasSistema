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

namespace Loja.View.Venda
{
    public partial class PagarVendaPendente : Form
    {
        String IdParaDecrementar;
        public PagarVendaPendente()
        {
            InitializeComponent();

            // USUARIO
            DAOUsuario usuario = new DAOUsuario();
            UsuarioModel usuarioLogado = new UsuarioModel();

            usuarioLogado = usuario.PegarUsuarioLogado();
            LblUsuario.Text = usuarioLogado.Nome;

            //DATA
            Controller tempo = new Controller();
            String hora = tempo.PegarDiaeHora();
            LblTestedata.Text = Convert.ToString(hora);

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            //OK ADICIONANDO NA LISTA
            LBITEM.Items.Clear();
            VendaController venda = new VendaController();
            VendaModel vendaM = new VendaModel();

            vendaM = venda.ListarVendasPendentesPorId(TxtId.Text);

            if (String.IsNullOrEmpty( vendaM.ValorPendente))
            {
                MessageBox.Show("Venda não encontrada");
            }
            else
            {
                LBITEM.Items.Add(vendaM.ValorPendente);
                IdParaDecrementar = Convert.ToString( vendaM.Id);
                TxtId.Text = "";
                TxtId.Focus();

                //CALCULAR TOTAL
                Decimal VT = 0;
                VT = Convert.ToDecimal(vendaM.ValorPendente);
                TxtTotal.Text = Convert.ToString(VT);
            }
                
            
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            LvPesquisa.Items.Clear();
            List<VendaModel> VM = new List<VendaModel>();
            VendaController v = new VendaController();

            VM = v.ListarVendasPendentes();

            foreach (var us in VM)
            {
                ListViewItem list = new ListViewItem(Convert.ToString(us.Id));
                list.SubItems.Add(us.ValorPendente);
                list.SubItems.Add(us.Data);
                list.SubItems.Add(us.nome);
                LvPesquisa.Items.Add(list);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LvPesquisa.Items.Clear();
            LBITEM.Items.Clear();
            TxtTotal.Text = "";
            TxtTroco.Text = "";
            TxtValor.Text = "";
            TxtId.Text = "";
            TxtDinCart.Text = "";
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtValor.Text.Contains("."))
            {
                MessageBox.Show("Para calcular substitua o ponto po virgula");
            }
            else
            {
                Decimal total = Convert.ToDecimal(TxtTotal.Text);
                Decimal pagamento = Convert.ToDecimal(TxtValor.Text);
                Decimal troco = total - pagamento;
                TxtTroco.Text = Convert.ToString(troco * -1);
                if (TxtTroco.Text.Contains("-"))
                {
                    TxtTroco.Text = TxtTroco.Text;
                    MessageBox.Show(" O Valor é Negativo");
                }
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
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
                v.FinalizarVenda(data, LblUsuario.Text, TxtTotal.Text, TxtValor.Text, TxtTroco.Text, TipoPagamento, 1, "","");

                //RETIRAR VENDA PENDETE
                VendaController venda = new VendaController();
                venda.RetirarPendencia(IdParaDecrementar);

                //SALVAR NO CAIXA
                Controler.CaixaController caixa = new Controler.CaixaController();
                caixa.SalvarNoCaixa(data, TxtTotal.Text, TipoPagamento, TxtDinCart.Text);

                //LIMPA TUDO
                LvPesquisa.Items.Clear();
                LBITEM.Items.Clear();
                TxtTotal.Text = "";
                TxtTroco.Text = "";
                TxtValor.Text = "";
                TxtId.Text = "";
                TxtDinCart.Text = "";
            }


        }

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            Duvida_PagaPendencia tela = new Duvida_PagaPendencia();
            tela.Show();
        }

        private void RBDinheiro_CheckedChanged_1(object sender, EventArgs e)
        {
            this.TxtDinCart.Text = "";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblDinCart.Visible = false;
        }

        private void RBCartao_CheckedChanged_1(object sender, EventArgs e)
        {
            this.TxtDinCart.Text = "";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblDinCart.Visible = false;
        }

        private void RBOutros_CheckedChanged_1(object sender, EventArgs e)
        {
            this.TxtDinCart.Text = "";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblDinCart.Visible = false;
        }

        private void RbDinCart_CheckedChanged_1(object sender, EventArgs e)
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

