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
using Loja.Model.DAO;
using Loja.View.Duvida;

namespace Loja.View.Venda
{
    public partial class NovaVenda : Form
    {

        Decimal _VT = 0;//VARIAVEL GLOBAL PARA CALCULAR VALOR TOTAL DOS PRODUTOS POR QUANITDADE
        List<ProdutoModel> _ListaProdutos = new List<ProdutoModel>();//LISTA DE PRODUTOS
        
        public NovaVenda()
        {
            InitializeComponent();

            // USUARIO
            DAOUsuario usuario = new DAOUsuario();
            UsuarioModel usuarioLogado = new UsuarioModel();

            usuarioLogado = usuario.PegarUsuarioLogado();
            LblUsuario.Text = usuarioLogado.Nome;

            //DATA
            String data = Date.PegarDiaMesAnoAtual();
            LblTestedata.Text = Convert.ToString(data);

            //INICAR TABELA CAIXA

            DAOCaixa daocaixa = new DAOCaixa();
            daocaixa.IniciarCaixa(Convert.ToString(data));

            //ZERAR TABELA TEMP
            DAOVENDATEMP temp = new DAOVENDATEMP();
            temp.ZerarTabela();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            
            var ProdutoModel = new ProdutoModel();
            var ProdutoController = new ProdutoController();

            ProdutoModel = ProdutoController.ExibirProduto(TxtId.Text);

            if (ProdutoModel.Id != 0)
            {
                //ADICIONAR NA LISTA
                ListViewItem list = new ListViewItem(ProdutoModel.Nome);
                list.SubItems.Add(TxtNumQuant.Value.ToString());
                ListItens.Items.Add(list);

                //CALCUAR POR QUANTIDADE
                VendaController VendaController = new VendaController();
                _VT += VendaController.CalcularPorQuantidade(ProdutoModel.Nome, TxtNumQuant.Value);
                TxtTotal.Text = Convert.ToString(_VT);

                //LIMPANDO DADOS
                TxtNumQuant.Value = 1;
                TxtId.Text = "";
                TxtId.Focus();

                //SALVA => QUANTIDADE - VALOR
                
                _ListaProdutos.Add(ProdutoModel);
               
            }

        }

        private void BtnCalcularValorItem_Click(object sender, EventArgs e)
        {
            _VT = 0;
            ListPesquisa.Items.Clear();
            //LBITEM.Items.Clear();
            TxtTotal.Text = "";
            LblTroco.Text = "";
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
            ListPesquisa.Items.Clear();
            List<ProdutoModel> PM = new List<ProdutoModel>();
            ProdutoController p = new ProdutoController();

            PM = p.ExibirProdutoPorNome(TxtPesquisa.Text);

            foreach (var us in PM)
            {
                ListViewItem list = new ListViewItem(Convert.ToString( us.Id ));
                list.SubItems.Add(us.Nome);
                list.SubItems.Add(us.Preco);
                ListPesquisa.Items.Add(list);
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
                    LblTroco.Text = Convert.ToString(troco * -1);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao calcular, digite os valores corretos");
                }

                if (LblTroco.Text.Contains("-"))
                {
                    LblTroco.Text = LblTroco.Text;
                    MessageBox.Show(" O Valor é Negativo");
                }
            }
        }

  

        private void button1_Click(object sender, EventArgs e)
        {

            //Forma de pagamento
            string TipoPagamento = null;
            if (RBDinheiro.Checked) TipoPagamento = RBDinheiro.Text;
            else if (RBCartao.Checked) TipoPagamento = RBCartao.Text;
            else if (RBOutros.Checked) TipoPagamento = RBOutros.Text;
            else if (RbDinCart.Checked) TipoPagamento = RbDinCart.Text;
           
            PagarDepois tela = new PagarDepois(LblUsuario.Text, TxtTotal.Text, TxtValor.Text, TipoPagamento, LblTroco.Text, _ListaProdutos);
            tela.Show();
            
        }

        private void RbDinCart_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDinCart.Checked)
            {
                this.TxtDinCart.ReadOnly = false;
                this.TxtDinCart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                this.LblDinCart.Visible = true;
                this.ImgAtencao.Visible = true;
                this.TxtDinCart.Visible = true;
            }
        }

        private void RBDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtDinCart.Text = "";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblDinCart.Visible = false;
            this.ImgAtencao.Visible = false;
            this.TxtDinCart.Visible = false;
        }

        private void RBCartao_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtDinCart.Text = "";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblDinCart.Visible = false;
            this.ImgAtencao.Visible = false;
            this.TxtDinCart.Visible = false;
        }

        private void RBOutros_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtDinCart.Text = "";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblDinCart.Visible = false;
            this.ImgAtencao.Visible = false;
            this.TxtDinCart.Visible = false;
        }

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            Duvida_NovaVenda_01 tela = new Duvida_NovaVenda_01();
            tela.Show();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            //LIMPA TUDO
            _VT = 0;
            ListPesquisa.Items.Clear();
            //LBITEM.Items.Clear();

            TxtTotal.Text = "";
            LblTroco.Text = "";
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

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
          
                //INFO => 1 = PAGO | 2 = PAGAR DEPOIS

                String data = Date.PegarDiaMesAnoAtual();

                //Forma de pagamento
                string TipoPagamento = null;
                if (RBDinheiro.Checked) TipoPagamento = RBDinheiro.Text;
                else if (RBCartao.Checked) TipoPagamento = RBCartao.Text;
                else if (RBOutros.Checked) TipoPagamento = RBOutros.Text;
                else if (RbDinCart.Checked) TipoPagamento = RbDinCart.Text;

                if (_ListaProdutos.Count == 0)
                {
                    Erro tela = new Erro("NPL", "Nenhum produto adicionado na lista", "Adicione pelo menos um produto para realizar a venda", "", "", "", "");
                    tela.Show();
                     //throw new Exception("Nenhum produto adicionado na lista");
                }
                else { 
                //SALVAR VENDA
                var vendaController = new VendaController();
                vendaController.FinalizarVenda(data, LblUsuario.Text, TxtTotal.Text, TxtValor.Text, LblTroco.Text, TipoPagamento, 1, "", "");

                //DECREMENTAR PRODUTOS
                var produtoDAO = new DAOProduto();
                foreach (var produto in _ListaProdutos)
                {
                    produtoDAO.DecrementaQuantidade(produto.Nome, produto.Quantidade_Estoque);
                }

                //SALVAR NO CAIXA
                CaixaController caixaController = new CaixaController();
                caixaController.SalvarNoCaixa(data, TxtTotal.Text, TipoPagamento, TxtDinCart.Text);

                //LIMPAR
                _VT = 0;
                _ListaProdutos.Clear();
                ListPesquisa.Items.Clear();
                ListItens.Items.Clear();

                TxtTotal.Text = "";
                LblTroco.Text = "";
                TxtValor.Text = "";
                TxtPesquisa.Text = "";
                TxtId.Text = "";
                TxtNumQuant.Value = 1;
                TxtDinCart.Text = "";


                //GERAR RECIBO
                var vendaModel = new VendaModel();
                var reciboController = new ReciboController();
                var SaveData = Date.DataPararCriarPasta();

                vendaModel = vendaController.PegarIdDaUltimaVenda();

                var local = Caminhos.CaminhoComprovante();


                var NomeArquivo = $@"{local}\Recibo_{SaveData}_{vendaModel.Id}.pdf";
                reciboController.GerarReciboDeVendaPeloId(Convert.ToString(vendaModel.Id), NomeArquivo);
            }

        }//FINALIZAR VENDA

        private void button1_Click_1(object sender, EventArgs e)
        {

            //Forma de pagamento
            string TipoPagamento = null;
            if (RBDinheiro.Checked) TipoPagamento = RBDinheiro.Text;
            else if (RBCartao.Checked) TipoPagamento = RBCartao.Text;
            else if (RBOutros.Checked) TipoPagamento = RBOutros.Text;
            else if (RbDinCart.Checked) TipoPagamento = RbDinCart.Text;

            
            DescontoCompra tela = new DescontoCompra(LblUsuario.Text, TxtTotal.Text, TipoPagamento, _ListaProdutos);
            tela.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DescontoProduto tela = new DescontoProduto(LblUsuario.Text, TxtTotal.Text, "", _ListaProdutos);
            tela.Show();
            this.Hide();
        }
    }
}
