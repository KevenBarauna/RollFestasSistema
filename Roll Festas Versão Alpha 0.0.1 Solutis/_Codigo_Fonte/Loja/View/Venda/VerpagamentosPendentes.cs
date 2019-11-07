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
using Loja.View.Duvida;

namespace Loja.View.Venda
{
    public partial class VerpagamentosPendentes : Form
    {
        public VerpagamentosPendentes()
        {
            InitializeComponent();

            try
            {

                VendaController venda = new VendaController();
                List<VendaModel> vendas = new List<VendaModel>();
                vendas = venda.ListarVendasPendentes();


                foreach (var p in vendas)
                {

                    ListViewItem listP = new ListViewItem(Convert.ToString(p.Id));
                    listP.SubItems.Add(Convert.ToString(p.ValorPendente));
                    listP.SubItems.Add(Convert.ToString(p.Data));

                    listCodigo.Items.Add(listP);

                }

            }
            catch (Exception e)
            {
                Erro TelaDeErro = new Erro("000", "Sem acesso ao bando de dados" + e, "Reinicie o programa", "Reinicie o computador", "Reinicie o banco de dados.", "", "");
                TelaDeErro.Show();
            }

        }

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            Duvida_PagamentoPendente tela = new Duvida_PagamentoPendente();
            tela.Show();
        }
    }
}
