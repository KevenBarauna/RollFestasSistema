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
using RollFestas.ServiçosExterno;
using RollFestas.Utils;

namespace RollFestas.View.Evento
{
    public partial class NovoEvento : Form
    {
        string TipoEvento;
        string TipoPagamento = "Dinheiro";

        public NovoEvento()
        {
            InitializeComponent();
        }

        private void BtnPesquisarEnd_Click(object sender, EventArgs e)
        {
            var End = ApiCorreios.ConsultaCEP(TxtCep.Text);
            TxtBairro.Text = End.Bairro;
            TxtCidade.Text = End.Cidade;
            TxtEndereco.Text = End.Endereco;
            TxtLocal.Text = End.Local;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var Tela = new Home(false);
            Tela.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LblTroco.Text = CalculoValores.CalcularTroco(TxtValorTotal.Text,TxtvalorEntrada.Text);

            if (LblTroco.Text == "PENDENTE")
            {
                var Tela = new PagarEventoPendente(TipoPagamento, TxtvalorEntrada.Text, TxtValorTotal.Text, TxtNome.Text, TxtCep.Text, TxtLocal.Text, TxtTel1.Text, TxtTel2.Text, TxtEmail.Text, TipoEvento, TxtData.Text, TxtHora.Text,TxtDinCart.Text,TxtDescEvento.Text); ;
                Tela.Show();
                this.Close();
            }
           
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            var eventoC = new EventoController();
            bool Sucesso = eventoC.NovoEvento(TxtCep.Text,TxtLocal.Text,TxtDescEvento.Text,TxtNome.Text,TxtTel1.Text,TxtTel2.Text,TxtEmail.Text,TipoEvento,TxtData.Text,TxtHora.Text,TxtValorTotal.Text,TxtvalorEntrada.Text,2, TipoPagamento, TxtDinCart.Text, 1, LblTroco.Text);
            if (Sucesso == true)
            {
                TxtCep.Text = "";
                TxtCidade.Text = "";
                TxtEndereco.Text = "";
                TxtBairro.Text = "";
                TxtNome.Text = "";
                TxtTel1.Text = "";
                TxtTel2.Text = "";
                TxtEmail.Text = "";
                TxtValorTotal.Text = "";
                TxtvalorEntrada.Text = "";
                TxtData.Text = "";
                TxtHora.Text = "";
                TxtLocal.Text = "";
                TxtDescEvento.Text = "";
                LblTroco.Text = "";
            }
        }

        private void RBDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            TipoPagamento = "Dinheiro";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.Visible = false;
            this.TxtDinCart.Visible = false;
        }

        private void RBCartao_CheckedChanged(object sender, EventArgs e)
        {
            TipoPagamento = "Cartão";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.Visible = false;
            this.TxtDinCart.Visible = false;
        }

        private void RBOutros_CheckedChanged(object sender, EventArgs e)
        {
            TipoPagamento = "Outros";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.Visible = false;
            this.TxtDinCart.Visible = false;
        }

        private void RbDinCart_CheckedChanged(object sender, EventArgs e)
        {
            TipoPagamento = "Dinheiro e Cartão";
            this.TxtDinCart.ReadOnly = false;
            this.TxtDinCart.Visible = true;
            this.TxtDinCart.Visible = true;
        }

        private void RbAniversaio_CheckedChanged(object sender, EventArgs e)
        {
            TipoEvento = "Aniversário";
        }

        private void RbMakingof_CheckedChanged(object sender, EventArgs e)
        {
            TipoEvento = "Making of";
        }

        private void RbCasamento_CheckedChanged(object sender, EventArgs e)
        {
            TipoEvento = "Casamento";
        }

        private void RbBodas_CheckedChanged(object sender, EventArgs e)
        {
            TipoEvento = "Bodas";
        }

        private void RbBatizado_CheckedChanged(object sender, EventArgs e)
        {
            TipoEvento = "Batizado";
        }

        private void RbFesta_CheckedChanged(object sender, EventArgs e)
        {
            TipoEvento = "Festa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Tela = new PagarEventoPendente(TipoPagamento, TxtvalorEntrada.Text, TxtValorTotal.Text, TxtNome.Text, TxtCep.Text, TxtLocal.Text, TxtTel1.Text, TxtTel2.Text, TxtEmail.Text, TipoEvento, TxtData.Text, TxtHora.Text, TxtDinCart.Text, TxtDescEvento.Text); ;
            Tela.Show();
            this.Close();
        }
    }
}
