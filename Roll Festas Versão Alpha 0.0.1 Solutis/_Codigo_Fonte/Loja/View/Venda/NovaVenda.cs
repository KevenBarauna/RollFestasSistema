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
using Loja.Model.DAO;
using Loja.View.Duvida;

namespace Loja.View.Venda
{
    public partial class NovaVenda : Form
    {

        Decimal VT = 0;//VARIAVEL GLOBAL PARA CALCULAR VALOR TOTAL DOS PRODUTOS POR QUANITDADE
        public NovaVenda()
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

            //INICAR TABELA CAIXA
            String data = tempo.PegarDiaMesAnoAtual();

            DAOCaixa daocaixa = new DAOCaixa();
            daocaixa.IniciarCaixa(Convert.ToString(data));

            //ZERAR TABELA TEMP
            DAOVENDATEMP temp = new DAOVENDATEMP();
            temp.ZerarTabela();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            //OK ADICIONANDO NA LISTA
            ProdutoController produto = new ProdutoController();
            ProdutoModel produtoM = new ProdutoModel();
            
            produtoM = produto.ExibirProduto(TxtId.Text);

            if (produtoM.Id != 0)
            {
                LBITEM.Items.Add(produtoM.Nome);

                //CALCUAR POR QUANTIDADE
                VendaController v = new VendaController();
                VT += v.CalcularPorQuantidade(produtoM.Nome, TxtNumQuant.Value);
                TxtTotal.Text = Convert.ToString(VT);

                TxtId.Text = "";
                TxtId.Focus();

                //MANDA PRO BANCO TEMP
                produto.PreparaBanco(produtoM.Nome, TxtNumQuant.Value);

                TxtNumQuant.Value = 1;
            }
           

        }

        private void BtnCalcularValorItem_Click(object sender, EventArgs e)
        {
            VT = 0;
            LVPesquisa.Items.Clear();
            LBITEM.Items.Clear();
            TxtTotal.Text = "";
            TxtTroco.Text = "";
            TxtValor.Text = "";
            TxtPesquisa.Text = "";
            TxtId.Text = "";
            TxtNumQuant.Value = 1;
            TxtDinCart.Text = "";
            RBDinheiro.Checked = true;

            //ZERAR TABELA TEMP
            DAOVENDATEMP temp = new DAOVENDATEMP();
            temp.ZerarTabela();

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            LVPesquisa.Items.Clear();
            List<ProdutoModel> PM = new List<ProdutoModel>();
            ProdutoController p = new ProdutoController();

            PM = p.ExibirProdutoPorNome(TxtPesquisa.Text);

            foreach (var us in PM)
            {
                ListViewItem list = new ListViewItem(Convert.ToString( us.Id ));
                list.SubItems.Add(us.Nome);
                list.SubItems.Add(us.Preco);
                LVPesquisa.Items.Add(list);
            }

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtValor.Text.Contains("."))
            {
                MessageBox.Show("Para calcular substitua o ponto po virgula");
            }
            else
            {
                try
                {
                    Decimal total = Convert.ToDecimal(TxtTotal.Text);
                    Decimal pagamento = Convert.ToDecimal(TxtValor.Text);
                    Decimal troco = total - pagamento;
                    TxtTroco.Text = Convert.ToString(troco * -1);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao calcular, digite os valores corretos");
                }

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
                v.FinalizarVenda(data, LblUsuario.Text, TxtTotal.Text, TxtValor.Text, TxtTroco.Text, TipoPagamento,1,"","");

                //DECREMENTAR PRODUTOS
                DAOVENDATEMP daotemp = new DAOVENDATEMP();
                List<ProdutoModel> lpm = new List<ProdutoModel>();
                lpm = daotemp.PegadoBanco();
                daotemp.DecrementaBanco(lpm);

                //SALVAR NO CAIXA
                CaixaController caixa = new CaixaController();
                caixa.SalvarNoCaixa(data, TxtTotal.Text, TipoPagamento,TxtDinCart.Text);

                //LIMPA TUDO
                VT = 0;
                LVPesquisa.Items.Clear();
                LBITEM.Items.Clear();

                TxtTotal.Text = "";
                TxtTroco.Text = "";
                TxtValor.Text = "";
                TxtPesquisa.Text = "";
                TxtId.Text = "";
                TxtNumQuant.Value = 1;
                TxtDinCart.Text = "";
                TxtNumQuant.Value = 1;

                //GERAR RECIBO
                VendaModel VendaM = new VendaModel();

                VendaController venda = new VendaController();
                VendaM = venda.PegarIdDaUltimaVenda();

                String SaveData = tempo.DataPararCriarPasta();

                ReciboController recibo = new ReciboController();

                DAOCaminho caminho = new DAOCaminho();
                string caminhocomp = caminho.CaminhoComprovante();

                recibo.GerarReciboDeVendaPeloId(Convert.ToString( VendaM.Id ), @"" + caminhocomp + @"\Recibo_" + SaveData + "_" + VendaM.Id + ".pdf");

            }

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                PagarDepois tela = new PagarDepois(LblUsuario.Text, TxtTotal.Text, TxtValor.Text, TipoPagamento, TxtTroco.Text);
                tela.Show();
            }
            

            ////FINALIZAR

            ////1 = PAGO
            ////2 = PAGAR DEPOIS

            //String TipoPagamento = "Não selecionado";
            //bool TodasAsInformacoes = false;

            //if (RBDinheiro.Checked)
            //{
            //    TipoPagamento = "Dinheiro";
            //    TodasAsInformacoes = true;
            //}
            //else if (RBCartao.Checked)
            //{
            //    TipoPagamento = "Cartão";
            //    TodasAsInformacoes = true;
            //}
            //else if (RbDinCart.Checked)
            //{
            //    this.TxtDinCart.ReadOnly = false;
            //    TipoPagamento = "Dinheiro e Cartão";
            //    if (!String.IsNullOrEmpty(TxtDinCart.Text))
            //    {
            //        TodasAsInformacoes = true;
            //    }
            //    TodasAsInformacoes = false;
            //}
            //else if (RBOutros.Checked)
            //{
            //    TipoPagamento = "Outros";
            //    TodasAsInformacoes = true;
            //}
            //else if (!RBDinheiro.Checked && !RBCartao.Checked && !RbDinCart.Checked && !RBOutros.Checked)
            //{
            //    MessageBox.Show("Informe a forma de pagamento");
            //}




            //if (TodasAsInformacoes == true)
            //{
            //    //FINALIZAR VENDA
            //    VendaController v = new VendaController();
            //    v.FinalizarVEnda(LblTestedata.Text, LblUsuario.Text, TxtTotal.Text, TxtValor.Text, TxtTroco.Text, TipoPagamento,2);

            //    //DECREMENTA PRODUTO
            //    DAOVENDATEMP daotemp = new DAOVENDATEMP();
            //    List<ProdutoModel> lpm = new List<ProdutoModel>();
            //    lpm = daotemp.PegadoBanco();
            //    daotemp.DecrementaBanco(lpm);

            //    //LIMPA TUDO
            //    VT = 0;
            //    LVPesquisa.Items.Clear();
            //    LBITEM.Items.Clear();
            //    TxtTotal.Text = "";
            //    TxtTroco.Text = "";
            //    TxtValor.Text = "";
            //    TxtPesquisa.Text = "";
            //    TxtId.Text = "";
            //    TxtNumQuant.Value = 1;
            //    TxtDinCart.Text = "";

            //}

        }

        private void RbDinCart_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDinCart.Checked)
            {
                this.TxtDinCart.ReadOnly = false;
                this.TxtDinCart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                this.LblDinCart.Visible = true;
                this.ImgAtencao.Visible = true;
            }
        }

        private void RBDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtDinCart.Text = "";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblDinCart.Visible = false;
            this.ImgAtencao.Visible = false;
        }

        private void RBCartao_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtDinCart.Text = "";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblDinCart.Visible = false;
            this.ImgAtencao.Visible = false;
        }

        private void RBOutros_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtDinCart.Text = "";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblDinCart.Visible = false;
            this.ImgAtencao.Visible = false;
        }

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            Duvida_NovaVenda_01 tela = new Duvida_NovaVenda_01();
            tela.Show();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            //LIMPA TUDO
            VT = 0;
            LVPesquisa.Items.Clear();
            LBITEM.Items.Clear();

            TxtTotal.Text = "";
            TxtTroco.Text = "";
            TxtValor.Text = "";
            TxtPesquisa.Text = "";
            TxtId.Text = "";
            TxtNumQuant.Value = 1;
            TxtDinCart.Text = "";
            TxtNumQuant.Value = 1;

            //Voltar Home
            Home tela = new Home();
            tela.Show();
            this.Hide();
        }
    }
}
