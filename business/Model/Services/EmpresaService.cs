using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.Context;
using business.Model.Classes;
using business.Model.DTO.Empresa;
using business.Model.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace business.Model.Services
{
    public class EmpresaService : IEmpresaService
    {
        public CabanaContext _context { get; set; }
        public EmpresaService(CabanaContext context){
            _context = context;
        }
        public async Task<Empresa> Cadastrar(NovaEmpresa model)
        {
            var empresa = new Empresa{
                Cnpj = model.Cnpj,
                Nome = model.Nome
            };
            await _context.Empresa.AddAsync(empresa);
            await _context.SaveChangesAsync();
            return empresa;

        }

        public async Task<List<Empresa>> Listar()
        {
            return await _context.Empresa.ToListAsync();
        }
    }
}