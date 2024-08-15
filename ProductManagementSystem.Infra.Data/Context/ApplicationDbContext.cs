using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductManagementSystem.Domain.Entities;

namespace ProductManagementSystem.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Variacao> Variacoes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Variacao>()
                .HasKey(v => v.Id);

            modelBuilder.Entity<Produto>()
                .HasMany(p => p.Variacoes)
                .WithOne()
                .HasForeignKey(v => v.ProdutoId);

            modelBuilder.Entity<Variacao>()
                .Property(v => v.ProdutoId)
                .IsRequired();
        }
    }
}
