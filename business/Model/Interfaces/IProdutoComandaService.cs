using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.Model.Classes;
using business.Model.DTO.ProdutoComanda;

namespace business.Model.Interfaces
{
    public interface IProdutoComandaService
    {
        public Task<ProdutoComanda> AdicionarProduto(AdicionarProdutoComandaDTO model); 
    }
}