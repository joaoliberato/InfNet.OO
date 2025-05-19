using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.OO.Domain.Exception
{
    public class TimeVazioException : System.Exception
    {
        public TimeVazioException(Equipe equipe) : base($"A equipe {equipe?.Nome} não possui funcionários.")
        {

        }
    }

    public class PercentualInvalidoException : System.Exception
    {
        public PercentualInvalidoException(decimal percentual) : base($"O percentual {percentual} é inválido.")
        {
        }
    }
    public class ValorInvalidoException : System.Exception
    {
        public ValorInvalidoException(decimal valor) : base($"O valor {valor} é inválido.")
        {
        }
    }
    
    public class EquipeNotFoundException : System.Exception
    {
        public EquipeNotFoundException() : base("Equipe não encontrada")
        {

        }
    }
}
