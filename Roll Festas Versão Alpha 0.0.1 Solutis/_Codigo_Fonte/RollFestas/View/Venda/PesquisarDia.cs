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

namespace RollFestas.View.Venda
{
    public partial class PesquisarDia : Form
    {
        public PesquisarDia()
        {
            InitializeComponent();


            TxtPesquisaData.Text = GetDate.PegarDiaMesAnoAtual();

        }


        private void BtnPesquisarData_Click(object sender, EventArgs e)
        {
            var vendaC = new VendaController();
            List<VendaModel> ListaVenda = vendaC.ListarVendas(TxtPesquisaData.Text);

            foreach (var item in ListaVenda)
            {

                ListViewItem listP = new ListViewItem(Convert.ToString(item.Id));
                listP.SubItems.Add(Convert.ToString(item.Data));
                listP.SubItems.Add(Convert.ToString(item.Usuario));
                listP.SubItems.Add(Convert.ToString(item.ValorTotal));
                listP.SubItems.Add(Convert.ToString(item.ValorPago));
                listP.SubItems.Add(Convert.ToString(item.Troco));
                listP.SubItems.Add(Convert.ToString(item.TipoPagamento));
                listP.SubItems.Add(Convert.ToString(item.StatusPagamento));
                listP.SubItems.Add(Convert.ToString(item.ValorPendente));
                listP.SubItems.Add(Convert.ToString(item.NomeCliente));
                listCodigo.Items.Add(listP);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Tela = new Home();
            Tela.Show();
            this.Hide();
        }
    }
}
