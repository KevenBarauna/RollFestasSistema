using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Controler.Utils
{
    public static class Date
    {

        public static string PegarHoraMinutoAtual()
        {
            string h = DateTime.Now.Hour.ToString();
            string m = DateTime.Now.Minute.ToString();

            string hora = h + ":" + m;

            return hora;
        }//hh:mm

        public static string PegarDiaMesAnoAtual()
        {


            DateTime data = DateTime.Now;

            //string dia = DateTime.Now.Day.ToString();
            //var mes = DateTime.Now.Month;
            //string ano = DateTime.Now.Year.ToString();
            // string data = dia + "/" + mes + "/" + ano;

            return data.ToShortDateString();
        }//dd/mm/aa

        public static string PegarDiaeHora()
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

        public static string PegarAno()
        {
            string ano = DateTime.Now.Year.ToString();
            return ano;
        }//AA

        public static string PegarMes()
        {

            string mes = DateTime.Now.Month.ToString();

            return mes;
        }//MM

        public static string PegarMesAno()
        {
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();

            string data = mes + "/" + ano;

            return data;
        }//MM/AA

        public static string DataPararCriarPasta()
        {
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();

            string data = dia + "." + mes + "." + ano;


            return data;
        } //dd.mm.aa

    }
}
