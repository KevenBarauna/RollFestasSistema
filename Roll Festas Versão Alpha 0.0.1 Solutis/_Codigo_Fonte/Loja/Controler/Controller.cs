using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Controler
{
    class Controller
    {

        public String PegarHoraMinutoAtual()
        {
            string h = DateTime.Now.Hour.ToString();
            string m = DateTime.Now.Minute.ToString();

            string hora = h + ":" + m;

            return hora;
        }

        public String PegarDiaMesAnoAtual()
        {
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();

            string data = dia + "/" + mes + "/" + ano;

            return data;
        }

        public String PegarDiaeHora()
        {
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();

            string data = dia + "/" + mes + "/" + ano;

            string h = DateTime.Now.Hour.ToString();
            string m = DateTime.Now.Minute.ToString();

            string hora = h + ":" + m;

            return data + " " + hora;
        }

        public String PegarAno()
        {
            string ano = DateTime.Now.Year.ToString();
            return ano;
        }

        public String PegarMes()
        {

            string mes = DateTime.Now.Month.ToString();

            return mes;
        }

        public String PegarMesAno()
        {
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();

            string data =  mes + "/" + ano;

            return data;
        }

        public String DataparaSalvar()
        {
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();

            string data = dia + "." + mes + "." + ano;

            return data;
        }
    }
}
