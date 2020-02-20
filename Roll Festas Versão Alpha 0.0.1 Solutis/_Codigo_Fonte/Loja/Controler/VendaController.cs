using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.Model;
using Loja.View;

namespace Loja.Controler
{
    class VendaController
    {
        public Decimal CalcularPorQuantidade(String nome, Decimal quantidadeDecimal)
        {
            Decimal VT = 0;

            try
            {
                DAOVenda dao = new DAOVenda();
                VT = dao.PegarValorPorNome(nome);
                VT = VT * quantidadeDecimal;
            }
            catch (Exception e)
            {
                Erro TelaDeErro = new Erro("005", "Erro ao converter valor" + e, "Verifique se o valor do produto foi salvo corretamente", "Verifique se o banco de dados está ativo", "","","");
                TelaDeErro.Show();
            }
            return VT;
        }//CALCULAR VALOR UNIDADE DO PRODUTO * QUANTIDADE

        public void FinalizarVenda(String data, String usuario, String valortotal, String valorpago, String troco, String tipopagamento, int status_pagamento, String valor_pendente, String nome)
        {
            try
            {
                DAOVenda dao = new DAOVenda();
                dao.NovaVenda(data, usuario, valortotal, valorpago, troco, tipopagamento, status_pagamento, valor_pendente, nome);
            }
            catch (Exception e)
            {
                Erro TelaDeErro = new Erro("006", "Erro ao salvar venda " + e, "Verifique se todos os campos foram preenchidos corretamente", "Verifique se o banco de dados está ativo", "", "", "");
                TelaDeErro.Show();
            }

        }//SALVAR NOVA VENDA

        public List<VendaModel> ListarVendas(String data)
        {
            List<VendaModel> venda = new List<VendaModel>();
            DAOVenda dao = new DAOVenda();
            venda  = dao.ListarVendas(data);

            return venda;
        }//LISTAR VENDAS POR DIA

        public List<VendaModel> ListarVendasPendentes()
        {
            List<VendaModel> venda = new List<VendaModel>();
            DAOVenda dao = new DAOVenda();
            venda = dao.ListarVendasPendentes();

            return venda;
        }//LISTAR VENDAS PENDENTES

        public VendaModel ListarVendasPendentesPorId(String id)
        {
            VendaModel venda = new VendaModel();
            DAOVenda dao = new DAOVenda();
            venda = dao.ListarVendasPendentesPorId(id);

            return venda;
        }//LISTAR VENDA PENDENTE PELO ID

        public void RetirarPendencia(String id)
        {

            DAOVenda dao = new DAOVenda();
            dao.RetirarPendencia(id);

        }//RETIRA STATUS DE PENDENCIA

        public void CancelarVenda(String id)
        {

            DAOVenda dao = new DAOVenda();
            dao.CancelarVenda(id);

        }//CANCELA UMA VENDA POR DEVOLUCAO

        public VendaModel PegarIdDaUltimaVenda()
        {
            VendaModel venda = new VendaModel();
            DAOVenda dao = new DAOVenda();
            venda = dao.PegarUltimaVendaParaGerarRecibo();

            return venda;
        }
    }
}
