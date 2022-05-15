using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace business.Model.Classes
{
    public class UsuarioPerfil: BaseClass
    {
        public Usuario Usuario { get; set; } = null!;
        public Perfil Perfil { get; set; } = null!;
    }
}