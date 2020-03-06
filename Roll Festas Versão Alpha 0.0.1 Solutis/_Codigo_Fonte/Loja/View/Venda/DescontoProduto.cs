using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.Model;

namespace Loja.View.Venda
{
    public partial class DescontoProduto : Form
    {
        List<ProdutoModel> _ListaProdutos;
        public DescontoProduto(string usuario, string Valor, string Tipopagamento, List<ProdutoModel> ListaProdutos)
        {
            InitializeComponent();

            //LISTA
            _ListaProdutos = ListaProdutos;

            foreach (var item in _ListaProdutos)
            {
                ListViewItem list = new ListViewItem(item.Nome);
                list.SubItems.Add(item.Quantidade_Estoque);
                list.SubItems.Add(item.Quantidade_Estoque);
                list.SubItems.Add(item.Preco);
                list.SubItems.Add(Convert.ToString( item.Id));
                ListItens.Items.Add(list);
            }
            

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

        }
    }
}
