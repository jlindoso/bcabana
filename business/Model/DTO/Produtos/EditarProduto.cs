using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace business.Model.DTO.Produtos
{
    public class EditarProduto
    {
        public string? Nome { get; set; } 
        public string? CodigoBarras { get; set; }
        public decimal? Preco { get; set; } = 0;
    }
}