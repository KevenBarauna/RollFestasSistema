using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.Model.DAO;

namespace Loja.Controler.Utils
{
    public static class Caminhos
    {

        public static string PegarCaminhoPonto()
        {
            DAOCaminho dao = new DAOCaminho();
            string caminho = dao.CaminhoPonto();
            return caminho;
        }//PEGA CAMINHO para SALVAR PONTO

        public static string CaminhoCahce()
        {
            DAOCaminho dao = new DAOCaminho();
            string caminho = dao.CaminhoCahce();
            return caminho;
        }//PEGA CAMINHO para SALVAR CAHCE

        public static string CaminhoComprovante()
        {
            DAOCaminho dao = new DAOCaminho();
            string caminho = dao.CaminhoComprovante();
            return caminho;
        }//PEGA CAMINHO para SALVAR CAHCE

    }
}
