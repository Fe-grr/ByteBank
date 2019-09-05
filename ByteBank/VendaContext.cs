using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace ByteBank
{

        public class VendasContext: DbContext
        {
            public DbSet<Cliente> CLIENTES1 { get; set; }

                protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=SIMP30006;Initial Catalog=VENDAS_SUCOS;Integrated Security=True");
            }
                    protected override void OnModelCreating(ModelBuilder modelBuilder)
                    {
                            modelBuilder.Entity<Cliente>()
                            .HasKey(c => new {c.nome,c.cpf });
                            
                    }


    }

}
    /*class MyContext : DbContext
    {
        public DbSet<Cliente> CLIENTES { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.matricula);
        }

    }*/