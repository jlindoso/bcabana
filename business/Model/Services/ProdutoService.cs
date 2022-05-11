using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.Model.Interfaces;
using business.Context;
using business.Model.Classes;
using business.Model.DTO;
using business.Model.DTO.Produtos;

namespace business.Model.Services
{
    public class ProdutoService: IProdutoService
    {
        public CabanaContext _context { get; set; }
        public ProdutoService(CabanaContext context){
            _context = context;
        }
        public List<Produto> Listar(){
            return _context.Produto.ToList().OrderBy(p=>p.Name).ToList();
        }
        public Produto Adicionar(NovoProduto model){
            var produto = new Produto{
                CodigoBarras = model.CodigoBarras,
                Name = model.Nome,
                Preco = model.Preco
            };
            _context.Produto.Add(produto);
            _context.SaveChanges();
            return produto;
        }

        public Produto? Editar(int id, EditarProduto model){
            Produto? produto = _context.Produto.Where(p=>p.Id==id).FirstOrDefault();
            if(produto!=null){
                
                produto.CodigoBarras = model.CodigoBarras !=null? model.CodigoBarras: produto.CodigoBarras;
                produto.Name = model.Nome!=null&& string.Empty!=model.Nome ? model.Nome: produto.Name;
                produto.Preco = model.Preco!=null ? (decimal) model.Preco: produto.Preco;
            
                _context.Produto.Update(produto);
                _context.SaveChanges();
            }
            return produto;
        }


        public Produto? AdicionarQuantidade(QuantidadeProduto model){
            var produto = _context.Produto.Where(p=>p.Id==model.Id).FirstOrDefault();
            if(produto!=null) {
                produto.Quantidade += model.Quantidade; 
                _context.SaveChanges();
            }
            return produto;
            
        }

        public Produto? RemoverQuantidade(QuantidadeProduto model){
            var produto = _context.Produto.Where(p=>p.Id==model.Id).FirstOrDefault();
            if(produto!=null) {
                produto.Quantidade -= model.Quantidade; 
                _context.SaveChanges();
            }
            return produto;
        }
        
    }
}