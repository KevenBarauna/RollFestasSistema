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

namespace Loja.View.Encomenda
{
    public partial class VerEncomenda : Form
    {
        public VerEncomenda()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            EncomendaController encomenda = new EncomendaController();
            EncomendaModel encomendaeditavel = new EncomendaModel();

            encomendaeditavel = encomenda.ExibirDetalhesdoDaEncomenda(txtPesquisaCodigo.Text);

            TxtCodigo.Text = Convert.ToString(encomendaeditavel.Id);
            TxtDataChegada.Text = encomendaeditavel.DataEntrada;
            TxtDataEntrega.Text = encomendaeditavel.DataEntrega;
            txtDescricao.Text = encomendaeditavel.Descricao;
            TxtPreco.Text = encomendaeditavel.Valor;
            TxtQuantidade.Text = encomendaeditavel.Quantidade;
            TxtTipo.Text = encomendaeditavel.TipoServico;
            TxtTema.Text = encomendaeditavel.Tema;
        }
    }
    
}
