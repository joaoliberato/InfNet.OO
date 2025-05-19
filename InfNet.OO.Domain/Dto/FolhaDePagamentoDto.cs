using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.OO.Domain.Dto
{
    public class FolhaDePagamentoDto
    {
        public string Area { get; internal set; }
        public string Gerente { get; internal set; }
        public int TamanhoDoTime { get; internal set; }
        public List<FolhaDePagamentoItemDto> Itens { get; internal set; }
        public decimal ValorTotal { get; internal set; }
    }
}
