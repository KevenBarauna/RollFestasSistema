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

namespace Loja.View.Caixa
{
    public partial class VerCaixaPorData : Form
    {
        public VerCaixaPorData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listViewUs.Items.Clear();

            List<CaixaModel> Lcaixa = new List<CaixaModel>();

            foreach (var us in Lcaixa)
            {
                ListViewItem list = new ListViewItem(us.Id);
                list.SubItems.Add(us.Data);
                list.SubItems.Add(us.Valor);
                list.SubItems.Add(us.Deposito);
                list.SubItems.Add(us.Retirada);
               listViewUs.Items.Add(list);
            }
        }
    }
}
