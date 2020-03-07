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

namespace RollFestas.View.Venda.PagamentoPendente
{
    public partial class VerTodos : Form
    {
        public VerTodos()
        {
            InitializeComponent();

            var vendaC = new VendaController();
             List<VendaModel> ListaVenda = vendaC.ListarVendasPendentes();

            foreach (var item in ListaVenda)
            {

                ListViewItem listP = new ListViewItem(Convert.ToString(item.Id));
                listP.SubItems.Add(Convert.ToString(item.ValorPendente));
                listP.SubItems.Add(Convert.ToString(item.Data));
                listP.SubItems.Add(Convert.ToString(item.NomeCliente));
                listCodigo.Items.Add(listP);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Tela = new Home();
            Tela.Show();
            this.Close();
        }
    }
}
