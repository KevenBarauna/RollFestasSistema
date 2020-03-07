using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using RollFestas.Data;
using RollFestas.Models;

namespace RollFestas.Utils
{
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

                String TrocoDaVenda = vendaModel.Troco;
                String PendenciaDaVenda = vendaModel.ValorPendente;


                paragrafo.Add("Troco: " + TrocoDaVenda + "                               ");
                paragrafo.Add("Pendencia: " + PendenciaDaVenda + "                       ");


                paragrafo.Add("         Obrigado pela preferência!!!      ");

                doc.Add(paragrafo);

                doc.Close();

                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro recibo: " + e);
                return false;
            }

        }


    }
}
