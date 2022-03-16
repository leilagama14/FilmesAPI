using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmesAPI.Models.EnderecoModel;
using FilmesAPI.Models.CinemaModel;
using FilmesAPI.Models.GerenteModel;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Data{

    public class FilmeContext : DbContext{

        public FilmeContext(DbContextOptions<FilmeContext> opt) : base (opt)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           /*UseLazyLoadingProxies para carregar propriedades diretamente das entidades.
            Com isso, será possível carregarmos as propriedades em tempo de execução.*/
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //relacionamento 1:1. Um Cinema possui um Endereco.
            builder.Entity<Endereco>()
                .HasOne(endereco => endereco.Cinema)
                .WithOne(cinema => cinema.Endereco)
                .HasForeignKey<Cinema>(cinema => cinema.EnderecoId);

            //relacionamento 1:n. Um Gerente possui um, nenhum ou muitos Cinemas.
            builder.Entity<Cinema>()
                .HasOne(cinema => cinema.Gerente)
                .WithMany(gerente => gerente.Cinemas)
                .HasForeignKey(cinema => cinema.GerenteId);

        }
              
        //public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
    }
    
}