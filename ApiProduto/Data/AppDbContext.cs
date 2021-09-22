using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProduto.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasData(

                new Produto { Id = 1, Nome = "Lapis", Valor = 7.95M, Estoque = 10 },
                new Produto { Id = 2, Nome = "Caneta", Valor = 2.45M, Estoque = 10 },
                new Produto { Id = 3, Nome = "Borracha", Valor = 6.25M, Estoque = 10 }
                );
        }



    }
}
