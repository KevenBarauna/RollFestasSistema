using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Model
{
    class EncomendaModel
    {
        public int Id { get; set; }
        public String TipoServico { get; set; }
        public String DataEntrada { get; set; }
        public String DataEntrega { get; set; }
        public String Tema { get; set; }
        public String Quantidade { get; set; }
        public String Valor { get; set; }
        public String Descricao { get; set; }


    }
}
