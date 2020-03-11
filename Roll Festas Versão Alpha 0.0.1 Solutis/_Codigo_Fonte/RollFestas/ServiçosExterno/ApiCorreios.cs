using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correios;
using RollFestas.Utils;
using RollFestas.View.MensagemErro;

namespace RollFestas.ServiçosExterno
{
    public static class ApiCorreios
    {
        public class EnderecoModel{

            public string UF { get; set; }
            public string Cidade { get; set; }
            public string Endereco { get; set; }
            public string Bairro { get; set; }
            public string Local { get; set; }

        }

        public static EnderecoModel ConsultaCEP(string CEP)
        {
            CorreiosApi correios = new CorreiosApi();
            var End = new EnderecoModel();
            try
            {
                var retorno = correios.consultaCEP(CEP);

                End.UF = retorno.uf;
                End.Cidade = retorno.cidade;
                End.Endereco = retorno.end;
                End.Bairro = retorno.bairro;

                End.Local = "Rua: " + retorno.end + " | " + retorno.bairro;
               
            }
            catch (Exception e)
            {
                GerarTxt.SalvarTxtErro(null,e.Message,null,null,null,Program._CaminhoCacheErro);
                var Tela = new Erro("Verifique o CEP ou sua conexão. " + e.Message);
                Tela.Show();
                //(https://viacep.com.br/)
            }

            return End;

        }
        


    }
}
