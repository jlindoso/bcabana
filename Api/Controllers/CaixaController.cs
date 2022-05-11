using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using business.Model.Classes;
using business.Model.DTO.Caixa;
using business.Model.Interfaces;

namespace Api.Controllers
{
    [Route("v1/[controller]/[action]")]
    public class CaixaController : Controller
    {
        private ICaixaService _service { get; set; }

        public CaixaController(ICaixaService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<List<Caixa>>> ListarAbertos()
        {
            return Ok(await _service.ListarAbertosAsync());
        }
        [HttpPost]
        public async Task<ActionResult<Caixa>> AbrirCaixa([FromBody] AbrirCaixaDTO model)
        {
            return Ok(await _service.AbrirCaixaAsync(model));
        }

        [HttpPost]
        public async Task<ActionResult<Caixa>> FecharCaixa([FromBody] FecharCaixaDTO model)
        {
            return Ok(await _service.FecharCaixaAsync(model));
        }
    }
}