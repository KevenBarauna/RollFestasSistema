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

namespace RollFestas.View.Evento
{
    public partial class TodosOsEventos : Form
    {
        public TodosOsEventos()
        {
            InitializeComponent();


            //LISTA DE ENTREGAS
            ListEntregas.Items.Clear();

            var eventoC = new EventoController();
            List<EventoModel> ListaEvento = eventoC.ListratotosEventos();

            if (ListaEvento.Count > 0)
            {
                foreach (var item in ListaEvento)
                {
                    ListViewItem Lista = new ListViewItem(Convert.ToString(item.Id));
                    Lista.SubItems.Add(item.Cep);
                    Lista.SubItems.Add(item.Local);
                    Lista.SubItems.Add(item.Descricao);
                    Lista.SubItems.Add(item.NomeCliente);
                    Lista.SubItems.Add(item.Telefone1);
                    Lista.SubItems.Add(item.Telefone2);
                    Lista.SubItems.Add(item.Email);
                    Lista.SubItems.Add(item.Tipo);
                    Lista.SubItems.Add(item.Data);
                    Lista.SubItems.Add(item.Hora);
                    Lista.SubItems.Add(item.ValorTotal);
                    Lista.SubItems.Add(item.ValorPago);
                    if (item.Entregue == 1)
                    {
                        Lista.SubItems.Add("Entregue");
                    }
                    else
                    {
                        Lista.SubItems.Add("Pendente");
                    }
                   
                    ListEntregas.Items.Add(Lista);

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
