using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Model
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tema { get; set; }
        public string Preco { get; set; }
        public string Quantidade_Estoque { get; set; }
        public string Quantidade_Venda { get; set; }
        public string Fornecedor { get; set; }
        public string Data { get; set; }
        public string Descricao { get; set; }
    }
}
