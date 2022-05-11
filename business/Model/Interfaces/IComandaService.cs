using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.Model.Classes;
using business.Model.DTO.Comanda;

namespace business.Model.Interfaces
{
    public interface IComandaService
    {
        public Task<Comanda> AbrirComanda(NovaComandaDTO model);
        public Task<Comanda> FecharComanda(FecharComandaDTO model);
    }
}