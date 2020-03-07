using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using RollFestas.Data;
using RollFestas.Models;
using RollFestas.Utils;
using RollFestas.View.MensagemErro;

namespace RollFestas.Controllers
{
    class PontoController
    {
        PontoDAO DAO = new PontoDAO();
        public bool BaterPonto(string Nome)
        {
            //PEGA HORA E DATA ATUAL

            string Data = GetDate.PegarDiaMesAnoAtual();
            string Hora = GetDate.PegarHoraMinutoAtual();

            //VERIFICA SE JÁ BATEU PONTO HOJE
            var pontoC = new PontoController();
            List<PontoModel> ListaPonto = pontoC.ListarPorData(Data);
            bool Sucesso = false;

            if (ListaPonto.Count == 0)
            {
                Sucesso = DAO.SalvarHoraNoBancoH1(Nome, Hora, Data);
            }
            else
            {

                int HoraFalta = 0;

                foreach (var ponto in ListaPonto)
                {
                    if (ponto.Nome == Nome && string.IsNullOrEmpty(ponto.Hora1))
                    {
                        HoraFalta = 1;
                    }
                    if (ponto.Nome == Nome && string.IsNullOrEmpty(ponto.Hora2))
                    {
                        HoraFalta = 2;
                    }
                    if (ponto.Nome == Nome && string.IsNullOrEmpty(ponto.Hora3))
                    {
                        HoraFalta = 3;
                    }
                    if (ponto.Nome == Nome && string.IsNullOrEmpty(ponto.Hora4))
                    {
                        HoraFalta = 4;
                    }
                }
                switch (HoraFalta)
                {
                    case 1:
                        Sucesso = DAO.SalvarHoraNoBancoH1(Nome, Hora, Data);
                        break;

                    case 2:
                        Sucesso = DAO.SalvarHoraNoBancoH2(Nome, Hora, Data);
                        break;

                    case 3:
                        Sucesso = DAO.SalvarHoraNoBancoH3(Nome, Hora, Data);
                        break;

                    case 4:
                        Sucesso = DAO.SalvarHoraNoBancoH4(Nome, Hora, Data);
                        break;

                    default:
                        var TelaErro = new Erro("Todas as horas de hoje já foram preenchidas");
                        break;
                }
            }

            if (Sucesso == true)
            {
                var Tela = new Sucesso("Ponto salvo");
                Tela.Show();
            }

            return Sucesso;

        }

        public List<PontoModel> ListarPorData(string Data)
        {

            List<PontoModel> ListaPonto = DAO.ListarPordata(Data);

            return ListaPonto;
        }

        public List<PontoModel> ListarPorMes(string MesAno)
        {

            List<PontoModel> ListaPonto = DAO.ListarPorMes(MesAno);

            return ListaPonto;
        }

     




    }
}
