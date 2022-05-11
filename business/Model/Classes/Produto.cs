using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace business.Model.Classes
{
    public class Produto: BaseClass
    {
        public string? Name { get; set; }             
        public string? CodigoBarras { get; set; }
        public string? Imagem { get; set; }
        public int Quantidade { get; set; }=0;
        public decimal Preco { get; set; } = 0;
    }
}