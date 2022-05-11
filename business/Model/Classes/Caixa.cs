using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace business.Model.Classes
{
    public class Caixa: BaseClass
    {
        public string Nome { get; set; } = null!;

        public DateTime DataAbertura { get; set; } = DateTime.UtcNow;

        public DateTime? DataFechamento { get; set; } = null;

        public decimal Total { get; set; } = 0;

        public decimal? TotalRecebido { get; set; } = null;
        public Usuario Usuario { get; set; } = null!;

        public Empresa Empresa { get; set; } = null!;

    }
}