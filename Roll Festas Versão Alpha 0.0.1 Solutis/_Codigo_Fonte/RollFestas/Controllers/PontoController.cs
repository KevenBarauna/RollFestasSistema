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
            //VERIFICA SE USUÁRIO EXISTE
            var usuarioC = new UsuarioController();
            UsuarioModel usuario = usuarioC.ExibirUsuario(Nome);
            if (usuario.Id == 0)
            {
                return false;
            }

            //PEGA HORA E DATA ATUAL

            string Data = GetDate.PegarDiaMesAnoAtual();
            string Hora = GetDate.PegarHoraMinutoAtual();

            //VERIFICA SE JÁ BATEU PONTO HOJE
            var pontoC = new PontoController();
            List<PontoModel> ListaPonto = pontoC.ListarPorData(Data);

            if (ListaPonto.Count == 0)
            {
                return DAO.SalvarHoraNoBancoH1(Nome, Hora, Data);
            }
           

                foreach (var ponto in ListaPonto)
                {
                    if (ponto.Nome == Nome)
                    {
                        if (string.IsNullOrEmpty(ponto.Hora1))
                        {
                            return DAO.SalvarHoraNoBancoH1(Nome, Hora, Data);
                        }
                        else if (string.IsNullOrEmpty(ponto.Hora2))
                        {
                            return DAO.SalvarHoraNoBancoH2(Nome, Hora, Data);
                        }
                        else if (string.IsNullOrEmpty(ponto.Hora3))
                        {
                            return DAO.SalvarHoraNoBancoH3(Nome, Hora, Data);
                        }
                        else if (string.IsNullOrEmpty(ponto.Hora4))
                        {
                            return DAO.SalvarHoraNoBancoH4(Nome, Hora, Data);
                        }
                        else
                        {
                            var TelaErro = new Erro("Todas as horas de hoje já foram preenchidas");
                            TelaErro.Show();
                            return false;
                        }
                    }

                }

    
                return DAO.SalvarHoraNoBancoH1(Nome, Hora, Data);
            

            return false;
            


             

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
