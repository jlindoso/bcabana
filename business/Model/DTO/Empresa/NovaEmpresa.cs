using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace business.Model.DTO.Empresa
{
    public class NovaEmpresa
    {
        [Required]
        public string Nome { get; set; } = null!;
        public string? Cnpj { get; set; }
    }
}