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
    public partial class CancelarVendaPendente : Form
    {
        string Id;
        public CancelarVendaPendente(string Usuario)
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

        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            var vendaC = new VendaController();
            var caixaC = new CaixaController();


            //RETIRAR PENDENCIA
            bool SucessoVenda = vendaC.RetirarPendencia(Id);

            if (SucessoVenda == true)
            {
                CarregarLista();
                TxtId.Text = "";
                ListaVenda.Items.Clear();
                Id = "0";

            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            var Tela = new Home();
            Tela.Show();
            this.Close();
        }
    }
}
