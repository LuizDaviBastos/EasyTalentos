using EasyTalentos.Dominio.Consulta;
using EasyTalentos.Dominio.Contratos;
using EasyTalentos.Dominio.Entity;
using EasyTalentos.Testes.DadosMock;
using EasyTalentos.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace EasyTalentos.Testes
{
    [TestClass]
    public class TestCandidatoController
    {

        private Mock<IUnityOfWork> _mock;
        private QueryParams _queryParams = new QueryParams();
        private CandidatoController _controller;

        [TestInitialize]
        public void InicializaTeste()
        {
            _mock = new Mock<IUnityOfWork>();
            _queryParams = new QueryParams();

            _mock.Setup(x => x.CandidatoRepositorio.Buscar(c => true, ref _queryParams)).Returns(CandidatoDados.GetCandidatos(0));
            _mock.Setup(x => x.CandidatoRepositorio.Obter(ref _queryParams)).Returns(CandidatoDados.GetCandidatos(4));

            _controller = new CandidatoController(_mock.Object);
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("2324")]
        public void Obter_Retorna_OkObjectResult_Com_ListaDeCanditados(string pesquisa)
        {
            //Atribuindo pesquisa para testar a lógica do controller
            _queryParams.Pesquisa = pesquisa;

            var result = _controller.Obter(_queryParams);

            Assert.IsInstanceOfType(result, typeof(IActionResult));

            Assert.IsInstanceOfType(result, typeof(OkObjectResult));

            var json = JsonConvert.SerializeObject((result as OkObjectResult).Value);
            var obj = JsonConvert.DeserializeObject<Retorno>(json);

            Assert.IsInstanceOfType(obj.Candidatos, typeof(IEnumerable<Candidato>));

            //Se nao existe um termo para a pesquisa, então retorna todos os registro (total 4)
            if (string.IsNullOrEmpty(pesquisa))
            {
                Assert.AreEqual(obj.Candidatos.Count(), 4);
            }
            else //Caso contrário devera retornar 0 registros (resposta da pesquisa)
            {
                Assert.AreEqual(obj.Candidatos.Count(), 0);
            }

        }

        [TestMethod]
        public void Excluir_Retorna_NoContent()
        {
            var result = _controller.Excluir(0);

            Assert.IsInstanceOfType(result, typeof(IActionResult));

            Assert.IsInstanceOfType(result, typeof(NoContentResult));
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("Nome Fake")]
        public void Cadastrar_Retorna_CreatedContent(string nome)
        {
            var candidato = CandidatoDados.GetCandidatos(1)[0];
            candidato.Nome = nome;

            var result = _controller.Cadastrar(candidato);

            Assert.IsInstanceOfType(result, typeof(IActionResult));

            if (!string.IsNullOrEmpty(nome)) Assert.IsInstanceOfType(result, typeof(CreatedResult));

            else Assert.IsInstanceOfType(result, typeof(BadRequestResult));
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("Nome Fake")]
        public void Atualizar_Retorna_OkObjectResult(string nome)
        {
            var candidato = CandidatoDados.GetCandidatos(1)[0];
            candidato.Nome = nome;

            var result = _controller.Atualizar(candidato);

            Assert.IsInstanceOfType(result, typeof(IActionResult));

            if (!string.IsNullOrEmpty(nome)) Assert.IsInstanceOfType(result, typeof(OkObjectResult));

            else Assert.IsInstanceOfType(result, typeof(BadRequestResult));

        }

    }

    public class Retorno
    {
        public IEnumerable<Candidato> Candidatos { get; set; }
        public QueryParams QueryParams { get; set; }
    }
}
