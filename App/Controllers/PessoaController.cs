using App.Domain.DTO;
using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;
using App.Application.Services;

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
            try
            {
                var minhaPessoa = _pessoaService.Busca(Cpf);
                return Json(minhaPessoa);
            }
            catch (Exception ex)
            {
                return Json(RetornoApi.Erro(ex.Message));
            }

        }
        [HttpGet("Listagem de Pessoas")]
        public JsonResult ListaPessoa(string? cpf, string? nome)
        {
            try
            {
                var minhaPessoa = _pessoaService.ListaPessoa(cpf, nome);
                return Json(RetornoApi.Sucesso(minhaPessoa));
            }
            catch (Exception ex)
            {
                return Json(RetornoApi.Erro(ex.Message));
            }
        }
        [HttpPost("Salvar")]
        public JsonResult Salvar([FromBody] Pessoa obj)
        {
            try
            {
               _pessoaService.Salvar(obj);
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(RetornoApi.Erro(ex.Message));
            }
        }
        [HttpDelete("Remover")]
        public JsonResult Remover(Guid id)
        {
            try
            {
                _pessoaService.Remover(id);
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(RetornoApi.Erro(ex.Message));
            }
        }
    }
}
