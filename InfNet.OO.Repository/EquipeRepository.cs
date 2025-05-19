using InfNet.OO.Domain;
using InfNet.OO.Domain.Repository;

namespace InfNet.OO.Repository
{
    public class EquipeRepository : IEquipeRepository
    {
        private List<Equipe> _equipes = new List<Equipe>();

        public void Add(Equipe equipeOrigem)
        {
            _equipes.Add(equipeOrigem);
        }

        public Equipe ObterPorNumero(int idEquipeOrigem)
        {
            return _equipes.Find(e => e.IdEquipe == idEquipeOrigem);
        }
    }
}
