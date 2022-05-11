using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace business.Model.Classes
{
    public class Estoque: BaseClass
    {
        public Produto Produto { get; set; } = null!;
        public int Quantidade { get; set; } = 0;
        
    }
}