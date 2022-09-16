using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Entities;

namespace App.Domain.Interfaces.Application
{
    public interface ICidadeService
    {
        Cidade BuscaPorCep(string Cep);
        void Remover(Guid id);
        void Salvar(Cidade obj);
        List<Cidade> ListaCidades(string? Cep, string? nome);
    }

}
