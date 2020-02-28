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

namespace Loja.View.Ponto
{
    public partial class VerPonto : Form
    {
        public VerPonto()
        {
            InitializeComponent();


            TxtAnoPesquisa.Text = Data.PegarDiaMesAnoAtual();
            TxtMes.Text = Data.PegarMesAno();
            TxtAno.Text = Data.PegarAno();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            listViewUs.Items.Clear();

            List<PontoModel> Lponto = new List<PontoModel>();
            PontoController pontoC = new PontoController();

            Lponto = pontoC.ListarPorData(TxtAnoPesquisa.Text);

            foreach (var us in Lponto)
            {
                ListViewItem list = new ListViewItem(us.Nome);
                list.SubItems.Add(us.Hora1);
                list.SubItems.Add(us.Hora2);
                list.SubItems.Add(us.Hora3);
                list.SubItems.Add(us.Hora4);
                list.SubItems.Add(us.Data);

                listViewUs.Items.Add(list);
            }

        }

        private void BtnMes_Click(object sender, EventArgs e)
        {
            listViewUs.Items.Clear();

            List<PontoModel> Lponto = new List<PontoModel>();
            PontoController pontoC = new PontoController();

            Lponto = pontoC.ListarPorMes(TxtMes.Text);

            foreach (var us in Lponto)
            {
                ListViewItem list = new ListViewItem(us.Nome);
                list.SubItems.Add(us.Hora1);
                list.SubItems.Add(us.Hora2);
                list.SubItems.Add(us.Hora3);
                list.SubItems.Add(us.Hora4);
                list.SubItems.Add(us.Data);

                listViewUs.Items.Add(list);
            }
        }

        private void BtnAno_Click(object sender, EventArgs e)
        {
            listViewUs.Items.Clear();

            List<PontoModel> Lponto = new List<PontoModel>();
            PontoController pontoC = new PontoController();

            Lponto = pontoC.ListarPorAno(TxtAno.Text);

            foreach (var us in Lponto)
            {
                ListViewItem list = new ListViewItem(us.Nome);
                list.SubItems.Add(us.Hora1);
                list.SubItems.Add(us.Hora2);
                list.SubItems.Add(us.Hora3);
                list.SubItems.Add(us.Hora4);
                list.SubItems.Add(us.Data);

                listViewUs.Items.Add(list);
            }
        }
    }
}
