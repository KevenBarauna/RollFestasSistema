using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollFestas.Models
{
    class VendaModel
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string Usuario { get; set; }
        public string ValorTotal { get; set; }
        public string ValorPago { get; set; }
        public string TipoPagamento { get; set; }
        public string StatusPagamento { get; set; }
        public string ValorPendente { get; set; }
        public string NomeCliente { get; set; }

    }
}
