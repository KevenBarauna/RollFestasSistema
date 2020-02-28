using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Loja.Controler.Utils;
using Loja.Model;

namespace Loja.Controler
{
    class ReciboController
    {

        public void GerarReciboDeVenda()
        {
            try
            {
                string caminho = Caminhos.CaminhoComprovante();

                Document doc = new Document(iTextSharp.text.PageSize.A6, 3, 3, 3, 3);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(@"" + caminho + ".pdf", FileMode.Create));
                doc.Open();


                string dados = "";

                Paragraph paragrafo = new Paragraph(dados, new Font(Font.NORMAL, 9));
                paragrafo.Alignment = 1;//NO


                paragrafo.Alignment = Element.ALIGN_CENTER;

                paragrafo.Font = new Font(Font.NORMAL, 9, (int)System.Drawing.FontStyle.Regular);
                paragrafo.Add("                                               ");

                paragrafo.Font = new Font(Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);
                paragrafo.Add("        Nome do Estabelecimento          ");

                paragrafo.Font = new Font(Font.NORMAL, 9, (int)System.Drawing.FontStyle.Regular);
                paragrafo.Add("                                               ");


                paragrafo.Font = new Font(Font.NORMAL, 9, (int)System.Drawing.FontStyle.Regular);
                paragrafo.Add("                 Endereço, 101 - Bairro          ");

                paragrafo.Font = new Font(Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular);
                paragrafo.Add("                              São Paulo - SP CEP 13.001-000               ");

                paragrafo.Font = new Font(Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular);
                paragrafo.Add("CNPJ: 11.222.333/0001-44     TEL: (71)3321-3333");


                paragrafo.Font = new Font(Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular);
                paragrafo.Add("_________________________________________________________");

                paragrafo.Font = new Font(Font.NORMAL, 9, (int)System.Drawing.FontStyle.Regular);
                paragrafo.Add("                                               ");

                paragrafo.Font = new Font(Font.NORMAL, 16, (int)System.Drawing.FontStyle.Bold);
                paragrafo.Add("          ESSE CUPOM NÃO É VALIDO                        ");

                paragrafo.Font = new Font(Font.NORMAL, 16, (int)System.Drawing.FontStyle.Bold);
                paragrafo.Add("                  FORA DO ESTABELICIMENTO     ");

                paragrafo.Font = new Font(Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular);
                paragrafo.Add("    Data: 01/01/2012                 Código: 1         ");

                paragrafo.Font = new Font(Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular);
                paragrafo.Add("    Valor total: 103,00            Valor pago: 120,00  ");

                paragrafo.Font = new Font(Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular);
                paragrafo.Add("                 Troco: 19,00                 Pendencia: 00,00     ");


                doc.Add(paragrafo);

                doc.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Comprovante aberto, feche!");
            }

        }

        //public void GerarReciboDeVendaPeloId(String id, String caminho)
        //{
        //    //DAO

        //    VendaModel Venda = new VendaModel();


        //    DAOVenda dao = new DAOVenda();
        //    Venda = dao.ExibirDetalhesdaVenda(id);


        //    try
        //    {

        //        Document doc = new Document(iTextSharp.text.PageSize.A6);
        //        PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
        //        doc.Open();


        //        string dados = "";

        //        Paragraph paragrafo = new Paragraph(dados, new Font(Font.NORMAL, 9));
        //        paragrafo.Alignment = 1;//NO


        //        paragrafo.Alignment = Element.ALIGN_CENTER;

        //        paragrafo.Font = new Font(Font.NORMAL, 7, (int)System.Drawing.FontStyle.Regular);
        //        paragrafo.Add("                                                     ");

        //        paragrafo.Font = new Font(Font.NORMAL, 7, (int)System.Drawing.FontStyle.Bold);
        //        paragrafo.Add("                      Roll Festas                    ");
        //        paragrafo.Add("_____________________________________________________");


        //        paragrafo.Font = new Font(Font.NORMAL, 7, (int)System.Drawing.FontStyle.Regular);
        //        paragrafo.Add("                                                     ");


        //        paragrafo.Font = new Font(Font.NORMAL, 7, (int)System.Drawing.FontStyle.Regular);
        //        paragrafo.Add("Endereço: Rua do Paraíso, n° 34, Box 1 Salvador - BA ");


        //        paragrafo.Font = new Font(Font.NORMAL, 7, (int)System.Drawing.FontStyle.Regular);
        //        paragrafo.Add("    CNPJ:  20.600.571/0001-74     TEL: (71) 3321-5411");


        //        paragrafo.Font = new Font(Font.NORMAL, 7, (int)System.Drawing.FontStyle.Regular);
        //        paragrafo.Add("_____________________________________________________");

        //        paragrafo.Font = new Font(Font.NORMAL, 7, (int)System.Drawing.FontStyle.Regular);
        //        paragrafo.Add("                                                     ");

        //        paragrafo.Font = new Font(Font.NORMAL, 7, (int)System.Drawing.FontStyle.Bold);
        //        paragrafo.Add("               ESSE CUPOM NÃO É VALIDO               ");

        //        paragrafo.Font = new Font(Font.NORMAL, 7, (int)System.Drawing.FontStyle.Bold);
        //        paragrafo.Add("                FORA DO ESTABELICIMENTO              ");

        //        paragrafo.Font = new Font(Font.NORMAL, 7, (int)System.Drawing.FontStyle.Regular);
        //        paragrafo.Add("                                                     ");

        //        String DataDaVenda = Venda.Data;
        //        String CodDaVenda = Convert.ToString(Venda.Id);

        //        paragrafo.Font = new Font(Font.NORMAL, 7, (int)System.Drawing.FontStyle.Regular);
        //        paragrafo.Add("                Data: " + DataDaVenda + "     Código: " + CodDaVenda);


        //        String ValorTotalDaVenda = Venda.ValorTotal;
        //        String ValorpagoDaVenda = Venda.ValorPago;

        //        paragrafo.Font = new Font(Font.NORMAL, 7, (int)System.Drawing.FontStyle.Regular);
        //        paragrafo.Add("                 Valor total:" + ValorTotalDaVenda + "          Valor pago: " + ValorpagoDaVenda);
        //        //paragrafo.Add("    Valor total: 103,00            Valor pago: 120,00  ");

        //        String TrocoDaVenda = Venda.Troco;
        //        String PendenciaDaVenda = Venda.ValorPendente;

        //        paragrafo.Font = new Font(Font.NORMAL, 7, (int)System.Drawing.FontStyle.Regular);
        //        paragrafo.Add("                 Troco: " + TrocoDaVenda + "     Pendencia: " + PendenciaDaVenda);


        //        doc.Add(paragrafo);

        //        doc.Close();

        //        MessageBox.Show("Compravante salvo em: " + caminho);

        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Comprovante aberto, feche!");
        //    }

        //}

        public bool GerarReciboDeVendaPeloId(String id, String NomeArquivo)
        {
            var data = Data.DataPararCriarPasta();
            var vendaModel = new VendaModel();
            var daoVenda = new DAOVenda();

            vendaModel = daoVenda.ExibirDetalhesdaVenda(id);


            try
            {

                Document doc = new Document(iTextSharp.text.PageSize.A6);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(NomeArquivo, FileMode.Create));
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

                String TrocoDaVenda = vendaModel.Troco;
                String PendenciaDaVenda = vendaModel.ValorPendente;


                paragrafo.Add("Troco: " + TrocoDaVenda + "                               ");
                paragrafo.Add("Pendencia: " + PendenciaDaVenda + "                       ");


                paragrafo.Add("         Obrigado pela preferência!!!      ");

                doc.Add(paragrafo);

                doc.Close();

                return true;
                //MessageBox.Show("Compravante salvo em: " + caminho);

            }
            catch (Exception)
            {
                return false;
                //MessageBox.Show("Comprovante aberto, feche!");
            }

        }
    }
}

