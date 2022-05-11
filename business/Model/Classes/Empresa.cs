using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace business.Model.Classes
{
    public class Empresa: BaseClass
    {
        public string Nome { get; set; } = null!;
        public string? Cnpj { get; set; }
    }
}