using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.Context;
using business.Model.Classes;
using business.Model.DTO.Caixa;
using business.Model.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace business.Model.Services
{
    public class CaixaService : ICaixaService
    {
        public CabanaContext _context { get; set; }
        public UserManager<Usuario> _userManager { get; set; }
        public CaixaService(CabanaContext context, UserManager<Usuario> userManager){
            _context = context;
            _userManager = userManager;
        }
        public async Task<Caixa> AbrirCaixaAsync(AbrirCaixaDTO model)
        {
            var empresa = _context.Empresa.Find(model.EmpresaId);
            var user = await _userManager.FindByIdAsync(model.UsuarioId.ToString()); 
            if(empresa==null) 
                throw new Exception("Empresa Inválida");
            if(user==null) 
                throw new Exception("Usuário Inválido");

            DateTime dataAbertura = DateTime.UtcNow; 
            Caixa caixa = new Caixa{
                DataAbertura = dataAbertura,
                DataFechamento = null,
                Nome = string.Format("{0}{1}{2}", dataAbertura.Year, dataAbertura.Month, dataAbertura.Day ),
                Usuario = user,
                Empresa = empresa,
                TotalRecebido = null
            };
            await _context.Caixa.AddAsync(caixa);
            await _context.SaveChangesAsync();
            return caixa;
        }

        public async Task<Caixa> FecharCaixaAsync(FecharCaixaDTO model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId.ToString()); 
            var caixa = await _context.Caixa.FindAsync(model.CaixaId);
            if(caixa==null) 
                throw new Exception("Caixa Inválido");
            if(user==null) 
                throw new Exception("Usuário Inválido");
            caixa.DataFechamento = DateTime.UtcNow;
            caixa.Usuario = user;    
            caixa.Total = BuscarTotalFechamentoCaixa(caixa.Id);
            caixa.TotalRecebido = model.TotalRecebido;
            _context.Caixa.Update(caixa);
            await _context.SaveChangesAsync();
            return caixa;
        }


        public async Task<List<Caixa>> ListarAbertosAsync()
        {
            return await _context.Caixa.Where(p=>p.DataFechamento==null).ToListAsync();
        }

        public Caixa VisualizarCaixa(int id)
        {
            throw new NotImplementedException();
        }
        private decimal BuscarTotalFechamentoCaixa(int id)
        {
            return 0;
        }
    }
}