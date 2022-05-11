using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.Model.Classes;
using business.Model.DTO.Empresa;

namespace business.Model.Interfaces
{
    public interface IEmpresaService
    {
        public Task<List<Empresa>> Listar();
        public Task<Empresa> Cadastrar(NovaEmpresa model);
    }
}