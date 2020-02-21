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

        public string PegarHoraMinutoAtual()
        {
            string h = DateTime.Now.Hour.ToString();
            string m = DateTime.Now.Minute.ToString();

            string hora = h + ":" + m;

            return hora;
        }//hh:mm

        public string PegarDiaMesAnoAtual()
        {


            DateTime data = DateTime.Now;

            //string dia = DateTime.Now.Day.ToString();
            //var mes = DateTime.Now.Month;
            //string ano = DateTime.Now.Year.ToString();
            // string data = dia + "/" + mes + "/" + ano;

            return data.ToShortDateString();
        }//dd/mm/aa

        public string PegarDiaeHora()
        {
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();

            string data = dia + "/" + mes + "/" + ano;

            string h = DateTime.Now.Hour.ToString();
            string m = DateTime.Now.Minute.ToString();

            string hora = h + ":" + m;

            return data + " " + hora;
        } //dd/mm/aa hj:mm

        public string PegarAno()
        {
            string ano = DateTime.Now.Year.ToString();
            return ano;
        }//AA

        public string PegarMes()
        {

            string mes = DateTime.Now.Month.ToString();

            return mes;
        }//MM

        public string PegarMesAno()
        {
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();

            string data = mes + "/" + ano;

            return data;
        }//MM/AA

        public String DataPararCriarPasta()
        {
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();

            string data = dia + "." + mes + "." + ano;


            return data;
        } //dd.mm.aa

        public string PegarCaminhoPonto()
        {
            DAOCaminho dao = new DAOCaminho();
            string caminho = dao.CaminhoPonto();
            return caminho;
        }//PEGA CAMINHO para SALVAR PONTO

        public string CaminhoCahce()
        {
            DAOCaminho dao = new DAOCaminho();
            string caminho = dao.CaminhoCahce();
            return caminho;
        }//PEGA CAMINHO para SALVAR CAHCE

        public string CaminhoComprovante()
        {
            DAOCaminho dao = new DAOCaminho();
            string caminho = dao.CaminhoComprovante();
            return caminho;
        }//PEGA CAMINHO para SALVAR CAHCE

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
