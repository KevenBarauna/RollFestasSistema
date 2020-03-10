using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RollFestas.View.Avisos;
using RollFestas.View.MensagemErro;

namespace RollFestas.View.Calculo
{
    public partial class CalcularBanner : Form
    {
        public CalcularBanner()
        {
            InitializeComponent();

            var Tela = new MensagemAlerta("Essa função não foi testada, para ser finalizada é preciso informar como é feito o calculo para o desenvolvedor do software");
            Tela.Show();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!RbAmador.Checked && !RbProfissional.Checked)
            {
                var Tela = new Erro("Calcular valor por profissional ou amador?");
                Tela.Show();
            }
            else if (!RbArteSim.Checked && !RbArteNao.Checked)
            {
                var Tela = new Erro("Com arte ou sem arte?");
                Tela.Show();
            }
            else if (!RbVarinha.Checked && !RbChassis.Checked && !RbIlhois.Checked && !RbNenhum.Checked)
            {
                var Tela = new Erro("Qual é o tipo de acabamento?");
                Tela.Show();
            }
            else
            {

                decimal tipo_cliente = 0;

                TxtAltura.Text = TxtAltura.Text.Replace(".", ",");
                TxtLargura.Text = TxtLargura.Text.Replace(".", ",");

                decimal Altura = Math.Round(Convert.ToDecimal(TxtAltura.Text), 1);
                decimal Largura = Math.Round(Convert.ToDecimal(TxtLargura.Text), 1);

                decimal Acabamento = 0;
                int Quantidade_Ilhois = 0;

                decimal FotoEstudio = 0;
                decimal Arte = 0;

                decimal ValorTotal = 0;


                if (RbProfissional.Checked)//PROFISSIONAL
                {
                    tipo_cliente = 35;
                }
                if (RbAmador.Checked)//AMADOR
                {
                    tipo_cliente = 70;
                }

                if (RbVarinha.Checked)//VARINHA
                {
                    Acabamento = 3;
                }
                if (RbChassis.Checked)//CHASSIS
                {
                    Acabamento = 45;
                }
                if (RbIlhois.Checked)//ILHOIS
                {
                    Quantidade_Ilhois = Convert.ToInt32(TxtQuantidade.Text);
                    Acabamento = Convert.ToDecimal(0.60 * Quantidade_Ilhois);
                }

                if (FtStudioSim.Checked)//FOTOESTUDIO SIM
                {
                    FotoEstudio = 35;
                }
                if (FtStudioNao.Checked)//FOTOESTUDIO NAO
                {
                    FotoEstudio = 0;
                }


                if (RbArteSim.Checked)
                {
                    Arte = 25;
                }
                if (RbArteNao.Checked)
                {
                    Arte = 0;
                }


                ValorTotal = Convert.ToDecimal((Altura * Largura) * tipo_cliente);
                ValorTotal = Convert.ToDecimal(ValorTotal + Acabamento);
                ValorTotal = Convert.ToDecimal(ValorTotal + Arte);

                LblValorTotal.Text = ValorTotal.ToString();
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var Tela = new Home(false);
            Tela.Show();
            this.Close();
        }
    }
}
