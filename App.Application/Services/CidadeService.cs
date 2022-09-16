using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using App.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Services
{
    public class CidadeService : ICidadeService
    {
        private IRepositoryBase<Cidade> _repository { get; set; }/*Basicamente essa linha divulga a conexão com a tabela Cidades do Banco de Dados*/
        public CidadeService(IRepositoryBase<Cidade> repository)
        {
            _repository = repository;
        }
        public Cidade BuscaPorCep(string Cep)
        {
            var retornoCidade = _repository.Query(cidade => cidade.Cep == Cep).FirstOrDefault();/**/
            return retornoCidade;
        }

        public List<Cidade> ListaCidades(string? Cep, string? nome)
        {
            var listaCidades = _repository.Query(
                x => (Cep == null || x.Cep.Contains(Cep))
                && (nome == null || x.Nome.Contains(nome))
                ).ToList();

            return listaCidades;
        }

        public void Remover(Guid id)
        {
            _repository.Delete(id);
            _repository.SaveChanges();
        }

        public void Salvar(Cidade obj)
        {
            _repository.Save(obj);
            _repository.SaveChanges();
        }
    }
}
