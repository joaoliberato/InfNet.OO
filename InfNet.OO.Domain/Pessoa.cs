using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.OO.Domain
{
    public class Pessoa
    {
        public Pessoa(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
