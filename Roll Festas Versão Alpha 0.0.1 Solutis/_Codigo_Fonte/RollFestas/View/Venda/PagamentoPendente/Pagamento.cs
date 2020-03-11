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

namespace RollFestas.View.Venda.PagamentoPendente
{
    public partial class Pagamento : Form
    {
        string TipoPagamento = "Dinheiro";
        string Id;
        public Pagamento(string Usuario)
        {
            InitializeComponent();


            LblUsuario.Text = Usuario;
            LblData.Text = GetDate.PegarDiaMesAnoAtual();

            //CARREGAR LISTA
            CarregarLista();
        }

        public void CarregarLista()
        {
            listCodigo.Items.Clear();
            var vendaC = new VendaController();
            List<VendaModel> ListaVenda = vendaC.ListarVendasPendentes();

            foreach (var item in ListaVenda)
            {

                ListViewItem listP = new ListViewItem(Convert.ToString(item.Id));
                listP.SubItems.Add(Convert.ToString(item.ValorPendente));
                listP.SubItems.Add(Convert.ToString(item.NomeCliente));
                listCodigo.Items.Add(listP);

            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            var vendaC = new VendaController();
            var vendaM = new VendaModel();
            vendaM = vendaC.ExibirVendaPendentePorId(TxtId.Text);

            if (vendaM.Id != 0)
            {
                ListaVenda.Items.Clear();
                ListViewItem listP = new ListViewItem(vendaM.NomeCliente);
                listP.SubItems.Add(Convert.ToString(vendaM.ValorPendente));
                ListaVenda.Items.Add(listP);
                Id = vendaM.Id.ToString();
            }

            LblTotal.Text = vendaM.ValorPendente;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            LblTroco.Text = CalculoValores.CalcularTroco(TxtValorRecebido.Text, TxtValorRecebido.Text);
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
            var caixaC = new CaixaController();

            //SALVAR NO CAIXA
            caixaC.SalvarValor(LblData.Text, LblTotal.Text, TipoPagamento, TxtDinCart.Text);

            //RETIRAR PENDENCIA
            bool SucessoVenda = vendaC.RetirarPendencia(Id);

            if (SucessoVenda == true)
            {
                CarregarLista();
                TxtId.Text = "";
                TxtValorRecebido.Text = "";
                TxtDinCart.Text = "";
                ListaVenda.Items.Clear();
                Id = "0";

            }
        }

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
    }
}
