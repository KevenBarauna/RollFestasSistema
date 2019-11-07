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
        public String Nome { get; set; }
        public String Tema { get; set; }
        public String Preco { get; set; }
        public String Quantidade { get; set; }
        public String Fornecedor { get; set; }
        public String Data { get; set; }
        public String Descricao { get; set; }
    }
}
