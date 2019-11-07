using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.View.Calcular
{
    public partial class CalcularBanner : Form
    {
        public CalcularBanner()
        {
            InitializeComponent();
            MessageBox.Show("Essa ferramenta está em manutenção, para adicionar essa função informa ao desenvolvedor como é feita o calculo do banner.");
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!RbAmador.Checked && !RbProfissional.Checked)
            {
                MessageBox.Show("Calcular valor por profissional ou amador?");
            }
            else if (!RbArteSim.Checked && !RbArteNao.Checked)
            {
                MessageBox.Show("Preencha o campo de Arte");
            }
            else if (!RbVarinha.Checked && !RbChassis.Checked && !RbIlhois.Checked && !RbNenhum.Checked)
            {
                MessageBox.Show("Preencha o campo de acabamento");
            }
            else
            {

                Decimal tipo_cliente=0;

                TxtAltura.Text = TxtAltura.Text.Replace(".", ",");
                TxtLargura.Text = TxtLargura.Text.Replace(".", ",");

                Decimal Altura = Math.Round(Convert.ToDecimal(TxtAltura.Text), 1);
                Decimal Largura = Math.Round(Convert.ToDecimal(TxtLargura.Text), 1);

                Decimal Acabamento =0;
                int Quantidade_Ilhois=0;

                Decimal FotoEstudio = 0;
                Decimal Arte =0;

                Decimal ValorTotal=0;


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
                    Acabamento = Convert.ToDecimal( 0.60 * Quantidade_Ilhois);
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


                ValorTotal = Convert.ToDecimal( (Altura * Largura) * tipo_cliente);
                ValorTotal = Convert.ToDecimal( ValorTotal + Acabamento);
                ValorTotal = Convert.ToDecimal(ValorTotal + Arte);
                ValorTotal = Convert.ToDecimal(ValorTotal + FotoEstudio);

                LblValorTotal.Text = "R$: " + Convert.ToString(ValorTotal);

            }




        }
    }
}
