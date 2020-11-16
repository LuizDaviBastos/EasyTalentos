using EasyTalentos.Dominio.Entity;
using System;
using System.Collections.Generic;

namespace EasyTalentos.Repositorio.lib
{
    public class Generate
    {
        private static string[,] _states = new string[,]
            {
                { "AC", "Acre" },
                { "AL", "Alagoas" },
                { "AP", "Amapá" },
                { "AM", "Amazonas" },
                { "BA", "Bahia" },
                { "CE", "Ceará" },
                { "DF", "Distrito Federal" },
                { "ES", "Espírito Santo" },
                { "GO", "Goiás" },
                { "MA", "Maranhão" },
                { "MT", "Mato Grosso" },
                { "MS", "Mato Grosso do Sul" },
                { "MG", "Minas Gerais" },
                { "PA", "Pará" },
                { "PB", "Paraíba" },
                { "PR", "Paraná" },
                { "PE", "Pernambuco" },
                { "PI", "Piauí" },
                { "RJ", "Rio de Janeiro" },
                { "RN", "Rio Grande do Norte" },
                { "RS", "Rio Grande do Sul" },
                { "RO", "Rondônia" },
                { "RR", "Roraima" },
                { "SC", "Santa Catarina" },
                { "SP", "São Paulo" },
                { "SE", "Sergipe" },
                { "TO", "Tocantins" }
            };

        public static string GenerateName(int len, Random r)
        {

            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2;
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;
        }

        public static string GenerateEmail(Random r)
        {
            var list = new string[] { "hotmail", "outlook", "gmail" };

            return $"{GenerateName(6, r)}@{list[r.Next(0, 2)]}.com";
        }

        public static string GeneratePhone(Random r)
        {
            return $"({r.Next(10, 40)}) 9{r.Next(1000, 9999)}-{r.Next(1000, 9999)}";
        }

        public static string GenerateCity(Random r)
        {
            return _states[r.Next(0, 25), 1];
        }

        public static string GenerateState(Random r)
        {
            return _states[r.Next(0, 25), 0];
        }

        public static List<Candidato> GenerateCandidatos(int qnt, Random rnd, out List<Conhecimento> conhecimentos,
            out List<Disponibilidade> disponibilidades, out List<Preferencia> preferencias)
        {
            disponibilidades = new List<Disponibilidade>();
            preferencias = new List<Preferencia>();
            conhecimentos = new List<Conhecimento>();

            List<Candidato> candidatos = new List<Candidato>();

            for (int i = 1; i <= qnt; i++)
            {
                candidatos.Add(new Candidato()
                {
                    Id = i,
                    Nome = Generate.GenerateName(8, rnd),
                    Email = Generate.GenerateEmail(rnd),
                    Cidade = Generate.GenerateCity(rnd),
                    Estado = Generate.GenerateState(rnd),
                    Portfolio = @"http://portfolio.com",
                    Linkedin = @"http://linkedin.com",
                    PretencaoSalario = rnd.Next(1000, 5000),
                    Telefone = Generate.GeneratePhone(rnd)
                });

                disponibilidades.Add(new Disponibilidade()
                {
                    Id = i,
                    CandidatoId = i,
                    AteQuatro = Convert.ToBoolean(rnd.Next(0, 1)),
                    QuatroAteSeis = Convert.ToBoolean(rnd.Next(0, 1)),
                    SeisAteOito = Convert.ToBoolean(rnd.Next(0, 1)),
                    AcimaDeOito = Convert.ToBoolean(rnd.Next(0, 1)),
                    FinaisDeSemana = Convert.ToBoolean(rnd.Next(0, 1))
                });

                preferencias.Add(new Preferencia()
                {
                    Id = i,
                    CandidatoId = i,
                    Manha = Convert.ToBoolean(rnd.Next(0, 1)),
                    Tarde = Convert.ToBoolean(rnd.Next(0, 1)),
                    Madrugada = Convert.ToBoolean(rnd.Next(0, 1)),
                    Comercial = Convert.ToBoolean(rnd.Next(0, 1))
                });

                conhecimentos.Add(new Conhecimento()
                {
                    Id = i,
                    CandidatoId = i,
                    Ionic = rnd.Next(2, 5),
                    ReactJs = rnd.Next(1, 5),
                    ReactNative = rnd.Next(1, 5),
                    Android = rnd.Next(1, 5),
                    Flutter = rnd.Next(1, 5),
                    Swift = rnd.Next(1, 5),
                    Ios = rnd.Next(1, 5),
                    Html = rnd.Next(1, 5),
                    Css = rnd.Next(1, 5),
                    Bootstrap = rnd.Next(1, 5),
                    Jquery = rnd.Next(1, 5),
                    AngularJs = rnd.Next(1, 5),
                    Angular = rnd.Next(0, 5),
                    Java = rnd.Next(0, 5),
                    Python = rnd.Next(0, 5),
                    Flask = rnd.Next(0, 5),
                    AspNetMvc = rnd.Next(0, 5),
                    AspNetWebForm = rnd.Next(0, 5),
                    C = rnd.Next(0, 5),
                    CSharp = rnd.Next(0, 5),
                    NodeJs = rnd.Next(0, 5),
                    ExpressNodeJs = rnd.Next(0, 5),
                    Cake = rnd.Next(0, 5),
                    DJango = rnd.Next(0, 5),
                    Majento = rnd.Next(0, 5),
                    Php = rnd.Next(0, 5),
                    Vue = rnd.Next(0, 5),
                    WordPress = rnd.Next(0, 5),
                    Ruby = rnd.Next(0, 5),
                    MySqlServer = rnd.Next(0, 5),
                    MySql = rnd.Next(0, 5),
                    SalesForce = rnd.Next(0, 5),
                    Photoshop = rnd.Next(0, 5),
                    Illustrator = rnd.Next(0, 5),
                    Seo = rnd.Next(0, 5),
                    Laravel = rnd.Next(0, 5),
                    LinkCrud = @"http://linkcrud.com",
                    Outras = "(Outras linguagens)"
                });

            }
            return candidatos;
        }


    }

}
