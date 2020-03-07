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

namespace RollFestas.View.Caixa
{
    public partial class Faturamento : Form
    {
        public Faturamento()
        {
            InitializeComponent();

            txtPesquisaHoje.Text = GetDate.PegarDiaMesAnoAtual();
            TxtPesquisaData.Text = GetDate.PegarDiaMesAnoAtual();
            TxtPesquisaMes.Text = GetDate.PegarMesAno();
            TxtPesquisaAno.Text = GetDate.PegarAno();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            var Tela = new Home();
            Tela.Show();
            this.Close();
        }

        private void BtnPesquisarHoje_Click(object sender, EventArgs e)
        {

            ListViewCaixa.Items.Clear();

            var caixaC = new CaixaController();
            CaixaModel caixaM = caixaC.TotalVendasNoDia(txtPesquisaHoje.Text);

            ListViewItem lista = new ListViewItem(Convert.ToString(caixaM.Id));
            lista.SubItems.Add(caixaM.ValorTotal);
            lista.SubItems.Add(caixaM.Data);
            lista.SubItems.Add(caixaM.Retirada);
            lista.SubItems.Add(caixaM.Deposito);
            lista.SubItems.Add(caixaM.Dinheiro);
            lista.SubItems.Add(caixaM.Cartao);
            lista.SubItems.Add(caixaM.Outros);

            ListViewCaixa.Items.Add(lista);

        }

        private void BtnPesquisarData_Click(object sender, EventArgs e)
        {
            ListViewCaixa.Items.Clear();

            var caixaC = new CaixaController();
            CaixaModel caixaM = caixaC.TotalVendasNoDia(TxtPesquisaData.Text);

            ListViewItem lista = new ListViewItem(Convert.ToString(caixaM.Id));
            lista.SubItems.Add(caixaM.ValorTotal);
            lista.SubItems.Add(caixaM.Data);
            lista.SubItems.Add(caixaM.Retirada);
            lista.SubItems.Add(caixaM.Deposito);
            lista.SubItems.Add(caixaM.Dinheiro);
            lista.SubItems.Add(caixaM.Cartao);
            lista.SubItems.Add(caixaM.Outros);

            ListViewCaixa.Items.Add(lista);
        }

        private void BtnPesquisarMes_Click(object sender, EventArgs e)
        {
            ListViewCaixa.Items.Clear();

            var caixaC = new CaixaController();
            List<CaixaModel> Listacaixa = caixaC.MostrarTotalVendaMes(TxtPesquisaMes.Text);

            foreach (var item in Listacaixa)
            {
                ListViewItem lista = new ListViewItem(Convert.ToString(item.Id));
                lista.SubItems.Add(item.ValorTotal);
                lista.SubItems.Add(item.Data);
                lista.SubItems.Add(item.Retirada);
                lista.SubItems.Add(item.Deposito);
                lista.SubItems.Add(item.Dinheiro);
                lista.SubItems.Add(item.Cartao);
                lista.SubItems.Add(item.Outros);

                ListViewCaixa.Items.Add(lista);
            }

        }

        private void BtnPesquisarAno_Click(object sender, EventArgs e)
        {
            ListViewCaixa.Items.Clear();

            var caixaC = new CaixaController();
            List<CaixaModel> Listacaixa = caixaC.MostrarTotalVendaAno(TxtPesquisaAno.Text);

            foreach (var item in Listacaixa)
            {
                ListViewItem lista = new ListViewItem(Convert.ToString(item.Id));
                lista.SubItems.Add(item.ValorTotal);
                lista.SubItems.Add(item.Data);
                lista.SubItems.Add(item.Retirada);
                lista.SubItems.Add(item.Deposito);
                lista.SubItems.Add(item.Dinheiro);
                lista.SubItems.Add(item.Cartao);
                lista.SubItems.Add(item.Outros);

                ListViewCaixa.Items.Add(lista);
            }

        }
    }
}

