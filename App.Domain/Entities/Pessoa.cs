using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{

    public class Pessoa
    {
        [Key]
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public int? Idade { get; set; }
        public string? Endereco { get; set; }
        public string? Cpf { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
    }

}
