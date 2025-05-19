using InfNet.OO.Domain.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.OO.Domain
{
    public class Gerente : Funcionario
    {
        internal Gerente(Pessoa pessoa, decimal salario, Equipe equipe) : base(pessoa, salario)
        {
            if (equipe is null || equipe.GetTime().Count() == 0)
            {
                throw new TimeVazioException(equipe ?? Equipe.EquipeVazia());
            }

            TamanhoEquipe = equipe.GetTime().Count();
        }

        public int TamanhoEquipe { get; private set; }

        public override decimal Bonus()
        {
            if (TamanhoEquipe > 10)
            {
                return 1.5m;
            }
            if (TamanhoEquipe > 5)
            {
                return 1.2m;
            }
            if (TamanhoEquipe > 0)
            {
                return 1.1m;
            }
            return 1m;
        }

        internal void SetEquipe(Equipe equipe)
        {
           TamanhoEquipe = equipe.GetTime().Count();
        }
    }
}
