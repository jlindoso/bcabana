using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace business.Model.DTO.Comanda
{
    public class NovaComandaDTO
    {
        [Required]
        public int CaixaId { get; set; }
        [Required]
        public int NumeroComanda { get; set; }
        public string? Mesa { get; set; }
        public int UsuarioAbriuId { get; set; }
    }
}