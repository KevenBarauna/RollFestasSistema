using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.Model;

namespace Loja.Controler
{
    class VendaController
    {
        public Decimal CalcularPorQuantidade(String nome, Decimal quantidadeDecimal)
        {
            DAOVenda dao = new DAOVenda();
            Decimal VT = 0;

            VT = dao.PegarValorPorNome(nome);
            VT = VT * quantidadeDecimal;

            return VT;
        }//CALCULAR VALOR UNIDADE DO PRODUTO * QUANTIDADE

        public void FinalizarVenda(String data, String usuario, String valortotal, String valorpago, String troco, String tipopagamento, int status_pagamento, String valor_pendente)
        {
            DAOVenda dao = new DAOVenda();
            dao.NovaVenda(data, usuario, valortotal, valorpago, troco, tipopagamento, status_pagamento,valor_pendente);
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
