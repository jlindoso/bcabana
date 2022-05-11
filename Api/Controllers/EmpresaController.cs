using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using business.Model.Interfaces;
using business.Model.DTO.Empresa;
using business.Model.Classes;

namespace Api.Controllers
{
    [Route("v1/[controller]/[action]")]
    public class EmpresaController : Controller
    {
         public IEmpresaService _service { get; set; }

        public EmpresaController(IEmpresaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empresa>>> Get()
        {
            return Ok(await _service.Listar());
        }


        [HttpPost]
        public async Task<ActionResult<Empresa>> Post([FromBody] NovaEmpresa model)
        {
            return Ok(await _service.Cadastrar(model));
        }
    }
}