using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.Model.Classes;
using business.Model.DTO.Comanda;
using business.Model.Interfaces;

namespace business.Model.Services
{
    public class ComandaService : IComandaService
    {
        public Task<Comanda> AbrirComanda(NovaComandaDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<Comanda> FecharComanda(FecharComandaDTO model)
        {
            throw new NotImplementedException();
        }
    }
}