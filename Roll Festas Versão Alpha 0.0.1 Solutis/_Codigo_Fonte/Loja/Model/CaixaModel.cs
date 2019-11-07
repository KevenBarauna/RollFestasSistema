using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Model
{
    class CaixaModel
    {
        public String Id { get; set; }
        public String Valor { get; set; }
        public String Retirada { get; set; }
        public String Deposito { get; set; }
        public String Data { get; set; }
        public Decimal  ValorTotal { get; set; }
        public Decimal ValorDinheiro { get; set; }
        public Decimal ValorCredito { get; set; }
        public Decimal ValorDebito { get; set; }
    }
    
}
