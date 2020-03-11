using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RollFestas.Data;
using RollFestas.Models;
using RollFestas.Utils;
using RollFestas.View;
using RollFestas.View.MensagemErro;

namespace RollFestas.Controllers
{
    class CaixaController
    {

        CaixaDAO DAO = new CaixaDAO();

        public bool IniciarCaixaDia(string Data)
        {

             return  DAO.IniciarCaixa(Data);

        }

        //SAlVAR VALOR CAIXA
        public bool SalvarValor(string Data, string Valor, string TipoPagamento, string ValorDivididoCartao)
        {

            CaixaModel caixaM = DAO.PegarValoresPorData(Data);
            decimal ValorRecebido = 0;
            decimal ValorBanco = 0;
            decimal NovoValor = 0;

            if (String.IsNullOrEmpty(Valor))
            {
                Valor = "0";
            }
            if (String.IsNullOrEmpty(caixaM.Dinheiro))
            {
                caixaM.Dinheiro = "0";
            }
            if (String.IsNullOrEmpty(caixaM.Cartao))
            {
                caixaM.Cartao = "0";
            }
            if (String.IsNullOrEmpty(caixaM.Outros))
            {
                caixaM.Outros = "0";
            }
            if (String.IsNullOrEmpty(caixaM.Devolucao))
            {
                caixaM.Devolucao = "0";
            }
            if (String.IsNullOrEmpty(ValorDivididoCartao))
            {
                ValorDivididoCartao = "0";
            }


            if (TipoPagamento == "Dinheiro")
            {
                ValorBanco = Convert.ToDecimal(caixaM.Dinheiro);
                ValorRecebido = Convert.ToDecimal(Valor);
                NovoValor = ValorBanco + ValorRecebido;

                return DAO.InserirDinheiro(NovoValor.ToString(), Data);
            }
            else if (TipoPagamento == "Cartão")
            {
                ValorBanco = Convert.ToDecimal(caixaM.Cartao);
                ValorRecebido = Convert.ToDecimal(Valor);
                NovoValor = ValorBanco + ValorRecebido;

                return DAO.InserirCartao(NovoValor.ToString(), Data);
            }
            else if (TipoPagamento == "Outros")
            {
                ValorBanco = Convert.ToDecimal(caixaM.Outros);
                ValorRecebido = Convert.ToDecimal(Valor);
                NovoValor = ValorBanco + ValorRecebido;

                return DAO.InserirOutros(NovoValor.ToString(), Data);
            }
            else if (TipoPagamento == "Dinheiro e Cartão")
            {
                //DECLARANDO VARIÁVEIS - PEGANDO VALOR TOTAL;
                decimal ValorRecebidoDinheiro = Convert.ToDecimal(Valor);
                decimal ValorRecebidoCartao = 0;
                decimal ValorBancoDinheiro = 0;
                decimal ValorBancoCartao = 0;

                //PEGAR VALOR DINHEIRO E CARTÃO
                ValorRecebidoCartao = Convert.ToDecimal(ValorDivididoCartao);
                ValorRecebidoDinheiro = ValorRecebidoDinheiro - ValorRecebidoCartao;

                //PEGANDO VALORES DO BANCO
                ValorBancoDinheiro = Convert.ToDecimal(caixaM.Dinheiro);
                ValorBancoCartao = Convert.ToDecimal(caixaM.Cartao);

                //SALVAR DINHEIRO
                NovoValor = ValorRecebidoDinheiro + ValorBancoDinheiro;
                DAO.InserirDinheiro(NovoValor.ToString(), Data);

                //SALVAR CARTÃO
                NovoValor = ValorRecebidoCartao + ValorBancoCartao;
                return DAO.InserirCartao(NovoValor.ToString(), Data);
            }
            else if (TipoPagamento == "Troca")
            {
                ValorBanco = Convert.ToDecimal(caixaM.Devolucao);
                decimal ValorDevolver = Convert.ToDecimal(Valor);
                NovoValor = ValorBanco + ValorDevolver;

                //GUARDAR VALOR TOTAL TROCA DO DIA
                DAO.InserirTroca(NovoValor.ToString(), Data);

                //TOTAL DINHEIRO - TROCA
                ValorBanco = Convert.ToDecimal(caixaM.Dinheiro);
                ValorDevolver = Convert.ToDecimal(Valor);
                NovoValor = ValorBanco - ValorDevolver;
                return DAO.InserirDinheiro(NovoValor.ToString(), Data);

            }
            return false;
        }

        //VALOR TOTAL DO DIA
        public CaixaModel TotalVendasNoDia(string Data)
        {
            SomarValorTotal(Data);

            CaixaModel CaixaM = DAO.PegarValoresPorData(Data);

            if (string.IsNullOrEmpty(CaixaM.Dinheiro))
            {
                CaixaM.Dinheiro = "0";
            }
            if (string.IsNullOrEmpty(CaixaM.Cartao))
            {
                CaixaM.Cartao = "0";
            }
            if (string.IsNullOrEmpty(CaixaM.Outros))
            {
                CaixaM.Outros = "0";
            }
            if (string.IsNullOrEmpty(CaixaM.Retirada))
            {
                CaixaM.Retirada = "0";
            }
            if (string.IsNullOrEmpty(CaixaM.Deposito))
            {
                CaixaM.Deposito = "0";
            }

            return CaixaM;
        }

        //RETIRAR DINHEIRO DO CAIXA EM CASO DE CANCELAMENTO
        public bool RetirarValorPorCancelamento(string Data, string ValorDevolvido, string TipoPagamento)
        {
            CaixaModel caixaM = DAO.PegarValoresPorData(Data);

            decimal ValorTotal = 0;
            decimal ValorBanco = 0;
            decimal NovoValor = 0;

            if (String.IsNullOrEmpty(ValorDevolvido))
            {
                ValorDevolvido = "0";
            }
            if (String.IsNullOrEmpty(caixaM.Dinheiro))
            {
                caixaM.Dinheiro = "0";
            }
            if (String.IsNullOrEmpty(caixaM.Cartao))
            {
                caixaM.Dinheiro = "0";
            }
            if (String.IsNullOrEmpty(caixaM.Outros))
            {
                caixaM.Dinheiro = "0";
            }


            if (TipoPagamento == "Dinheiro")
            {
                ValorBanco = Convert.ToDecimal(caixaM.Dinheiro);
                ValorTotal = Convert.ToDecimal(ValorDevolvido);
                NovoValor = ValorBanco - ValorTotal;

                return DAO.InserirDinheiro(NovoValor.ToString(), Data);
            }
            else if (TipoPagamento == "Cartão")
            {
                ValorBanco = Convert.ToDecimal(caixaM.Cartao);
                ValorTotal = Convert.ToDecimal(ValorDevolvido);
                NovoValor = ValorBanco - ValorTotal;

                return DAO.InserirCartao(NovoValor.ToString(), Data);
            }
            else if (TipoPagamento == "Outros")
            {
                ValorBanco = Convert.ToDecimal(caixaM.Outros);
                ValorTotal = Convert.ToDecimal(ValorDevolvido);
                NovoValor = ValorBanco - ValorTotal;

                return DAO.InserirOutros(NovoValor.ToString(), Data);
            }
            return false;

        }

        //REALIZAR RETIRADA
        public bool Retirada(string Valor)
        {
            //DATA
            var Data = GetDate.PegarDiaMesAnoAtual();
            DAO.IniciarCaixa(Data);

            //PEGAR VALOR DO BANCO
            CaixaModel caixaM = DAO.PegarValoresPorData(Data);

            //VERIFICA VALORES
            try
            {
                decimal VerificaValor = Convert.ToDecimal(Valor);
            }
            catch (Exception)
            {
                var TelaErro = new Erro("Não foi possível realizar essa ação, verifique se o valor digitado está correto");
                TelaErro.Show();
                return false;
            }

            //CASO VALORES SEJA NULL
            if (String.IsNullOrEmpty(Valor))
            {
                Valor = "0";
            }
            if (String.IsNullOrEmpty(caixaM.Dinheiro))
            {
                caixaM.Dinheiro = "0";
            }
            if (String.IsNullOrEmpty(caixaM.Retirada))
            {
                caixaM.Retirada = "0";
            }

            //CONVERTER VALORES
            decimal ValorBanco = Convert.ToDecimal(caixaM.Dinheiro);
            decimal ValorRetirada = Convert.ToDecimal(Valor);

            //VERIFICA SE TEM ESSE VALOR NO CAIXA
            if (ValorBanco < ValorRetirada)
            {
                var TelaErro = new ErroController("R02VM", "O valor da retirada é maior que o valor disponível no caixa", "Realize uma venda", "Informe o valor de fundo de caixa", "");
                TelaErro.Show();
                return false;
            }

            decimal NovoValor = ValorBanco - ValorRetirada;

            //ADICIONAR RETIRADA
            decimal RetiradaTotal = Convert.ToDecimal(caixaM.Retirada);
            RetiradaTotal = RetiradaTotal + ValorRetirada;
            bool SucessoDAO = DAO.Retirada(RetiradaTotal.ToString(), Data);

            //ADICIONA NOVO VALOR DINHEIRO
            DAO.InserirDinheiro(NovoValor.ToString(), Data);

            //SOMA VALOR TOTAL
            SomarValorTotal(Data);


            //TELA DE SUCESSO
            if (SucessoDAO == true)
            {
                var TelaHome = new Home(false);
                TelaHome.Show();
                var Tela = new Sucesso("Retirada registrada com sucesso!");
                Tela.Show();
            }

            return SucessoDAO;

        }

        //REALIZAR DEPOSITO
        public bool Deposito(string Valor)
        {
            //DATA
            var Data = GetDate.PegarDiaMesAnoAtual();
            DAO.IniciarCaixa(Data);

            //PEGAR VALOR DO BANCO
            CaixaModel caixaM = DAO.PegarValoresPorData(Data);

            //VERIFICA VALORES
            try
            {
                decimal VerificaValor = Convert.ToDecimal(Valor);
            }
            catch (Exception)
            {
                var TelaErro = new Erro("Não foi possível realizar essa ação, verifique se o valor digitado está correto");
                TelaErro.Show();
                return false;
            }

            //CASO VALORES SEJA NULL
            if (String.IsNullOrEmpty(Valor))
            {
                Valor = "0";
            }
            if (String.IsNullOrEmpty(caixaM.Dinheiro))
            {
                caixaM.Dinheiro = "0";
            }
            if (String.IsNullOrEmpty(caixaM.Deposito))
            {
                caixaM.Deposito = "0";
            }

            //REALIZAR DEPOSITO
            decimal ValorBanco = Convert.ToDecimal(caixaM.Dinheiro);
            decimal ValorDeposito = Convert.ToDecimal(Valor);

            decimal NovoValor = ValorBanco + ValorDeposito;

            //SALVAR VALOR
            decimal DepositoTotal = Convert.ToDecimal(caixaM.Deposito);
            DepositoTotal = DepositoTotal + ValorDeposito;
            bool SucessoDAO = DAO.Deposito(DepositoTotal.ToString(), Data);

            //NOVO VALOR DINHEIRO
            DAO.InserirDinheiro(NovoValor.ToString(), Data);

            //SOMAR VALOR TOTAL
            SomarValorTotal(Data);

            //TELA DE SUCESSO
            if (SucessoDAO == true)
            {
                var TelaHome = new Home(false);
                TelaHome.Show();
                var Tela = new Sucesso("Depósito registrado com sucesso!");
                Tela.Show();
            }

            return SucessoDAO;

        }

        //SOMA VALOR TOTAL
        public void SomarValorTotal(string Data)
        {

            //PEGAR VALOR DO BANCO
            CaixaModel caixaM = DAO.PegarValoresPorData(Data);


            //CASO VALORES SEJA NULL
            if (String.IsNullOrEmpty(caixaM.Dinheiro) || caixaM.Dinheiro == "")
            {
                caixaM.Dinheiro = "0";
            }
            if (String.IsNullOrEmpty(caixaM.Cartao) || caixaM.Cartao == "")
            {
                caixaM.Cartao = "0";
            }
            if (String.IsNullOrEmpty(caixaM.Outros) || caixaM.Outros == "")
            {
                caixaM.Outros = "0";
            }


            //REALIZAR DEPOSITO
            decimal ValorDinheiro = Convert.ToDecimal(caixaM.Dinheiro);
            decimal ValorCartao = Convert.ToDecimal(caixaM.Cartao);
            decimal ValorOutros = Convert.ToDecimal(caixaM.Outros);
            decimal NovoValor = (ValorDinheiro + ValorCartao + ValorOutros);

            //SALVAR VALOR
            DAO.InserirValorTotal(NovoValor.ToString(), Data);

        }

        //VALOR TOTAL DO MES
        public List<CaixaModel> MostrarTotalVendaMes(string Mes)
        {

            List<CaixaModel> ListaCaixa = DAO.PegarValoresPorMes(Mes);

            if (ListaCaixa.Count < 0)
            {
                var TelaErro = new Erro("Nenhum registro encontrado");
                TelaErro.Show();
            }

            return ListaCaixa;

        }

        //VALOR TOTAL DO ANO
        public List<CaixaModel> MostrarTotalVendaAno(string Ano)
        {

            List<CaixaModel> ListaCaixa = DAO.PegarValoresPorAno(Ano);

            if (ListaCaixa.Count < 0)
            {
                var TelaErro = new Erro("Nenhum registro encontrado");
                TelaErro.Show();
            }

            return ListaCaixa;

        }


    }
}
