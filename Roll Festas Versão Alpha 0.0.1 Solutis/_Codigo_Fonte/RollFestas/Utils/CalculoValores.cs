using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RollFestas.View.MensagemErro;

namespace RollFestas.Utils
{
    public static class CalculoValores
    {

        //CALCULAR TROCO
        public static string CalcularTroco(string ValorTotal, string ValorRecebido)
        {
            decimal Total;
            decimal Recebido;

            if (string.IsNullOrEmpty(ValorTotal))
            {
                var TelaErro = new Erro("Informe o valor total");
                TelaErro.Show();
                return null;
            }

            if (string.IsNullOrEmpty(ValorRecebido))
            {
                var TelaErro = new Erro("Informe o valor recebido");
                TelaErro.Show();
                return null;
            }

            try
            {
                Total = Convert.ToDecimal(ValorTotal);
                Recebido = Convert.ToDecimal(ValorRecebido);

            }
            catch (Exception)
            {
                var TelaErro = new ErroController("CVT", "Erro, valores invalidos", "Os valores informados estão corretos?", "Os valores informados não podem ser negativos", "Informou somente núemros e virgula?");
                TelaErro.Show();
                return null;
            }

            decimal ValorTroco = Recebido - Total;

            string Valor = ValorTroco.ToString();
            if (Valor.Contains("-"))
            {

                if (MessageBox.Show("Resta uma pendencia de " + Valor + ". Clique em OK para ir pra tela de pagamentos pendentes", "Valor negativo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    return "PENDENTE";

                }
            }

            return ValorTroco.ToString();
        }

        //CALCULAR TROCO
        public static decimal Convertevalor(string ValorRecebido)
        {
            decimal NovoValor = 0;

            try
            {
                NovoValor = Convert.ToDecimal(ValorRecebido);
                return NovoValor;
            }
            catch (Exception)
            {
                return NovoValor;
            }
           
        }

    }
}
