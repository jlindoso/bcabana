using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace business.Model.Classes
{
    public class Comanda: BaseClass
    {
        public Caixa Caixa { get; set; } = null!;
        public int NumeroComanda { get; set; }
        public DateTime? DataFechamento { get; set; } = null;
        public string? Mesa { get; set; }
        public decimal Total { get; set; } = 0;
        public Usuario UsuarioAbriu { get; set; } = null!;
        public Usuario? UsuarioFechou { get; set; } = null;
        
    }
}