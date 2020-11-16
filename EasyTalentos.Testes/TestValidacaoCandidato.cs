using EasyTalentos.Dominio.Entity;
using EasyTalentos.Dominio.Validacoes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EasyTalentos.Testes
{
    [TestClass]
    public class TestValidacaoCandidato
    {

        [TestMethod]
        [DataRow("Nome candidato")]
        [DataRow("Nome candidato", "Email@email.com")]
        [DataRow("Nome candidato", "Email@email.com", "cidade")]
        [DataRow("Nome candidato", "Email@email.com", "cidade", "estado")]
        [DataRow("Nome candidato", "Email@email.com", "cidade", "estado", "(21) 99999-8888")]
        [DataRow("Nome candidato", "Email@email.com", "cidade", "estado", "(21) 99999-8888", 2000)]
        public void TestValidacao(string nome = "", string email = "", string cidade = "",
            string estado = "", string telefone = "", int pretencaoSalarial = 0)
        {
            var candidato = new Candidato()
            {
                Cidade = cidade,
                Telefone = telefone,
                Nome = nome,
                Email = email,
                Estado = estado,
                PretencaoSalario = pretencaoSalarial
            };

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(cidade) || string.IsNullOrEmpty(estado) ||
                pretencaoSalarial <= 0 || string.IsNullOrEmpty(telefone))
            {
                Assert.IsFalse(Validacao.IsValid(candidato));
            }

            else Assert.IsTrue(Validacao.IsValid(candidato));

        }
    }
}

