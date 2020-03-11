using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RollFestas.Data;
using RollFestas.Date;

namespace RollFestas.Utils
{
    public static class GerarTxt
    {

        public static void SalvarTxtErro(string Titulo, string Mensagem, string NumeroErro, string Erros, string ErrosCode, string Caminho)
        {
            //CASO SEJA NULL
            if (string.IsNullOrEmpty(Titulo))
            {
                Titulo = "";
            }
            if (string.IsNullOrEmpty(Mensagem))
            {
                Mensagem = "";
            }
            if (string.IsNullOrEmpty(NumeroErro))
            {
                NumeroErro = "";
            }
            if (string.IsNullOrEmpty(Erros))
            {
                Erros = "";
            }
            if (string.IsNullOrEmpty(ErrosCode))
            {
                ErrosCode = "";
            }
            if (string.IsNullOrEmpty(Caminho))
            {
                Caminho = "";
            }
            if (string.IsNullOrEmpty(Program._Usuario.Nome))
            {
                Program._Usuario.Nome = "";
            }



            string DataPasta = GetDate.DataPararCriarPasta();
            //CRIAR PASTA
            DirectoryInfo raiz = new DirectoryInfo(@"" + Caminho);
            raiz.CreateSubdirectory(DataPasta);

            //GERAR ARQUIVO TXT
            StreamWriter STW_Arquivo;

            STW_Arquivo = new StreamWriter(@"" + Caminho + @"\" + DataPasta + @"\ErroCache" + NumeroErro + ".txt");

            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine(GetDate.PegarDiaeHora());
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("Titulo: " + Titulo);
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("Mensagem: " + Mensagem);
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("Número do erro: " + NumeroErro);
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("Erro: " + Erros);
            STW_Arquivo.WriteLine("");
            STW_Arquivo.WriteLine("Usuário logado: " + Program._Usuario.Nome);

            STW_Arquivo.Close();
        }

    }
}
