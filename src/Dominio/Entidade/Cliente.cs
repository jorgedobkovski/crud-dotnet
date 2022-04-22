using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Cliente
    {
        public Cliente()
        {

        }
        public Cliente(string nome, string cpf, string rg, DateTime dataNascimento)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            CPF = cpf;
            RG = rg;
            DataNascimento = dataNascimento;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public DateTime DataNascimento { get; private set; }    

    }
}
