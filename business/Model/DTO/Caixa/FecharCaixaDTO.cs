using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace business.Model.DTO.Caixa
{
    public class FecharCaixaDTO
    {
        public int CaixaId { get; set; }
        public int UserId { get; set; }
        public decimal TotalRecebido{ get; set; }
    }
}