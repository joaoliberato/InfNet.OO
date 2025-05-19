using InfNet.OO.Domain.Dto;
using InfNet.OO.Domain.Exception;
using InfNet.OO.Domain.Repository;
using InfNet.OO.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.OO.Application
{
    public class GerarFolhaDePagamento
    {
        private readonly IEquipeRepository _equipeRepository;
        
        public GerarFolhaDePagamento(IEquipeRepository equipeRepository)
        {
            _equipeRepository = equipeRepository;
        }
        public FolhaDePagamentoDto Gerar(int idEquipeOrigem)
        {
            var equipe = _equipeRepository.ObterPorNumero(idEquipeOrigem);
            return equipe == null ? throw new EquipeNotFoundException() : FolhaDePagamentoService.GerarFolha(equipe);
        }
    }
}
