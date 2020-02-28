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
using Loja.Controler.Utils;
using Loja.Model;
using Loja.View.Duvida;

namespace Loja.View.Venda
{
    public partial class VerVendas : Form
    {
        public VerVendas()
        {
            InitializeComponent();


            try
            {
                var data = Data.PegarDiaMesAnoAtual();

                VendaController venda = new VendaController();
                List<VendaModel> vendas = new List<VendaModel>();
                vendas = venda.ListarVendas(data);


                foreach (var p in vendas)
                {

                    ListViewItem listP = new ListViewItem(Convert.ToString(p.Id));
                    listP.SubItems.Add(Convert.ToString(p.Usuario));
                    listP.SubItems.Add(Convert.ToString(p.ValorTotal));
                    //  listP.SubItems.Add(Convert.ToString( p.Data));
                    listP.SubItems.Add(Convert.ToString(p.ValorPago));

                    listP.SubItems.Add(Convert.ToString(p.Troco));
                    listP.SubItems.Add(Convert.ToString(p.TipoPagamento));

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
            Duvida_VerTodasAsVendas tela = new Duvida_VerTodasAsVendas();
            tela.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home tela = new Home();
            tela.Show();
            this.Hide();
        }
    }
}
