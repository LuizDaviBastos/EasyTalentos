using EasyTalentos.Dominio.Entity;
using EasyTalentos.Repositorio.lib;
using System;
using System.Collections.Generic;

namespace EasyTalentos.Testes.DadosMock
{
    public class CandidatoDados
    {

        public static IList<Candidato> GetCandidatos(int qnt)
        {
            List<Candidato> candidatos = new List<Candidato>();

            Random rnd = new Random();

            for (int i = 0; i < qnt; i++)
            {
                candidatos.Add(new Candidato()
                {
                    Id = i,
                    Nome = Generate.GenerateName(8, rnd),
                    Email = $"{Generate.GenerateName(5, rnd)}@hotmail.com",
                    Cidade = Generate.GenerateCity(rnd),
                    Estado = Generate.GenerateState(rnd),
                    Portfolio = @"http://portfolio.com",
                    Linkedin = @"http://linkedin.com",
                    PretencaoSalario = new Random().Next(1000, 5000),
                    Telefone = Generate.GeneratePhone(rnd)
                });
            }
            return candidatos;
        }

        public CandidatoDados()
        {

        }
    }
}
