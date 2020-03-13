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

    public partial class EditarEvento : Form
    {

        string TipoEvento;
        int Entregue = 2;
        int Id = 0;
        public EditarEvento()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            var eventoC = new EventoController();
            EventoModel eventoM = eventoC.ExibirDetalhesdoDoEvento(txtPesquisaCodigo.Text);

            if (eventoM.Id != 0)
            {
                Id = eventoM.Id;

                TxtNome.Text = eventoM.NomeCliente;
                TxtTel1.Text = eventoM.Telefone1;
                TxtEmail.Text = eventoM.Email;
                TxtTel2.Text = eventoM.Telefone2;
                TxtData.Text = eventoM.Data;
                TxtHora.Text = eventoM.Hora;
                TxtLocal.Text = eventoM.Local;
                TxtDescEvento.Text = eventoM.Descricao;
                TxtCep.Text = eventoM.Cep;

                if (eventoM.Tipo == "Aniversário")
                {
                    RbAniversaio.Checked = true;
                }
                if (eventoM.Tipo == "Making of")
                {
                    RbMakingof.Checked = true;
                }
                if (eventoM.Tipo == "Casamento")
                {
                    RbCasamento.Checked = true;
                }
                if (eventoM.Tipo == "Bodas")
                {
                    RbBodas.Checked = true;
                }
                if (eventoM.Tipo == "Batizado")
                {
                    RbBatizado.Checked = true;
                }
                if (eventoM.Tipo == "Festa")
                {
                    RbFesta.Checked = true;
                }

                if (eventoM.Entregue == 1)
                {
                    CbFinalizado.Checked = true;
                }

                TxtNome.ReadOnly = false;
                TxtTel1.ReadOnly = false;
                TxtEmail.ReadOnly = false;
                TxtTel2.ReadOnly = false;
                TxtData.ReadOnly = false;
                TxtHora.ReadOnly = false;
                TxtLocal.ReadOnly = false;
                TxtDescEvento.ReadOnly = false;
                RbAniversaio.Enabled = true;
                RbMakingof.Enabled = true;
                RbCasamento.Enabled = true;
                RbBodas.Enabled = true;
                RbBatizado.Enabled = true;
                RbFesta.Enabled = true;
                CbFinalizado.Enabled = true;



            }
            else
            {
                TxtNome.Text = "";
                TxtTel1.Text = "";
                TxtEmail.Text = "";
                TxtTel2.Text = "";
                TxtData.Text = "";
                TxtHora.Text = "";
                TxtLocal.Text = "";
                TxtDescEvento.Text = "";
                TxtCep.Text = "";
                RbAniversaio.Checked = false;
                RbMakingof.Checked = false;
                RbCasamento.Checked = false;
                RbBodas.Checked = false;
                RbBatizado.Checked = false;
                RbFesta.Checked = false;
                CbFinalizado.Checked = false;

            }

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var Tela = new Home(false);
            Tela.Show();
            this.Close();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            var eventoC = new EventoController();
            bool Sucesso = eventoC.EditarEvento(TxtCep.Text,TxtLocal.Text,TxtDescEvento.Text,TxtNome.Text,TxtTel1.Text,TxtTel2.Text,TxtEmail.Text, TipoEvento, TxtData.Text,TxtHora.Text, Entregue,Id.ToString());
            if (Sucesso == true)
            {
                TxtCep.Text = "";
                TxtNome.Text = "";
                TxtTel1.Text = "";
                TxtTel2.Text = "";
                TxtEmail.Text = "";
                TxtData.Text = "";
                TxtHora.Text = "";
                TxtLocal.Text = "";
                TxtDescEvento.Text = "";
            }
        }

        private void RbAniversaio_CheckedChanged(object sender, EventArgs e)
        {
            TipoEvento = "Aniversário";
        }

        private void RbMakingof_CheckedChanged(object sender, EventArgs e)
        {
            TipoEvento = "Making of";
        }

        private void RbCasamento_CheckedChanged(object sender, EventArgs e)
        {
            TipoEvento = "Casamento";
        }

        private void RbBodas_CheckedChanged(object sender, EventArgs e)
        {
            TipoEvento = "Bodas";
        }

        private void RbBatizado_CheckedChanged(object sender, EventArgs e)
        {
            TipoEvento = "Batizado";
        }

        private void RbFesta_CheckedChanged(object sender, EventArgs e)
        {
            TipoEvento = "Festa";
        }

        private void CbFinalizado_CheckedChanged(object sender, EventArgs e)
        {
            if (CbFinalizado.Checked)
            {
                Entregue = 1;
            }
            else
            {
                Entregue = 2;
            }
            
        }
    }
}
