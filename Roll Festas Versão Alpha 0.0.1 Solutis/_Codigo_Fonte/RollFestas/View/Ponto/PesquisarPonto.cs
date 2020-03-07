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
using RollFestas.View.MensagemErro;

namespace RollFestas.View.Ponto
{
    public partial class PesquisarPonto : Form
    {
        public PesquisarPonto()
        {
            InitializeComponent();
            TxtDataPesquisa.Text = GetDate.PegarDiaMesAnoAtual();
            TxtMes.Text = GetDate.PegarMesAno();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listViewPonto.Items.Clear();

            var pontoC = new PontoController();
            List<PontoModel> ListaPonto = pontoC.ListarPorData(TxtDataPesquisa.Text);

            if (ListaPonto.Count > 0)
            {
                foreach (var item in ListaPonto)
                {
                    ListViewItem Lista = new ListViewItem(Convert.ToString(item.Nome));
                    Lista.SubItems.Add(item.Data);
                    Lista.SubItems.Add(item.Hora1);
                    Lista.SubItems.Add(item.Hora2);
                    Lista.SubItems.Add(item.Hora3);
                    Lista.SubItems.Add(item.Hora4);

                    listViewPonto.Items.Add(Lista);

                }
            }
            else
            {
                var Tela = new Erro("Nenhum registro encontrado");
                Tela.Show();
            }
        }

        private void BtnMes_Click(object sender, EventArgs e)
        {
            listViewPonto.Items.Clear();

            var pontoC = new PontoController();
            List<PontoModel> ListaPonto = pontoC.ListarPorMes(TxtMes.Text);

            if (ListaPonto.Count > 0)
            {
                foreach (var item in ListaPonto)
                {
                    ListViewItem Lista = new ListViewItem(Convert.ToString(item.Nome));
                    Lista.SubItems.Add(item.Data);
                    Lista.SubItems.Add(item.Hora1);
                    Lista.SubItems.Add(item.Hora2);
                    Lista.SubItems.Add(item.Hora3);
                    Lista.SubItems.Add(item.Hora4);

                    listViewPonto.Items.Add(Lista);

                }
            }
            else
            {
                var Tela = new Erro("Nenhum registro encontrado");
                Tela.Show();
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var Tela = new Home();
            Tela.Show();
            this.Close();
        }
    }
}
