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
using Loja.Model.DAO;

namespace Loja.View.Recibo
{
    public partial class ReciboPorId : Form
    {
        public ReciboPorId()
        {
            InitializeComponent();

            //DATA
            TxtData.Text = Date.PegarDiaMesAnoAtual();
        }


        private void BtnGerarPdf_Click(object sender, EventArgs e)
        {

        }

        private void BtnVerVendas_Click_1(object sender, EventArgs e)
        {
            VendaController venda = new VendaController();
            List<VendaModel> vendas = new List<VendaModel>();
            vendas = venda.ListarVendas(TxtData.Text);


            foreach (var p in vendas)
            {

                ListViewItem listP = new ListViewItem(Convert.ToString(p.Id));
                listP.SubItems.Add(Convert.ToString(p.ValorTotal));
                listP.SubItems.Add(Convert.ToString(p.ValorPago));
                listP.SubItems.Add(Convert.ToString(p.Troco));

                listCodigo.Items.Add(listP);

            }
        }

        private void BtnGerarPdf_Click_1(object sender, EventArgs e)
        {

            DAOCaminho dao = new DAOCaminho();
            string pasta = dao.CaminhoComprovante();

            String caminho = @"" + pasta + @"\" + TxtId.Text + ".pdf";

            ReciboController recibo = new ReciboController();
            recibo.GerarReciboDeVendaPeloId(TxtId.Text, caminho);

            TxtId.Text = "";
        }
    }
}
