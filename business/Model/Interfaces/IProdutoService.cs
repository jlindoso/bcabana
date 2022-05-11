using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.Model.Classes;
using business.Model.DTO;
using business.Model.DTO.Produtos;

namespace business.Model.Interfaces
{
    public interface IProdutoService
    {
        public List<Produto> Listar();

        public Produto Adicionar(NovoProduto produto);

        public Produto? AdicionarQuantidade(QuantidadeProduto produto);

        public Produto? RemoverQuantidade(QuantidadeProduto produto);

        public Produto? Editar(int id, EditarProduto model);

    }
}