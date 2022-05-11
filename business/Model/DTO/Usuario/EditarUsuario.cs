using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace business.Model.DTO.Usuario
{
    public class EditarUsuario
    {
        public string? Nome { get; set; } = null;
        public string? Email { get; set; } = null;
        public string? Password { get; set; } = null;
    }
}