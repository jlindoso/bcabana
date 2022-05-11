using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using business.Model.Services;
using business.Model.Interfaces;
using business.Model.Classes;
using business.Model.DTO.Usuario;

namespace Api.Controllers
{
    [Route("v1/[controller]/[action]")]
    public class UsuarioController : Controller
    {
        public  IUsuarioService _service {get; set;}

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }


        [HttpPost]
        public async  Task<ActionResult<Usuario>> Post([FromBody] NovoUsuario produto)
        {
            return Ok(await _service.CadastrarAsync(produto));
        }
       
    }
}