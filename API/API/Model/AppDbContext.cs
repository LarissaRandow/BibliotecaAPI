using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Data;

namespace API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Bibliotecario> Bibliotecarios { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Reserva> Reserva { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Livro>().Property(x => x.Id)

            modelBuilder.Entity<Reserva>().Property(p => p.Cpf).HasMaxLength(11);
            //modelBuilder.Entity<Produto>().Property(p => p.Preco).HasPrecision(10, 2);


            //modelBuilder.Entity<Produto>()
            //    .HasData(
            //        new Produto { Id = 1, Nome = "Caderno", Preco = 7.95M, Estoque = 10 },
            //        new Produto { Id = 2, Nome = "Borracha", Preco = 2.45M, Estoque = 30 },
            //        new Produto { Id = 3, Nome = "Estojo", Preco = 6.25M, Estoque = 15 });
        }

    }
}
