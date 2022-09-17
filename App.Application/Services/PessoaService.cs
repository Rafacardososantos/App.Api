using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using App.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Services
{
    public class PessoaService: IPessoaService
    {
        private IRepositoryBase<Pessoa> _repository { get; set; }/*Basicamente essa linha divulga a conexão com a tabela Cidades do Banco de Dados*/
        public PessoaService(IRepositoryBase<Pessoa> repository)
        {
            _repository = repository;
        }
        public Pessoa Busca(string Cpf)
        {
            var retornoPessoa = _repository.Query(x => x.Cpf == Cpf).FirstOrDefault();
            return retornoPessoa;
        }
        public List<Pessoa> ListaPessoa(string? Cpf, string? Nome)
        {
            var listaPessoas = _repository.Query(
              x => x.Nome.Contains(Nome)
              ).ToList();

            return listaPessoas;
        }
        public void Salvar(Pessoa obj)
        {
            _repository.Save(obj);
            _repository.SaveChanges();
        }
        public void Remover(Guid id)
        {
            _repository.Delete(id);
        }
    }
}
