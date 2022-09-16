using App.Domain.DTO;
using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace App.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CidadeController : Controller
    {
        private ICidadeService _service;
        public CidadeController(ICidadeService service)
        {
            _service = service;
        }
        [HttpGet("BuscaPorCep")]
        public JsonResult BuscaPorCep(string cep)
        {
            try
            {
                var minhaCidade = _service.BuscaPorCep(cep);
                return Json(minhaCidade);
            }
            catch(Exception ex)
            {
                return Json(RetornoApi.Erro(ex.Message));
            }
        }
        [HttpGet("ListaCidades")]
        public JsonResult ListaCidades(string? cep, string? nome)
        {
            try
            {
                var minhaLista = _service.ListaCidades(cep, nome);
                return Json(RetornoApi.Sucesso(minhaLista));
            }
            catch (Exception ex)
            {
                return Json(RetornoApi.Erro(ex.Message));
            }
        }

        [HttpPost("Salvar")]
        public JsonResult Salvar([FromBody] Cidade obj)
        {
            try
            {
                _service.Salvar(obj);
                return Json(true);
            }
            catch(Exception ex)
            {
                return Json(RetornoApi.Erro(ex.Message));
            }   
        }
        [HttpDelete("Remover")]
        public JsonResult Remover(Guid id)
        {
            try
            {
                _service.Remover(id);
                return Json(true);
            }
            catch(Exception ex)
            {
                return Json(RetornoApi.Erro(ex.Message));
            }
        }
    }
}
