using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.OO.Domain.Factory
{
    public static class FuncionarioFactory
    {
        public static Funcionario Create(Pessoa pessoa, decimal salario)
        {
            return new Funcionario(pessoa, salario);
        }
        public static Funcionario Create(Pessoa pessoa, decimal salario, string formacao, decimal comissao)
        {
            return new Tecnico(pessoa, salario, formacao, comissao);
        }
        public static Funcionario Create(Pessoa pessoa, decimal salario, Equipe equipe)
        {
            return new Gerente(pessoa, salario, equipe);
        }
    }
}
