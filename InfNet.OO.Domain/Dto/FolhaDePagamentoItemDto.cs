using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.OO.Domain.Dto
{
    public class FolhaDePagamentoItemDto
    {
        public string Nome { get; internal set; }
        public decimal SalarioBase { get; internal set; }
        public decimal Bonus { get; internal set; }
        public decimal SalarioFinal { get; internal set; }
    }
}
