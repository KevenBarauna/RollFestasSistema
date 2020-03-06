using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollFestas.Models
{
    class CaixaModel
    {
        public int Id { get; set; }
        public string ValorTotal { get; set; }
        public string Data { get; set; }
        public string Retirada { get; set; }
        public string Deposito { get; set; }
        public string Dinheiro { get; set; }
        public string Cartao { get; set; }
        public string Outros { get; set; }
        public string Devolucao { get; set; }


    }
}
