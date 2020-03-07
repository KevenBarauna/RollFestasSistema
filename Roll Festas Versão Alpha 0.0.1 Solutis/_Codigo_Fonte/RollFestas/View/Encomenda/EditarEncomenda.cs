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

namespace RollFestas.View.Encomenda
{
    public partial class EditarEncomenda : Form
    {
        string Id = "0";
        int Entregue = 1;
        public EditarEncomenda()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            var encomendaC = new EncomendaController();

            EncomendaModel encomendaM = encomendaC.ExibirDetalhesdoDaEncomenda(txtPesquisa.Text);

            if (encomendaM.Id != 0)
            {
                TxtTipo.Text = encomendaM.TipoServico;
                TxtQuantidade.Text = encomendaM.Quantidade;
                TxtDataPedido.Text = encomendaM.DataEntrada;
                TxtDataEntrega.Text = encomendaM.DataEntrega;
                TxtValor.Text = encomendaM.Valor;
                TxtTema.Text = encomendaM.Tema;
                TxtNomeCliente.Text = encomendaM.NomeCliente;
                txtDescricao.Text = encomendaM.Descricao;

                Id = encomendaM.Id.ToString();

                if (encomendaM.Entregue == 2)
                {
                    CbAviso.Checked = true;
                }


            }
        }

        private void CbEntregue_CheckedChanged(object sender, EventArgs e)
        {
            if (CbEntregue.Checked)
            {
                CbAviso.Checked = true;
                Entregue = 2;
            }
            else
            {
                CbAviso.Checked = false;
                Entregue = 1;
            }
        }

        private void CbAviso_CheckedChanged(object sender, EventArgs e)
        {
            if (CbAviso.Checked)
            {
                CbEntregue.Checked = true;
                Entregue = 2;
            }
            else
            {
                CbEntregue.Checked = false;
                Entregue = 1;
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {

            var encomendaC = new EncomendaController();
            bool Sucesso = encomendaC.EditarEncomenda(TxtTipo.Text, TxtDataPedido.Text, TxtDataEntrega.Text, TxtTema.Text, Entregue, TxtQuantidade.Text, TxtValor.Text, txtDescricao.Text, TxtNomeCliente.Text,Id);

            if (Sucesso == true)
            {

                if (Sucesso == true)
                {
                    TxtTipo.Text = "";
                    TxtQuantidade.Text = "";
                    TxtDataPedido.Text = "";
                    TxtDataEntrega.Text = "";
                    TxtValor.Text = "";
                    TxtTema.Text = "";
                    TxtNomeCliente.Text = "";
                    txtDescricao.Text = "";
                    CbAviso.Checked = false;
                    CbEntregue.Checked = false;

                }
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var Tela = new Home();
            Tela.Show();
            this.Close();
        }
    }
}
