using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace business.Model.Classes
{
    public class Usuario: BaseClass
    {
        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
        
        [JsonIgnore]
        public string Senha { get; set; } = null!;
    }
}