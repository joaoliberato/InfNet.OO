using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.OO.Domain.Repository
{
    public interface IEquipeRepository
    {
        void Add(Equipe equipeOrigem);
        Equipe ObterPorNumero(int idEquipeOrigem);
    }
}
