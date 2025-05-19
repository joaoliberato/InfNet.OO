using InfNet.OO.Domain.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.OO.Domain
{
    public class Tecnico : Funcionario
    {
        internal Tecnico(Pessoa pessoa, decimal salario, string formacao, decimal comissao) : base(pessoa, salario)
        {
            if (comissao <= 0)
            {
                throw new PercentualInvalidoException(comissao);
            }
            Formacao = formacao;
            Comissao = comissao;
        }

        public string Formacao { get; set; }
        public decimal Comissao { get; private set; }
        public override decimal Bonus()
        {
            return 1 + Comissao / 100;
        }
    }
}
