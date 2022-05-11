using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace business.Model.Classes
{
    public class ComandaPagamento: BaseClass
    {
        public Comanda Comanda { get; set; } = null!;
        public TipoPagamento TipoPagamento { get; set; }= null!;
        public decimal Valor { get; set; }
    }
}