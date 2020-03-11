using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RollFestas.Models;

namespace RollFestas
{
    static class Program
    {

        public static UsuarioModel _Usuario { get; set; }
        public static List<ProdutoModel> _Produtos { get; set; }
        public static EncomendaModel _Encomenda{ get; set; }
        public static string _CaminhoReciboVenda { get; set; }
        public static string _CaminhoPlanilhaPonto { get; set; }
        public static string _CaminhoCache { get; set; }
        public static string _CaminhoCacheErro { get; set; }
        public static string _CaminhoTabelaPonto { get; set; }
        public static string _CaminhoArquivoDuvida { get; set; }

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
