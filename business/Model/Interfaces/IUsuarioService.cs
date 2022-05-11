using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.Model.Classes;
using business.Model.DTO;
using business.Model.DTO.Usuario;

namespace business.Model.Interfaces
{
    public interface IUsuarioService
    {
        public Task<Usuario> CadastrarAsync(NovoUsuario model);

        public void Desabilitar(int id);

        public Usuario Editar(int id, EditarUsuario model);
    }
}