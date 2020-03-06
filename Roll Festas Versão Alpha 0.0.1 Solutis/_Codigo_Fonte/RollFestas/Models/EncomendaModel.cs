using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollFestas.Models
{
    class EncomendaModel
    {
        public int Id { get; set; }
        public string TipoServico { get; set; }
        public string DataEntrada { get; set; }
        public string DataEntrega { get; set; }
        public int Entregue { get; set; }
        public string Tema { get; set; }
        public string Quantidade { get; set; }
        public string Valor { get; set; }
        public string Descricao { get; set; }
        public string NomeCliente { get; set; }
    }
}
