using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollFestas.Models
{
    class EventoModel
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }
        public string NomeCliente { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public string ValorTotal { get; set; }
        public string ValorPago { get; set; }
        public int Entregue { get; set; }
    }
}
