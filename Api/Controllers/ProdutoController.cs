using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using business.Model.Interfaces;
using business.Model.Classes;
using business.Model.DTO.Produtos;

namespace Api.Controllers
{
    [Route("v1/[controller]/[action]")]
    public class ProdutoController : Controller
    {
         public IProdutoService _service { get; set; }

        public ProdutoController(IProdutoService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            return Ok(_service.Listar());
        }


        [HttpPost]
        public ActionResult<Produto> Post([FromBody] NovoProduto produto)
        {
            return Ok(_service.Adicionar(produto));
        }

        [HttpPut]
        public ActionResult<Produto> Put(int id, [FromBody] EditarProduto produto)
        {
            return Ok(_service.Editar(id, produto));
        }

    }
}