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

namespace Loja.View.Produto
{
    public partial class PesquisarPorTema : Form
    {
        public PesquisarPorTema()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            LVPesquisa.Items.Clear();
            List<ProdutoModel> PM = new List<ProdutoModel>();
            ProdutoController p = new ProdutoController();

            PM = p.ExibirProdutoPorTema(TxtTema.Text);

            foreach (var us in PM)
            {
                ListViewItem list = new ListViewItem(Convert.ToString(us.Id));
                list.SubItems.Add(us.Nome);
                list.SubItems.Add(us.Preco);
                LVPesquisa.Items.Add(list);
            }

        }
    }
}
