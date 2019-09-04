using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projeto02_ApiChamados.Models
{
    public class ChamadosContext : DbContext
    {

        // ESTABELECEMOS A CONEXÃO COM O BANCO, ENVIANDO A STRING DE 
        //CONEXAO PARA A SUPER CLASSE
        public ChamadosContext() : base("name=ChamadosConnection")
        {

        }
        //DEFINIMOS A COLEÇÃO {DbSet}

        public DbSet<Chamado> Chamados { get; set; }

        protected override  void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //definindo o nome da tabela a ser gerada
            modelBuilder.Entity<Chamado>().ToTable("TBChamados");

            //definindo parametros dos campos
            modelBuilder.Entity<Chamado>()
                .Property(p => p.Data)
                .IsRequired();

            modelBuilder.Entity<Chamado>()
                .Property(p => p.Documento)
                .HasMaxLength(14)
                .IsRequired();

            modelBuilder.Entity<Chamado>()
               .Property(p => p.Assunto)
               .HasMaxLength(20)
               .IsRequired();

            modelBuilder.Entity<Chamado>()
              .Property(p => p.Descricao)
              .HasMaxLength(100)
              .IsRequired();
            
            modelBuilder.Entity<Chamado>()
              .Property(p => p.Resolvido)
              .IsRequired();
        }


    }
}