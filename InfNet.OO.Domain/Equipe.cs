using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.OO.Domain
{
    public class Equipe
    {
        public static Equipe EquipeVazia()
        {
            return new Equipe();
        }

        public string Nome { get; set; }
        private List<Funcionario> time { get; set; } = new List<Funcionario>();
        public Gerente Gerente { get; set; }
        public int IdEquipe { get; set; }

        public void AddFuncionario(Funcionario funcionario)
        {
            time.Add(funcionario);
            Gerente?.SetEquipe(this);
        }
        public void RemoveFuncionario(Funcionario funcionario)
        {
            time.Remove(funcionario);
            Gerente?.SetEquipe(this);
        }
        public IEnumerable<Funcionario> GetTime()
        {
            return time;
        }

        internal decimal GetValorTotal()
        {
            return time.Sum(f => f.GetSalarioComBonus()) + Gerente.GetSalarioComBonus();
        }
    }
}
