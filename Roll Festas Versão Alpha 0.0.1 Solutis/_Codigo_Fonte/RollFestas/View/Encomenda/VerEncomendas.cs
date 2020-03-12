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
using RollFestas.View.Avisos;

namespace RollFestas.View.Encomenda
{
    public partial class VerEncomendas : Form
    {
        public VerEncomendas()
        {
            InitializeComponent();

            //LISTA DE ENTREGAS
            ListEncomendas.Items.Clear();

            var encomendaoC = new EncomendaController();
            List<EncomendaModel> ListaEncomenda = encomendaoC.ListraEncomendas();

            if (ListaEncomenda.Count > 0)
            {
                foreach (var item in ListaEncomenda)
                {
                    ListViewItem Lista = new ListViewItem(Convert.ToString(item.Id));
                    Lista.SubItems.Add(item.TipoServico);
                    Lista.SubItems.Add(item.DataEntrada);
                    Lista.SubItems.Add(item.DataEntrega);
                    if (item.Entregue == 2)
                    {
                        Lista.SubItems.Add("Entregue");
                    }
                    else
                    {
                        Lista.SubItems.Add("Pendente");
                    }
                    Lista.SubItems.Add(item.Tema);
                    Lista.SubItems.Add(item.Quantidade);
                    Lista.SubItems.Add(item.Valor);
                    Lista.SubItems.Add(item.NomeCliente);
                    Lista.SubItems.Add(item.Descricao);

                    ListEncomendas.Items.Add(Lista);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Tela = new Home(false);
            Tela.Show();
            this.Close();
        }
    }
}
