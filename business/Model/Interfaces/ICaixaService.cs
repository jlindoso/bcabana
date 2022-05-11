using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.Model.Classes;
using business.Model.DTO.Caixa;

namespace business.Model.Interfaces
{
    public interface ICaixaService
    {
        public Task<List<Caixa>> ListarAbertosAsync();

        public Task<Caixa> AbrirCaixaAsync(AbrirCaixaDTO produto);

        public Task<Caixa> FecharCaixaAsync(FecharCaixaDTO produto);

        public Caixa VisualizarCaixa(int id);
    }
}