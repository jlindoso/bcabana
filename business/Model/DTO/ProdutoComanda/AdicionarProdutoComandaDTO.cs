using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace business.Model.DTO.ProdutoComanda
{
    public class AdicionarProdutoComandaDTO
    {
        public int ProdutoId { get; set; }
        public int ComandaId { get; set; } 
        public int Quantidade { get; set; } = 1;
        public int GarcomId { get; set; } 
        public int? AtendenteId { get; set; } = null;
    }
}