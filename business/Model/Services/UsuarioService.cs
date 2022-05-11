using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.Context;
using business.Model.Classes;
using business.Model.DTO.Usuario;
using business.Model.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace business.Model.Services
{
    public class UsuarioService : IUsuarioService
    {
        public UserManager<Usuario> _context { get; set; }
        public UsuarioService(UserManager<Usuario> context){
            _context = context;

        }
        public async Task<Usuario> CadastrarAsync(NovoUsuario model)
        {
            Usuario user = new Usuario{
                Email = model.Email,
                UserName = model.Nome
            };
            var result =  await _context.CreateAsync(user, model.Password);
            return user;
        }

        public void Desabilitar(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario Editar(int id, EditarUsuario model)
        {
            throw new NotImplementedException();
        }

    }
}