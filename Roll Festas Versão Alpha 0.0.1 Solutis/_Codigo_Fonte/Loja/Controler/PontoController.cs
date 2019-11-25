using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.Model;
using ClosedXML.Excel;
using Loja.Model.DAO;

namespace Loja.Controler
{
    class PontoController
    {
        public void BaterPonto(String nome)
        {
            //PEGA HORA E DATA ATUAL
            Controller tempo = new Controller();
            string data = tempo.PegarDiaMesAnoAtual();
            string hora = tempo.PegarHoraMinutoAtual();

            //VERIFICA SE JÁ BATEU PONTO HOJE
            int ordem = 0;
            int v1,v2,v3,v4;

            DAOPonto dao = new DAOPonto();

            v1 = dao.VerificaH1(nome, data);
            v2 = dao.VerificaH2(nome, data);
            v3 = dao.VerificaH3(nome, data);
            v4 = dao.VerificaH4(nome, data);

            if (v1 != 0)
            {
                ordem = v1;
            }
            else if (v2 != 0)
            {
                ordem = v2;
            }
            else if (v3 != 0)
            {
                ordem = v3;
            }
            else if (v4 != 0)
            {
                ordem = v4;
            }

            switch (ordem)
            {
                case 1:
                    dao.SalvarHoraNoBancoH1(nome, hora, data);
                    break;

                case 2:
                    dao.SalvarHoraNoBancoH2(nome, hora, data);
                    break;

                case 3:
                    dao.SalvarHoraNoBancoH3(nome, hora, data);
                    break;

                case 4:
                    dao.SalvarHoraNoBancoH4(nome, hora, data);
                    break;

                default:
                    MessageBox.Show("Todas as horas de hoje já foram preenchidas");
                    break;
            }

        }

        public List<PontoModel> ListarPorData(String data)
        {
            //Controller tempo = new Controller();
            //String data = tempo.PegarDiaMesAnoAtual();

            DAOPonto dao = new DAOPonto();
            List<PontoModel> p = new List<PontoModel>();

            p = dao.ListarPordata(data);

            return p;
        }

        public List<PontoModel> ListarPorMes(String mes)
        {

            DAOPonto dao = new DAOPonto();
            List<PontoModel> p = new List<PontoModel>();

            p = dao.ListarPorMes(mes);

            return p;
        }

        public List<PontoModel> ListarPorAno(String ano)
        {

            DAOPonto dao = new DAOPonto();
            List<PontoModel> p = new List<PontoModel>();

            p = dao.ListarPorAno(ano);

            return p;
        }

        public void GerarPDFPonto(String mes)
        {

            DAOCaminho daoCaminho = new DAOCaminho();
            string caminho = daoCaminho.CaminhoPonto();

            //PADRÂO
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Follha de ponto ");

            var rngTable = ws.Range("B2:G5");


            //TITULO
            ws.Cell("B3").Value = "Folha de ponto do mês " + mes;//TITULO

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
            DAOPonto dao = new DAOPonto();
            List<PontoModel> ListaPonto = new List<PontoModel>();
            ListaPonto = dao.ListarPorMes(mes);

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
            wb.SaveAs(@"" + caminho + @"\PontoPlanilha" + mes +".xlsx");

            wb.Dispose();


        }

        public void GerarPDFPontoo(String mes)
        {

            DAOCaminho daoCaminho = new DAOCaminho();
            string caminho = daoCaminho.CaminhoPonto();

            //PADRÂO
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Follha de ponto ");


            //TITULO
            ws.Cell("B2").Value = "Folha de ponto do mês " + mes;//TITULO

            //PRIMEIRAS LINHAS
            ws.Cell("B4").Value = "Data";
            ws.Cell("C4").Value = "Chegada";
            ws.Cell("D4").Value = "Saída almoço";
            ws.Cell("E4").Value = "Volta almoço";
            ws.Cell("F4").Value = "Saída";
            ws.Cell("G4").Value = "Nome";

            //AJUSTAR A NUMERACAO
            var linha = 5;


            //PEGAR PONTO DO BANCO
            DAOPonto dao = new DAOPonto();
            List<PontoModel> ListaPonto = new List<PontoModel>();
            ListaPonto = dao.ListarPorMes(mes);

            //COLOCAR DATA
            linha = 5;
            foreach (var item in ListaPonto)
            {

                ws.Cell("B" + linha.ToString()).Value = item.Data.ToString();
                linha++;
            }


            //COLOCAR HORA1 (CHEGADA)
            linha = 5;
            foreach (var item in ListaPonto)
            {

                ws.Cell("C" + linha.ToString()).Value = item.Hora1.ToString();
                linha++;
            }

            //COLOCAR HORA2
            linha = 5;
            foreach (var item in ListaPonto)
            {

                ws.Cell("D" + linha.ToString()).Value = item.Hora2.ToString();
                linha++;
            }

            //COLOCAR HORA3
            linha = 5;
            foreach (var item in ListaPonto)
            {

                ws.Cell("E" + linha.ToString()).Value = item.Hora3.ToString();
                linha++;
            }

            //COLOCAR HORA4
            linha = 5;
            foreach (var item in ListaPonto)
            {

                ws.Cell("F" + linha.ToString()).Value = item.Hora4.ToString();
                linha++;
            }

            //COLOCAR HORA4
            linha = 5;
            foreach (var item in ListaPonto)
            {

                ws.Cell("G" + linha.ToString()).Value = item.Nome.ToString();
                linha++;
            }

            var rngTable = ws.Range("B2:G35");

            int LinhaParaBorda = 4;
            //TUDO COM BORDA
            for (int i = 1; i <= 61; i++)
            {
                rngTable = ws.Range("B" + LinhaParaBorda.ToString());
                rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;//BORDA fina
                LinhaParaBorda = LinhaParaBorda + 1;
            }
            LinhaParaBorda = 4;
            //TUDO COM BORDA
            for (int i = 1; i <= 61; i++)
            {
                rngTable = ws.Range("C" + LinhaParaBorda.ToString());
                rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;//BORDA fina
                LinhaParaBorda = LinhaParaBorda + 1;
            }
            LinhaParaBorda = 4;
            //TUDO COM BORDA
            for (int i = 1; i <= 61; i++)
            {
                rngTable = ws.Range("D" + LinhaParaBorda.ToString());
                rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;//BORDA fina
                LinhaParaBorda = LinhaParaBorda + 1;
            }
            LinhaParaBorda = 4;
            //TUDO COM BORDA
            for (int i = 1; i <= 61; i++)
            {
                rngTable = ws.Range("E" + LinhaParaBorda.ToString());
                rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;//BORDA fina
                LinhaParaBorda = LinhaParaBorda + 1;
            }
            LinhaParaBorda = 4;
            //TUDO COM BORDA
            for (int i = 1; i <= 61; i++)
            {
                rngTable = ws.Range("F" + LinhaParaBorda.ToString());
                rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;//BORDA fina
                LinhaParaBorda = LinhaParaBorda + 1;
            }
            LinhaParaBorda = 4;
            //TUDO COM BORDA
            for (int i = 1; i <= 61; i++)
            {
                rngTable = ws.Range("G" + LinhaParaBorda.ToString());
                rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;//BORDA fina
                LinhaParaBorda = LinhaParaBorda + 1;
            }

            //TITULO
            rngTable = ws.Range("B2:G3");//SELECIONAR
            rngTable.Row(1).Merge(); //JUNTAR
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
            rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            rngTable.Style.Fill.BackgroundColor = XLColor.FromTheme(XLThemeColor.Accent1);
            rngTable.Style.Font.FontColor = XLColor.White;
            rngTable.Style.Font.Bold = true;
            rngTable.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            ////TAMANHO DA PLANILHA
            //rngTable = ws.Range("B2:G35");
            //rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Medium;

            
            //SALVAR PLANILHA
            //wb.SaveAs(@"C:\Users\keven.barauna\Desktop\Roll Festas Versão Alpha Solutis\Ponto\PontoPlanilhaDePonto" + mes + ".xlsx");
            wb.SaveAs(@"" + caminho + @"\PontoPlanilha.xlsx");

            wb.Dispose();

        }

        public bool VerificaSeUsuarioExiste(String nome)
        {
            bool usuario = false;
            DAOUsuario dao = new DAOUsuario();
            usuario = dao.ValidaNomeUsuario(nome);
            return usuario;

        }


    }
}
