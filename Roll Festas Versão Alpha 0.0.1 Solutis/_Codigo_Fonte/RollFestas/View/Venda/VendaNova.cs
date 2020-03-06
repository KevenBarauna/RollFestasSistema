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
using RollFestas.Models;
using RollFestas.Utils;
using RollFestas.View.Avisos;
using RollFestas.View.MensagemErro;

namespace RollFestas.View.Venda
{
    public partial class VendaNova : Form
    {

        decimal _ValorTotal = 0;//VARIAVEL GLOBAL PARA CALCULAR VALOR TOTAL DOS PRODUTOS POR QUANITDADE
        List<ProdutoModel> _ListaProdutos = new List<ProdutoModel>();//LISTA DE PRODUTOS
        string TipoPagamento = "Dinheiro";

        public VendaNova()
        {
            InitializeComponent();

            //CARREGAR USUÁRIO
            LblUsuario.Text = Program._Usuario.Nome;

            //CARREGAR DATA
            LblData.Text = GetDate.PegarDiaMesAnoAtual();

            //INICIAR CAIXA
            CaixaController caixaC = new CaixaController();
            caixaC.IniciarCaixaDia(LblData.Text);
        }

        public void LimparDados()
        {
            _ValorTotal = 0;
            _ListaProdutos.Clear();

            ListPesquisa.Items.Clear();
            ListItens.Items.Clear();

            LblTotal.Text = "";
            LblTroco.Text = "";
            TxtValorRecebido.Text = "";
            TxtPesquisa.Text = "";
            TxtId.Text = "";
            TxtNumQuant.Value = 1;
            TxtDinCart.Text = "";
        }

        #region CHECKBOX
        private void RBDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtDinCart.Text = "";
            this.TxtDinCart.ReadOnly = true;

            this.LblDinCart.Visible = false;
            this.ImgAtencao.Visible = false;
            this.TxtDinCart.Visible = false;

            TipoPagamento = "Dinheiro";
        }

        private void RBCartao_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtDinCart.Text = "";
            this.TxtDinCart.ReadOnly = true;

            this.LblDinCart.Visible = false;
            this.ImgAtencao.Visible = false;
            this.TxtDinCart.Visible = false;

            TipoPagamento = "Cartão";
        }

        private void RBOutros_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtDinCart.Text = "";
            this.TxtDinCart.ReadOnly = true;

            this.LblDinCart.Visible = false;
            this.ImgAtencao.Visible = false;
            this.TxtDinCart.Visible = false;

            TipoPagamento = "Outros";
        }

        private void RbDinCart_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDinCart.Checked)
            {
                this.TxtDinCart.ReadOnly = false;

                this.LblDinCart.Visible = true;
                this.ImgAtencao.Visible = true;
                this.TxtDinCart.Visible = true;

                TipoPagamento = "Dinheiro e Cartão";
            }
        }

        #endregion

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            var produtoM = new ProdutoModel();
            var produtoC = new ProdutoController();
            var vendaC = new VendaController();

            produtoM = produtoC.ExibirProduto(TxtId.Text);

            if (produtoM.Id != 0)
            {
                //ADICIONAR NA LISTA 1
                ListViewItem list = new ListViewItem(produtoM.Nome);
                list.SubItems.Add(TxtNumQuant.Value.ToString());
                ListItens.Items.Add(list);

                //VALOR TOTAL
                decimal ValorProduto = Convert.ToDecimal(produtoM.Preco);
                ValorProduto = ValorProduto * TxtNumQuant.Value;
                _ValorTotal += ValorProduto;
                LblTotal.Text = _ValorTotal.ToString();

                //SALVA => QUANTIDADE - VALOR
                produtoM.QuantidadeVenda = TxtNumQuant.Value.ToString();
                _ListaProdutos.Add(produtoM);

                //LIMPANDO DADOS
                TxtNumQuant.Value = 1;
                TxtId.Text = "";
                TxtId.Focus();


            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            ListPesquisa.Items.Clear();
            var ListaProduto = new List<ProdutoModel>();
            var produtoC = new ProdutoController();

            ListaProduto = produtoC.ExibirProdutoPorNome(TxtPesquisa.Text);

            foreach (var produto in ListaProduto)
            {
                ListViewItem list = new ListViewItem(Convert.ToString(produto.Id));
                list.SubItems.Add(produto.Nome);
                list.SubItems.Add(produto.Preco);
                ListPesquisa.Items.Add(list);
            }

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            var vendaC = new VendaController();
            string Troco = vendaC.CalcularTroco(LblTotal.Text, TxtValorRecebido.Text);

            if (Troco != "PENDENTE")
            {
                LblTroco.Text = Troco;
            }
            else
            {
                Program._Produtos = null;
                Program._Produtos = _ListaProdutos;

                if (Program._Produtos.Count <= 0)
                {
                    var TelaErro = new Erro("Adicione pelo menos produto deve ser adicionado na lista");
                    TelaErro.Show();
                }
                else
                {
                    var Tela = new VendaSemPagamento(LblTotal.Text, TxtValorRecebido.Text, TipoPagamento, LblTroco.Text);
                    Tela.Show();
                    this.Hide();
                }
                
            }



        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            var vendaC = new VendaController();
            bool SucessoVenda = vendaC.FinalizarVenda(LblData.Text, LblUsuario.Text, LblTotal.Text, TxtValorRecebido.Text, LblTroco.Text, TipoPagamento, TxtDinCart.Text ,1, null, null,_ListaProdutos,false);

            if (SucessoVenda == true)
            {
                LimparDados();
            }


        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            var Tela = new Home();
            Tela.Show();
            this.Hide();
        }

        private void BtnPagarDepos_Click(object sender, EventArgs e)
        {
            Program._Produtos = null;
            Program._Produtos = _ListaProdutos;

            if (Program._Produtos.Count <= 0)
            {
                var TelaErro = new Erro("Adicione pelo menos produto deve ser adicionado na lista");
                TelaErro.Show();
            }
            else if (string.IsNullOrEmpty(TxtValorRecebido.Text))
            {
                var TelaErro = new Erro("Informe o valor recebido pelo cliente, caso não tenha recebido informe o valor zero");
                TelaErro.Show();
            }
            else
            {
                var Tela = new VendaSemPagamento(LblTotal.Text, TxtValorRecebido.Text, TipoPagamento, LblTroco.Text);
                Tela.Show();
                this.Hide();
            }

            
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void BtnDescontoCompra_Click(object sender, EventArgs e)
        {
            Program._Produtos = null;
            Program._Produtos = _ListaProdutos;
            var Tela = new VendaDescontoTotal(LblUsuario.Text,LblData.Text,LblTotal.Text,TipoPagamento);
            Tela.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program._Produtos = null;
            Program._Produtos = _ListaProdutos;
            var Tela = new VendaDescontoProduto(LblUsuario.Text, LblData.Text, LblTotal.Text, TipoPagamento);
            Tela.Show();
            this.Hide();
        }
    }
}
