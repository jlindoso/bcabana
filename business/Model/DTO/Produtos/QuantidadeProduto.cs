using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace business.Model.DTO.Produtos
{
    public class QuantidadeProduto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Quantidade { get; set; }             
    }
}