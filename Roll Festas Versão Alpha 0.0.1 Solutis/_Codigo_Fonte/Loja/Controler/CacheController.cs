using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Loja.Model;
using Loja.Model.DAO;

namespace Loja.Controler
{
    class CacheController
    {
        public void SalvarPontoTxt()
        {

            //PEGAR DATA
            Controller tempo = new Controller();
            String dia = tempo.DataPararCriarPasta();
            String data = tempo.PegarDiaMesAnoAtual();

            //ACESSAR BANCO PONTO
            List<PontoModel> ListaDePonto = new List<PontoModel>();

            DAOPonto pontod = new DAOPonto();
            ListaDePonto = pontod.ListarPordata(data);

            //ACESSAR BANCO VENDA
            List<VendaModel> ListaDeVenda = new List<VendaModel>();

            DAOVenda vendad = new DAOVenda();
            ListaDeVenda = vendad.ListarVendas(data);


            //CAMINHO PARA SALVAR
            DAOCaminho daoCaminho = new DAOCaminho();
            string caminho = daoCaminho.CaminhoCahce();

            //CRIAR PASTA
            //DirectoryInfo raiz = new DirectoryInfo(@"C:\Users\keven.barauna\Desktop\Roll Festas Versão Alpha Solutis\Cache");
            DirectoryInfo raiz = new DirectoryInfo(@"" + caminho );
            raiz.CreateSubdirectory(dia);

            //GERAR ARQUIVO TXT
            StreamWriter STW_Arquivo;
        
            //STW_Arquivo = new StreamWriter(@"C:\Users\keven.barauna\Desktop\Roll Festas Versão Alpha Solutis\Cache\" + dia + "\\Arq_Cache.txt");
            STW_Arquivo = new StreamWriter(@"" + caminho + @"\" + dia + @"\Arq_Cache.txt");

            STW_Arquivo.WriteLine(dia);

            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("PONTO:");
            STW_Arquivo.WriteLine("");

            foreach (var ponto in ListaDePonto)
            {
              STW_Arquivo.WriteLine("Usuário: " + ponto.Nome + "|" + "Chegada: " + ponto.Hora1 + "|" + "Saída almoço: " + ponto.Hora2 + "|" + "Chegada almoço: " + ponto.Hora3 + "|" + "Saída: " + ponto.Hora4 + " .");
            }

            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("VENDA:");
            STW_Arquivo.WriteLine("");

            foreach (var venda in ListaDeVenda)
            {
                STW_Arquivo.WriteLine("Código: " + venda.Id + "|" + "Usuário: " + venda.Usuario + "|" + "Valor total: " + venda.ValorTotal + "|" + "Valor pago: " + venda.ValorPago + "|" + "Troco: " + venda.Troco + "|" + "Tipo de pagamento: " + venda.TipoPagamento + "|" + "Status de pagamento:" + venda.StatusPagamento + "|" + "Valor pendente: " + venda.ValorPendente + ".");
            }


            STW_Arquivo.Close();
        }


       
    }
}
