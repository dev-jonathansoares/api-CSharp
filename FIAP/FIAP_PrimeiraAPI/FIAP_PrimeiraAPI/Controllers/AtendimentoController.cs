using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FIAP_PrimeiraAPI.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FIAP_PrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    public class AtendimentoController : Controller
    {
        private readonly IAlunoCadastro alunoCadastro;
        private IAlunoCadastro _alunoCadastro;

        public AtendimentoController(IAlunoCadastro alunoCadastro)
        {
            _alunoCadastro = alunoCadastro;
        }
        [HttpGet("Aluno")]
        public IActionResult GetAluno()
        {
            return Ok(_alunoCadastro.ListaAlunos());
        }

        [HttpPost("inserirAluno")]
        public IActionResult CriarAluno()
        {
            return Ok();
        }

        [HttpPut("atualizacaoAluno")]
        public IActionResult PutAtualizacaoAluno()
        {
            return Ok();
        }

        [HttpDelete("deleteAluno")]
        public IActionResult DeleteAluno()
        {
            return Ok();
        }
    }   
}

