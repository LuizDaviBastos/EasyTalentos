using EasyTalentos.Dominio.Entity;
using EasyTalentos.Repositorio.Configs;
using EasyTalentos.Repositorio.lib;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace EasyTalentos.Repositorio.DataBase
{
    public class EasyContext : DbContext
    {
        public EasyContext(DbContextOptions options) : base(options) { }

        public DbSet<Candidato> Candidatos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new CandidatoConfiguration());

            List<Disponibilidade> disponibilidades;
            List<Preferencia> preferencias;
            List<Conhecimento> conhecimentos;
            List<Candidato> candidatos;

            Random rnd = new Random();

            candidatos = Generate.GenerateCandidatos(10, rnd, out conhecimentos,
                out disponibilidades, out preferencias);


            modelBuilder.Entity<Candidato>().HasData(candidatos);

            modelBuilder.Entity<Disponibilidade>().HasData(disponibilidades);
            modelBuilder.Entity<Preferencia>().HasData(preferencias);
            modelBuilder.Entity<Conhecimento>().HasData(conhecimentos);


            base.OnModelCreating(modelBuilder);
        }
    }
}
