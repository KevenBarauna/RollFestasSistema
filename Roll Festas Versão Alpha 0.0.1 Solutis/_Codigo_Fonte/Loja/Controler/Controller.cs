using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.Model.DAO;

namespace Loja.Controler
{
    class Controller
    {
        public bool VerificaDinheiro(string valor)
        {
            bool TudoCerto = false;
            Decimal NovoValor;

            try
            {
                NovoValor = Convert.ToDecimal(valor);
                TudoCerto = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro! Impossível converter o valor digitado, use somente número e virgula e tente novamente");
            }

            return TudoCerto;
        }//VERIFICA SE DINHEIRO É VALIDO

        public void MensagemSucesso()
        {
            MessageBox.Show("Sucesso!");
        }
    }
}
