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
    public partial class CancelarVendaPendente : Form
    {
        String IdParaDecrementar;
        public CancelarVendaPendente()
        {
            InitializeComponent();

            // USUARIO
            DAOUsuario usuario = new DAOUsuario();
            UsuarioModel usuarioLogado = new UsuarioModel();

            usuarioLogado = usuario.PegarUsuarioLogado();
            LblUsuario.Text = usuarioLogado.Nome;

            //DATA
            Controller tempo = new Controller();
            String hora = tempo.PegarDiaeHora();
            LblTestedata.Text = Convert.ToString(hora);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            //OK ADICIONANDO NA LISTA
            LBITEM.Items.Clear();
            VendaController venda = new VendaController();
            VendaModel vendaM = new VendaModel();

            vendaM = venda.ListarVendasPendentesPorId(TxtId.Text);

            if (String.IsNullOrEmpty(vendaM.ValorPendente))
            {
                MessageBox.Show("Venda não encontrada");
            }
            else
            {
                LBITEM.Items.Add(vendaM.ValorPendente);
                IdParaDecrementar = Convert.ToString(vendaM.Id);
                TxtId.Text = "";
                TxtId.Focus();

            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LvPesquisa.Items.Clear();
            LBITEM.Items.Clear();
            TxtId.Text = "";

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            LvPesquisa.Items.Clear();
            List<VendaModel> VM = new List<VendaModel>();
            VendaController v = new VendaController();

            VM = v.ListarVendasPendentes();

            foreach (var us in VM)
            {
                ListViewItem list = new ListViewItem(Convert.ToString(us.Id));
                list.SubItems.Add(us.ValorPendente);
                list.SubItems.Add(us.Data);
                LvPesquisa.Items.Add(list);
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            //1 = PAGO
            //2 = PAGAR DEPOIS

            Controller tempo = new Controller();
            String data = tempo.PegarDiaMesAnoAtual();

                //RETIRAR VENDA PENDETE
                VendaController venda = new VendaController();
                venda.RetirarPendencia(IdParaDecrementar);

                //LIMPA TUDO
                LvPesquisa.Items.Clear();
                LBITEM.Items.Clear();
                TxtId.Text = "";

        }

        private void BtnDuvida_Click(object sender, EventArgs e)
        {
            Duvida_CancelarPendencia tela = new Duvida_CancelarPendencia();
            tela.Show();
        }
    }
}
