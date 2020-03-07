using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using RollFestas.Data;
using RollFestas.Models;
using RollFestas.View.MensagemErro;

namespace RollFestas.Utils
{
    public static class GerarPlanilha
    {
        
        public static bool GerarPlanilhaPonto(string Mes)
        {
            try
            {

                PontoDAO DAO = new PontoDAO();
                string caminho = Program._CaminhoPlanilhaPonto;

                //PADRÂO
                var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("Follha de ponto ");

                var rngTable = ws.Range("B2:G5");


                //TITULO
                ws.Cell("B3").Value = "Folha de ponto do mês " + Mes;//TITULO

                //PRIMEIRAS LINHAS
                ws.Cell("B5").Value = "Data";
                ws.Cell("C5").Value = "Chegada";
                ws.Cell("D5").Value = "Saída almoço";
                ws.Cell("E5").Value = "Volta almoço";
                ws.Cell("F5").Value = "Saída";
                ws.Cell("G5").Value = "Nome";

                //BORDA NOS TITULOS
                rngTable = ws.Range("B5");
                rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                rngTable = ws.Range("C5");
                rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                rngTable = ws.Range("D5");
                rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                rngTable = ws.Range("E5");
                rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                rngTable = ws.Range("F5");
                rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                rngTable = ws.Range("G5");
                rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                //AJUSTAR A NUMERACAO
                var linha = 6;


                //PEGAR PONTO DO BANCO
                List<PontoModel> ListaPonto = new List<PontoModel>();
                ListaPonto = DAO.ListarPorMes(Mes);

                //COLOCAR DATA
                linha = 6;
                foreach (var item in ListaPonto)
                {
                    ws.Cell("B" + linha.ToString()).Value = item.Data.ToString();
                    string borda = "B" + linha;
                    rngTable = ws.Range(borda);
                    rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;//BORDA FINA
                    linha++;
                }


                //COLOCAR HORA1 (CHEGADA)
                linha = 6;
                foreach (var item in ListaPonto)
                {
                    ws.Cell("C" + linha.ToString()).Value = item.Hora1.ToString();
                    string borda = "C" + linha;
                    rngTable = ws.Range(borda);
                    rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;//BORDA FINA
                    linha++;
                }

                //COLOCAR HORA2
                linha = 6;
                foreach (var item in ListaPonto)
                {
                    ws.Cell("D" + linha.ToString()).Value = item.Hora2.ToString();
                    string borda = "D" + linha;
                    rngTable = ws.Range(borda);
                    rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;//BORDA FINA
                    linha++;
                }

                //COLOCAR HORA3
                linha = 6;
                foreach (var item in ListaPonto)
                {
                    ws.Cell("E" + linha.ToString()).Value = item.Hora3.ToString();
                    string borda = "E" + linha;
                    rngTable = ws.Range(borda);
                    rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;//BORDA FINA
                    linha++;
                }

                //COLOCAR HORA4
                linha = 6;
                foreach (var item in ListaPonto)
                {
                    ws.Cell("F" + linha.ToString()).Value = item.Hora4.ToString();
                    string borda = "F" + linha;
                    rngTable = ws.Range(borda);
                    rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;//BORDA FINA
                    linha++;
                }

                //COLOCAR HORA4
                linha = 6;
                foreach (var item in ListaPonto)
                {
                    ws.Cell("G" + linha.ToString()).Value = item.Nome.ToString();
                    string borda = "G" + linha;
                    rngTable = ws.Range(borda);
                    rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;//BORDA FINA
                    linha++;
                }



                //TITULO
                rngTable = ws.Range("B2:G4");//SELECIONAR
                rngTable.Row(2).Merge(); //JUNTAR
                rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;//BORDA fina
                rngTable.Style.Fill.BackgroundColor = XLColor.FromTheme(XLThemeColor.Accent1);//COR FUNDO
                rngTable.Style.Font.FontColor = XLColor.White;//COR FONTE
                rngTable.Style.Font.Bold = true;//FONT BOLD
                rngTable.Style.Font.FontSize = 15;//FONT TAmANHO
                rngTable.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;//ALINHAR CENTRO
                rngTable.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;//ALINHAR CENTRO

                ws.Columns(2, 6).AdjustToContents();//AJUSTAR LARGURA CELULA
                                                    //LINHAS CIMA
                rngTable = ws.Range("B4:G4");
                rngTable.Style.Fill.BackgroundColor = XLColor.FromTheme(XLThemeColor.Accent1);
                rngTable.Style.Font.FontColor = XLColor.White;
                rngTable.Style.Font.Bold = true;
                rngTable.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                //SALVAR PLANILHA
                wb.SaveAs(Program._CaminhoPlanilhaPonto + @"\" + Mes + ".xlsx");

                wb.Dispose();


            }
            catch (Exception e)
            {
                var Tela = new Erro("Erro ao gerar planilha. " + e.Message);
                Tela.Show();
                return false;
            }
            return true;
        }

    }
}
