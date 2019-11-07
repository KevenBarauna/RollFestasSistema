using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Model
{
    class VendaModel
    {
        public int Id { get; set; }
        public String Data { get; set; }
        public String Usuario { get; set; }
        public String ValorTotal { get; set; }
        public String ValorPago { get; set; }
        public String Troco { get; set; }
        public String TipoPagamento { get; set; }
        public String StatusPagamento { get; set; }
        public String ValorPendente { get; set; }
        public Decimal ValorParaCalcuar { get; set; }
    }
}
