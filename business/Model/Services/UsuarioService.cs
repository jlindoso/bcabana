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
        public CabanaContext _context { get; set; }
        public UsuarioService(CabanaContext context){
            _context = context;

        }
        public async Task<Usuario> CadastrarAsync(NovoUsuario model)
        {
            Usuario user = new Usuario{
                Email = model.Email,
                Nome = model.Nome,
                Senha = model.Password
            };
            var result =  await _context.Usuario.AddAsync(user);
            await _context.SaveChangesAsync();
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