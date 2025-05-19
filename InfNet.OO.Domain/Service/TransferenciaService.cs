using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.OO.Domain.Service
{
    public class TransferenciaService
    {
        public void Transferir(Funcionario funcionario, Equipe equipeOrigem, Equipe equipeDestino)
        {
            if (funcionario is null)
            {
                throw new ArgumentNullException(nameof(funcionario), "Funcionário não pode ser nulo.");
            }
            equipeOrigem.RemoveFuncionario(funcionario);
            equipeDestino.AddFuncionario(funcionario);
        }
    }
}
