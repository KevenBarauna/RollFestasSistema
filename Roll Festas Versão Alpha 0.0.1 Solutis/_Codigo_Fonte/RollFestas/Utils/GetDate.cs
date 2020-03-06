using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollFestas.Utils
{
    public static class GetDate
    {
         public static string PegarHoraMinutoAtual()
    {
        string h = System.DateTime.Now.Hour.ToString();
        string m = System.DateTime.Now.Minute.ToString();

        string hora = h + ":" + m;

        return hora;
    }//hh:mm

    public static string PegarDiaMesAnoAtual()
    {


            System.DateTime data = System.DateTime.Now;

        //string dia = DateTime.Now.Day.ToString();
        //var mes = DateTime.Now.Month;
        //string ano = DateTime.Now.Year.ToString();
        // string data = dia + "/" + mes + "/" + ano;

        return data.ToShortDateString();
    }//dd/mm/aa

    public static string PegarDiaeHora()
    {
        string dia = System.DateTime.Now.Day.ToString();
        string mes = System.DateTime.Now.Month.ToString();
        string ano = System.DateTime.Now.Year.ToString();

        string data = dia + "/" + mes + "/" + ano;

        string h = System.DateTime.Now.Hour.ToString();
        string m = System.DateTime.Now.Minute.ToString();

        string hora = h + ":" + m;

        return data + " " + hora;
    } //dd/mm/aa hj:mm

    public static string PegarAno()
    {
        string ano = System.DateTime.Now.Year.ToString();
        return ano;
    }//AA

    public static string PegarMes()
    {

        string mes = System.DateTime.Now.Month.ToString();

        return mes;
    }//MM

    public static string PegarMesAno()
    {
        string mes = System.DateTime.Now.Month.ToString();
        string ano = System.DateTime.Now.Year.ToString();

        string data = mes + "/" + ano;

        return data;
    }//MM/AA

    public static string DataPararCriarPasta()
    {
        string dia = System.DateTime.Now.Day.ToString();
        string mes = System.DateTime.Now.Month.ToString();
        string ano = System.DateTime.Now.Year.ToString();

        string data = dia + "." + mes + "." + ano;


        return data;
    } //dd.mm.aa

}
}
