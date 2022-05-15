using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using business.Model.Classes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace business.Context
{
    public class CabanaContext : DbContext
    {
       public CabanaContext(DbContextOptions<CabanaContext> options)
        : base(options)
        {
        }
        public DbSet<Produto> Produto { get; set; } = null!;
        public DbSet<Estoque> Estoque { get; set; } = null!;
        public DbSet<Caixa> Caixa { get; set; } = null!;
        public DbSet<Empresa> Empresa { get; set; } = null!;
        public DbSet<Comanda> Comanda { get; set; } = null!;
        public DbSet<Usuario> Usuario { get; set; } = null!;
        public DbSet<Perfil> Perfil { get; set; } = null!;
        public DbSet<UsuarioPerfil> UsuarioPerfil { get; set; } = null!;
        public DbSet<ProdutoComanda> ProdutoComanda { get; set; } = null!;
        public DbSet<TipoPagamento> TipoPagamento { get; set; } = null!;
        public DbSet<ComandaPagamento> ComandaPagamento { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"User ID =timvyrhkevxieb;Password=d5695b961299c5dc365e2e2f50e0ba67ad317f649163407a9163e19b01dfa703;Server=ec2-3-224-164-189.compute-1.amazonaws.com;Port=5432;Database=d12gvl6so6hahr;Integrated Security=true;Pooling=true;", b => b.MigrationsAssembly("Api"));
        }
    
    }
}