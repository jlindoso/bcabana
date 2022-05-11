using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace business.Model.DTO.Produtos
{
    public class NovoProduto
    {
        [Required]
        public string Nome { get; set; } = null!;
        [Required]
        public string CodigoBarras { get; set; } = null!;
        public decimal Preco { get; set; } = 0;
    }
}