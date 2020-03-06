using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RollFestas.Data;
using RollFestas.Models;
using RollFestas.Services;
using RollFestas.Utils;
using RollFestas.View.Avisos;
using RollFestas.View.MensagemErro;

namespace RollFestas.Controllers
{
    class VendaController
    {
        VendaDAO DAO = new VendaDAO();

        //SALVAR NOVA VENDA
        public bool FinalizarVenda(string Data, string Usuario, string ValorTotal, string ValorPago, string Troco, string TipoPagamento, string ParteCartao ,int StatusPagamento, string ValorPendente, string NomeCliente, List<ProdutoModel> ListaProdutos, bool Encomenda)
        {

            //VERIFICA SEM TEM PRODUTOS NA LISTA
            if (Encomenda == false)
            {
                if (ListaProdutos.Count <= 0)
                {
                    var TelaErro = new Erro("Adicione pelo menos um produto na lista");
                    TelaErro.Show();
                    return false;
                }
            }
            

            //VERIFICA A COMPRA TEM VALOR
            if (string.IsNullOrEmpty(ValorTotal))
            {
                var TelaErro = new Erro("Informe o valor total da venda");
                TelaErro.Show();
                return false;
            }

            //DEPENDENDO DO TIPO DE PAGAMENTO EXIGE O VALOR PENDENTE E NOME DO CLIENTE
            if (StatusPagamento == 1)
            {
                ValorPendente = "";
                NomeCliente = "";
            }

            if (StatusPagamento == 2)
            {
                if (ValorPendente == "")
                {
                    var TelaErro = new Erro("Informe o valor pendente");
                    TelaErro.Show();
                    return false;
                }
                if (NomeCliente == "")
                {
                    var TelaErro = new Erro("Informe o nome do cliente");
                    TelaErro.Show();
                    return false;
                }
 
            }

            //SALVA VENDA
            bool SucessoVenda = DAO.NovaVenda(Data, Usuario, ValorTotal, ValorPago, Troco, TipoPagamento, StatusPagamento, ValorPendente, NomeCliente);
            if (SucessoVenda == false)
            {
                var TelaErro = new Erro("Não foi possível finalizar a venda, verifique os valores e tente novamente");
                TelaErro.Show();
                return false;
            }

            //DECREMENTAR PRODUTOS
            if (Encomenda == false)
            {
                var produtoC = new ProdutoController();
                bool SucessoDecrementa = produtoC.DecrementarProdutos(ListaProdutos);
                if (SucessoDecrementa == false)
                {
                    var TelaErro = new Erro("Erro ao decrementar produto");
                    TelaErro.Show();
                }
            }


            //SE JÁ FOI PAGO
            if (StatusPagamento == 1)
            {
                //SALVAR DINHEIRO NO CAIXA
                var caixaC = new CaixaController();
                bool SucessoCaixa = caixaC.SalvarValor(Data, ValorTotal, TipoPagamento, ParteCartao);
                if (SucessoCaixa == false)
                {
                    var TelaErro = new Erro("Erro ao salvar valor no caixa");
                    TelaErro.Show();
                    return false;
                }
            }

            //SE AINDA VAI SER PAGO
            if (StatusPagamento == 2)
            {
                //SALVAR DINHEIRO NO CAIXA
                var caixaC = new CaixaController();
                bool SucessoCaixa = caixaC.SalvarValor(Data, ValorPago, TipoPagamento, ParteCartao);
                if (SucessoCaixa == false)
                {
                    var TelaErro = new Erro("Erro ao salvar valor no caixa");
                    TelaErro.Show();
                    return false;
                }
            }


            //GERAR RECIBO
            VendaModel UltimaVenda = PegarIdDaUltimaVenda();
            bool SucessoRecibo = GerarPDF.GerarReciboVenda(UltimaVenda.Id.ToString());
            if (SucessoRecibo == false)
            {
                var TelaErro = new Erro("Erro ao gerar recibo");
                TelaErro.Show();
            }

            VendaModel vendaM = PegarIdDaUltimaVenda();
            var Tela = new Sucesso("Venda cadastrada. Código da venda: " + vendaM.Id);
            Tela.Show();
            return true;
        }

        //CALCULAR TROCO
        public string CalcularTroco(string ValorTotal, string ValorRecebido)
        {
            decimal Total;
            decimal Recebido;

            if (string.IsNullOrEmpty(ValorTotal))
            {
                var TelaErro = new Erro("Informe o valor total");
                TelaErro.Show();
                return null;

            }

            if (string.IsNullOrEmpty(ValorRecebido))
            {
                var TelaErro = new Erro("Informe o valor recebido");
                TelaErro.Show();
                return null;
            }

            try
            {
                Total = Convert.ToDecimal(ValorTotal);
                Recebido = Convert.ToDecimal(ValorRecebido);

            }
            catch (Exception)
            {
                var TelaErro = new ErroController("CVT", "Erro, valores invalidos","Os valores informados estão corretos?", "Os valores informados não podem ser negativos", "Informou somente núemros e virgula?");
                TelaErro.Show();
                return null;
            }

            decimal ValorTroco = Recebido - Total;

            string Valor = ValorTroco.ToString();
            if (Valor.Contains("-"))
            {
                
                if (MessageBox.Show("Resta uma pendencia de " + Valor + ". Clique em OK para ir pra tela de pagamentos pendentes", "Valor negativo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    return "PENDENTE";

                }
            }

            return ValorTroco.ToString();
        }


        //LISTAR VENDAS POR DIA
        public List<VendaModel> ListarVendas(string Data)
        {
            List<VendaModel> ListaVenda = DAO.ListarVendas(Data);

            return ListaVenda;
        }

        //LISTAR VENDAS POR USUARIO
        public List<VendaModel> ListarVendasPorVendedor(string Vendedor)
        {
            var Ano = GetDate.PegarAno();

            List<VendaModel> ListaVenda = DAO.ListarVendasPorVendedor(Vendedor, Ano);

            return ListaVenda;
        }

        //LISTAR TODAS AS VENDAS PENDENTES
        public List<VendaModel> ListarVendasPendentes()
        {
            List<VendaModel> ListaVenda = DAO.ListarVendasPendentes();

            return ListaVenda;
        }

        //LISTAR VENDA PENDENTE PELO ID
        public VendaModel ExibirVendaPendentePorId(string Id)
        {
            VendaModel vendaM = DAO.ExibirVendaPendentes(Id);

            if (vendaM.Id == 0)
            {
                var TelaErro = new Erro("Venda pendente não encontrada");
                TelaErro.Show();

            }

            return vendaM;
        }

        //RETIRA STATUS DE PENDENCIA
        public bool RetirarPendencia(string Id)
        {
            VendaModel vendaM = DAO.ExibirVendaPendentes(Id);
            bool SucessoDAO = false;

            if (vendaM.Id == 0)
            {
                var TelaErro = new Erro("Venda pendente não encontrada");
                TelaErro.Show();
                return false;

            }
            else
            {
                SucessoDAO = DAO.RetirarPendencia(Id);
            }

            if (SucessoDAO == true)
            {
                var Tela = new Sucesso("Pendencia retirada com sucesso!");
                Tela.Show();

            }
            return SucessoDAO;
        }

        //APAGAR VENDA
        public bool ApagarVenda(string Id)
        {
            VendaModel vendaM = DAO.ExibirDetalhesdaVenda(Id);

            if (vendaM.Id == 0)
            {
                var TelaErro = new Erro("Venda não encontrada");
                TelaErro.Show();
                return false;

            }

            bool SucessoDAO = DAO.ApagarVenda(Id);

            if (SucessoDAO == true)
            {
                var TelaErro = new Sucesso("Venda apagada");
                TelaErro.Show();

            }

            return SucessoDAO;

        }

        //RETORNA ULTIMA VENDA
        public VendaModel PegarIdDaUltimaVenda()
        {
            VendaModel vendaM = DAO.UltimaVenda();

            return vendaM;
        }

        //EXIBIR VENDA POR USUARIO
        public string VendaPorUsuario(string Nome)
        {

            var Ano = GetDate.PegarAno();

            List<VendaModel> vendaM = DAO.ListarVendasPorVendedor(Nome, Ano);

            decimal ValorTotal = 0;
            foreach (var venda in vendaM)
            {
                decimal ValorVenda=0;

                try
                {
                    ValorVenda = Convert.ToDecimal(venda.ValorTotal);
                }
                catch (Exception)
                {
                    venda.ValorTotal = "0";
                }

                ValorTotal += Convert.ToDecimal(venda.ValorTotal);

            }
            
            return ValorTotal.ToString();
        }




    }
}
