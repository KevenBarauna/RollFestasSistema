using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using RollFestas.Data;
using RollFestas.Models;
using RollFestas.View.MensagemErro;

namespace RollFestas.Utils
{
    public class Produto
    {
        List<ProdutoModel> ListaProdutos = Program._Produtos;
    }
    public static class GerarPDF
    {
        public static bool GerarReciboVenda(string Id)
        {
            try
            {

                var DAO = new VendaDAO();

                string Data = GetDate.DataPararCriarPasta();

                VendaModel vendaModel = DAO.ExibirDetalhesdaVenda(Id);

                Document doc = new Document(iTextSharp.text.PageSize.A6);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(Program._CaminhoReciboVenda + @"\" + Id + ".pdf", FileMode.Create));

                doc.Open();

                string dados = "";

                Paragraph paragrafo = new Paragraph(dados, new Font(Font.NORMAL, 9));


                paragrafo.Font = new Font(Font.NORMAL, 7, (int)System.Drawing.FontStyle.Regular);
                paragrafo.Add("                                                     ");

                paragrafo.Font = new Font(Font.NORMAL, 9, (int)System.Drawing.FontStyle.Bold);
                paragrafo.Add("                Roll Festas               ");
                paragrafo.Add("-----------------------------------------");



                paragrafo.Add("     Endereço: Rua do Paraíso, n° 34      ");
                paragrafo.Add("              Box 1 Salvador - BA         ");
                paragrafo.Add("                                         ");



                paragrafo.Add("CNPJ:  20.600.571/0001-74                ");
                paragrafo.Add("                                         ");
                paragrafo.Add("E-mail: rollfestas@hotmail.com           ");
                paragrafo.Add("Telefone: (71) 3321-5411                 ");
                paragrafo.Add("@lojarollfestas                          ");
                paragrafo.Add("                                         ");



                paragrafo.Add("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                paragrafo.Add("         ESSE CUPOM NÃO É VALIDO       ");
                paragrafo.Add("             FORA DO ESTABELICIMENTO   ");
                paragrafo.Add("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

                paragrafo.Add("                                         ");

                String DataDaVenda = vendaModel.Data;
                String CodDaVenda = Convert.ToString(vendaModel.Id);


                paragrafo.Add("Data: " + DataDaVenda + "                       ");
                paragrafo.Add("Código: " + CodDaVenda + "                             ");
                paragrafo.Add("                                         ");

                String ValorTotalDaVenda = vendaModel.ValorTotal;
                String ValorpagoDaVenda = vendaModel.ValorPago;


                paragrafo.Add("Valor total: " + ValorTotalDaVenda + "                       ");
                paragrafo.Add("Valor pago: " + ValorpagoDaVenda + "                       ");

                //String TrocoDaVenda = vendaModel.Troco;
                String PendenciaDaVenda = vendaModel.ValorPendente;


                //paragrafo.Add("Troco: " + TrocoDaVenda + "                               ");
                paragrafo.Add("Pendencia: " + PendenciaDaVenda + "                       ");


                paragrafo.Add("         Obrigado pela preferência!!!      ");

                doc.Add(paragrafo);

                doc.Close();

                GerarReciboListaVenda(Id);

                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro recibo: " + e);
                return false;
            }

        }

        public static bool GerarReciboListaVenda(string Id)
        {
            try
            {

                string Data = GetDate.DataPararCriarPasta();

                Document doc = new Document(iTextSharp.text.PageSize.A6);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(Program._CaminhoReciboVenda + @"\ListaProduto" + Id + ".pdf", FileMode.Create));

                doc.Open();

                string dados = "";

                Paragraph paragrafo = new Paragraph(dados, new Font(Font.NORMAL, 9));


                paragrafo.Font = new Font(Font.NORMAL, 7, (int)System.Drawing.FontStyle.Regular);
                paragrafo.Add("                                                     ");

                paragrafo.Font = new Font(Font.NORMAL, 9, (int)System.Drawing.FontStyle.Bold);
                paragrafo.Add("                Roll Festas               ");
                paragrafo.Add("-----------------------------------------");



                paragrafo.Add("     Endereço: Rua do Paraíso, n° 34      ");
                paragrafo.Add("              Box 1 Salvador - BA         ");
                paragrafo.Add("                                         ");



                paragrafo.Add("CNPJ:  20.600.571/0001-74                ");
                paragrafo.Add("                                         ");
                paragrafo.Add("E-mail: rollfestas@hotmail.com           ");
                paragrafo.Add("Telefone: (71) 3321-5411                 ");
                paragrafo.Add("@lojarollfestas                          ");
                paragrafo.Add("                                         ");



                paragrafo.Add("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                paragrafo.Add("         ESSE CUPOM NÃO É VALIDO       ");
                paragrafo.Add("             FORA DO ESTABELICIMENTO   ");
                paragrafo.Add("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

                paragrafo.Add("                                         ");

                decimal ValorTotal = 0;
                foreach (var item in Program._Produtos)
                {
                    paragrafo.Add("[ Código: " + item.Id + " ]");
                    paragrafo.Add("[ Produto: " + item.Nome + " ]");
                    paragrafo.Add("[ Quantidade: " + item.QuantidadeVenda + " ]");
                    paragrafo.Add("[ Valor da unidade: " + item.Preco + " ]");
                    ValorTotal = ValorTotal + Convert.ToDecimal(item.Preco) * Convert.ToDecimal(item.QuantidadeVenda);
                }

                paragrafo.Add("");

                paragrafo.Add("Valor Total: R$ " + ValorTotal);

                paragrafo.Add("");

                paragrafo.Add("Data: " + GetDate.PegarHoraMinutoAtual());
                paragrafo.Add("Usuário: " + Program._Usuario.Nome);

                paragrafo.Add("");

                paragrafo.Add("         Obrigado pela preferência!!!      ");

                doc.Add(paragrafo);

                doc.Close();

                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro recibo de lista de venda: " + e);
                return false;
            }

        }

        public static bool GerarPDFA4(string Informacoes)
        {
            try
            {

                string Data = GetDate.DataPararCriarPasta();

                Document doc = new Document(iTextSharp.text.PageSize.A4);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(Program._CaminhoReciboVenda + @"\Arquivo.pdf", FileMode.Create));

                doc.Open();

                string dados = "";

                Paragraph paragrafo = new Paragraph(dados, new Font(Font.NORMAL, 9));


                paragrafo.Font = new Font(Font.NORMAL, 7, (int)System.Drawing.FontStyle.Regular);
                paragrafo.Add(Informacoes);

                doc.Add(paragrafo);

                doc.Close();

                var Tela = new Sucesso("Arquivo salvo em: " + Program._CaminhoReciboVenda + @"\Arquivo.pdf");
                Tela.Show();

                
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gerar PDF: " + e);
                return false;
            }

        }


    }
}
