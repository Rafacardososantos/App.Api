using App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces.Application
{
    public interface IPessoaService
    {

        Pessoa Busca(string Cpf);
        void Remover(Guid id);
        void Salvar(Pessoa obj);
        List<Pessoa> ListaPessoa(string Cpf, string Nome);
    }

}
