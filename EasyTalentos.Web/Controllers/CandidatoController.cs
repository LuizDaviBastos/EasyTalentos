using EasyTalentos.Dominio.Consulta;
using EasyTalentos.Dominio.Contratos;
using EasyTalentos.Dominio.Entity;
using EasyTalentos.Dominio.Validacoes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace EasyTalentos.Web.Controllers
{

    [Route("api/[Controller]")]
    public class CandidatoController : ControllerBase
    {
        private readonly IUnityOfWork _uow;
        public CandidatoController(IUnityOfWork uow)
        {
            _uow = uow;
        }


        #region Cadastrar candidato - CREATE
        [HttpPost("cadastrar")]
        public IActionResult Cadastrar([FromBody] Candidato candidato)
        {

            if (Validacao.IsValid(candidato))
            {
                _uow.CandidatoRepositorio.Adicionar(candidato);
                _uow.SaveChanges();

                return Created($"api/candidato/obter?id={candidato.Id}", candidato);
            }

            else return BadRequest();

        }
        #endregion

        #region Obter todos os candidatos - READ
        [HttpGet("obter")]
        public IActionResult Obter([FromQuery] QueryParams queryParams)
        {

            IEnumerable<Candidato> candidatos;

            if (string.IsNullOrEmpty(queryParams.Pesquisa))
            {
                candidatos = _uow.CandidatoRepositorio.Obter(ref queryParams);

            }
            else
            {
                candidatos = _uow.CandidatoRepositorio.Buscar(c =>
                    c.Email.ToLower().Contains(queryParams.Pesquisa) ||
                    c.Nome.ToLower().Contains(queryParams.Pesquisa), ref queryParams);
            }

            return Ok(new { candidatos, queryParams });

        }
        #endregion

        #region Atualizar candidato - UPDATE
        [HttpPut("atualizar")]
        public IActionResult Atualizar([FromBody] Candidato candidato)
        {

            if (Validacao.IsValid(candidato))
            {
                _uow.CandidatoRepositorio.Atualizar(candidato);

                _uow.SaveChanges();

                return Ok(candidato);
            }
            else return BadRequest();

        }
        #endregion

        #region Excluir candidato - DELETE
        [HttpDelete("{id}", Name = "excluir")]
        public IActionResult Excluir([FromQuery] int id)
        {

            _uow.CandidatoRepositorio.Excluir(id);
            _uow.SaveChanges();

            return NoContent();
        }
        #endregion

    }
}
