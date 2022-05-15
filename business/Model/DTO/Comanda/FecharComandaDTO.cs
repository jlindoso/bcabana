using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace business.Model.DTO.Comanda
{
    public class FecharComandaDTO
    {
        [Required]
        public int ComandaId { get; set; }
        [Required]
        public int UsuarioFechouId { get; set; }
    }
}