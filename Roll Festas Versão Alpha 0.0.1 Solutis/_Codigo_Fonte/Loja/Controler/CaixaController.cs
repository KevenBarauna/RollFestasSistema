using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.Controler.Utils;
using Loja.Model;

namespace Loja.Controler
{
    class CaixaController
    {

        public void SalvarNoCaixa(String Data, String valor, String Tipo_Pagamento,String TxtDinCart)
        {
            DAOCaixa dao = new DAOCaixa();
            Decimal ValorTotal = 0;

            if (String.IsNullOrEmpty(valor))
            {
                valor = "0";
            }

            if (Tipo_Pagamento == "Dinheiro")
            {
                ValorTotal = dao.PegarValorDinheiro(Data);
                ValorTotal = ValorTotal + Convert.ToDecimal(valor);
                dao.InserirVendaNoCaixaDinheiro(Convert.ToString(ValorTotal), Data);
            }
            else if (Tipo_Pagamento == "Cartão")
            {
                ValorTotal = dao.PegarValorCartao(Data);
                ValorTotal = ValorTotal + Convert.ToDecimal(valor);
                dao.InserirVendaNoCaixaCartao(Convert.ToString(ValorTotal), Data);
            }
            else if (Tipo_Pagamento == "Outros")
            {
                ValorTotal = dao.PegarValorOutros(Data);
                ValorTotal = ValorTotal + Convert.ToDecimal(valor);
                dao.InserirVendaNoCaixaOutros(Convert.ToString(ValorTotal), Data);
            }
            else if (Tipo_Pagamento == "Dinheiro e Cartão")
            {
                Decimal ValorTotalDinheiro = 0;
                Decimal ValorTotalCartao = 0;

                //PEGAR VALORES
                ValorTotalDinheiro = dao.PegarValorDinheiro(Data);
                ValorTotalCartao   = dao.PegarValorCartao(Data);

                //INFORMOU CARTAO

                if (String.IsNullOrEmpty(TxtDinCart))
                {
                    TxtDinCart = "0";
                }

                Decimal ValorCartão   = Convert.ToDecimal(TxtDinCart);
                Decimal ValorDinheiro = Convert.ToDecimal(valor) - ValorCartão;


                ValorTotalDinheiro = ValorTotalDinheiro + ValorDinheiro;
                dao.InserirVendaNoCaixaDinheiro(Convert.ToString(ValorTotalDinheiro), Data);

                ValorTotalCartao = ValorTotalCartao + ValorCartão;
                dao.InserirVendaNoCaixaCartao(Convert.ToString(ValorTotalCartao), Data); ;
            }
        }//SALVAR VALOR NO CAIXA

        public String FechamentoDoDiaTotal(String data)
        {
            //LISTAR TODAS AS VENDAS PAGAS

            //List<VendaModel> vendas = new List<VendaModel>();
            //List<CaixaModel> caixaM = new List<CaixaModel>();

            //DAOVenda dao = new DAOVenda();
            //vendas = dao.ListarVendasPagas(data);


            //foreach (var v in vendas)
            //{
            //    CaixaModel caixa = new CaixaModel();
            //    caixa.ValorTotal = Convert.ToDecimal(v.ValorTotal);
            //    caixaM.Add(caixa);

            //}

            ////SOMAR TODAS AS VENDAS PAGAS

            //Decimal ValorTotal = 0;

            //foreach (var v in caixaM)
            //{
            //    ValorTotal = ValorTotal + Convert.ToDecimal(v.ValorTotal);

            //}

            //PEGAR VALOR NO CAIXA
            Decimal ValorTotal = 0;
            DAOCaixa vcaoxa = new DAOCaixa();
            ValorTotal = ValorTotal + vcaoxa.PegarValorDinheiro(data);
            ValorTotal = ValorTotal + vcaoxa.PegarValorCartao(data);
            ValorTotal = ValorTotal + vcaoxa.PegarValorOutros(data);

           // MessageBox.Show("Debuug: O valor TOTAL de hoje é: " + ValorTotal);
            return Convert.ToString( ValorTotal);
        }//LISTAR TODOS OS VALORES DO CAIXA

        public void TotalVendasNoDia(String data)
        {
            Decimal ValorTotal = 0;
            DAOCaixa vcaoxa = new DAOCaixa();
            ValorTotal = ValorTotal + vcaoxa.PegarValorDinheiro(data);
            ValorTotal = ValorTotal + vcaoxa.PegarValorCartao(data);
            ValorTotal = ValorTotal + vcaoxa.PegarValorOutros(data);
            vcaoxa.SomarValorTotal(Convert.ToString( ValorTotal ), data);
        }//LISTAR TODOS OS VALORES DO CAIXA

        public String FechamentoDoDiaTotalDinheiro(String data)
        {
            DAOCaixa dao = new DAOCaixa();
            Decimal TotalDinheiro = dao.PegarValorDinheiro(data);

            return Convert.ToString(TotalDinheiro); 
        }

        public String FechamentoDoDiaTotalCartao(String data)
        {
            DAOCaixa dao = new DAOCaixa();
            Decimal TotalCartao = dao.PegarValorCartao(data);

            return Convert.ToString(TotalCartao);
        }

        public String FechamentoDoDiaTotalOutros(String data)
        {
            DAOCaixa dao = new DAOCaixa();
            Decimal TotalOutros = dao.PegarValorOutros(data);

            return Convert.ToString(TotalOutros);
        }

        public String FechamentoDoDiaTotalRetirada(String data)
        {
            DAOCaixa dao = new DAOCaixa();
            Decimal TotalOutros = dao.VerRetirada (data);

            return Convert.ToString(TotalOutros);
        }

        public String FechamentoDoDiaTotalDeposito(String data)
        {
            DAOCaixa dao = new DAOCaixa();
            Decimal TotalOutros = dao.VerDeposito(data);

            return Convert.ToString(TotalOutros);
        }

        public void RetirarDoCaixaPorCancelamento(String Data, String valor)
        {
            DAOCaixa dao = new DAOCaixa();
            Decimal ValorTotal = 0;

            if (String.IsNullOrEmpty(valor))
            {
                valor = "0";
            }

                ValorTotal = dao.PegarValorDinheiro(Data);
                ValorTotal = ValorTotal - Convert.ToDecimal(valor);
                dao.RetirarDinheiroCaixa(Convert.ToString(ValorTotal), Data);
        }//CANCELAR VENDA

        public void Retirada(String valor)
        {
            //VERIFICA VALOR DIGITADO
            Controller VerificaValor = new Controller();
            if (VerificaValor.VerificaDinheiro(valor))
            {
                    
                String data = Date.PegarDiaMesAnoAtual();

                DAOCaixa dao = new DAOCaixa();
                Decimal ValorTotal = 0;

                if (String.IsNullOrEmpty(valor))
                {
                    valor = "0";
                }

                ValorTotal = dao.PegarValorDinheiro(data);
                ValorTotal = ValorTotal - Convert.ToDecimal(valor);
                dao.LarcarRetirada(Convert.ToString(valor), data);
                dao.RetirarDinheiroCaixa(Convert.ToString(ValorTotal), data);
                MessageBox.Show("sucesso!");
            }
        }//REALIZAR RETIRADA

        public void Deposito(String valor)
        {

            Controller VerificaValor = new Controller();
            if (VerificaValor.VerificaDinheiro(valor))
            {

                String data = Date.PegarDiaMesAnoAtual();

                DAOCaixa dao = new DAOCaixa();
                Decimal ValorTotal = 0;

                if (String.IsNullOrEmpty(valor))
                {
                    valor = "0";
                }

                ValorTotal = dao.PegarValorDinheiro(data);
                ValorTotal = ValorTotal + Convert.ToDecimal(valor);
                dao.LarcarDeposito(Convert.ToString(valor), data);
                dao.RetirarDinheiroCaixa(Convert.ToString(ValorTotal), data);
                MessageBox.Show("Sucesso!");
            }
        }//REalIZAR DEPOSITO

        public String MostrarTotalVendaDia(String dia)
        {
            String ValorTotal;
            DAOCaixa dao = new DAOCaixa();
            ValorTotal = dao.ListarCaixaPorDia(dia);
            return ValorTotal;
            
        }//LISTAR TOTAL CAIXA PELO DIA

        public String MostrarTotalVendaMes(String data)
        {
            Decimal ValorTotal=0;
            List<CaixaModel> ListaCaixa = new List<CaixaModel>();

            DAOCaixa dao = new DAOCaixa();
            ListaCaixa = dao.ListarCaixaPorMes(data);

            foreach (var valor in ListaCaixa)
            {
                ValorTotal = ValorTotal + Convert.ToDecimal( valor.ValorTotal);
            }

            String Total = Convert.ToString(ValorTotal);
            return Total;

        }//LISTAR TOTAL CAIXA PELO ANO

        public String MostrarTotalVendaAno(String data)
        {
            Decimal ValorTotal = 0;
            List<CaixaModel> ListaCaixa = new List<CaixaModel>();

            DAOCaixa dao = new DAOCaixa();
            ListaCaixa = dao.ListarCaixaPorAno(data);

            foreach (var valor in ListaCaixa)
            {
                ValorTotal = ValorTotal + Convert.ToDecimal(valor.ValorTotal);
            }

            String Total = Convert.ToString(ValorTotal);
            return Total;

        }//LISTAR TOTAL CAIXA PELO MÊS


    }
}
