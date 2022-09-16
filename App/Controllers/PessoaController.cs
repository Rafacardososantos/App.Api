using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : Controller
    {
        private IPessoaService _pessoaService;
        public PessoaController(IPessoaService service)
        {
            _pessoaService = service;
        }
        [HttpGet("BuscaPorCpf")]
        public JsonResult Busca(string Cpf)
        {
            var minhaPessoa = _pessoaService.Busca(Cpf);
            return Json(minhaPessoa);
        }
        [HttpPost("Salvar")]
        public JsonResult Salvar(string Nome, string Email, string Cpf)
        {
            var  objPessoa = new Pessoa
            {
                Nome = Nome,
                Email= Email,
                Cpf = Cpf,
            };
            _pessoaService.Salvar(objPessoa);
            return Json(true);
        }
    }
}
