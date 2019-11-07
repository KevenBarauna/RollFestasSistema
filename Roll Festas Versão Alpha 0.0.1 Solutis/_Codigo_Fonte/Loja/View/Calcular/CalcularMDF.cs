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
    public partial class CalcularMDF : Form
    {
        public CalcularMDF()
        {
            InitializeComponent();
            MessageBox.Show("ESSE CAMPO PRECISA DE MANUTENÇÃO, PARA CONCLUIR É NECESSÁRIO CRIAR UMA PLANILHA COM TAMANHOS E VALORES DE MDF E ENTRAR EM CONTATO COM O DESENVOLVEDOR");
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //CONVERTENDO VALORES
            Decimal Largura = Convert.ToDecimal(TxtLargura.Text);
            Decimal Altura = Convert.ToDecimal(TxtAltura.Text);




            //REGRAS DE PREENCHIMENTO DE CAMPOS
            if (TxtAltura.Text == "" || TxtLargura.Text == "")
            {
                MessageBox.Show("Preencha o tamanho");
            }
            if (!RbRiscado.Checked && !RbVazado.Checked && !RbAdesivado.Checked && !RbNenhum.Checked)
            {
                MessageBox.Show("Preencha o tipo de corte");
            }
            if (!RbArteNao.Checked && !RbArteSim.Checked)
            {
                MessageBox.Show("Preencha o campo de arte");
            }
            if (!RbPersonagem.Checked && !RbFoto.Checked)
            {
                MessageBox.Show("Preencha o campo de imagem");
            }

            //REGRAS DE NEGOCIO

            if (TxtAltura.Text == "89" && TxtLargura.Text == "89")//LARGURA DA CHAPA
            {
                MessageBox.Show("Esse serviço é muito grande, reduza para até 89cm");
            }
            if (TxtQuantidade.Value < 10 && Largura <= 15 )//PEQUENO SÓ EM QUANTIDADE
            {
                MessageBox.Show("Nessa tamanho só é possivel fazer em quantidade (10 unidades)");
            }

            //APLICANDO VALOES
            else
            {
                Decimal ValorTotal = 0;


                //CORTE
                if (RbRiscado.Checked)//RISCADO
                {
                    ValorTotal = ValorTotal + 5;
                }
                if (RbVazado.Checked)//VAZADO
                {
                    ValorTotal = ValorTotal + 7;
                }
                if (RbAdesivado.Checked)//ADESIVADO
                {
                    ValorTotal = ValorTotal + 10;
                }
                if (RbNenhum.Checked)//NENHUM
                {
                    ValorTotal = ValorTotal + 0;
                }

                //ARTE
                if (RbArteSim.Checked)//COM ARTE
                {
                    ValorTotal = ValorTotal + 10;
                }
                if (RbArteNao.Checked)//SEM ARTE
                {
                    ValorTotal = ValorTotal + 0;
                }

                //IMAGEM
                if (RbPersonagem.Checked)//COM ARTE
                {
                    ValorTotal = ValorTotal + 0;
                }
                if (RbFoto.Checked)//SEM ARTE
                {
                    ValorTotal = ValorTotal + 7;
                }

                //TAMANHO
                if (Altura <= 15 && Largura <= 15)//MINITOTEM 2,50 -- DE 0 ate 15cm
                {
                    Double valorMinitotem = 2.50;
                    ValorTotal = Convert.ToDecimal(valorMinitotem);
                }
                if (Altura <=20 && Altura >15  && Largura <20)//-- DE 16 ATE 20
                {
                    ValorTotal = ValorTotal + 20;
                }
                if (Altura <= 30 && Altura > 20 && Largura < 30)//-- DE 21 ATE 30
                {
                    ValorTotal = ValorTotal + 30;
                }
                if (Altura <= 40 && Altura > 30 && Largura < 40)//- DE 31 ATE 40
                {
                    ValorTotal = ValorTotal + 40;
                }
                if (Altura <= 50 && Altura > 40 && Largura < 50)//-- DE 41 ATE 50
                {
                    ValorTotal = ValorTotal + 50;
                }
                if (Altura <= 60 && Altura > 50 && Largura < 60)//-- DE 51 ATE 60
                {
                    ValorTotal = ValorTotal + 60;
                }
                if (Altura <= 70 && Altura > 60 && Largura < 70)//-- DE 61 ATE 70
                {
                    ValorTotal = ValorTotal + 70;
                }
                if (Altura <= 80 && Altura > 70 && Largura < 80)//-- DE 71 ATE 80
                {
                    ValorTotal = ValorTotal + 80;
                }
                if (Altura > 80)//- MAIRO QUE 80
                {
                    ValorTotal = ValorTotal + 100;
                }

                //PLACA
                if (Largura == 30 && Altura == 40)
                {
                    ValorTotal =  40;
                }
                if (Largura == 40 && Altura == 50)
                {
                    ValorTotal = 40;
                }

                //RETORNA VALOR FInal
                LblValorTotal.Text = "O valor da unidade é R$ " + Convert.ToString(ValorTotal);
            }




        }
    }
}
